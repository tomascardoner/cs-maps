using CardonerSistemas.Framework.Base;
using Geo;
using Geo.Gps;
using MediaDevices;
using Microsoft.IdentityModel.Tokens;

namespace CSMaps.ImportExport;

public partial class FormImportGpsFile : Form
{

    #region Declarations

#pragma warning disable CA2213 // Disposable fields should be disposed
    private readonly Models.CSMapsContext _dbContext = new();
#pragma warning restore CA2213 // Disposable fields should be disposed
    private List<MediaDevice> _mediaDevices;

    private sealed class PuntosGpsBD
    {
        public int IdPunto { get; set; }
        public string NombreGps { get; set; }
        public decimal LatitudGps { get; set; }
        public decimal LongitudGps { get; set; }
        public decimal AltitudGps { get; set; }
        public string NombreBD { get; set; }
        public decimal LatitudBD { get; set; }
        public decimal LongitudBD { get; set; }
        public decimal AltitudBD { get; set; }
    }

    private List<Models.Punto> _puntosCoincidentes;
    private List<PuntosGpsBD> _puntosCoincidentesCoordenadas;
    private List<PuntosGpsBD> _puntosCoincidentesNombres;
    private List<Models.Punto> _puntosNuevos;

    private int _puntosNuevosCount;
    private int _puntosCoincidentesCoordenadasCount;
    private int _puntosCoincidentesNombresCount;

    private bool _sourceIsDevice;
    private string _fileFullPath;

    private const byte StepNumberMax = 3;
    private byte _stepNumberCurrent = 1;

    #endregion Declarations

    #region Form stuff

    public FormImportGpsFile()
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
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageImport32);
        Common.Appearance.SetControlsDataGridViews(this.Controls, true);
        ShowControls();

        CardonerSistemas.Framework.Controls.DataGridViewExtension dataGridViewExtension;
        // Crear grupos de columnas en grilla de coincidentes por coordenadas para GPS y Base de datos
        dataGridViewExtension = new(
        [
            new CardonerSistemas.Framework.Controls.DataGridViewExtension.TopHeaderInfo()
            {
                FirstHeaderText = "GPS",
                FirstHeaderFont = this.Font,
                FirstHeadersBGColor = DataGridViewPuntosCoincidentesCoordenadas.ColumnHeadersDefaultCellStyle.BackColor,
                SecondHeaderFirstIndex = 2,
                SecondHeaderLastIndex = 4
            },
            new CardonerSistemas.Framework.Controls.DataGridViewExtension.TopHeaderInfo()
            {
                FirstHeaderText = "Base de datos",
                FirstHeaderFont = this.Font,
                FirstHeadersBGColor = DataGridViewPuntosCoincidentesCoordenadas.ColumnHeadersDefaultCellStyle.BackColor,
                SecondHeaderFirstIndex = 5,
                SecondHeaderLastIndex = 6
            }
        ]);
        dataGridViewExtension.BuildDualHeader(DataGridViewPuntosCoincidentesCoordenadas);

        // Crear grupos de columnas en grilla de coincidentes por coordenadas para GPS y Base de datos
        dataGridViewExtension = new(
        [
            new CardonerSistemas.Framework.Controls.DataGridViewExtension.TopHeaderInfo()
            {
                FirstHeaderText = "GPS",
                FirstHeaderFont = this.Font,
                FirstHeadersBGColor = DataGridViewPuntosCoincidentesNombres.ColumnHeadersDefaultCellStyle.BackColor,
                SecondHeaderFirstIndex = 1,
                SecondHeaderLastIndex = 4
            },
            new CardonerSistemas.Framework.Controls.DataGridViewExtension.TopHeaderInfo()
            {
                FirstHeaderText = "Base de datos",
                FirstHeaderFont = this.Font,
                FirstHeadersBGColor = DataGridViewPuntosCoincidentesNombres.ColumnHeadersDefaultCellStyle.BackColor,
                SecondHeaderFirstIndex = 5,
                SecondHeaderLastIndex = 7
            }
        ]);
        dataGridViewExtension.BuildDualHeader(DataGridViewPuntosCoincidentesNombres);
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
        using OpenFileDialog openFileDialog = new()
        {
            FileName = CommonFunctions.GarminFileName,
            RestoreDirectory = true,
            Title = Properties.Resources.StringExportGpsFileSaveDialogTitle,
            Filter = Properties.Resources.StringGpsFileDialogFilter,
            CheckPathExists = true,
            AddExtension = true,
            DefaultExt = CommonFunctions.GarminFileExtension,
        };
        if (string.IsNullOrWhiteSpace(TextBoxFile.Text))
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
        }
        else
        {
            var pathWithoutFileName = FileSystem.GetPathWithoutFileName(TextBoxFile.Text);
            openFileDialog.InitialDirectory = !string.IsNullOrWhiteSpace(pathWithoutFileName) && Path.Exists(pathWithoutFileName)
                ? pathWithoutFileName
                : Application.StartupPath;
        }

        if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            TextBoxFile.Text = openFileDialog.FileName;
            ButtonFinish.Focus();
        }
    }

    private void ButtonPuntosNuevosMarcarTodos_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosNuevos, 0, true);
    }

    private void ButtonPuntosNuevosMarcarInvertir_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosNuevos, 0, null);
    }

    private void ButtonPuntosNuevosMarcarNinguno_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosNuevos, 0, false);
    }

    private void ButtonPuntosCoincidentesCoordenadasMarcarTodos_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosCoincidentesCoordenadas, 2, true);
    }

    private void ButtonPuntosCoincidentesCoordenadasMarcarInvertir_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosCoincidentesCoordenadas, 2, null);
    }

    private void ButtonPuntosCoincidentesCoordenadasMarcarNinguno_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosCoincidentesCoordenadas, 2, false);
    }

    private void ButtonPuntosCoincidentesNombresMarcarTodos_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosCoincidentesNombres, 1, true);
    }

    private void ButtonPuntosCoincidentesNombresMarcarInvertir_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosCoincidentesNombres, 1, null);
    }

    private void ButtonPuntosCoincidentesNombresMarcarNinguno_Click(object sender, EventArgs e)
    {
        ChangeDataGridMarks(DataGridViewPuntosCoincidentesNombres, 1, false);
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
        if (ImportSaveData())
        {
            this.Close();
        }
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
            this.Cursor = Cursors.WaitCursor;
            CommonFunctions.GetGpsDevicesAndDrives(ref _mediaDevices, ListViewDevices, TextBoxFile);
            this.Cursor = Cursors.Default;
        }

        if (_stepNumberCurrent == 2)
        {
            this.Cursor = Cursors.WaitCursor;
            ReadGpxFile();
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
        return _stepNumberCurrent switch
        {
            1 => VerifySource(),
            2 => VerifySelectedPoints(),
            _ => true,
        };
    }

    private bool VerifySource()
    {
        if (ListViewDevices.SelectedItems.Count == 0 && TextBoxFile.Text.Trim().IsNullOrEmpty())
        {
            MessageBox.Show(Properties.Resources.StringImportSourceNotSpecified, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        if (!TextBoxFile.Text.Trim().IsNullOrEmpty() && !Path.Exists(FileSystem.GetPathWithoutFileName(TextBoxFile.Text)))
        {
            MessageBox.Show("La ubicación del archivo de origen a importar no existe.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        if (!File.Exists(TextBoxFile.Text.Trim()))
        {
            MessageBox.Show("El archivo de origen a importar no existe.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        return true;
    }

    private bool VerifySelectedPoints()
    {
        _puntosNuevosCount = CountDataGridMarkedRows(DataGridViewPuntosNuevos, 0);
        _puntosCoincidentesCoordenadasCount = CountDataGridMarkedRows(DataGridViewPuntosCoincidentesCoordenadas, 2);
        _puntosCoincidentesNombresCount = CountDataGridMarkedRows(DataGridViewPuntosCoincidentesNombres, 1);

        if (_puntosNuevosCount + _puntosCoincidentesCoordenadasCount + _puntosCoincidentesNombresCount == 0)
        {
            MessageBox.Show("No hay ningún punto seleccionado para importar.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        return true;
    }

    private void ShowSummary()
    {
        string summary;
        summary = $"Se importarán los siguientes puntos desde el GPS:\n\n";
        summary += $"Puntos nuevos: {_puntosNuevosCount:N0}\n";
        summary += $"Puntos coincidentes por coordenadas: {_puntosCoincidentesCoordenadasCount:N0}\n";
        summary += $"Puntos coincidentes por nombres: {_puntosCoincidentesNombresCount:N0}\n\n";
        summary += $"Puntos totales a importar: {_puntosNuevosCount + _puntosCoincidentesCoordenadasCount + _puntosCoincidentesNombresCount:N0}\n\n";
        if (_sourceIsDevice)
        {
            summary += $"El dispositivo de origen es: {ListViewDevices.SelectedItems[0].Text} - unidad {ListViewDevices.SelectedItems[0].SubItems[1].Text}";
        }
        else
        {
            summary += $"El archivo de origen es: {_fileFullPath}";
        }

        LabelSummary.Text = summary;
    }

    #endregion Steps methods

    #region Import GPX file

    private void ReadGpxFile()
    {
        _sourceIsDevice = TextBoxFile.Text.IsNullOrEmpty();

        this.Cursor = Cursors.WaitCursor;

        if (_sourceIsDevice)
        {
            // Descargo el archivo desde el dispositivo a la carpeta Temp
            _fileFullPath = Path.Combine(Path.GetTempPath(), CommonFunctions.GarminFileName);
            if (!ImportDownloadFileFromDevice(_fileFullPath, Path.Combine(ListViewDevices.SelectedItems[0].Tag.ToString(), CommonFunctions.GarminFileName)))
            {
                this.Cursor = Cursors.Default;
                return;
            }
        }
        else
        {
            _fileFullPath = TextBoxFile.Text.Trim();
        }

        if (!ImportGetGpsData(_fileFullPath))
        {
            this.Cursor = Cursors.Default;
            return;
        }

        this.Cursor = Cursors.Default;
    }

    private bool ImportDownloadFileFromDevice(string sourceFilePath, string destinationFilePath)
    {
        try
        {
            using var mediaDevice = _mediaDevices[ListViewDevices.SelectedItems[0].Index];
            mediaDevice.Connect();
            if (!mediaDevice.FileExists(sourceFilePath))
            {
                mediaDevice.Disconnect();
                this.Cursor = Cursors.Default;
                return false;
            }

            if (!CommonFunctions.DeleteTempFileAndFolder(destinationFilePath))
            {
                mediaDevice.Disconnect();
                this.Cursor = Cursors.Default;
                return false;
            }

            mediaDevice.DownloadFile(sourceFilePath, destinationFilePath);
            mediaDevice.Disconnect();
            return true;
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, "Error al descargar el archivo de datos desde el dispositivo de origen.");
            return false;
        }
    }

    private bool ImportGetGpsData(string fileFullPath)
    {
        try
        {
            _puntosCoincidentes = [];
            _puntosCoincidentesCoordenadas = [];
            _puntosCoincidentesNombres = [];
            _puntosNuevos = [];

            GpsData gpsData;
            Geo.Gps.Serialization.Gpx11Serializer serializer = new();
            using FileStream fileStream = new(fileFullPath, FileMode.Open, FileAccess.Read, FileShare.None);
            Geo.Gps.Serialization.StreamWrapper streamWrapper = new(fileStream);
            gpsData = serializer.DeSerialize(streamWrapper);
            using Models.CSMapsContext dbContext = new();
#pragma warning disable S3267 // Loops should be simplified with "LINQ" expressions
            foreach (var waypoint in gpsData.Waypoints)
            {
                if (!ImportFindPointFromGpsWaypoint(dbContext, waypoint))
                {
                    return false;
                }
            }
#pragma warning restore S3267 // Loops should be simplified with "LINQ" expressions

            _puntosNuevos = [.. _puntosNuevos.OrderBy(p => p.Nombre)];
            DataGridViewPuntosNuevos.AutoGenerateColumns = false;
            DataGridViewPuntosNuevos.DataSource = _puntosNuevos;
            LabelPuntosNuevosCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _puntosNuevos.Count);

            _puntosCoincidentesCoordenadas = [.. _puntosCoincidentesCoordenadas.OrderBy(p => p.LatitudGps).ThenBy(p => p.LongitudGps)];
            DataGridViewPuntosCoincidentesCoordenadas.AutoGenerateColumns = false;
            DataGridViewPuntosCoincidentesCoordenadas.DataSource = _puntosCoincidentesCoordenadas;
            LabelPuntosCoincidentesCoordenadasCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _puntosCoincidentesCoordenadas.Count);

            _puntosCoincidentesNombres = [.. _puntosCoincidentesNombres.OrderBy(p => p.LatitudGps).ThenBy(p => p.LongitudGps)];
            DataGridViewPuntosCoincidentesNombres.AutoGenerateColumns = false;
            DataGridViewPuntosCoincidentesNombres.DataSource = _puntosCoincidentesNombres;
            LabelPuntosCoincidentesNombresCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _puntosCoincidentesNombres.Count);

            _puntosCoincidentes = [.. _puntosCoincidentes.OrderBy(p => p.Nombre)];
            DataGridViewPuntosCoincidentes.AutoGenerateColumns = false;
            DataGridViewPuntosCoincidentes.DataSource = _puntosCoincidentes;
            LabelPuntosCoincidentesCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _puntosCoincidentes.Count);

            if (_sourceIsDevice)
            {
                CommonFunctions.DeleteTempFileAndFolder(_fileFullPath);
            }

            return true;
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringGpxFileReadError);
            return false;
        }
    }

    private bool ImportFindPointFromGpsWaypoint(Models.CSMapsContext dbContext, Waypoint waypoint)
    {
        try
        {
            var added = false;

            // Busco por coordenada
            foreach (var punto in dbContext.Puntos.Where(p => p.Latitud == (decimal)waypoint.Coordinate.Latitude && p.Longitud == (decimal)waypoint.Coordinate.Longitude))
            {
                if (punto.Nombre == waypoint.Name.Trim() && (waypoint.Coordinate.Is3D && punto.Altitud == (decimal)((CoordinateZ)waypoint.Coordinate).Elevation) || (!waypoint.Coordinate.Is3D && punto.Altitud == 0))
                {
                    _puntosCoincidentes.Add(punto);
                }
                else
                {
                    _puntosCoincidentesCoordenadas.Add(new()
                    {
                        IdPunto = punto.IdPunto,
                        NombreGps = waypoint.Name.Trim(),
                        LatitudGps = (decimal)waypoint.Coordinate.Latitude,
                        LongitudGps = (decimal)waypoint.Coordinate.Longitude,
                        AltitudGps = waypoint.Coordinate.Is3D ? (decimal)((CoordinateZ)waypoint.Coordinate).Elevation : 0,
                        NombreBD = punto.Nombre,
                        LatitudBD = punto.Latitud,
                        LongitudBD = punto.Longitud,
                        AltitudBD = punto.Altitud
                    });
                }

                added = true;
            }

            if (added)
            {
                return true;
            }

            // Busco por nombre
            foreach (var punto in dbContext.Puntos.Where(p => !_puntosCoincidentes.Contains(p) && p.Nombre == waypoint.Name.Trim()))
            {
                if (!_puntosCoincidentesCoordenadas.Exists(p => p.LatitudGps != p.LatitudBD || p.LongitudGps != p.LongitudBD))
                {
                    _puntosCoincidentesNombres.Add(new()
                    {
                        IdPunto = punto.IdPunto,
                        NombreGps = waypoint.Name.Trim(),
                        LatitudGps = (decimal)waypoint.Coordinate.Latitude,
                        LongitudGps = (decimal)waypoint.Coordinate.Longitude,
                        AltitudGps = waypoint.Coordinate.Is3D ? (decimal)((CoordinateZ)waypoint.Coordinate).Elevation : 0,
                        NombreBD = punto.Nombre,
                        LatitudBD = punto.Latitud,
                        LongitudBD = punto.Longitud,
                        AltitudBD = punto.Altitud
                    });
                }

                added = true;
            }

            if (added)
            {
                return true;
            }

            // El waypoint es nuevo
            _puntosNuevos.Add(new()
            {
                Nombre = waypoint.Name.Trim(),
                Latitud = (decimal)waypoint.Coordinate.Latitude,
                Longitud = (decimal)waypoint.Coordinate.Longitude,
                Altitud = waypoint.Coordinate.Is3D ? (decimal)((CoordinateZ)waypoint.Coordinate).Elevation : 0
            });
            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, "Error al buscar el punto en la base de datos.");
            return false;
        }
    }

    private bool ImportSaveData()
    {
        try
        {
            this.Cursor = Cursors.WaitCursor;

            using Models.CSMapsContext dbContext = new();

            // Puntos nuevos
            if (_puntosNuevosCount > 0)
            {
                var idPunto = 0;
                if (dbContext.Puntos.Any())
                {
                    idPunto = dbContext.Puntos.Max(p => p.IdPunto);
                }

                foreach (DataGridViewRow row in DataGridViewPuntosNuevos.Rows)
                {
                    if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                    {
                        idPunto++;
                        var puntoAdd = (Models.Punto)row.DataBoundItem;
                        puntoAdd.IdPunto = idPunto;
                        puntoAdd.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                        puntoAdd.FechaHoraCreacion = DateTime.UtcNow;
                        puntoAdd.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
                        puntoAdd.FechaHoraUltimaModificacion = puntoAdd.FechaHoraCreacion;
                        dbContext.Puntos.Add(puntoAdd);
                    }
                }
            }

            // Puntos coincidentes por coordenadas
            if (_puntosCoincidentesCoordenadasCount > 0)
            {
                foreach (DataGridViewRow row in DataGridViewPuntosCoincidentesCoordenadas.Rows)
                {
                    if (row.Cells[2].Value != null && (bool)row.Cells[2].Value)
                    {
                        var puntoFromUpdate = (PuntosGpsBD)row.DataBoundItem;
                        var puntoToUpdate = dbContext.Puntos.FirstOrDefault(p => p.IdPunto == puntoFromUpdate.IdPunto);
                        if (puntoToUpdate != null)
                        {
                            if (puntoFromUpdate.NombreGps != puntoFromUpdate.NombreBD)
                            {
                                puntoToUpdate.Nombre = puntoFromUpdate.NombreGps;
                            }

                            if (puntoFromUpdate.AltitudGps > 0 && puntoFromUpdate.AltitudGps != puntoFromUpdate.AltitudBD)
                            {
                                puntoToUpdate.Altitud = puntoFromUpdate.AltitudGps;
                            }

                            puntoToUpdate.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
                            puntoToUpdate.FechaHoraUltimaModificacion = DateTime.UtcNow;
                        }
                    }
                }
            }

            // Puntos coincidentes por nombres
            if (_puntosCoincidentesNombresCount > 0)
            {
                foreach (DataGridViewRow row in DataGridViewPuntosCoincidentesNombres.Rows)
                {
                    if (row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                    {
                        var puntoFromUpdate = (PuntosGpsBD)row.DataBoundItem;
                        var puntoToUpdate = dbContext.Puntos.FirstOrDefault(p => p.IdPunto == puntoFromUpdate.IdPunto);
                        if (puntoToUpdate != null)
                        {
                            if (puntoFromUpdate.LatitudGps != puntoFromUpdate.LatitudBD)
                            {
                                puntoToUpdate.Latitud = puntoFromUpdate.LatitudGps;
                            }

                            if (puntoFromUpdate.LongitudGps != puntoFromUpdate.LongitudBD)
                            {
                                puntoToUpdate.Longitud = puntoFromUpdate.LongitudGps;
                            }

                            if (puntoFromUpdate.AltitudGps > 0 && puntoFromUpdate.AltitudGps != puntoFromUpdate.AltitudBD)
                            {
                                puntoToUpdate.Altitud = puntoFromUpdate.AltitudGps;
                            }

                            puntoToUpdate.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
                            puntoToUpdate.FechaHoraUltimaModificacion = DateTime.UtcNow;
                        }
                    }
                }
            }

            dbContext.SaveChanges();

            this.Cursor = Cursors.Default;
            MessageBox.Show($"Se ha importado correctamente la información desde el origen especificado.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, "Error al guardar los puntos en la base de datos.");
            return false;
        }
    }

    #endregion Import GPX file

    #region Extra stuff

    private static void ChangeDataGridMarks(DataGridView dataGridView, int columnIndex, bool? value)
    {
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            row.Cells[columnIndex].Value = value ?? !(bool)(row.Cells[columnIndex].Value ?? false);
        }
    }

    private static int CountDataGridMarkedRows(DataGridView dataGridView, int columnIndex)
    {
        var counter = 0;
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            if (row.Cells[columnIndex].Value != null && (bool)row.Cells[columnIndex].Value)
            {
                counter++;
            }
        }

        return counter;
    }

    #endregion Extra stuff

}
