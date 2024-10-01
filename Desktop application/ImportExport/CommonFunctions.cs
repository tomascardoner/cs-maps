using CardonerSistemas.Framework.Base;
using MediaDevices;

namespace CSMaps.ImportExport
{
    internal static class CommonFunctions
    {

        #region Declarations

        internal const string GarminFileName = "Current.gpx";
        internal const string GarminFileExtension = "gpx";

        const string ExpectedFileSystem = "FAT32";
        readonly static string[] ManufacturerExpectedContains = ["Garmin"];
        readonly static string[] FriendlyNameExpectedContains = ["Garmin"];
        readonly static string[] DirectoriesExpected = ["GPX", "Garmin\\GPX"];
        readonly static string[] VolumeNameExpectedContains = ["Garmin"];

        #endregion Declarations

        #region Find GPS devices and drives

        internal static void GetGpsDevicesAndDrives(ref List<MediaDevice> mediaDevices, ListView listView, TextBox textBox)
        {
            List<string> drivesBestCandidates = [];
            List<string> drivesOtherCandidates = [];

            string gpsFilePath = string.Empty;

            // Try to get GPS devices by using devices method
            if (!GetGpsDevices(ref mediaDevices, listView))
            {
                return;
            }

            // Gets list of possible drives
            if (!GetPossibleGpsDrives(ref drivesBestCandidates, ref drivesOtherCandidates))
            {
                return;
            }

            // Try directories in best candidates drives
            if (drivesBestCandidates.Exists(dbc => FindGpsDirectory(dbc, ref gpsFilePath)))
            {
                textBox.Text = gpsFilePath;
                return;
            }

            // Try directories in other candidates drives
            if (drivesOtherCandidates.Exists(doc => FindGpsDirectory(doc, ref gpsFilePath)))
            {
                textBox.Text = gpsFilePath;
                return;
            }

            MessageBox.Show("No se encontraron dispositivos o unidades de almacenamiento correspondientes a un GPS.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private static bool GetGpsDevices(ref List<MediaDevice> mediaDevices, ListView listView)
        {
            try
            {
                mediaDevices = [];
#pragma warning disable CA1862 // Use the 'StringComparison' method overloads to perform case-insensitive string comparisons
                foreach (MediaDevice mediaDevice in MediaDevice.GetDevices().Where(md => Array.Exists(ManufacturerExpectedContains, m => md.Manufacturer.ToLowerInvariant().Contains(m.ToLowerInvariant())) || Array.Exists(FriendlyNameExpectedContains, fn => md.FriendlyName.ToLowerInvariant().Contains(fn.ToLowerInvariant()))))
                {
                    mediaDevice.Connect();
                    if (mediaDevice.DeviceType == DeviceType.Generic && mediaDevice.FunctionalCategories().Any(fc => fc == FunctionalCategory.Storage))
                    {
                        MediaDriveInfo mediaDriveInfo = mediaDevice.GetDrives().FirstOrDefault();
                        MediaDirectoryInfo mediaDirectoryInfo = mediaDriveInfo?.RootDirectory;
                        if (mediaDirectoryInfo is not null)
                        {
                            foreach (string directory in DirectoriesExpected.Where(de => !string.IsNullOrWhiteSpace(de) && GpsDeviceDirectoryExists(de, ref mediaDirectoryInfo)))
                            {
                                mediaDevices.Add(mediaDevice);
                                listView.Items.Add(
                                    new ListViewItem([
                                        mediaDevice.Description.Trim(),
                                        mediaDriveInfo?.Name
                                            .Replace(Path.DirectorySeparatorChar.ToString(), string.Empty)
                                            .Replace(Path.AltDirectorySeparatorChar.ToString(), string.Empty)
                                        ])
                                    { Tag = mediaDirectoryInfo.FullName });
                            }
                        }
                    }
                    mediaDevice.Disconnect();
                }
                return mediaDevices.Count > 0;
#pragma warning restore CA1862 // Use the 'StringComparison' method overloads to perform case-insensitive string comparisons
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al obtener la lista de dispositivos del sistema.");
                return false;
            }
        }

        private static bool GpsDeviceDirectoryExists(string directory, ref MediaDirectoryInfo mediaDirectoryInfo)
        {
            char[] separators = [Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar];
            string firstDirectoryPart = directory.Split(separators, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[0];
            MediaDirectoryInfo targetMediaDirectoryInfo = mediaDirectoryInfo.EnumerateDirectories().FirstOrDefault(d => d.Name.Equals(firstDirectoryPart, StringComparison.InvariantCultureIgnoreCase));
            if (targetMediaDirectoryInfo is null)
            {
                return false;
            }
            mediaDirectoryInfo = targetMediaDirectoryInfo;
            if (directory.Length > firstDirectoryPart.Length)
            {
                return GpsDeviceDirectoryExists(directory[(firstDirectoryPart.Length + 1)..], ref mediaDirectoryInfo);
            }
            return true;
        }

        private static bool GetPossibleGpsDrives(ref List<string> bestCandidates, ref List<string> otherCandidates)
        {
            try
            {
                foreach (DriveInfo driveInfo in DriveInfo.GetDrives().Where(di => di.DriveType == DriveType.Removable && di.IsReady && di.DriveFormat == ExpectedFileSystem))
                {
#pragma warning disable CA1862 // Use the 'StringComparison' method overloads to perform case-insensitive string comparisons
                    if (Array.Exists(VolumeNameExpectedContains, vn => driveInfo.VolumeLabel.ToLowerInvariant().Contains(vn.ToLowerInvariant())))
                    {
                        bestCandidates.Add(driveInfo.RootDirectory.ToString());
                    }
                    else
                    {
                        otherCandidates.Add(driveInfo.RootDirectory.ToString());
                    }
#pragma warning restore CA1862 // Use the 'StringComparison' method overloads to perform case-insensitive string comparisons
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al obtener la información de las unidades de la computadora.");
                return false;
            }
        }

        private static bool FindGpsDirectory(string rootDirectory, ref string gpsFilePath)
        {
            string directoryName = (from de in DirectoriesExpected
                                    where Path.Exists(Path.Combine(rootDirectory, de))
                                    select de).FirstOrDefault();
            if (directoryName is null)
            {
                gpsFilePath = string.Empty;
                return false;
            }
            else
            {
                gpsFilePath = Path.Combine(rootDirectory, directoryName, GarminFileName);
                return true;
            }
        }

        #endregion

        #region Files

        internal static bool DeleteTempFileAndFolder(string tempFilePath, string tempPath = null)
        {
            try
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
                if (tempPath is not null && Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al eliminar el archivo temporario.");
                return false;
            }
        }

        #endregion Files

    }
}
