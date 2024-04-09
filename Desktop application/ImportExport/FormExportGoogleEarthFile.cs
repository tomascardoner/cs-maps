using CardonerSistemas.Framework.Base;
using Microsoft.EntityFrameworkCore;
using SharpKml.Base;
using SharpKml.Dom;

namespace CSMaps.General
{
    public partial class FormExportGoogleEarthFile : Form
    {

        #region Declarations

        const string DefaultFileName = "doc.kml";
        const string MapName = "SOS Rural - tranquera segura";
        const string StyleIdPrefix = "icon-";

        Models.CSMapsContext context = new();

        #endregion

        #region Form stuff

        public FormExportGoogleEarthFile()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            SetAppearance();
            Common.Lists.GetGroups(CheckedListBoxGrupos, context);
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageExport32);
            Forms.SetFont(this, Program.AppearanceConfig.Font);
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            this.Dispose();
        }

        #endregion

        #region Controls events

        private void ChangeSelection(bool? value)
        {
            for (int i = 0; i < CheckedListBoxGrupos.Items.Count; i++)
            {
                CheckedListBoxGrupos.SetItemChecked(i, value ?? !CheckedListBoxGrupos.GetItemChecked(i));
            }
        }

        private void ButtonGruposSeleccionarTodos_Click(object sender, EventArgs e)
        {
            ChangeSelection(true);
        }

        private void ButtonGruposSeleccionarNinguno_Click(object sender, EventArgs e)
        {
            ChangeSelection(false);
        }

        private void ButtonGruposInvertirSeleccion_Click(object sender, EventArgs e)
        {
            ChangeSelection(null);
        }

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
                Title = Properties.Resources.StringExportGoogleEarthFileSaveDialogTitle,
                Filter = Properties.Resources.StringGoogleEarthFileDialogFilter,
                CheckPathExists = true,
                AddExtension = true,
                CheckWriteAccess = true,
                DefaultExt = "kml",
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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (CheckedListBoxGrupos.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos uno de los grupos.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckedListBoxGrupos.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxFile.Text))
            {
                MessageBox.Show(Properties.Resources.StringExportFileNotSpecified, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Path.Exists(TextBoxFile.Text.Trim()) && MessageBox.Show("El archivo de destino ya existe y será reemplazado por el nuevo.\n\n¿Desea continuar?", Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            CreatKmlFile(TextBoxFile.Text.Trim());
        }

        #endregion

        #region Export functions

        private void CreatKmlFile(string filePath)
        {

            this.Cursor = Cursors.WaitCursor;

            Kml kml = new();
            Document document = CreateDocument(MapName);
            kml.Feature = document;
            try
            {
                foreach (Models.Grupo grupo in CheckedListBoxGrupos.CheckedItems)
                {
                    document.AddStyle(CreateStyle(grupo));
                    Folder folder = CreateFolder(grupo.Nombre);
                    document.AddFeature(folder);
                    if (!AddPlacemarks(grupo.IdGrupo, ref folder))
                    {
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error generando los datos para el archivo.");
                return;
            }

            try
            {
                var serializer = new SharpKml.Base.Serializer();
                using FileStream fileStream = new(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                fileStream.SetLength(0);
                serializer.Serialize(kml, fileStream);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error al guardar los datos en el archivo de destino.");
                return;
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show($"Se ha exportado correctamente la información al archivo de Google Earth especificado.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool AddPlacemarks(short idGrupo, ref Folder folder)
        {
            try
            {
                foreach (Models.Punto punto in from p in context.Puntos.Include(p => p.PuntoDato).ThenInclude(pd => pd.IdEstablecimientoNavigation).ThenInclude(e => e.IdEntidadNavigation)
                                               join gp in context.GrupoPuntos on p.IdPunto equals gp.IdPunto
                                               where gp.IdGrupo == idGrupo
                                               select p)
                {

                    folder.AddFeature(CreatePlacemark(punto, $"{StyleIdPrefix}{idGrupo}"));
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al obtener los puntos del grupo.");
                return false;
            }
        }

        private static Document CreateDocument(string name)
        {
            return new() { Name = name };
        }

        private static Style CreateStyle(Models.Grupo grupo)
        {
            Style style = new() { Id = $"{StyleIdPrefix}{grupo.IdGrupo}" };
            if (!string.IsNullOrWhiteSpace(grupo.IconoMapaDireccion))
            {
                style.Icon = new()
                {
                    Scale = 1,
                    Icon = new(new Uri(grupo.IconoMapaDireccion)),
                };
                if (!string.IsNullOrWhiteSpace(grupo.IconoMapaColor))
                {
                    style.Icon.Color = Color32.Parse(grupo.IconoMapaColor);
                }
                if (grupo.IconoMapaHotSpotX.HasValue && !string.IsNullOrWhiteSpace(grupo.IconoMapaHotSpotXunits) && grupo.IconoMapaHotSpotY.HasValue && !string.IsNullOrWhiteSpace(grupo.IconoMapaHotSpotYunits))
                {
                    style.Icon.Hotspot = new()
                    {
                        X = grupo.IconoMapaHotSpotX.Value,
                        XUnits = GetUnit(grupo.IconoMapaHotSpotXunits[0]),
                        Y = grupo.IconoMapaHotSpotY.Value,
                        YUnits = GetUnit(grupo.IconoMapaHotSpotYunits[0])
                    };
                }
            }
            if (!string.IsNullOrWhiteSpace(grupo.IconoMapaLeyendaTexto))
            {
                style.Balloon = new() { Text = grupo.IconoMapaLeyendaTexto };
            }
            return style;
        }

        private static Unit GetUnit(char value)
        {
            return char.ToLower(value) switch
            {
                'f' => Unit.Fraction,
                'p' => Unit.Pixel,
                'i' => Unit.InsetPixel,
                _ => throw new ArgumentOutOfRangeException(nameof(value))
            };
        }

        private static Folder CreateFolder(string nombre)
        {
            return new() { Name = nombre };
        }

        private static Placemark CreatePlacemark(Models.Punto punto, string styleId)
        {
            return new()
            {
                Name = punto.NombreExportar,
                Geometry = CreatePoint(punto),
                Description = new() { Text = punto.DescripcionExportar },
                PhoneNumber = punto.TelefonoMovilExportar,
                StyleUrl = new($"#{styleId}", UriKind.Relative)
            };
        }

        private static SharpKml.Dom.Point CreatePoint(Models.Punto punto)
        {
            return new()
            {
                Coordinate = new SharpKml.Base.Vector((double)punto.Latitud, (double)punto.Longitud, (double)punto.Altitud)
            };

        }

        #endregion

    }
}
