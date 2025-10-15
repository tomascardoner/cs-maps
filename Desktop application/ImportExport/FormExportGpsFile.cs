using System.Globalization;
using CardonerSistemas.Framework.Base;
using Geo.Gps;
using MediaDevices;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CSMaps.ImportExport;

public partial class FormExportGpsFile : Form
{

    #region Declarations

    private const string DefaultFileNameExport = "CSMaps.gpx";

#pragma warning disable CA2213 // Disposable fields should be disposed
    private readonly Models.CSMapsContext _dbContext = new();
#pragma warning restore CA2213 // Disposable fields should be disposed
    private List<MediaDevice> _mediaDevices;

    private const byte StepNumberMax = 3;
    private byte _stepNumberCurrent = 1;

    #endregion Declarations

    #region Form stuff

    public FormExportGpsFile()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        SetAppearance();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageExport32);
        ShowControls();
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _dbContext?.Dispose();
    }

    #endregion Form stuff

    #region Controls events

    private void TextBoxFile_Enter(object sender, EventArgs e)
    {
        TextBoxFile.SelectAll();
    }

    private void ButtonFile_Click(object sender, EventArgs e)
    {
        using SaveFileDialog saveFileDialog = new()
        {
            FileName = DefaultFileNameExport,
            RestoreDirectory = true,
            Title = Properties.Resources.StringExportGpsFileSaveDialogTitle,
            Filter = Properties.Resources.StringGpsFileDialogFilter,
            CheckPathExists = true,
            AddExtension = true,
            CheckWriteAccess = true,
            DefaultExt = CommonFunctions.GarminFileExtension,
            OverwritePrompt = true
        };
        if (string.IsNullOrWhiteSpace(TextBoxFile.Text))
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;
        }
        else
        {
            var pathWithoutFileName = FileSystem.GetPathWithoutFileName(TextBoxFile.Text);
            saveFileDialog.InitialDirectory = !string.IsNullOrWhiteSpace(pathWithoutFileName) && Path.Exists(pathWithoutFileName)
                ? pathWithoutFileName
                : Application.StartupPath;
        }

        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            TextBoxFile.Text = saveFileDialog.FileName;
            ButtonFinish.Focus();
        }
    }

    private void ButtonPrevious_Click(object sender, EventArgs e)
    {
        StepPrevious();
    }

    private void ButtonNext_Click(object sender, EventArgs e)
    {
        StepNext();
    }

    private void ButtonFinish_Click(object sender, EventArgs e)
    {
        ExportGpxFile();
    }

    #endregion Controls events

    #region Steps methods

    private void ShowControls()
    {
        GroupBoxStep1.Visible = _stepNumberCurrent == 1;
        GroupBoxStep2.Visible = _stepNumberCurrent == 2;
        GroupBoxSummary.Visible = _stepNumberCurrent == 3;

        if (_stepNumberCurrent == 1)
        {
            RadioButtonPointsWithData.Text = $"Sólo los que tienen datos asociados ({_dbContext.PuntoDatos.Count():N0} puntos).";
            RadioButtonPointsAll.Text = $"Todos ({_dbContext.Puntos.Count():N0} puntos).";
        }

        if (_stepNumberCurrent == 2)
        {
            this.Cursor = Cursors.WaitCursor;
            CommonFunctions.GetGpsDevicesAndDrives(ref _mediaDevices, ListViewDevices, TextBoxFile);
            this.Cursor = Cursors.Default;
        }

        if (_stepNumberCurrent == 3)
        {
            ShowSummary();
        }

        ButtonPrevious.Visible = _stepNumberCurrent > 1;
        ButtonNext.Visible = _stepNumberCurrent < StepNumberMax;
        ButtonFinish.Visible = _stepNumberCurrent == StepNumberMax;
    }

    private void StepPrevious()
    {
        if (_stepNumberCurrent > 1)
        {
            _stepNumberCurrent--;
            ShowControls();
        }
    }

    private void StepNext()
    {
        if (_stepNumberCurrent < StepNumberMax && StepVerifyRequirements())
        {
            _stepNumberCurrent++;
            ShowControls();
        }
    }

    private bool StepVerifyRequirements()
    {
        switch (_stepNumberCurrent)
        {
            case 1:
                if (!RadioButtonPointsWithData.Checked && !RadioButtonPointsAll.Checked)
                {
                    MessageBox.Show("Debe especificar qué puntos quiere incluir en el archivo a exportar.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }
            case 2:
                return VerifyDestination();
            default:
                return true;
        }
    }

    private bool VerifyDestination()
    {
        if (ListViewDevices.SelectedItems.Count == 0 && TextBoxFile.Text.Trim().IsNullOrEmpty())
        {
            MessageBox.Show(Properties.Resources.StringExportDestinationNotSpecified, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        if (!TextBoxFile.Text.Trim().IsNullOrEmpty() && !Path.Exists(FileSystem.GetPathWithoutFileName(TextBoxFile.Text)))
        {
            MessageBox.Show("La ubicación del archivo de destino a exportar no existe.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        return true;
    }

    private void ShowSummary()
    {
        var summary = RadioButtonPointsAll.Checked
            ? $"Se exportarán todos los puntos del sistema (cantidad: {_dbContext.Puntos.Count():N0}).\n\n"
            : $"Se exportarán sólo los puntos del sistema que tienen datos asociados (cantidad: {_dbContext.PuntoDatos.Count():N0}).\n\n";

        if (TextBoxFile.Text.IsNullOrEmpty())
        {
            summary += $"El dispositivo de destino es: {ListViewDevices.SelectedItems[0].Text} - unidad {ListViewDevices.SelectedItems[0].SubItems[1].Text}";
        }
        else
        {
            summary += $"El archivo de destino es: {TextBoxFile.Text.Trim()}";
        }

        LabelSummary.Text = summary;
    }

    #endregion Steps methods

    #region Export GPX file

    private void ExportGpxFile()
    {
        var destinationIsDevice = TextBoxFile.Text.IsNullOrEmpty();
        var fileFullPath = destinationIsDevice
            ? Path.Combine(ListViewDevices.SelectedItems[0].Tag.ToString(), DefaultFileNameExport)
            : TextBoxFile.Text.Trim();

        this.Cursor = Cursors.WaitCursor;
        if (!ExportVerifyDestination(destinationIsDevice, fileFullPath))
        {
            this.Cursor = Cursors.Default;
            return;
        }

        var puntos = ExportGetPoints();
        if (puntos.Count == 0)
        {
            this.Cursor = Cursors.Default;
            return;
        }

        GpsData gpsData = new();
        if (!ExportGetGpsData(puntos, gpsData))
        {
            this.Cursor = Cursors.Default;
            return;
        }

        var tempPath = Path.GetTempPath();
        var tempFilePath = Path.Combine(tempPath, DefaultFileNameExport);
        if (!ExportSaveToFile(destinationIsDevice, destinationIsDevice ? tempFilePath : fileFullPath, gpsData))
        {
            this.Cursor = Cursors.Default;
            return;
        }

        if (destinationIsDevice && !ExportUploadFileToDevice(tempFilePath, fileFullPath))
        {
            this.Cursor = Cursors.Default;
            return;
        }

        if (destinationIsDevice)
        {
            CommonFunctions.DeleteTempFileAndFolder(tempFilePath);
        }

        this.Cursor = Cursors.Default;
        MessageBox.Show($"Se ha exportado correctamente la información de {puntos.Count:N0} puntos al destino especificado.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }

    private bool ExportVerifyDestination(bool destinationIsDevice, string fileFullPath)
    {
        if (destinationIsDevice)
        {
            try
            {
                using var mediaDevice = _mediaDevices[ListViewDevices.SelectedItems[0].Index];
                mediaDevice.Connect();
                if (mediaDevice.FileExists(fileFullPath) && MessageBox.Show(string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringFileDestinationConfirmOverwrite, Environment.NewLine), Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    mediaDevice.Disconnect();
                    return false;
                }

                mediaDevice.Disconnect();
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al verificar la ubicación en el dispositivo de destino.");
                return false;
            }
        }
        else if (Path.Exists(fileFullPath) && MessageBox.Show(Properties.Resources.StringFileDestinationConfirmOverwrite, Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        {
            return false;
        }

        return true;
    }

    private List<Models.Punto> ExportGetPoints()
    {
        try
        {
            return RadioButtonPointsWithData.Checked
                ? [.. _dbContext.Puntos
                            .Include(p => p.PuntoDato)
                            .ThenInclude(pd => pd.IdEstablecimientoNavigation)
                            .ThenInclude(e => e.IdEntidadNavigation)
                            .Where(p => p.PuntoDato != null)
                            .OrderBy(p => p.Nombre)]
                : [.. _dbContext.Puntos
                            .Include(p => p.PuntoDato)
                            .ThenInclude(pd => pd.IdEstablecimientoNavigation)
                            .ThenInclude(e => e.IdEntidadNavigation)
                            .OrderBy(p => p.Nombre)];
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, "Error al obtener los puntos para exportar.");
            return [];
        }
    }

    private static bool ExportGetGpsData(List<Models.Punto> puntos, GpsData gpsData)
    {
        try
        {
            foreach (var punto in puntos)
            {
                Geo.Geometries.Point point = new((double)punto.Latitud, (double)punto.Longitud, (double)punto.Altitud);
                gpsData.Waypoints.Add(new(point, punto.NombreExportar, punto.ComentarioExportar, punto.DescripcionExportar));
            }

            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, "Error al convertir los puntos para exportar.");
            return false;
        }
    }

    private static bool ExportSaveToFile(bool destinationIsDevice, string fileFullPath, GpsData gpsData)
    {
        try
        {
            Geo.Gps.Serialization.Gpx11Serializer serializer = new();
            using FileStream fileStream = new(fileFullPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            fileStream.SetLength(0);
            serializer.Serialize(gpsData, fileStream);
            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, destinationIsDevice ? Properties.Resources.StringExportFileTempWriteError : Properties.Resources.StringExportFileWriteError);
            return false;
        }
    }

    private bool ExportUploadFileToDevice(string tempFilePath, string fileFullPath)
    {
        try
        {
            using var mediaDevice = _mediaDevices[ListViewDevices.SelectedItems[0].Index];
            mediaDevice.Connect();
            if (mediaDevice.FileExists(fileFullPath))
            {
                mediaDevice.DeleteFile(fileFullPath);
            }

            using var fileStream = File.OpenRead(tempFilePath);
            mediaDevice.UploadFile(fileStream, fileFullPath);
            mediaDevice.Disconnect();
            return true;
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, "Error al enviar el archivo de datos al dispositivo de destino.");
            return false;
        }
    }

    #endregion Export GPX file

}