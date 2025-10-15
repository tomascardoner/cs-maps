using System.Globalization;
using CardonerSistemas.Framework.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace CSMaps.General;

public partial class FormImportGoogleEarthFile : Form
{

    #region Form stuff

    public FormImportGoogleEarthFile()
    {
        InitializeComponent();
        SetAppearance();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageImport32);
        Forms.SetFont(this, Program.AppearanceConfig.Font);
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
            RestoreDirectory = true,
            Title = Properties.Resources.StringImportGoogleEarthFileOpenDialogTitle,
            Filter = Properties.Resources.StringGoogleEarthFileDialogFilter,
            CheckPathExists = true,
            CheckFileExists = true,
            Multiselect = false
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
            ButtonStart.Focus();
        }
    }

    private void ButtonStart_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxFile.Text))
        {
            MessageBox.Show(Properties.Resources.StringImportFileNotSpecified, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (!Path.Exists(TextBoxFile.Text.Trim()))
        {
            MessageBox.Show(Properties.Resources.StringFileNotFound, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        ImportFile(TextBoxFile.Text.Trim());
    }

    #endregion Controls events

    #region Import functions

    private void ImportFile(string filePath)
    {
        switch (Path.GetExtension(filePath))
        {
            case ".kmz":
                ImportKmzFile(filePath);
                break;
            case ".kml":
                ImportKmlFile(filePath);
                break;
            default:
                ImportUnknowFile(filePath);
                break;
        }
    }

    private void ImportUnknowFile(string filePath)
    {
        try
        {
            byte[] kmzFileHeader = [0x50, 0x4b, 0x03, 0x04, 0x14];
            byte[] kmlFileHeader = [0x3c, 0x3f, 0x78, 0x6d, 0x6c];

            Stream stream = File.OpenRead(filePath);
            var buffer = new byte[5];
            stream.ReadExactly(buffer, 0, 5);
            if (buffer.SequenceEqual(kmzFileHeader))
            {
                ImportKmzFile(filePath);
            }
            else if (buffer.SequenceEqual(kmlFileHeader))
            {
                ImportKmlFile(filePath);
            }
            else
            {
                MessageBox.Show(Properties.Resources.StringImportUnknownFileInvalidContent, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, Properties.Resources.StringImportUnknownFileReadError);
        }
    }

    private void ImportKmzFile(string filePath)
    {
        try
        {
            this.Cursor = Cursors.WaitCursor;

            Stream stream = File.OpenRead(filePath);
            var kmzFile = KmzFile.Open(stream);
            var kmlFile = kmzFile.GetDefaultKmlFile();
            ImportKmlFile(kmlFile);
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringKmlFileReadError);
        }
    }

    private void ImportKmlFile(string filePath)
    {
        try
        {
            this.Cursor = Cursors.WaitCursor;

            // Cargo la información del archivo .kml
            TextReader textReader = File.OpenText(filePath);
            var kmlFile = KmlFile.Load(textReader);
            ImportKmlFile(kmlFile);
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringKmlFileReadError);
        }
    }

    private void ImportKmlFile(KmlFile kmlFile)
    {
        this.Cursor = Cursors.WaitCursor;
        Kml rootElement;

        rootElement = (Kml)kmlFile.Root;
        if (rootElement == null)
        {
            this.Cursor = Cursors.Default;
            MessageBox.Show(Properties.Resources.StringKmlFileInvalidContent, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Preparo la conexión a la base de datos y obtengo próximo id
        using Models.CSMapsContext context = new();
        int idPuntoUltimo;
        int idPuntoNuevo;
        try
        {
            idPuntoUltimo = context.Puntos.Any() ? context.Puntos.Max(p => p.IdPunto) : 0;
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringDatabaseError);
            return;
        }

        try
        {
            // Parseo la información del archivo y la agrego a la base de datos
            idPuntoNuevo = idPuntoUltimo;
#pragma warning disable S3267 // Loops should be simplified with "LINQ" expressions
            foreach (var placemark in rootElement.Flatten().OfType<Placemark>())
            {
                if (!context.Puntos.Any(p => p.Nombre == placemark.Name))
                {
                    var coordinates = ((SharpKml.Dom.Point)placemark.Geometry).Coordinate;

                    Models.Punto punto = new();
                    idPuntoNuevo++;
                    punto.IdPunto = idPuntoNuevo;
                    punto.Nombre = placemark.Name;
                    punto.Latitud = (decimal)coordinates.Latitude;
                    punto.Longitud = (decimal)coordinates.Longitude;
                    punto.Altitud = (decimal)coordinates.Altitude;
                    punto.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                    punto.FechaHoraCreacion = DateTime.UtcNow;
                    punto.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
                    punto.FechaHoraUltimaModificacion = DateTime.UtcNow;
                    context.Puntos.Add(punto);
                }
            }
#pragma warning restore S3267 // Loops should be simplified with "LINQ" expressions
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringKmlFileInvalidContentPlacemark);
            return;
        }

        try
        {
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringDatabaseSaveError);
            return;
        }

        this.Cursor = Cursors.Default;
        if (idPuntoNuevo - idPuntoUltimo > 0)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringImportFileSuccesful, idPuntoNuevo - idPuntoUltimo), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    #endregion Import functions

}