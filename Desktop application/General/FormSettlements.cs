using System.Globalization;
using CardonerSistemas.Framework.Base;
using CSMaps.Main;
using CSMaps.Users;

namespace CSMaps.General;

public partial class FormSettlements : Form
{

    #region Declarations

    private const string EntityNameSingle = "establecimiento";
    private const string EntityNamePlural = "establecimientos";
    private const bool EntityIsFemale = false;

    private List<DataGridViewRowData> _entitiesAll;
    private List<DataGridViewRowData> _entitiesFiltered;

    private readonly Permissions.Actions _addPermission = Permissions.Actions.SettlementAdd;
    private readonly Permissions.Actions _editPermission = Permissions.Actions.SettlementEdit;
    private readonly Permissions.Actions _deletePermission = Permissions.Actions.SettlementDelete;

    private DataGridViewColumn _sortedColumn;
    private SortOrder _sortOrder;

    private bool _skipFilterApply = true;

    public class DataGridViewRowData
    {
        public short IdEstablecimiento { get; set; }
        public string Nombre { get; set; }
        public short? IdEntidad { get; set; }
        public string EntidadNombre { get; set; }
        public string TelefonoMovil { get; set; }
    }

    #endregion Declarations

    #region Form stuff

    public FormSettlements()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        SetAppearance();

        using Models.CSMapsContext dbContext = new();
        Common.Lists.GetEntidades(ToolStripComboBoxEntityFilter.ComboBox, dbContext, true, true);

        ToolStripComboBoxNameFilterType.Items.AddRange([Properties.Resources.StringTextFilterTypeBegin, Properties.Resources.StringTextFilterTypeContains]);
        ToolStripComboBoxNameFilterType.SelectedIndex = 1;

        // Set the initial sorted column of the grid
        _sortedColumn = DataGridViewColumnNombre;
        _sortOrder = SortOrder.Ascending;

        _skipFilterApply = false;
        ReadData();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageEstablecimiento32);
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

    internal void ReadData(short idEstablecimiento = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            _entitiesAll = [.. from es in context.Establecimiento
                              join en in context.Entidad on es.IdEntidad equals en.IdEntidad into entidadesGrupo
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
            idEstablecimiento = DataGridViewMain.CurrentRow == null ? (short)0 : ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEstablecimiento;
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
        if (_skipFilterApply)
        {
            return;
        }

        _entitiesFiltered = _entitiesAll;
        if (ToolStripComboBoxEntityFilter.SelectedIndex > 0)
        {
            _entitiesFiltered = (short)ToolStripComboBoxEntityFilter.ComboBox.SelectedValue == CardonerSistemas.Framework.Base.Constants.ShortFieldValueNotSpecified
                ? [.. _entitiesFiltered.Where(e => !e.IdEntidad.HasValue)]
                : [.. _entitiesFiltered.Where(e => e.IdEntidad == (short)ToolStripComboBoxEntityFilter.ComboBox.SelectedValue)];
        }

        if (!string.IsNullOrWhiteSpace(ToolStripTextBoxNameFilter.Text))
        {
            _entitiesFiltered = ToolStripComboBoxNameFilterType.SelectedIndex switch
            {
                0 => [.. _entitiesAll.Where(e => e.Nombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().StartsWith(ToolStripTextBoxNameFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                1 => [.. _entitiesAll.Where(e => e.Nombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().Contains(ToolStripTextBoxNameFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                _ => throw new NotImplementedException(),
            };
        }

        ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(EntityNameSingle, EntityNamePlural, _entitiesFiltered.Count);

        OrderData();
    }

    private void OrderData()
    {
        if (_sortedColumn == DataGridViewColumnNombre)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.Nombre)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.Nombre)];
        }
        else if (_sortedColumn == DataGridViewColumnEntidad)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.EntidadNombre).ThenBy(e => e.Nombre)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.EntidadNombre).ThenByDescending(e => e.Nombre)];
        }
        else if (_sortedColumn == DataGridViewColumnTelefonoMovil)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(e => e.TelefonoMovil)]
                : [.. _entitiesFiltered.OrderByDescending(e => e.TelefonoMovil)];
        }

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = _entitiesFiltered;
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
        this.Cursor = Cursors.Default;
    }

    #endregion User interface data

    #region Controls events

    private void ToolStripComboBoxEntityFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        FilterData();
    }

    private void ToolStripComboBoxNameFilterType_SelectedIndexChanged(object sender, EventArgs e)
    {
        FilterData();
    }

    private void ToolStripTextBoxNameFilter_Enter(object sender, EventArgs e)
    {
        ToolStripTextBoxNameFilter.Select();
    }

    private void ToolStripTextBoxNameFilter_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Common.Forms.Filter_KeyPress(e, ToolStripTextBoxNameFilter.TextBox))
        {
            FilterData();
            e.Handled = true;
        }
    }

    private void ToolStripButtonNameFilterClear_Click(object sender, EventArgs e)
    {
        ToolStripTextBoxNameFilter.Clear();
        FilterData();
    }

    private void DataGridViewMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref _sortedColumn, ref _sortOrder, [DataGridViewColumnNombre, DataGridViewColumnEntidad, DataGridViewColumnTelefonoMovil]))
        {
            OrderData();
        }
    }

    private void DataGridViewMain_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (_sortedColumn == DataGridViewColumnNombre)
        {
            Common.DataGridViews.SearchByKeyPress(e, DataGridViewMain, DataGridViewColumnNombre);
        }
    }

    #endregion Controls events

    #region Main toolbar

    private void ToolStripButtonAdd_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.AddVerify(this, DataGridViewMain, _addPermission))
        {
            FormSettlement formSettlement = new(true, 0);
            formSettlement.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonView_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            FormSettlement formSettlement = new(false, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEstablecimiento);
            formSettlement.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _editPermission, EntityNameSingle, EntityIsFemale))
        {
            FormSettlement formSettlement = new(true, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEstablecimiento);
            formSettlement.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonDelete_Click(object sender, EventArgs e)
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _deletePermission, EntityNameSingle, EntityIsFemale))
        {
            return;
        }

        var rowData = (DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Nombre: {rowData.Nombre}\nEntidad: {rowData.EntidadNombre}\nTeléfono móvil: {rowData.TelefonoMovil}";
        if (!Common.DataGridViews.DeleteConfirm(EntityNameSingle, EntityIsFemale, entidadDatos))
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            var establecimiento = context.Establecimiento.Find(rowData.IdEstablecimiento);
            context.Establecimiento.Attach(establecimiento);
            context.Establecimiento.Remove(establecimiento);
            context.SaveChanges();
            Common.RefreshLists.Settlements();
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

    #endregion Main toolbar

}
