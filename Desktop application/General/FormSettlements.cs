﻿using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormSettlements : Form
    {

        #region Declarations

        private const string entityNameSingle = "establecimiento";
        private const string entityNamePlural = "establecimientos";
        private const bool entityIsFemale = false;

        private List<DataGridViewRowData> entitiesAll;
        private List<DataGridViewRowData> entitiesFiltered;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

        public class DataGridViewRowData
        { 
            public short IdEstablecimiento { get; set; }
            public string Nombre { get; set; }
            public short? IdEntidad { get; set; }
            public string EntidadNombre { get; set; }
            public string TelefonoMovil { get; set; }
        }

        #endregion

        #region Form stuff

        public FormSettlements()
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
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageEstablecimiento32);
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
            Program.formMdi.formSettlements = null;
        }

        #endregion

        #region User interface data

        internal void ReadData(short idEstablecimiento = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                entitiesAll = [.. from es in context.Establecimientos
                                  join en in context.Entidades on es.IdEntidad equals en.IdEntidad into entidadesGrupo
                                  from eg in entidadesGrupo.DefaultIfEmpty()
                                  select new DataGridViewRowData { IdEstablecimiento = es.IdEstablecimiento, Nombre = es.Nombre, IdEntidad = es.IdEntidad, EntidadNombre = (eg == null ? string.Empty : eg.Nombre), TelefonoMovil = es.TelefonoMovil }];
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
                    idEstablecimiento = 0;
                }
                else
                {
                    idEstablecimiento = ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEstablecimiento;
                }
            }

            FilterData();

            // Restore position
            if (idEstablecimiento != 0)
            {
                foreach (DataGridViewRow row in DataGridViewMain.Rows)
                {
                    if (((DataGridViewRowData)row.DataBoundItem).IdEstablecimiento == idEstablecimiento)
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
            else if (sortedColumn == DataGridViewColumnEntidad)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.EntidadNombre).ThenBy(e => e.Nombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.EntidadNombre).ThenByDescending(e => e.Nombre)];
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
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnNombre, DataGridViewColumnEntidad, DataGridViewColumnTelefonoMovil]))
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
                FormSettlement formSettlement = new(true, 0);
                formSettlement.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormSettlement formSettlement = new(false, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEstablecimiento);
                formSettlement.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormSettlement formSettlement = new(true, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEstablecimiento);
                formSettlement.ShowDialog(this);
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
            string entidadDatos = $"Nombre: {rowData.Nombre}\nEntidad: {rowData.EntidadNombre}\nTeléfono móvil: {rowData.TelefonoMovil}";
            if (!Common.DataGridViews.DeleteConfirm(entityNameSingle, entityIsFemale, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.Establecimiento establecimiento = context.Establecimientos.Find(rowData.IdEstablecimiento);
                context.Establecimientos.Attach(establecimiento);
                context.Establecimientos.Remove(establecimiento);
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
