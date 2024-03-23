using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormEntities : Form
    {

        #region Declarations

        private const string entityNameSingle = "entidad";
        private const string entityNamePlural = "entidades";
        private const bool entityIsFemale = true;

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

            ToolStripComboBoxNameFilterType.Items.AddRange([Properties.Resources.StringTextFilterTypeBegin, Properties.Resources.StringTextFilterTypeContains]);
            ToolStripComboBoxNameFilterType.SelectedIndex = 1;

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            skipFilterApply = false;
            ReadData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageEntidad32);
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetControlsDataGridViews(this.Controls, false);
        }

        private void This_Load(object sender, EventArgs e)
        {
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            entitiesAll = null;
            entitiesFiltered = null;
            Program.formMdi.formEntities = null;
        }

        #endregion

        #region User interface data

        internal void ReadData(short idEntidad = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                entitiesAll = [.. context.Entidades];
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
                return;
            }

            // Save position
            if (restoreCurrentPosition)
            {
                if (DataGridViewMain.CurrentRow == null)
                {
                    idEntidad = 0;
                }
                else
                {
                    idEntidad = ((Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem).IdEntidad;
                }
            }

            FilterData();

            // Restore position
            if (idEntidad != 0)
            {
                foreach (DataGridViewRow row in DataGridViewMain.Rows)
                {
                    if (((Models.Entidad)row.DataBoundItem).IdEntidad == idEntidad)
                    {
                        DataGridViewMain.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void FilterData()
        {
            if (skipFilterApply)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(ToolStripTextBoxNameFilter.Text))
            {
                entitiesFiltered = entitiesAll;
            }
            else
            {
                entitiesFiltered = ToolStripComboBoxNameFilterType.SelectedIndex switch
                {
                    0 => [.. entitiesAll.Where(e => e.Nombre.ToLower().ReplaceDiacritics().StartsWith(ToolStripTextBoxNameFilter.Text.ToLower().ReplaceDiacritics()))],
                    1 => [.. entitiesAll.Where(e => e.Nombre.ToLower().ReplaceDiacritics().Contains(ToolStripTextBoxNameFilter.Text.ToLower().ReplaceDiacritics()))],
                    _ => throw new NotImplementedException(),
                };
            }

            ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(entityNameSingle, entityNamePlural, entitiesFiltered.Count);

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
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Controls events

        private void ToolStripComboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void ToolStripTextBoxSearch_Enter(object sender, EventArgs e)
        {
            ToolStripTextBoxNameFilter.Select();
        }

        private void ToolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Common.Forms.Filter_KeyPress(e, ToolStripTextBoxNameFilter.TextBox))
            {
                FilterData();
                e.Handled = true;
            }
        }

        private void ToolStripButtonSearchClear_Click(object sender, EventArgs e)
        {
            ToolStripTextBoxNameFilter.Clear();
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

        #region Main toolbar

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain))
            {
                FormEntity formEntity = new(true, 0);
                formEntity.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormEntity formEntity = new(false, ((Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem).IdEntidad);
                formEntity.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormEntity formEntity = new(true, ((Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem).IdEntidad);
                formEntity.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                return;
            }

            Models.Entidad rowData = (Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Nombre: {rowData.Nombre}\nTeléfono móvil: {rowData.TelefonoMovil}";
            if (!Common.DataGridViews.DeleteConfirm(entityNameSingle, entityIsFemale, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.Entidad entidad = context.Entidades.Find(rowData.IdEntidad);
                context.Entidades.Attach(entidad);
                context.Entidades.Remove(entidad);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException dbUEx)
            {
                Common.DBErrors.DbUpdateException(dbUEx, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }
            catch (Exception ex)
            {
                Common.DBErrors.OtherUpdateException(ex, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }

            ReadData();
            this.Cursor = Cursors.Default;
        }

        #endregion

    }
}
