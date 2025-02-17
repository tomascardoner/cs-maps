﻿using CardonerSistemas.Framework.Base;
using CSMaps.Users;

namespace CSMaps.General
{
    public partial class FormPoints : Form
    {

        #region Declarations

        private const string entityNameSingle = "punto";
        private const string entityNamePlural = "puntos";
        private const bool entityIsFemale = false;

        private List<Models.Punto> entitiesAll;
        private List<Models.Punto> entitiesFiltered;

        private readonly Permissions.Actions addPermission = Permissions.Actions.PointAdd;
        private readonly Permissions.Actions editPermission = Permissions.Actions.PointEdit;
        private readonly Permissions.Actions deletePermission = Permissions.Actions.PointDelete;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

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

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            skipFilterApply = false;
            ReadData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImagePunto32);
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
        }

        #endregion

        #region User interface data

        internal void ReadData(int idPunto = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                entitiesAll = [.. context.Puntos];
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
                    idPunto = ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto;
                }
            }

            FilterData();

            // Restore position
            if (idPunto != 0)
            {
                foreach (DataGridViewRow row in DataGridViewMain.Rows)
                {
                    if (((Models.Punto)row.DataBoundItem).IdPunto == idPunto)
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
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnNombre]))
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
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain, addPermission))
            {
                FormPoint formPoint = new(true, 0);
                formPoint.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormPoint formPoint = new(false, ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
                formPoint.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonViewOnMap_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                Maps.FormViewer formViewer = new(((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).Latitud, ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).Longitud);
                Program.FormMdi.ShowMdiForm(formViewer, true);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, editPermission, entityNameSingle, entityIsFemale))
            {
                FormPoint formPoint = new(true, ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
                formPoint.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, deletePermission, entityNameSingle, entityIsFemale))
            {
                return;
            }

            Models.Punto rowData = (Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Nombre: {rowData.Nombre}\nLatitud: {rowData.Latitud}\nLongitud: {rowData.Longitud}\nAltitud: {rowData.Altitud}";
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
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                Common.DBErrors.DbUpdateException(dbUEx, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }
            catch (Exception ex)
            {
                Common.DBErrors.OtherUpdateException(ex, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }

            Common.RefreshLists.Points();
            this.Cursor = Cursors.Default;
        }

        #endregion

    }
}
