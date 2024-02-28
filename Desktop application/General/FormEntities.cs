using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormEntities : Form
    {
        private List<Models.Entidad> entidades;

        public FormEntities()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            SetAppearance();
            ReadData();
        }

        private void SetAppearance()
        {
            //this.Icon = Graphics.GetIconFromBitmap(Properties.Resources.ImageEntidad16);
            //this.Text = entidadNombreSingular.FirstCharToUpperCase();
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetControlsDataGridViews(this.Controls, false);
        }

        private bool ReadData()
        {
            try
            {
                using Models.CSMapsContext context = new();
                entidades = [.. context.Entidads];
                DataGridViewMain.AutoGenerateColumns = false;
                DataGridViewMain.DataSource = entidades;
                ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText("Entidad", "Entidades", entidades.Count);
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
                return false;
            }
        }

    }
}
