using CardonerSistemas.Framework.Base;
using Geo.Gps;
using Microsoft.EntityFrameworkCore;

namespace CSMaps.General
{
    public partial class FormExportGpsFile : Form
    {

        #region Declarations

        const string DefaultFileName = "Current.gpx";

        Models.CSMapsContext context = new();

        #endregion

        #region Form stuff

        public FormExportGpsFile()
        {
            InitializeComponent();
            InitializeFormAndControls();
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();

            RadioButtonPointsWithData.Text = $"Sólo los que tienen datos asociados ({context.PuntoDatos.Count():N0} puntos).";
            RadioButtonPointsAll.Text = $"Todos ({context.Puntos.Count():N0} puntos).";
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageImport32);
            Forms.SetFont(this, Program.AppearanceConfig.Font);
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            Program.FormMdi.FormExportGarminFile = null;
            this.Dispose();
        }

        #endregion

        #region Controls events

        private void TextBoxFile_Enter(object sender, EventArgs e)
        {
            TextBoxFile.SelectAll();
        }

        private void ButtonFile_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new()
            {
                FileName = DefaultFileName,
                RestoreDirectory = true,
                Title = Properties.Resources.StringGpsFileSaveDialogTitle,
                Filter = Properties.Resources.StringGpsFileSaveDialogFilter,
                CheckPathExists = true,
                AddExtension = true,
                CheckWriteAccess = true,
                DefaultExt = "gpx",
                OverwritePrompt = true
            };
            if (string.IsNullOrWhiteSpace(TextBoxFile.Text))
            {
                saveFileDialog.InitialDirectory = Application.StartupPath;
            }
            else
            {
                string pathWithoutFileName = FileSystem.GetPathWithoutFileName(TextBoxFile.Text);
                if (!string.IsNullOrWhiteSpace(pathWithoutFileName) && Path.Exists(pathWithoutFileName))
                {
                    saveFileDialog.InitialDirectory = pathWithoutFileName;
                }
                else
                {
                    saveFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                TextBoxFile.Text = saveFileDialog.FileName;
                ButtonStart.Focus();
            }
        }

        private void ButtonFileFindGps_Click(object sender, EventArgs e)
        {
            FindGpsLocation();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxFile.Text))
            {
                MessageBox.Show(Properties.Resources.StringExportFileNotSpecified, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Path.Exists(TextBoxFile.Text.Trim()) && MessageBox.Show("El archivo de destino ya existe y será reemplazado por el nuevo.\n\n¿Desea continuar?", Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            ExportGpxFile(TextBoxFile.Text.Trim());
        }

        #endregion

        #region Misc functions

        private void FindGpsLocation()
        {
            List<string> drivesBestCandidates = [];
            List<string> drivesOtherCandidates = [];

            this.Cursor = Cursors.WaitCursor;
            string gpsFilePath = string.Empty;

            // Gets list of possible drives
            if (!GetPossibleGpsDrives(ref drivesBestCandidates, ref drivesOtherCandidates))
            {
                this.Cursor = Cursors.Default;
                return;
            }

            // Try directories in best candidates drives
            foreach (var _ in from string drive in drivesBestCandidates
                              where FindGpsDirectory(drive, ref gpsFilePath)
                              select new { })
            {
                this.Cursor = Cursors.Default;
                TextBoxFile.Text = gpsFilePath;
#pragma warning disable S1751	//Refactor the containing loop to do more than one iteration.
                return;
#pragma warning restore S1751    //Refactor the containing loop to do more than one iteration.                                                                
            }

            // Try directories in other candidates drives
            foreach (var _ in from string drive in drivesOtherCandidates
                              where FindGpsDirectory(drive, ref gpsFilePath)
                              select new { })
            {
                this.Cursor = Cursors.Default;
                TextBoxFile.Text = gpsFilePath;
#pragma warning disable S1751	//Refactor the containing loop to do more than one iteration.
                return;
#pragma warning restore S1751    //Refactor the containing loop to do more than one iteration.                                                                
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show("No se encontró la unidad de almacenamiento correspondiente al GPS.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool GetPossibleGpsDrives(ref List<string> bestCandidates, ref List<string> otherCandidates)
        {
            const string GpsExpectedFileSystem = "FAT32";
            string[] GpsVolumeNameExpectedContains = ["Garm"];

            try
            {
                foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
                {
                    if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady && driveInfo.DriveFormat == GpsExpectedFileSystem)
                    {

                        if (Array.Exists(GpsVolumeNameExpectedContains, vn => driveInfo.VolumeLabel.ToLowerInvariant().Contains(vn.ToLowerInvariant())))
                        {
                            bestCandidates.Add(driveInfo.RootDirectory.ToString());
                        }
                        else
                        {
                            otherCandidates.Add(driveInfo.RootDirectory.ToString());
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error al obtener la información de las unidades de la computadora.");
                return false;
            }
        }

        private static bool FindGpsDirectory(string rootDirectory, ref string gpsFilePath)
        {
            string[] GpsDirectoriesExpected = ["Garmin\\GPX", "GPX"];
            foreach (string directoryName in from string directoryName in GpsDirectoriesExpected
                                          where Path.Exists(Path.Combine(rootDirectory, directoryName))
                                          select directoryName)
            {
                gpsFilePath = Path.Combine(rootDirectory, directoryName, DefaultFileName);
#pragma warning disable S1751 //Refactor the containing loop to do more than one iteration.                                                                
                return true;
#pragma warning restore S1751 //Refactor the containing loop to do more than one iteration.                                                                
            }

            return false;
        }

        private void ExportGpxFile(string filePath)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Models.Punto> puntos;
            try
            {
                if (RadioButtonPointsWithData.Checked)
                {
                    puntos = [.. context.Puntos
                                .Include(p => p.PuntoDato)
                                .ThenInclude(pd => pd.IdEstablecimientoNavigation)
                                .ThenInclude(e => e.IdEntidadNavigation)
                                .Where(p => p.PuntoDato != null)
                                .OrderBy(p => p.Nombre)];
                }
                else
                {
                    puntos = [.. context.Puntos
                                .Include(p => p.PuntoDato)
                                .ThenInclude(pd => pd.IdEstablecimientoNavigation)
                                .ThenInclude(e => e.IdEntidadNavigation)
                                .OrderBy(p => p.Nombre)];
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error al obtener los puntos para exportar.");
                return;
            }

            GpsData gpsData = new();
            try
            {
                foreach (Models.Punto punto in puntos)
                {
                    Geo.Geometries.Point point = new((double)punto.Latitud, (double)punto.Longitud, (double)punto.Altitud);
                    gpsData.Waypoints.Add(new(point, punto.NombreExportar, punto.ComentarioExportar, punto.DescripcionExportar));
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error al convertir los puntos para exportar.");
                return;
            }

            try
            {
                Geo.Gps.Serialization.Gpx11Serializer serializer = new();
                using FileStream fileStream = new(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                serializer.Serialize(gpsData, fileStream);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error al guardar los datos en el archivo de destino.");
                return;
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show($"Se ha exportado correctamente la información de {puntos.Count:N0} puntos al archivo GPX especificado.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }
}
