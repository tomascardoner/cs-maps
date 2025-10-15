using System.Globalization;
using CardonerSistemas.Framework.Base;
using CSMaps.Users;

namespace CSMaps.General;

public partial class FormPoints : Form
{

    #region Declarations

    private const string EntityNameSingle = "punto";
    private const string EntityNamePlural = "puntos";
    private const bool EntityIsFemale = false;

    private List<Models.Punto> _entitiesAll;
    private List<Models.Punto> _entitiesFiltered;

    private readonly Permissions.Actions _addPermission = Permissions.Actions.PointAdd;
    private readonly Permissions.Actions _editPermission = Permissions.Actions.PointEdit;
    private readonly Permissions.Actions _deletePermission = Permissions.Actions.PointDelete;

    private DataGridViewColumn _sortedColumn;
    private SortOrder _sortOrder;

    private bool _skipFilterApply = true;

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
        _sortedColumn = DataGridViewColumnNombre;
        _sortOrder = SortOrder.Ascending;

        _skipFilterApply = false;
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
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
    }

    private void This_FormClosed(object sender, FormClosedEventArgs e)
    {
        _entitiesAll = null;
        _entitiesFiltered = null;
    }

    #endregion

    #region User interface data

    internal void ReadData(int idPunto = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            _entitiesAll = [.. context.Puntos];
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
            idPunto = DataGridViewMain.CurrentRow == null ? 0 : ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto;
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
        if (_skipFilterApply)
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;

        _entitiesFiltered = string.IsNullOrWhiteSpace(ToolStripTextBoxNameFilter.Text)
            ? _entitiesAll
            : ToolStripComboBoxNameFilterType.SelectedIndex switch
            {
                0 => [.. _entitiesAll.Where(p => p.Nombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().StartsWith(ToolStripTextBoxNameFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
                1 => [.. _entitiesAll.Where(p => p.Nombre.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics().Contains(ToolStripTextBoxNameFilter.Text.ToLower(CultureInfo.CurrentCulture).ReplaceDiacritics(), StringComparison.CurrentCulture))],
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

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = _entitiesFiltered;
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
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
        if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref _sortedColumn, ref _sortOrder, [DataGridViewColumnNombre]))
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

    #endregion

    #region Main toolbar

    private void ToolStripButtonAdd_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.AddVerify(this, DataGridViewMain, _addPermission))
        {
            FormPoint formPoint = new(true, 0);
            formPoint.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonView_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            FormPoint formPoint = new(false, ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
            formPoint.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonViewOnMap_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            CardonerSistemas.Framework.Base.Maps.OpenMap(Convert.ToDouble(((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).Latitud), Convert.ToDouble(((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).Longitud), CardonerSistemas.Framework.Base.Maps.MapProviders.GoogleMaps, CardonerSistemas.Framework.Base.Maps.MapActions.Search);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _editPermission, EntityNameSingle, EntityIsFemale))
        {
            FormPoint formPoint = new(true, ((Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem).IdPunto);
            formPoint.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonDelete_Click(object sender, EventArgs e)
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _deletePermission, EntityNameSingle, EntityIsFemale))
        {
            return;
        }

        var rowData = (Models.Punto)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Nombre: {rowData.Nombre}\nLatitud: {rowData.Latitud}\nLongitud: {rowData.Longitud}\nAltitud: {rowData.Altitud}";
        if (!Common.DataGridViews.DeleteConfirm(EntityNameSingle, EntityIsFemale, entidadDatos))
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            var punto = context.Puntos.Find(rowData.IdPunto);
            context.Puntos.Attach(punto);
            context.Puntos.Remove(punto);
            context.SaveChanges();
            Common.RefreshLists.Points();
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
