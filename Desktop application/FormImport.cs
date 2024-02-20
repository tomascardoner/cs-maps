using CardonerSistemas.Framework.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace CSMaps
{
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
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

            ImportKmlFile(TextBoxGoogleEarthFile.Text.Trim());
        }

        private bool ImportKmzFile(string filePath)
        {
            //BinaryReader reader = File.OpenRead(filePath);
            //KmzFile kmz = KmzFile.Open(filePath);
            //KmlFile file = kmz.GetDefaultKmlFile();
            return true;
        }

        private void ImportKmlFile(string filePath)
        {
            this.Cursor = Cursors.WaitCursor;
            Kml rootElement;

            try
            {
                // Cargo la información del archivo .kml
                TextReader textReader = File.OpenText(filePath);
                KmlFile file = KmlFile.Load(textReader);
                rootElement = (Kml)file.Root;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, Properties.Resources.StringKmlFileReadError);
                return;
            }

            if (rootElement == null)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(Properties.Resources.StringKmlFileInvalidContent, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Preparo la conexión a la base de datos y obtengo próximo id
            using Models.CSMapsContext context = new();
            int idPuntoNuevo;
            try
            {
                if (context.Puntos.Any())
                {
                    idPuntoNuevo = context.Puntos.Max(p => p.IdPunto);
                }
                else
                {
                    idPuntoNuevo = 0;
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
                foreach (Placemark placemark in rootElement.Flatten().OfType<Placemark>())
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
            if (idPuntoNuevo > 0)
            {
                MessageBox.Show(string.Format(Properties.Resources.StringImportFileSuccesful, idPuntoNuevo), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}