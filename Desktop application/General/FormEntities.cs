using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormEntities : Form
    {

        #region Declarations

        private List<Models.Entidad> entitiesAll;
        private List<Models.Entidad> entitiesFiltered;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

        #endregion

        #region Form stuff

        public FormEntities()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            SetAppearance();

            ToolStripComboBoxFilterType.Items.AddRange([Properties.Resources.StringTextFilterTypeBegin, Properties.Resources.StringTextFilterTypeContains]);
            ToolStripComboBoxFilterType.SelectedIndex = 0;

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            skipFilterApply = false;
            ReadData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageEntidad16);
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetControlsDataGridViews(this.Controls, false);
        }

        private void FormEntities_Load(object sender, EventArgs e)
        {
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void FormEntities_FormClosed(object sender, FormClosedEventArgs e)
        {
            entitiesAll = null;
            entitiesFiltered = null;
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
                entitiesAll = [.. context.Entidads];
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            FilterData();
        }

        private void FilterData()
        {
            if (skipFilterApply)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(ToolStripTextBoxFilter.Text))
            {
                entitiesFiltered = entitiesAll;
            }
            else
            {
                entitiesFiltered = ToolStripComboBoxFilterType.SelectedIndex switch
                {
                    0 => [.. entitiesAll.Where(e => e.Nombre.ToLower().ReplaceDiacritics().StartsWith(ToolStripTextBoxFilter.Text.ToLower().ReplaceDiacritics()))],
                    1 => [.. entitiesAll.Where(e => e.Nombre.ToLower().ReplaceDiacritics().Contains(ToolStripTextBoxFilter.Text.ToLower().ReplaceDiacritics()))],
                    _ => throw new NotImplementedException(),
                };                
            }

            ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText("Entidad", "Entidades", entitiesFiltered.Count);

            OrderData();
        }

        private void OrderData()
        {
            if (sortedColumn == DataGridViewColumnNombre)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.Nombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.Nombre)];
                }
            }
            else if (sortedColumn == DataGridViewColumnTelefonoMovil)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.TelefonoMovil)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.TelefonoMovil)];
                }
            }
            DataGridViewMain.AutoGenerateColumns = false;
            DataGridViewMain.DataSource = entitiesFiltered;
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        #endregion

        #region Controls events

        private void ToolStripComboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void ToolStripTextBoxSearch_Enter(object sender, EventArgs e)
        {
            ToolStripTextBoxFilter.Select();
        }

        private void ToolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                FilterData();
                e.Handled = true;
            }
        }

        private void ToolStripButtonSearchClear_Click(object sender, EventArgs e)
        {
            ToolStripTextBoxFilter.Clear();
            FilterData();
        }

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
