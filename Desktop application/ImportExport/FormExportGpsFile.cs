using CardonerSistemas.Framework.Base;
using Geo.Gps;
using MediaDevices;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CSMaps.General
{
    public partial class FormExportGpsFile : Form
    {

        #region Declarations

        const byte StepNumberMax = 3;

        const string DefaultFileName = "CSMaps.gpx";
        const string DefaultFileExtension = "gpx";
        const string ExpectedFileSystem = "FAT32";
        readonly string[] ManufacturerExpectedContains = ["Garmin"];
        readonly string[] FriendlyNameExpectedContains = ["Garmin"];
        readonly string[] DirectoriesExpected = ["GPX", "Garmin\\GPX"];
        readonly string[] VolumeNameExpectedContains = ["Garmin"];

        Models.CSMapsContext context = new();
        List<MediaDevice> mediaDevices;
        byte stepNumber = 1;

        #endregion

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
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageExport32);
            ShowControls();
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            mediaDevices = null;
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
                Title = Properties.Resources.StringExportGpsFileSaveDialogTitle,
                Filter = Properties.Resources.StringGpsFileDialogFilter,
                CheckPathExists = true,
                AddExtension = true,
                CheckWriteAccess = true,
                DefaultExt = DefaultFileExtension,
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

        #endregion

        #region Find GPS devices and drives

        private void GetGpsDevicesAndDrives()
        {
            List<string> drivesBestCandidates = [];
            List<string> drivesOtherCandidates = [];

            this.Cursor = Cursors.WaitCursor;
            string gpsFilePath = string.Empty;

            // Try to get GPS devices by using devices method
            GetGpsDevices();
            if (ListViewDevices.Items.Count > 0)
            {
                this.Cursor = Cursors.Default;
                return;
            }

            // Gets list of possible drives
            if (!GetPossibleGpsDrives(ref drivesBestCandidates, ref drivesOtherCandidates))
            {
                this.Cursor = Cursors.Default;
                return;
            }

            // Try directories in best candidates drives
            if (drivesBestCandidates.Exists(dbc => FindGpsDirectory(dbc, ref gpsFilePath)))
            {
                this.Cursor = Cursors.Default;
                TextBoxFile.Text = gpsFilePath;
                return;
            }

            // Try directories in other candidates drives
            if (drivesOtherCandidates.Exists(doc => FindGpsDirectory(doc, ref gpsFilePath)))
            {
                this.Cursor = Cursors.Default;
                TextBoxFile.Text = gpsFilePath;
                return;
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show("No se encontraron dispositivos o unidades de almacenamiento correspondientes a un GPS.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void GetGpsDevices()
        {
            try
            {
                mediaDevices = [];
                foreach (MediaDevice mediaDevice in MediaDevice.GetDevices().Where(md => Array.Exists(ManufacturerExpectedContains, m => md.Manufacturer.ToLowerInvariant().Contains(m.ToLowerInvariant())) || Array.Exists(FriendlyNameExpectedContains, fn => md.FriendlyName.ToLowerInvariant().Contains(fn.ToLowerInvariant()))))
                {
                    mediaDevice.Connect();
                    if (mediaDevice.DeviceType == DeviceType.Generic && mediaDevice.FunctionalCategories().Any(fc => fc == FunctionalCategory.Storage))
                    {
                        MediaDriveInfo mediaDriveInfo = mediaDevice.GetDrives().FirstOrDefault();
                        MediaDirectoryInfo mediaDirectoryInfo = mediaDriveInfo?.RootDirectory;
                        if (mediaDirectoryInfo != null)
                        {
                            foreach (string directory in DirectoriesExpected.Where(de => !string.IsNullOrWhiteSpace(de) && GpsDeviceDirectoryExists(de, ref mediaDirectoryInfo)))
                            {
                                mediaDevices.Add(mediaDevice);
                                ListViewDevices.Items.Add(
                                    new ListViewItem(
                                        new string[] {
                                        mediaDevice.Description.Trim(),
                                        mediaDriveInfo?.Name
                                            .Replace(Path.DirectorySeparatorChar.ToString(), string.Empty)
                                            .Replace(Path.AltDirectorySeparatorChar.ToString(), string.Empty)
                                        })
                                    { Tag = mediaDirectoryInfo.FullName });
                            }
                        }
                    }
                    mediaDevice.Disconnect();
                }
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al obtener la lista de dispositivos del sistema.");
            }

        }

        private static bool GpsDeviceDirectoryExists(string directory, ref MediaDirectoryInfo mediaDirectoryInfo)
        {
            char[] separators = [Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar];
            string firstDirectoryPart = directory.Split(separators, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[0];
            MediaDirectoryInfo targetMediaDirectoryInfo = mediaDirectoryInfo.EnumerateDirectories().FirstOrDefault(d => d.Name.Equals(firstDirectoryPart, StringComparison.InvariantCultureIgnoreCase));
            if (targetMediaDirectoryInfo == null)
            {
                return false;
            }
            mediaDirectoryInfo = targetMediaDirectoryInfo;
            if(directory.Length > firstDirectoryPart.Length)
            {
                return GpsDeviceDirectoryExists(directory[(firstDirectoryPart.Length + 1)..], ref mediaDirectoryInfo);
            }
            return true;
        }

        private bool GetPossibleGpsDrives(ref List<string> bestCandidates, ref List<string> otherCandidates)
        {

            try
            {
                foreach (DriveInfo driveInfo in DriveInfo.GetDrives().Where(di => di.DriveType == DriveType.Removable && di.IsReady && di.DriveFormat == ExpectedFileSystem))
                {
                    if (Array.Exists(VolumeNameExpectedContains, vn => driveInfo.VolumeLabel.ToLowerInvariant().Contains(vn.ToLowerInvariant())))
                    {
                        bestCandidates.Add(driveInfo.RootDirectory.ToString());
                    }
                    else
                    {
                        otherCandidates.Add(driveInfo.RootDirectory.ToString());
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

        private bool FindGpsDirectory(string rootDirectory, ref string gpsFilePath)
        {
            string directoryName = (from de in DirectoriesExpected
                                    where Path.Exists(Path.Combine(rootDirectory, de))
                                    select de).FirstOrDefault();
            if (directoryName == null)
            {
                gpsFilePath = string.Empty;
                return false;
            }
            else
            {
                gpsFilePath = Path.Combine(rootDirectory, directoryName, DefaultFileName);
                return true;
            }
        }

        #endregion

        #region Steps methods

        private void ShowControls()
        {
            GroupBoxStep1.Visible = stepNumber == 1;
            GroupBoxStep2.Visible = stepNumber == 2;
            GroupBoxSummary.Visible = stepNumber == 3;

            if (stepNumber == 1)
            {
                RadioButtonPointsWithData.Text = $"Sólo los que tienen datos asociados ({context.PuntoDatos.Count():N0} puntos).";
                RadioButtonPointsAll.Text = $"Todos ({context.Puntos.Count():N0} puntos).";
            }
            if (stepNumber == 2)
            {
                GetGpsDevicesAndDrives();
            }
            if (stepNumber == 3)
            {
                ShowSummary();
            }

            ButtonPrevious.Visible = stepNumber > 1;
            ButtonNext.Visible = stepNumber < StepNumberMax;
            ButtonFinish.Visible = stepNumber == StepNumberMax;
        }

        private void StepPrevious()
        {
            if (stepNumber > 1)
            {
                stepNumber--;
                ShowControls();
            }
        }

        private void StepNext()
        {
            if (stepNumber < StepNumberMax && StepVerifyRequirements())
            {
                stepNumber++;
                ShowControls();
            }
        }

        private bool StepVerifyRequirements()
        {
            switch (stepNumber)
            {
                case 1:
                    if (!RadioButtonPointsWithData.Checked && !RadioButtonPointsAll.Checked)
                    {
                        MessageBox.Show("Debe especificar qué puntos quiere incluir en el archivo a exportar.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show(Properties.Resources.StringExportDestinationNotSpecified, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!TextBoxFile.Text.Trim().IsNullOrEmpty() && !Path.Exists(FileSystem.GetPathWithoutFileName(TextBoxFile.Text)))
            {
                MessageBox.Show("La ubicación del archivo de destino a exportar no existe.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void ShowSummary()
        {
            string summary;
            if (RadioButtonPointsAll.Checked)
            {
                summary = $"Se exportarán todos los puntos del sistema (cantidad: {context.Puntos.Count():N0}).\n\n";
            }
            else
            {
                summary = $"Se exportarán sólo los puntos del sistema que tienen datos asociados (cantidad: {context.PuntoDatos.Count():N0}).\n\n";
            }
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

        #endregion

        #region Export GPX file

        private void ExportGpxFile()
        {
            bool destinationIsDevice = TextBoxFile.Text.IsNullOrEmpty();
            string fileFullPath;

            if (destinationIsDevice)
            {
                fileFullPath = Path.Combine(ListViewDevices.SelectedItems[0].Tag.ToString(), DefaultFileName);
            }
            else
            {
                fileFullPath = TextBoxFile.Text.Trim();
            }

            this.Cursor = Cursors.WaitCursor;
            if (!ExportVerifyDestination(destinationIsDevice, fileFullPath))
            {
                this.Cursor = Cursors.Default;
                return;
            }

            List<Models.Punto> puntos = ExportGetPoints();
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

            string tempPath = Path.GetTempPath();
            string tempFilePath = Path.Combine(tempPath, DefaultFileName);
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

            try
            {
                if (destinationIsDevice)
                {
                    File.Delete(tempFilePath);
                    Directory.Delete(tempPath);
                }
            }
            catch (Exception)
            {
                // Ignore the exception because if the file or directory delete fails, doesn't matter because is a temp file
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show($"Se ha exportado correctamente la información de {puntos.Count:N0} puntos al destino especificado.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ExportVerifyDestination(bool destinationIsDevice, string fileFullPath)
        {
            if (destinationIsDevice)
            {
                try
                {
                    using MediaDevice mediaDevice = mediaDevices[ListViewDevices.SelectedItems[0].Index];
                    mediaDevice.Connect();
                    if (mediaDevice.FileExists(fileFullPath) && MessageBox.Show(string.Format(Properties.Resources.StringFileDestinationConfirmOverwrite, Environment.NewLine), Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
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
            else if (Path.Exists(fileFullPath) && MessageBox.Show(Properties.Resources.StringFileDestinationConfirmOverwrite, Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        private List<Models.Punto> ExportGetPoints()
        {
            try
            {
                if (RadioButtonPointsWithData.Checked)
                {
                    return [.. context.Puntos
                                .Include(p => p.PuntoDato)
                                .ThenInclude(pd => pd.IdEstablecimientoNavigation)
                                .ThenInclude(e => e.IdEntidadNavigation)
                                .Where(p => p.PuntoDato != null)
                                .OrderBy(p => p.Nombre)];
                }
                else
                {
                    return [.. context.Puntos
                                .Include(p => p.PuntoDato)
                                .ThenInclude(pd => pd.IdEstablecimientoNavigation)
                                .ThenInclude(e => e.IdEntidadNavigation)
                                .OrderBy(p => p.Nombre)];
                }
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
                foreach (Models.Punto punto in puntos)
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
                using MediaDevice mediaDevice = mediaDevices[ListViewDevices.SelectedItems[0].Index];
                mediaDevice.Connect();
                if (mediaDevice.FileExists(fileFullPath))
                {
                    mediaDevice.DeleteFile(fileFullPath);
                }
                using FileStream fileStream = File.OpenRead(tempFilePath);
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

        #endregion

    }
}
