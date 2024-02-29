using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormEntities : Form
    {

        #region Declarations

        private List<Models.Entidad> entidades;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        #endregion

        #region Form stuff

        public FormEntities()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            ReadData();
        }

        private void SetAppearance()
        {
            //this.Icon = Graphics.GetIconFromBitmap(Properties.Resources.ImageEntidad16);
            //this.Text = entidadNombreSingular.FirstCharToUpperCase();
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetControlsDataGridViews(this.Controls, false);
        }

        private void FormEntities_Load(object sender, EventArgs e)
        {
            SetAppearance();
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void FormEntities_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMdi.formEntities = null;
        }

        #endregion

        #region User interface data

        private void ReadData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                entidades = [.. context.Entidads];
                ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText("Entidad", "Entidades", entidades.Count);
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            OrderData();
        }

        private void OrderData()
        {
            if (sortedColumn == DataGridViewColumnNombre)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entidades = [.. entidades.OrderBy(e => e.Nombre)];
                }
                else
                {
                    entidades = [.. entidades.OrderByDescending(e => e.Nombre)];
                }
            }
            else if (sortedColumn == DataGridViewColumnTelefonoMovil)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entidades = [.. entidades.OrderBy(e => e.TelefonoMovil)];
                }
                else
                {
                    entidades = [.. entidades.OrderByDescending(e => e.TelefonoMovil)];
                }
            }
            DataGridViewMain.AutoGenerateColumns = false;
            DataGridViewMain.DataSource = entidades;
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        #endregion

        #region Controls events

        private void DataGridViewMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnNombre, DataGridViewColumnTelefonoMovil]))
            {
                OrderData();
            }
        }

        private void DataGridViewMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sortedColumn == DataGridViewColumnNombre)
            {
                Common.DataGridViews.SearchByKeyPress(e, DataGridViewMain, DataGridViewColumnNombre);
            }
        }

        #endregion

    }
}
