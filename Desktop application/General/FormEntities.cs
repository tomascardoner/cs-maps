using System.Globalization;
using CardonerSistemas.Framework.Base;
using CSMaps.Users;

namespace CSMaps.General;

public partial class FormEntities : Form
{

    #region Declarations

    private const string EntityNameSingle = "entidad";
    private const string EntityNamePlural = "entidades";
    private const bool EntityIsFemale = true;

    private List<Models.Entidad> _entitiesAll;
    private List<Models.Entidad> _entitiesFiltered;

    private readonly Permissions.Actions _addPermission = Permissions.Actions.EntityAdd;
    private readonly Permissions.Actions _editPermission = Permissions.Actions.EntityEdit;
    private readonly Permissions.Actions _deletePermission = Permissions.Actions.EntityDelete;

    private DataGridViewColumn _sortedColumn;
    private SortOrder _sortOrder;

    private bool _skipFilterApply = true;

    #endregion Declarations

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
        _sortedColumn = DataGridViewColumnNombre;
        _sortOrder = SortOrder.Ascending;

        _skipFilterApply = false;
        ReadData();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageEntidad32);
        this.Text = EntityNamePlural.FirstCharToUpperCase();
        Forms.SetFont(this, Program.AppearanceConfig.Font);
        Common.Appearance.SetControlsDataGridViews(this.Controls, false);
    }

    private void This_Load(object sender, EventArgs e)
    {
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
    }

    #endregion Form stuff

    #region User interface data

    internal void ReadData(short idEntidad = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            _entitiesAll = [.. context.Entidades];
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
            idEntidad = DataGridViewMain.CurrentRow == null ? (short)0 : ((Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem).IdEntidad;
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
        if (_skipFilterApply)
        {
            return;
        }

        _entitiesFiltered = string.IsNullOrWhiteSpace(ToolStripTextBoxNameFilter.Text)
            ? _entitiesAll
            : ToolStripComboBoxNameFilterType.SelectedIndex switch
            {
                0 => [.. _entitiesAll.Where(e => e.Nombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().StartsWith(ToolStripTextBoxNameFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCultureIgnoreCase))],
                1 => [.. _entitiesAll.Where(e => e.Nombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().Contains(ToolStripTextBoxNameFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCultureIgnoreCase))],
                _ => throw new NotImplementedException(),
            };

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
        if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref _sortedColumn, ref _sortOrder, [DataGridViewColumnNombre, DataGridViewColumnTelefonoMovil]))
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
            FormEntity formEntity = new(true, 0);
            formEntity.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonView_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            FormEntity formEntity = new(false, ((Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem).IdEntidad);
            formEntity.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _editPermission, EntityNameSingle, EntityIsFemale))
        {
            FormEntity formEntity = new(true, ((Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem).IdEntidad);
            formEntity.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonDelete_Click(object sender, EventArgs e)
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _deletePermission, EntityNameSingle, EntityIsFemale))
        {
            return;
        }

        var rowData = (Models.Entidad)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Nombre: {rowData.Nombre}\nTeléfono móvil: {rowData.TelefonoMovil}";
        if (!Common.DataGridViews.DeleteConfirm(EntityNameSingle, EntityIsFemale, entidadDatos))
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            var entidad = context.Entidades.Find(rowData.IdEntidad);
            context.Entidades.Attach(entidad);
            context.Entidades.Remove(entidad);
            context.SaveChanges();
            Common.RefreshLists.Entities();
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