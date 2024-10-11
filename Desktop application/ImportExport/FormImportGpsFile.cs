using CardonerSistemas.Framework.Base;
using Geo;
using Geo.Gps;
using MediaDevices;
using Microsoft.IdentityModel.Tokens;

namespace CSMaps.ImportExport
{
    public partial class FormImportGpsFile : Form
    {

        #region Declarations

        Models.CSMapsContext _DbContext = new();
        List<MediaDevice> _MediaDevices;

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

        List<Models.Punto> _PuntosCoincidentes;
        List<PuntosGpsBD> _PuntosCoincidentesCoordenadas;
        List<PuntosGpsBD> _PuntosCoincidentesNombres;
        List<Models.Punto> _PuntosNuevos;

        int _PuntosNuevosCount;
        int _PuntosCoincidentesCoordenadasCount;
        int _PuntosCoincidentesNombresCount;

        bool _SourceIsDevice;
        string _FileFullPath;

        const byte StepNumberMax = 3;
        byte _StepNumberCurrent = 1;

        #endregion

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

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            _DbContext.Dispose();
            _DbContext = null;
            _MediaDevices = null;
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
                string pathWithoutFileName = FileSystem.GetPathWithoutFileName(TextBoxFile.Text);
                if (!string.IsNullOrWhiteSpace(pathWithoutFileName) && Path.Exists(pathWithoutFileName))
                {
                    openFileDialog.InitialDirectory = pathWithoutFileName;
                }
                else
                {
                    openFileDialog.InitialDirectory = Application.StartupPath;
                }
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

        #endregion

        #region Steps methods

        private void ShowControls()
        {
            GroupBoxStep1.Visible = _StepNumberCurrent == 1;
            GroupBoxStep2.Visible = _StepNumberCurrent == 2;
            GroupBoxSummary.Visible = _StepNumberCurrent == 3;

            if (_StepNumberCurrent == 1)
            {
                this.Cursor = Cursors.WaitCursor;
                CommonFunctions.GetGpsDevicesAndDrives(ref _MediaDevices, ListViewDevices, TextBoxFile);
                this.Cursor = Cursors.Default;
            }
            if (_StepNumberCurrent == 2)
            {
                this.Cursor = Cursors.WaitCursor;
                ReadGpxFile();
                this.Cursor = Cursors.Default;
            }
            if (_StepNumberCurrent == 3)
            {
                ShowSummary();
            }

            ButtonPrevious.Visible = _StepNumberCurrent > 1;
            ButtonNext.Visible = _StepNumberCurrent < StepNumberMax;
            ButtonFinish.Visible = _StepNumberCurrent == StepNumberMax;
        }

        private void StepPrevious()
        {
            if (_StepNumberCurrent > 1)
            {
                _StepNumberCurrent--;
                ShowControls();
            }
        }

        private void StepNext()
        {
            if (_StepNumberCurrent < StepNumberMax && StepVerifyRequirements())
            {
                _StepNumberCurrent++;
                ShowControls();
            }
        }

        private bool StepVerifyRequirements()
        {
            return _StepNumberCurrent switch
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
            _PuntosNuevosCount = CountDataGridMarkedRows(DataGridViewPuntosNuevos, 0);
            _PuntosCoincidentesCoordenadasCount = CountDataGridMarkedRows(DataGridViewPuntosCoincidentesCoordenadas, 2);
            _PuntosCoincidentesNombresCount = CountDataGridMarkedRows(DataGridViewPuntosCoincidentesNombres, 1);

            if (_PuntosNuevosCount + _PuntosCoincidentesCoordenadasCount + _PuntosCoincidentesNombresCount == 0)
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
            summary += $"Puntos nuevos: {_PuntosNuevosCount:N0}\n";
            summary += $"Puntos coincidentes por coordenadas: {_PuntosCoincidentesCoordenadasCount:N0}\n";
            summary += $"Puntos coincidentes por nombres: {_PuntosCoincidentesNombresCount:N0}\n\n";
            summary += $"Puntos totales a importar: {_PuntosNuevosCount + _PuntosCoincidentesCoordenadasCount + _PuntosCoincidentesNombresCount:N0}\n\n";
            if (_SourceIsDevice)
            {
                summary += $"El dispositivo de origen es: {ListViewDevices.SelectedItems[0].Text} - unidad {ListViewDevices.SelectedItems[0].SubItems[1].Text}";
            }
            else
            {
                summary += $"El archivo de origen es: {_FileFullPath}";
            }

            LabelSummary.Text = summary;
        }

        #endregion

        #region Import GPX file

        private void ReadGpxFile()
        {
            _SourceIsDevice = TextBoxFile.Text.IsNullOrEmpty();

            this.Cursor = Cursors.WaitCursor;

            if (_SourceIsDevice)
            {
                // Descargo el archivo desde el dispositivo a la carpeta Temp
                _FileFullPath = Path.Combine(Path.GetTempPath(), CommonFunctions.GarminFileName);
                if (!ImportDownloadFileFromDevice(_FileFullPath, Path.Combine(ListViewDevices.SelectedItems[0].Tag.ToString(), CommonFunctions.GarminFileName)))
                {
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            else
            {
                _FileFullPath = TextBoxFile.Text.Trim();
            }

            if (!ImportGetGpsData(_FileFullPath))
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
                using MediaDevice mediaDevice = _MediaDevices[ListViewDevices.SelectedItems[0].Index];
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
                _PuntosCoincidentes = [];
                _PuntosCoincidentesCoordenadas = [];
                _PuntosCoincidentesNombres = [];
                _PuntosNuevos = [];

                GpsData gpsData;
                Geo.Gps.Serialization.Gpx11Serializer serializer = new();
                using FileStream fileStream = new(fileFullPath, FileMode.Open, FileAccess.Read, FileShare.None);
                Geo.Gps.Serialization.StreamWrapper streamWrapper = new(fileStream);
                gpsData = serializer.DeSerialize(streamWrapper);
                using Models.CSMapsContext dbContext = new();
                foreach (Waypoint waypoint in gpsData.Waypoints)
                {
                    if (!ImportFindPointFromGpsWaypoint(dbContext, waypoint))
                    {
                        return false;
                    }
                }

                _PuntosNuevos = [.. _PuntosNuevos.OrderBy(p => p.Nombre)];
                DataGridViewPuntosNuevos.AutoGenerateColumns = false;
                DataGridViewPuntosNuevos.DataSource = _PuntosNuevos;
                LabelPuntosNuevosCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _PuntosNuevos.Count);

                _PuntosCoincidentesCoordenadas = [.. _PuntosCoincidentesCoordenadas.OrderBy(p => p.LatitudGps).ThenBy(p => p.LongitudGps)];
                DataGridViewPuntosCoincidentesCoordenadas.AutoGenerateColumns = false;
                DataGridViewPuntosCoincidentesCoordenadas.DataSource = _PuntosCoincidentesCoordenadas;
                LabelPuntosCoincidentesCoordenadasCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _PuntosCoincidentesCoordenadas.Count);

                _PuntosCoincidentesNombres = [.. _PuntosCoincidentesNombres.OrderBy(p => p.LatitudGps).ThenBy(p => p.LongitudGps)];
                DataGridViewPuntosCoincidentesNombres.AutoGenerateColumns = false;
                DataGridViewPuntosCoincidentesNombres.DataSource = _PuntosCoincidentesNombres;
                LabelPuntosCoincidentesNombresCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _PuntosCoincidentesNombres.Count);

                _PuntosCoincidentes = [.. _PuntosCoincidentes.OrderBy(p => p.Nombre)];
                DataGridViewPuntosCoincidentes.AutoGenerateColumns = false;
                DataGridViewPuntosCoincidentes.DataSource = _PuntosCoincidentes;
                LabelPuntosCoincidentesCount.Text = Common.DataGridViews.GetItemsCountText("punto", "puntos", _PuntosCoincidentes.Count);

                if (_SourceIsDevice)
                {
                    CommonFunctions.DeleteTempFileAndFolder(_FileFullPath);
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
                bool added = false;

                // Busco por coordenada
                foreach (Models.Punto punto in dbContext.Puntos.Where(p => p.Latitud == (decimal)waypoint.Coordinate.Latitude && p.Longitud == (decimal)waypoint.Coordinate.Longitude))
                {
                    if (punto.Nombre == waypoint.Name.Trim() && (waypoint.Coordinate.Is3D && punto.Altitud == (decimal)((CoordinateZ)waypoint.Coordinate).Elevation) || (!waypoint.Coordinate.Is3D && punto.Altitud == 0))
                    {
                        _PuntosCoincidentes.Add(punto);
                    }
                    else
                    {
                        _PuntosCoincidentesCoordenadas.Add(new()
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
                foreach (Models.Punto punto in dbContext.Puntos.Where(p => !_PuntosCoincidentes.Contains(p) && p.Nombre == waypoint.Name.Trim()))
                {
                    if (!_PuntosCoincidentesCoordenadas.Exists(p => p.LatitudGps != p.LatitudBD || p.LongitudGps != p.LongitudBD))
                    {
                        _PuntosCoincidentesNombres.Add(new()
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
                _PuntosNuevos.Add(new()
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
                if (_PuntosNuevosCount > 0)
                {
                    int idPunto = 0;
                    if (dbContext.Puntos.Any())
                    { 
                        idPunto = dbContext.Puntos.Max(p => p.IdPunto);
                    }
                    foreach (DataGridViewRow row in DataGridViewPuntosNuevos.Rows)
                    {
                        if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                        {
                            idPunto++;
                            Models.Punto puntoAdd = (Models.Punto)row.DataBoundItem;
                            puntoAdd.IdPunto = idPunto;
                            puntoAdd.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                            puntoAdd.FechaHoraCreacion = DateTime.Now;
                            puntoAdd.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
                            puntoAdd.FechaHoraUltimaModificacion = puntoAdd.FechaHoraCreacion;
                            dbContext.Puntos.Add(puntoAdd);
                        }
                    }
                }

                // Puntos coincidentes por coordenadas
                if (_PuntosCoincidentesCoordenadasCount > 0)
                {
                    foreach (DataGridViewRow row in DataGridViewPuntosCoincidentesCoordenadas.Rows)
                    {
                        if (row.Cells[2].Value != null && (bool)row.Cells[2].Value)
                        {
                            PuntosGpsBD puntoFromUpdate = (PuntosGpsBD)row.DataBoundItem;
                            Models.Punto puntoToUpdate = dbContext.Puntos.FirstOrDefault(p => p.IdPunto == puntoFromUpdate.IdPunto);
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
                                puntoToUpdate.FechaHoraUltimaModificacion = DateTime.Now;
                            }
                        }
                    }
                }

                // Puntos coincidentes por nombres
                if (_PuntosCoincidentesNombresCount > 0)
                {
                    foreach (DataGridViewRow row in DataGridViewPuntosCoincidentesNombres.Rows)
                    {
                        if (row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                        {
                            PuntosGpsBD puntoFromUpdate = (PuntosGpsBD)row.DataBoundItem;
                            Models.Punto puntoToUpdate = dbContext.Puntos.FirstOrDefault(p => p.IdPunto == puntoFromUpdate.IdPunto);
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
                                puntoToUpdate.FechaHoraUltimaModificacion = DateTime.Now;
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

        #endregion

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
            int counter = 0;
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
}
