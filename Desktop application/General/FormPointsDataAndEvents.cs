using CardonerSistemas.Framework.Base;

namespace CSMaps.General
{
    public partial class FormPointsDataAndEvents : Form
    {

        #region Declarations

        internal FormPointEvents FormPointEvents;

        private const string entityNameSingle = "dato del punto";
        private const string entityNamePlural = "datos de los puntos";
        private const bool entityIsFemale = false;

        private List<Models.ObtenerPuntosDatosYEventosResult> entitiesAll;
        private List<Models.ObtenerPuntosDatosYEventosResult> entitiesFiltered;

        private readonly Users.Permissions.Actions addPermission = Users.Permissions.Actions.PointDataAdd;
        private readonly Users.Permissions.Actions editPermission = Users.Permissions.Actions.PointDataEdit;
        private readonly Users.Permissions.Actions deletePermission = Users.Permissions.Actions.PointDataDelete;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

        #endregion

        #region Form stuff

        public FormPointsDataAndEvents()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            SetAppearance();

            ToolStripComboBoxNameAndSettlementFilterType.Items.AddRange([string.Format(Properties.Resources.StringTextFilterTypeCompositeBegin, "establecimientos"), string.Format(Properties.Resources.StringTextFilterTypeCompositeContains, "establecimientos"), string.Format(Properties.Resources.StringTextFilterTypeCompositeBegin, "nombres"), string.Format(Properties.Resources.StringTextFilterTypeCompositeContains, "nombres")]);
            ToolStripComboBoxNameAndSettlementFilterType.SelectedIndex = 1;
            using Models.CSMapsContext context = new();
            Common.Lists.GetEventosTipos(ToolStripComboBoxLastEventTypeFilter.ComboBox, context, true, true, true);

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            skipFilterApply = false;
            _ = ReadData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImagePuntoDato32);
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

        internal async Task ReadData(int idPunto = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.CSMapsContextProcedures procedures = new(context);
                entitiesAll = await procedures.ObtenerPuntosDatosYEventosAsync();
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
                    idPunto = ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto;
                }
            }

            FilterData();

            // Restore position
            if (idPunto != 0)
            {
                foreach (DataGridViewRow row in DataGridViewMain.Rows)
                {
                    if (((Models.ObtenerPuntosDatosYEventosResult)row.DataBoundItem).IdPunto == idPunto)
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

            if (string.IsNullOrWhiteSpace(ToolStripTextBoxNameAndSettlementFilter.Text))
            {
                entitiesFiltered = entitiesAll;
            }
            else
            {
                entitiesFiltered = ToolStripComboBoxNameAndSettlementFilterType.SelectedIndex switch
                {
                    0 => [.. entitiesAll.Where(p => p.EstablecimientoNombre.ToLower().ReplaceDiacritics().StartsWith(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower().ReplaceDiacritics()))],
                    1 => [.. entitiesAll.Where(p => p.EstablecimientoNombre.ToLower().ReplaceDiacritics().Contains(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower().ReplaceDiacritics()))],
                    2 => [.. entitiesAll.Where(p => p.PuntoNombre.ToLower().ReplaceDiacritics().StartsWith(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower().ReplaceDiacritics()))],
                    3 => [.. entitiesAll.Where(p => p.PuntoNombre.ToLower().ReplaceDiacritics().Contains(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower().ReplaceDiacritics()))],
                    _ => throw new NotImplementedException()
                };
            }

            entitiesFiltered = ToolStripComboBoxLastEventTypeFilter.ComboBox.SelectedValue switch
            {
                CardonerSistemas.Framework.Base.Constants.ByteFieldValueAll => entitiesFiltered,
                CardonerSistemas.Framework.Base.Constants.ByteFieldValueNotSpecified => [.. entitiesFiltered.Where(p => !p.IdEventoTipo.HasValue)],
                CardonerSistemas.Framework.Base.Constants.ByteFieldValueOther => [.. entitiesFiltered.Where(p => p.IdEventoTipo.HasValue)],
                _ => [.. entitiesFiltered.Where(p => p.IdEventoTipo == (byte)ToolStripComboBoxLastEventTypeFilter.ComboBox.SelectedValue)]
            };

            ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(entityNameSingle, entityNamePlural, entitiesFiltered.Count);

            OrderData();
        }

        private void OrderData()
        {
            if (sortedColumn == DataGridViewColumnNombre)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.PuntoNombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.PuntoNombre)];
                }
            }
            else if (sortedColumn == DataGridViewColumnEstablecimiento)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.EstablecimientoNombre).ThenBy(e => e.PuntoNombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.EstablecimientoNombre).ThenByDescending(e => e.PuntoNombre)];
                }
            }
            else if (sortedColumn == DataGridViewColumnChapaNumero)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.ChapaNumero)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.ChapaNumero)];
                }
            }
            else if (sortedColumn == DataGridViewColumnFechaHora)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(e => e.FechaHora).ThenBy(e => e.PuntoNombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(e => e.FechaHora).ThenByDescending(e => e.PuntoNombre)];
                }
            }
            DataGridViewMain.AutoGenerateColumns = false;
            DataGridViewMain.DataSource = entitiesFiltered;
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Controls events

        private void ToolStripComboBoxNameAndSettlementFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void ToolStripTextBoxNameAndSettlementSearch_Enter(object sender, EventArgs e)
        {
            ToolStripTextBoxNameAndSettlementFilter.Select();
        }

        private void ToolStripTextBoxNameAndSettlementSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Common.Forms.Filter_KeyPress(e, ToolStripTextBoxNameAndSettlementFilter.TextBox))
            {
                FilterData();
                e.Handled = true;
            }
        }

        private void ToolStripButtonNameAndSettlementSearchClear_Click(object sender, EventArgs e)
        {
            ToolStripTextBoxNameAndSettlementFilter.Clear();
            FilterData();
        }

        private void ToolStripComboBoxLastEventTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void DataGridViewMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnNombre, DataGridViewColumnEstablecimiento, DataGridViewColumnChapaNumero, DataGridViewColumnFechaHora]))
            {
                OrderData();
            }
        }

        #endregion

        #region Main toolbar

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain, addPermission))
            {
                FormPointData formPointData = new(true, 0);
                formPointData.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormPointData formPointData = new(false, ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
                formPointData.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, editPermission, entityNameSingle, entityIsFemale))
            {
                FormPointData formPointData = new(true, ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
                formPointData.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, deletePermission, entityNameSingle, entityIsFemale))
            {
                return;
            }

            Models.ObtenerPuntosDatosYEventosResult rowData = (Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Nombre: {rowData.PuntoNombre}\nLatitud: {rowData.Latitud}\nLongitud: {rowData.Longitud}\nEstablecimiento: {rowData.EstablecimientoNombre}\nNº de chapa:: {rowData.ChapaNumero}";
            if (!Common.DataGridViews.DeleteConfirm(entityNameSingle, entityIsFemale, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                if (context.PuntoEventos.Any(pe => pe.IdPunto == rowData.IdPunto))
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Para poder borrar los datos de este punto, primero deberá borrar los eventos del mismo.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Models.PuntoDato puntoDato = context.PuntoDatos.Find(rowData.IdPunto);
                context.PuntoDatos.Attach(puntoDato);
                context.PuntoDatos.Remove(puntoDato);
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

            Common.RefreshLists.PointsData();
            this.Cursor = Cursors.Default;
        }

        private void ToolStripButtonPointEventAdd_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain.CurrentRow == null)
            {
                MessageBox.Show($"No hay ningún {entityNameSingle} para agregar un evento.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Users.Permissions.Verify(Users.Permissions.Actions.PointEventAdd))
            {
                return;
            }
            FormPointEvent formPointEvent = new(true, ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto, 0);
            formPointEvent.ShowDialog(this);
        }

        private void ToolStripButtonPointEvents_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain.CurrentRow == null)
            {
                MessageBox.Show($"No hay ningún {entityNameSingle} para ver sus eventos.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormPointEvents ??= new(((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
            FormPointEvents.ShowDialog(this);
        }

        #endregion

    }
}
