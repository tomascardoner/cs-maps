using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormPoints : Form
    {

        #region Declarations

        private const string entityNameSingle = "punto";
        private const string entityNamePlural = "puntos";
        private const bool entityIsFemale = false;

        private List<DataGridViewRowData> entitiesAll;
        private List<DataGridViewRowData> entitiesFiltered;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

        public class DataGridViewRowData
        {
            public int IdPunto { get; set; }
            public string Nombre { get; set; }
            public decimal Latitud { get; set; }
            public decimal Longitud { get; set; }
            public bool ExisteDato { get; set; }
            public string EstablecimientoNombre { get; set; }
            public int? ChapaNumero { get; set; }
        }

        #endregion

        #region Form stuff

        public FormPoints()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            SetAppearance();

            ToolStripComboBoxNameFilterType.Items.AddRange([Properties.Resources.StringTextFilterTypeBegin, Properties.Resources.StringTextFilterTypeContains]);
            ToolStripComboBoxNameFilterType.SelectedIndex = 1;
            Common.Lists.GetAllYesNo(ToolStripComboBoxDataExistFilter.ComboBox, 0);

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            skipFilterApply = false;
            ReadData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImagePunto32);
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
            Program.formMdi.formPoints = null;
        }

        #endregion

        #region User interface data

        internal void ReadData(int idPunto = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
#pragma warning disable IDE0031 // Use null propagation
                entitiesAll = [.. from p in context.Puntos
                                  join pd in context.PuntoDatos on p.IdPunto equals pd.IdPunto into puntoDatosGrupo
                                  from pdg in puntoDatosGrupo.DefaultIfEmpty()
                                  join e in context.Establecimientos on pdg.IdEstablecimiento equals e.IdEstablecimiento into establecimientosGrupo
                                  from eg in establecimientosGrupo.DefaultIfEmpty()
                                  select new DataGridViewRowData { IdPunto = p.IdPunto, Nombre = p.Nombre, Latitud = p.Latitud, Longitud = p.Longitud, ExisteDato =  eg != null, EstablecimientoNombre = (eg == null ? string.Empty : eg.Nombre), ChapaNumero = (pdg == null ? null : pdg.ChapaNumero) }];
#pragma warning restore IDE0031 // Use null propagation
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
                    idPunto = 0;
                }
                else
                {
                    idPunto = ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto;
                }
            }

            FilterData();

            // Restore position
            if (idPunto != 0)
            {
                foreach (DataGridViewRow row in DataGridViewMain.Rows)
                {
                    if (((DataGridViewRowData)row.DataBoundItem).IdPunto == idPunto)
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

            this.Cursor = Cursors.WaitCursor;

            if (string.IsNullOrWhiteSpace(ToolStripTextBoxNameFilter.Text))
            {
                entitiesFiltered = entitiesAll;
            }
            else
            {
                entitiesFiltered = ToolStripComboBoxNameFilterType.SelectedIndex switch
                {
                    0 => [.. entitiesAll.Where(p => p.Nombre.ToLower().ReplaceDiacritics().StartsWith(ToolStripTextBoxNameFilter.Text.ToLower().ReplaceDiacritics()))],
                    1 => [.. entitiesAll.Where(p => p.Nombre.ToLower().ReplaceDiacritics().Contains(ToolStripTextBoxNameFilter.Text.ToLower().ReplaceDiacritics()))],
                    _ => throw new NotImplementedException(),
                };
            }

            switch (ToolStripComboBoxDataExistFilter.SelectedIndex)
            {
                case 1:
                    entitiesFiltered = [.. entitiesFiltered.Where(p => p.ExisteDato)];
                    break;
                case 2:
                    entitiesFiltered = [.. entitiesFiltered.Where(p => !p.ExisteDato)];
                    break;
                default:
                    break;
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
            else if (sortedColumn == DataGridViewColumnEstablecimiento)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.Nombre).ThenBy(e => e.EstablecimientoNombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.Nombre).ThenByDescending(e => e.EstablecimientoNombre)];
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

        private void ToolStripComboBoxDataExistFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void DataGridViewMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnNombre, DataGridViewColumnEstablecimiento]))
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

        private void ToolStripButtonShowButtons_Click(object sender, EventArgs e)
        {
            ToolStripButtonShowButtons.Checked = !ToolStripButtonShowButtons.Checked;
            ToolStripButtonAdd.Visible = ToolStripButtonShowButtons.Checked;
            ToolStripButtonView.Visible = ToolStripButtonShowButtons.Checked;
            ToolStripButtonEdit.Visible = ToolStripButtonShowButtons.Checked;
            ToolStripButtonDelete.Visible = ToolStripButtonShowButtons.Checked;
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain))
            {
                FormPoint FormPoint = new(true, 0);
                FormPoint.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormPoint FormPoint = new(false, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
                FormPoint.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormPoint FormPoint = new(true, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
                FormPoint.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                return;
            }

            DataGridViewRowData rowData = (DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Nombre: {rowData.Nombre}\nLatitud: {rowData.Latitud}\nLogitud: {rowData.Longitud}";
            if (!Common.DataGridViews.DeleteConfirm(entityNameSingle, entityIsFemale, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.Punto punto = context.Puntos.Find(rowData.IdPunto);
                context.Puntos.Attach(punto);
                context.Puntos.Remove(punto);
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

        private void ToolStripButtonDataComplete_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonDataDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
