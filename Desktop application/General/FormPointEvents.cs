using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Main;

namespace CSMaps.General;

public partial class FormPointEvents : Form
{

    #region Declarations

    private const string EntityNameSingle = "evento del punto";
    private const string EntityNamePlural = "eventos del punto";
    private const bool EntityIsFemale = false;

    private readonly int _idPunto;
    private List<DataGridViewRowData> _entitiesAll;
    private List<DataGridViewRowData> _entitiesFiltered;

    private readonly Users.Permissions.Actions _addPermission = Users.Permissions.Actions.PointEventAdd;
    private readonly Users.Permissions.Actions _editPermission = Users.Permissions.Actions.PointEventEdit;
    private readonly Users.Permissions.Actions _deletePermission = Users.Permissions.Actions.PointEventDelete;

    private ToolStripControlHost _hostDateTimePickerDateFilterFrom;
    private ToolStripControlHost _hostDateTimePickerDateFilterTo;

    private DataGridViewColumn _sortedColumn;
    private SortOrder _sortOrder;

    private bool _skipFilterApply = true;

    public class DataGridViewRowData
    {
        public short IdEvento { get; set; }
        public byte IdEventoTipo { get; set; }
        public string EventoTipoNombre { get; set; }
        public DateTime FechaHora { get; set; }
    }

    #endregion

    #region Form stuff

    public FormPointEvents(int idPuntoOrigen)
    {
        InitializeComponent();

        _idPunto = idPuntoOrigen;

        InitializeForm();
    }

    private void InitializeForm()
    {
        SetAppearance();

        InitializeDateFilter();
        ToolStripComboBoxDateFilterPeriodType.ComboBox.Items.AddRange(DateAndTime.GetPeriodTypes());
        ToolStripComboBoxDateFilterPeriodType.ComboBox.SelectedItem = DateAndTime.PeriodTypes.All;

        using Models.CSMapsContext context = new();
        SetDataToUserInterface(context);
        Common.Lists.GetEventosTipos(ToolStripComboBoxEventTypeFilter.ComboBox, context, true, false, false);

        // Set the initial sorted column of the grid
        _sortedColumn = DataGridViewColumnFechaHora;
        _sortOrder = SortOrder.Descending;

        _skipFilterApply = false;
        ReadData();
    }

    private void SetAppearance()
    {
        Forms.SetFont(this, Program.AppearanceConfig.Font);
        Common.Appearance.SetControlsDataGridViews(this.Controls, true);
    }

    private void InitializeDateFilter()
    {
#pragma warning disable S6562 // Always set the "DateTimeKind" when creating new "DateTime" instances

        // Date from control
        DateTimePicker dateTimePickerDateFilterFrom = new()
        {
            Format = DateTimePickerFormat.Short,
            MinDate = new(2022, 1, 1),
            MaxDate = new(2099, 12, 31),
            Value = DateTime.UtcNow.ToLocalTime(),
            Width = 100
        };
        dateTimePickerDateFilterFrom.ValueChanged += DateTimePickerDateFilter_ValueChanged;
        _hostDateTimePickerDateFilterFrom = new(dateTimePickerDateFilterFrom)
        {
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            Visible = false,
            Width = 100
        };
        ToolStripDateFilter.Items.Insert(3, _hostDateTimePickerDateFilterFrom);

        // Date to control
        DateTimePicker dateTimePickerDateFilterTo = new()
        {
            Format = DateTimePickerFormat.Short,
            MinDate = new(2022, 1, 1),
            MaxDate = new(2099, 12, 31),
            Value = DateTime.UtcNow.ToLocalTime(),
            Width = 100
        };
        dateTimePickerDateFilterTo.ValueChanged += DateTimePickerDateFilter_ValueChanged;
        _hostDateTimePickerDateFilterTo = new(dateTimePickerDateFilterTo)
        {
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            Visible = false,
            Width = 100
        };
        ToolStripDateFilter.Items.Add(_hostDateTimePickerDateFilterTo);
#pragma warning restore S6562 // Always set the "DateTimeKind" when creating new "DateTime" instances
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

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
            _hostDateTimePickerDateFilterFrom?.Dispose();
            _hostDateTimePickerDateFilterTo?.Dispose();
        }

        base.Dispose(disposing);
    }

    #endregion

    #region User interface data

    private void SetDataToUserInterface(Models.CSMapsContext context)
    {
        var puntoDato = context.PuntoDato.Find(_idPunto);
        if (puntoDato.IdEstablecimiento.HasValue)
        {
            var establecimiento = context.Establecimiento.Find(puntoDato.IdEstablecimiento);
            TextBoxEstablecimiento.Text = establecimiento.Nombre;
        }
        else
        {
            TextBoxEstablecimiento.Text = string.Empty;
        }

        Values.ToControl(TextBoxChapaNumero, puntoDato.ChapaNumero);
    }

    internal void ReadData(short idEvento = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            _entitiesAll = [.. from pe in context.PuntoEvento
                              join e in context.EventoTipo on pe.IdEventoTipo equals e.IdEventoTipo into eventoTiposGrupo
                              from etg in eventoTiposGrupo.DefaultIfEmpty()
                              where pe.IdPunto == _idPunto
                              select new DataGridViewRowData { IdEvento = pe.IdEvento, IdEventoTipo = pe.IdEventoTipo, EventoTipoNombre = (etg == null ? string.Empty : etg.Nombre), FechaHora = pe.FechaHora }];
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
            idEvento = DataGridViewMain.CurrentRow == null ? (short)0 : ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEvento;
        }

        FilterData();

        // Restore position
        if (idEvento != 0)
        {
            foreach (DataGridViewRow row in DataGridViewMain.Rows)
            {
                if (((DataGridViewRowData)row.DataBoundItem).IdEvento == idEvento)
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

        // Date
        (var fechaDesde, var fechaHasta) = DateAndTime.GetDatesFromPeriodTypeAndValue((DateAndTime.PeriodTypes)ToolStripComboBoxDateFilterPeriodType.SelectedIndex, (byte)ToolStripComboBoxDateFilterPeriodValue.SelectedIndex, DateOnly.FromDateTime(((DateTimePicker)_hostDateTimePickerDateFilterFrom.Control).Value), DateOnly.FromDateTime(((DateTimePicker)_hostDateTimePickerDateFilterTo.Control).Value));
        _entitiesFiltered = [.. _entitiesAll.Where(pe => pe.FechaHora >= fechaDesde.ToDateTime(new()) && pe.FechaHora <= fechaHasta.ToDateTime(new(23, 59, 59)))];

        // Event type
        if ((byte)ToolStripComboBoxEventTypeFilter.ComboBox.SelectedValue != CardonerSistemas.Framework.Base.Constants.ByteFieldValueAll)
        {
            _entitiesFiltered = [.. _entitiesFiltered.Where(pe => pe.IdEventoTipo == (byte)ToolStripComboBoxEventTypeFilter.ComboBox.SelectedValue)];
        }

        ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(EntityNameSingle, EntityNamePlural, _entitiesFiltered.Count);

        OrderData();
    }

    private void OrderData()
    {
        if (_sortedColumn == DataGridViewColumnFechaHora)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(pe => pe.FechaHora)]
                : [.. _entitiesFiltered.OrderByDescending(pe => pe.FechaHora)];
        }
        else if (_sortedColumn == DataGridViewColumnEventoTipo)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(pe => pe.EventoTipoNombre).ThenBy(pe => pe.FechaHora)]
                : [.. _entitiesFiltered.OrderByDescending(pe => pe.EventoTipoNombre).ThenByDescending(pe => pe.FechaHora)];
        }

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = _entitiesFiltered;
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
        this.Cursor = Cursors.Default;
    }

    #endregion

    #region Controls events

    private void ToolStripComboBoxDateFilterPeriodType_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToolStripComboBoxDateFilterPeriodValue.ComboBox.Items.AddRange(DateAndTime.GetPeriodValues((DateAndTime.PeriodTypes)ToolStripComboBoxDateFilterPeriodType.SelectedIndex));
    }

    private void ToolStripComboBoxDateFilterPeriodValue_SelectedIndexChanged(object sender, EventArgs e)
    {
        _hostDateTimePickerDateFilterFrom.Visible = (ToolStripComboBoxDateFilterPeriodType.SelectedIndex == (int)DateAndTime.PeriodTypes.Range);
        ToolStripLabelDateFilterAnd.Visible = (ToolStripComboBoxDateFilterPeriodType.SelectedIndex == (int)DateAndTime.PeriodTypes.Range && ToolStripComboBoxDateFilterPeriodValue.SelectedIndex == (int)DateAndTime.PeriodDateRangeValues.Between);
        _hostDateTimePickerDateFilterTo.Visible = ToolStripLabelDateFilterAnd.Visible;
        ReadData();
    }

    private void DateTimePickerDateFilter_ValueChanged(object sender, EventArgs e)
    {
        FilterData();
    }

    private void ToolStripComboBoxEventTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        FilterData();
    }

    private void DataGridViewMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref _sortedColumn, ref _sortOrder, [DataGridViewColumnEventoTipo, DataGridViewColumnFechaHora]))
        {
            OrderData();
        }
    }

    #endregion

    #region Main toolbar

    private void ToolStripButtonAdd_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.AddVerify(this, DataGridViewMain, _addPermission))
        {
            using FormPointEvent formPointEvent = new(true, _idPunto, 0);
            formPointEvent.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonView_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            using FormPointEvent formPointEvent = new(false, _idPunto, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEvento);
            formPointEvent.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _editPermission, EntityNameSingle, EntityIsFemale))
        {
            using FormPointEvent formPointEvent = new(true, _idPunto, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEvento);
            formPointEvent.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

#pragma warning disable MA0155 // Do not use async void methods (event handler)
    private async void ToolStripButtonDelete_Click(object sender, EventArgs e)
#pragma warning restore MA0155
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _deletePermission, EntityNameSingle, EntityIsFemale))
        {
            return;
        }

        var rowData = (DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Tipo: {rowData.EventoTipoNombre}\nFecha-hora: {rowData.FechaHora:g}";
        if (!Common.DataGridViews.DeleteConfirm(EntityNameSingle, EntityIsFemale, entidadDatos))
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        try
        {
            await using Models.CSMapsContext context = new();
            var puntoEvento = await context.PuntoEvento.FindAsync(_idPunto, rowData.IdEvento);
            context.PuntoEvento.Attach(puntoEvento);
            context.PuntoEvento.Remove(puntoEvento);
            await context.SaveChangesAsync();
            await Common.RefreshLists.PointsEventsAsync(_idPunto);
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

    #endregion

}
