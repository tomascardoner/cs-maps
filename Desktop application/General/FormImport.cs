using CardonerSistemas.Framework.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace CSMaps.General
{
    public partial class FormImport : Form
    {

        #region Form stuff

        public FormImport()
        {
            InitializeComponent();
            SetAppearance();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageImport16);
            Forms.SetFont(this, Program.AppearanceConfig.Font);
        }

        private void FormImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMdi.formImport = null;
        }

        #endregion

        #region Controls events

        private void ButtonGoogleEarthFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofdGoogleEarthFile = new()
            {
                RestoreDirectory = true,
                Title = Properties.Resources.StringKmlFileOpenDialogTitle,
                Filter = Properties.Resources.StringKmlFileOpenDialogFilter,
                CheckPathExists = true,
                CheckFileExists = true,
                Multiselect = false
            };
            if (string.IsNullOrWhiteSpace(TextBoxGoogleEarthFile.Text))
            {
                ofdGoogleEarthFile.InitialDirectory = Application.StartupPath;
            }
            else
            {
                string pathWithoutFileName = FileSystem.GetPathWithoutFileName(TextBoxGoogleEarthFile.Text);
                if (!string.IsNullOrWhiteSpace(pathWithoutFileName) && Path.Exists(pathWithoutFileName))
                {
                    ofdGoogleEarthFile.InitialDirectory = pathWithoutFileName;
                }
                else
                {
                    ofdGoogleEarthFile.InitialDirectory = Application.StartupPath;
                }
            }
            if (ofdGoogleEarthFile.ShowDialog(this) == DialogResult.OK)
            {
                TextBoxGoogleEarthFile.Text = ofdGoogleEarthFile.FileName;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (TextBoxGoogleEarthFile.Text.Trim() == string.Empty)
            {
                MessageBox.Show(Properties.Resources.StringImportFileNotSpecified, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Path.Exists(TextBoxGoogleEarthFile.Text.Trim()))
            {
                MessageBox.Show(Properties.Resources.StringFileNotFound, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ImportFile(TextBoxGoogleEarthFile.Text.Trim());
        }

        #endregion

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
                byte[] KmzFileHeader = [0x50, 0x4b, 0x03, 0x04, 0x14];
                byte[] KmlFileHeader = [0x3c, 0x3f, 0x78, 0x6d, 0x6c];

                Stream stream = File.OpenRead(filePath);
                byte[] buffer = new byte[5];
                stream.ReadExactly(buffer, 0, 5);
                if (buffer.SequenceEqual(KmzFileHeader))
                {
                    ImportKmzFile(filePath);
                }
                else if (buffer.SequenceEqual(KmlFileHeader))
                {
                    ImportKmlFile(filePath);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.StringImportUnknownFileInvalidContent, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                KmzFile kmzFile = KmzFile.Open(stream);
                KmlFile kmlFile = kmzFile.GetDefaultKmlFile();
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
                KmlFile kmlFile = KmlFile.Load(textReader);
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
                MessageBox.Show(Properties.Resources.StringKmlFileInvalidContent, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Preparo la conexión a la base de datos y obtengo próximo id
            using Models.CSMapsContext context = new();
            int idPuntoUltimo;
            int idPuntoNuevo;
            try
            {
                if (context.Puntos.Any())
                {
                    idPuntoUltimo = context.Puntos.Max(p => p.IdPunto);
                }
                else
                {
                    idPuntoUltimo = 0;
                }
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
                foreach (Placemark placemark in rootElement.Flatten().OfType<Placemark>())
                {
                    if (!context.Puntos.Any(p => p.Nombre == placemark.Name))
                    {
                        SharpKml.Base.Vector coordinates = ((SharpKml.Dom.Point)placemark.Geometry).Coordinate;

                        Models.Punto punto = new();
                        idPuntoNuevo++;
                        punto.IdPunto = idPuntoNuevo;
                        punto.Nombre = placemark.Name;
                        punto.Latitud = (decimal)coordinates.Latitude;
                        punto.Longitud = (decimal)coordinates.Longitude;
                        punto.Altitud = (decimal)coordinates.Altitude;
                        context.Puntos.Add(punto);
                    }
                }
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
                MessageBox.Show(string.Format(Properties.Resources.StringImportFileSuccesful, idPuntoNuevo - idPuntoUltimo), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

    }
}