using System.Globalization;
using CardonerSistemas.Framework.Base;

namespace CSMaps.General;

public partial class FormPointsDataAndEvents : Form
{

    #region Declarations

    internal FormPointEvents FormPointEvents;

    private const string EntityNameSingle = "dato del punto";
    private const string EntityNamePlural = "datos de los puntos";
    private const bool EntityIsFemale = false;

    private List<Models.ObtenerPuntosDatosYEventosResult> _entitiesAll;
    private List<Models.ObtenerPuntosDatosYEventosResult> _entitiesFiltered;

    private readonly Users.Permissions.Actions _addPermission = Users.Permissions.Actions.PointDataAdd;
    private readonly Users.Permissions.Actions _editPermission = Users.Permissions.Actions.PointDataEdit;
    private readonly Users.Permissions.Actions _deletePermission = Users.Permissions.Actions.PointDataDelete;

    private DataGridViewColumn _sortedColumn;
    private SortOrder _sortOrder;

    private bool _skipFilterApply = true;

    #endregion Declarations

    #region Form stuff

    public FormPointsDataAndEvents()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        SetAppearance();

        ToolStripComboBoxNameAndSettlementFilterType.Items.AddRange([string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringTextFilterTypeCompositeBegin, "establecimientos"), string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringTextFilterTypeCompositeContains, "establecimientos"), string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringTextFilterTypeCompositeBegin, "nombres"), string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringTextFilterTypeCompositeContains, "nombres")]);
        ToolStripComboBoxNameAndSettlementFilterType.SelectedIndex = 1;
        using Models.CSMapsContext context = new();
        Common.Lists.GetEventosTipos(ToolStripComboBoxLastEventTypeFilter.ComboBox, context, true, true, true);

        // Set the initial sorted column of the grid
        _sortedColumn = DataGridViewColumnNombre;
        _sortOrder = SortOrder.Ascending;

        _skipFilterApply = false;
        _ = ReadData();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImagePuntoDato32);
        Forms.SetFont(this, Program.AppearanceConfig.Font);
        Common.Appearance.SetControlsDataGridViews(this.Controls, false);
    }

    private void This_Load(object sender, EventArgs e)
    {
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
    }

    private void This_FormClosed(object sender, FormClosedEventArgs e)
    {
        _entitiesAll = null;
        _entitiesFiltered = null;
    }

    #endregion Form stuff

    #region User interface data

    internal async Task ReadData(int idPunto = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            await using Models.CSMapsContext context = new();
            Models.CSMapsContextProcedures procedures = new(context);
            _entitiesAll = await procedures.ObtenerPuntosDatosYEventosAsync();
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
            idPunto = DataGridViewMain.CurrentRow == null
                ? 0
                : ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto;
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
        if (_skipFilterApply)
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;

        _entitiesFiltered = string.IsNullOrWhiteSpace(ToolStripTextBoxNameAndSettlementFilter.Text)
            ? _entitiesAll
            : ToolStripComboBoxNameAndSettlementFilterType.SelectedIndex switch
            {
                0 => [.. _entitiesAll.Where(p => p.EstablecimientoNombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().StartsWith(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                1 => [.. _entitiesAll.Where(p => p.EstablecimientoNombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().Contains(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                2 => [.. _entitiesAll.Where(p => p.PuntoNombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().StartsWith(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                3 => [.. _entitiesAll.Where(p => p.PuntoNombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().Contains(ToolStripTextBoxNameAndSettlementFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                _ => throw new NotImplementedException()
            };

        _entitiesFiltered = ToolStripComboBoxLastEventTypeFilter.ComboBox.SelectedValue switch
        {
            Constants.ByteFieldValueAll => _entitiesFiltered,
            Constants.ByteFieldValueNotSpecified => [.. _entitiesFiltered.Where(p => !p.IdEventoTipo.HasValue)],
            Constants.ByteFieldValueOther => [.. _entitiesFiltered.Where(p => p.IdEventoTipo.HasValue)],
            _ => [.. _entitiesFiltered.Where(p => p.IdEventoTipo == (byte)ToolStripComboBoxLastEventTypeFilter.ComboBox.SelectedValue)]
        };

        ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(EntityNameSingle, EntityNamePlural, _entitiesFiltered.Count);

        OrderData();
    }

    private void OrderData()
    {
        if (_sortedColumn == DataGridViewColumnNombre)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.PuntoNombre)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.PuntoNombre)];
        }
        else if (_sortedColumn == DataGridViewColumnEstablecimiento)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.EstablecimientoNombre).ThenBy(e => e.PuntoNombre)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.EstablecimientoNombre).ThenByDescending(e => e.PuntoNombre)];
        }
        else if (_sortedColumn == DataGridViewColumnChapaNumero)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.ChapaNumero)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.ChapaNumero)];
        }
        else if (_sortedColumn == DataGridViewColumnFechaHora)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.FechaHora).ThenBy(e => e.PuntoNombre)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.FechaHora).ThenByDescending(e => e.PuntoNombre)];
        }

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = _entitiesFiltered;
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
        this.Cursor = Cursors.Default;
    }

    #endregion User interface data

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
        if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref _sortedColumn, ref _sortOrder, [DataGridViewColumnNombre, DataGridViewColumnEstablecimiento, DataGridViewColumnChapaNumero, DataGridViewColumnFechaHora]))
        {
            OrderData();
        }
    }

    #endregion Controls events

    #region Main toolbar

    private void ToolStripButtonAdd_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.AddVerify(this, DataGridViewMain, _addPermission))
        {
            FormPointData formPointData = new(true, 0);
            formPointData.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonView_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            FormPointData formPointData = new(false, ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
            formPointData.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonViewOnMap_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            CardonerSistemas.Framework.Base.Maps.OpenMap(Convert.ToDouble(((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).Latitud), Convert.ToDouble(((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).Longitud), CardonerSistemas.Framework.Base.Maps.MapProviders.GoogleMaps, CardonerSistemas.Framework.Base.Maps.MapActions.Search);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _editPermission, EntityNameSingle, EntityIsFemale))
        {
            FormPointData formPointData = new(true, ((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
            formPointData.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonDelete_Click(object sender, EventArgs e)
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _deletePermission, EntityNameSingle, EntityIsFemale))
        {
            return;
        }

        var rowData = (Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Nombre: {rowData.PuntoNombre}\nLatitud: {rowData.Latitud}\nLongitud: {rowData.Longitud}\nEstablecimiento: {rowData.EstablecimientoNombre}\nNº de chapa:: {rowData.ChapaNumero}";
        if (!Common.DataGridViews.DeleteConfirm(EntityNameSingle, EntityIsFemale, entidadDatos))
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
                MessageBox.Show("Para poder borrar los datos de este punto, primero deberá borrar los eventos del mismo.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var puntoDato = context.PuntoDatos.Find(rowData.IdPunto);
            context.PuntoDatos.Attach(puntoDato);
            context.PuntoDatos.Remove(puntoDato);
            context.SaveChanges();
            Common.RefreshLists.PointsData();
        }
        catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
        {
            Common.DBErrors.DbUpdateException(dbUEx, EntityNameSingle, EntityIsFemale, Properties.Resources.StringActionDelete);
        }
        catch (Exception ex)
        {
            Common.DBErrors.OtherUpdateException(ex, EntityNameSingle, EntityIsFemale, Properties.Resources.StringActionDelete);
        }

        this.Cursor = Cursors.Default;
    }

    private void ToolStripButtonPointEventAdd_Click(object sender, EventArgs e)
    {
        if (DataGridViewMain.CurrentRow == null)
        {
            MessageBox.Show($"No hay ningún {EntityNameSingle} para agregar un evento.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"No hay ningún {EntityNameSingle} para ver sus eventos.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        FormPointEvents ??= new(((Models.ObtenerPuntosDatosYEventosResult)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
        FormPointEvents.ShowDialog(this);
    }

    #endregion Main toolbar

}
