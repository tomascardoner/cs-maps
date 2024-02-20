using SharpKml.Dom;
using SharpKml.Engine;
using System.Diagnostics;

namespace CSMaps
{
    public partial class FormImportar : Form
    {
        public FormImportar()
        {
            InitializeComponent();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            if (TextBoxArchivoKml.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe especificar el archivo que desea importar.");
                return;
            }
            if (!Path.Exists(TextBoxArchivoKml.Text.Trim()))
            {
                MessageBox.Show("El archivo especificado no existe.");
                return;
            }

            ImportarArchivoKml(TextBoxArchivoKml.Text.Trim());
        }

        private bool ImportarArchivoKmz(string filePath)
        {
            //BinaryReader reader = File.OpenRead(filePath);
            //KmzFile kmz = KmzFile.Open(filePath);
            //KmlFile file = kmz.GetDefaultKmlFile();
            return true;
        }

        private static bool ImportarArchivoKml(string filePath)
        {
            TextReader reader = File.OpenText(filePath);
            KmlFile file = KmlFile.Load(reader);
            Kml rootElement = (Kml)file.Root;

            if (rootElement == null)
            {
                return false;
            }

            foreach (Placemark placemark in rootElement.Flatten().OfType<Placemark>())
            {
                SharpKml.Base.Vector coordinates = ((SharpKml.Dom.Point)placemark.Geometry).Coordinate;

                Debug.Print($"Chapa: {placemark.Name}, Latitud: {coordinates.Latitude}, Longitud: {coordinates.Longitude}, Altitud: {coordinates.Altitude}");
            }

            return true;
        }
    }
}