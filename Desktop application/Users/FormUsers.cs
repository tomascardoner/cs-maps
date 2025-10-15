using CardonerSistemas.Framework.Base;

namespace CSMaps.Users;

public partial class FormUsers : Form
{

    #region Declarations

    internal class DataGridRowData
    {
        public short IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte IdUsuarioGrupo { get; set; }
        public string UsuarioGrupoNombre { get; set; }
        public bool EsActivo { get; set; }
    }

    private const string EntityNameSingle = "usuario";
    private const string EntityNamePlural = "usuarios";
    private const bool EntityIsFemale = false;

    private List<DataGridRowData> _entitiesAll;
    private List<DataGridRowData> _entitiesFiltered;

    private readonly Permissions.Actions _addPermission = Permissions.Actions.UserAdd;
    private readonly Permissions.Actions _editPermission = Permissions.Actions.UserEdit;
    private readonly Permissions.Actions _deletePermission = Permissions.Actions.UserDelete;

    private DataGridViewColumn _sortedColumn;
    private SortOrder _sortOrder;

    private bool _skipFilterApply = true;

    #endregion Declarations

    #region Form stuff

    public FormUsers()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        SetAppearance();

        using Models.CSMapsContext context = new();
        Common.Lists.GetUsersGroups(ToolStripComboBoxUserGroupFilter.ComboBox, context, false, true);
        Common.Lists.GetAllYesNo(ToolStripComboBoxActiveFilter.ComboBox, 1);

        // Set the initial sorted column of the grid
        _sortedColumn = DataGridViewColumnNombre;
        _sortOrder = SortOrder.Ascending;

        _skipFilterApply = false;
        ReadData();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageTablas32);
        this.Text = EntityNamePlural.FirstCharToUpperCase();
        Forms.SetFont(this, Program.AppearanceConfig.Font);
        Common.Appearance.SetDataGrid(DataGridViewMain);
    }

    private void This_Load(object sender, EventArgs e)
    {
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
    }

    #endregion Form stuff

    #region User interface data

    internal void ReadData(short idUsuario = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            _entitiesAll = [.. from u in context.Usuarios
                              join ug in context.UsuarioGrupos on u.IdUsuarioGrupo equals ug.IdUsuarioGrupo
                              where u.IdUsuario != Main.Constants.UserAdministratorId
                              select new DataGridRowData() { IdUsuario = u.IdUsuario, Nombre = u.Nombre, Descripcion = u.Descripcion, IdUsuarioGrupo = u.IdUsuarioGrupo, UsuarioGrupoNombre = ug.Nombre, EsActivo = u.EsActivo }];
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
            return;
        }

        this.Cursor = Cursors.Default;

        // Save position
        if (restoreCurrentPosition)
        {
            idUsuario = DataGridViewMain.CurrentRow == null ? (short)0 : ((DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuario;
        }

        FilterData();

        // Restore position
        if (idUsuario != 0)
        {
            foreach (DataGridViewRow row in DataGridViewMain.Rows)
            {
                if (((DataGridRowData)row.DataBoundItem).IdUsuario == idUsuario)
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

        if (ToolStripComboBoxUserGroupFilter.SelectedIndex > 0)
        {
            _entitiesFiltered = [.. _entitiesFiltered.Where(u => u.IdUsuarioGrupo == ((Models.UsuarioGrupo)ToolStripComboBoxUserGroupFilter.SelectedItem).IdUsuarioGrupo)];
        }

        _entitiesFiltered = ToolStripComboBoxActiveFilter.ComboBox.SelectedIndex switch
        {
            1 => [.. _entitiesFiltered.Where(u => u.EsActivo)],
            2 => [.. _entitiesFiltered.Where(u => !u.EsActivo)],
            _ => _entitiesFiltered
        };

        ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(EntityNameSingle, EntityNamePlural, _entitiesFiltered.Count);

        OrderData();
    }

    private void OrderData()
    {
        if (_sortedColumn == DataGridViewColumnNombre)
        {
            _entitiesFiltered = _sortOrder == SortOrder.Ascending
                ? [.. _entitiesFiltered.OrderBy(u => u.Nombre)]
                : [.. _entitiesFiltered.OrderByDescending(u => u.Nombre)];
        }

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = _entitiesFiltered;
        _sortedColumn.HeaderCell.SortGlyphDirection = _sortOrder;
        this.Cursor = Cursors.Default;
    }

    #endregion User interface data

    #region Controls events

    private void ToolStripComboBoxUserGroupFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        FilterData();
    }

    private void ToolStripComboBoxActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
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

    #endregion Controls events

    #region Main toolbar

    private void ToolStripButtonAdd_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.AddVerify(this, DataGridViewMain, _addPermission))
        {
            using FormUser formUser = new(true, 0);
            formUser.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonView_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, EntityNameSingle, EntityIsFemale))
        {
            using FormUser formUser = new(false, ((DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuario);
            formUser.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _editPermission, EntityNameSingle, EntityIsFemale))
        {
            using FormUser formUser = new(true, ((DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuario);
            formUser.ShowDialog(this);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void ToolStripButtonDelete_Click(object sender, EventArgs e)
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _deletePermission, EntityNameSingle, EntityIsFemale))
        {
            return;
        }

        var rowData = (DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Nombre: {rowData.Nombre}\nDescripción: {rowData.Descripcion}\nGrupo: {rowData.UsuarioGrupoNombre}";
        if (!Common.DataGridViews.DeleteConfirm(EntityNameSingle, EntityIsFemale, entidadDatos))
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            var usuario = context.Usuarios.Find(rowData.IdUsuario);
            context.Usuarios.Attach(usuario);
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
        catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
        {
            Common.DBErrors.DbUpdateException(dbUEx, EntityNameSingle, EntityIsFemale, Properties.Resources.StringActionDelete);
        }
        catch (Exception ex)
        {
            Common.DBErrors.OtherUpdateException(ex, EntityNameSingle, EntityIsFemale, Properties.Resources.StringActionDelete);
        }

        Common.RefreshLists.Users();
        this.Cursor = Cursors.Default;
    }

    #endregion Main toolbar

}
