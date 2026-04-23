using CardonerSistemas.Framework.Base;
using CSMaps.Main;

namespace CSMaps.Users;

public partial class FormUsersGroups : Form
{

    #region Declaraciones comunes

    private List<Models.UsuarioGrupo> _listaBase;
    private List<Models.UsuarioGrupo> _listaFiltradaYOrdenada;

    private readonly string _entidadNombrePlural = "grupos de usuarios";
    private readonly string _entidadNombreSingular = "grupo de usuarios";
    private const bool EntidadFemenina = false;

    private readonly Permissions.Actions _permisoAgregar = Permissions.Actions.UserGroupAdd;
    private readonly Permissions.Actions _permisoEditar = Permissions.Actions.UserGroupEdit;
    private readonly Permissions.Actions _permisoBorrar = Permissions.Actions.UserGroupDelete;

    private readonly bool _skipFilterData;

    private DataGridViewColumn _ordenColumna;
    private SortOrder _ordenTipo;

    #endregion

    #region Cosas del form

    public FormUsersGroups()
    {
        InitializeComponent();

        SetAppearance();

        _skipFilterData = true;

        Common.Lists.GetAllYesNo(ToolStripComboBoxActiveFilter.ComboBox, 1);

        _skipFilterData = false;

        _ordenColumna = DataGridViewColumnNombre;
        _ordenTipo = SortOrder.Ascending;

        ReadData();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageTablas32);
        this.Text = _entidadNombrePlural.FirstCharToUpperCase();
        Forms.SetFont(this, Program.AppearanceConfig.Font);
        Common.Appearance.SetControlsDataGridViews(this.Controls, false);
    }

    #endregion

    #region Leer y mostrar datos

    internal void ReadData(short positionIdUsuario = 0, bool restoreCurrentPosition = false)
    {
        this.Cursor = Cursors.WaitCursor;

        try
        {
            using Models.CSMapsContext context = new();
            _listaBase = [.. context.UsuarioGrupo.Where(ug => ug.IdUsuarioGrupo != Main.Constants.UserGroupAdministratorsId)];
        }
        catch (Exception ex)
        {
            this.Cursor = Cursors.Default;
            Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
            return;
        }

        this.Cursor = Cursors.Default;

        if (restoreCurrentPosition)
        {
            positionIdUsuario = DataGridViewMain.CurrentRow == null ? (short)0 : ((Models.UsuarioGrupo)DataGridViewMain.SelectedRows[0].DataBoundItem).IdUsuarioGrupo;
        }

        FilterData();

        if (positionIdUsuario != 0)
        {
            foreach (DataGridViewRow row in DataGridViewMain.Rows)
            {
                if (((Models.UsuarioGrupo)row.DataBoundItem).IdUsuarioGrupo == positionIdUsuario)
                {
                    DataGridViewMain.CurrentCell = row.Cells[DataGridViewColumnNombre.Name];
                    break;
                }
            }
        }
    }

    private void FilterData()
    {
        if (!_skipFilterData)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                _listaFiltradaYOrdenada = _listaBase;

                // Filtro por Activo
                switch (ToolStripComboBoxActiveFilter.SelectedIndex)
                {
                    case 0:     // Todos
                        break;
                    case 1:     // Sí
                        _listaFiltradaYOrdenada = [.. _listaFiltradaYOrdenada.Where(u => u.EsActivo)];
                        break;
                    case 2:     // No
                        _listaFiltradaYOrdenada = [.. _listaFiltradaYOrdenada.Where(u => !u.EsActivo)];
                        break;
                    default:
                        break;
                }

                ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(_entidadNombreSingular, _entidadNombrePlural, _listaFiltradaYOrdenada.Count);

            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
                this.Cursor = Cursors.Default;
                return;
            }

            OrderData();

            this.Cursor = Cursors.Default;
        }
    }

    private void OrderData()
    {
        if (_ordenColumna.Name == DataGridViewColumnNombre.Name)
        {
            _listaFiltradaYOrdenada = _ordenTipo == SortOrder.Ascending
                ? [.. _listaFiltradaYOrdenada.OrderBy(u => u.Nombre)]
                : [.. _listaFiltradaYOrdenada.OrderByDescending(u => u.Nombre)];
        }

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = _listaFiltradaYOrdenada;

        //  Muestro el ícono de orden en la columna correspondiente
        _ordenColumna.HeaderCell.SortGlyphDirection = _ordenTipo;
    }

    #endregion

    #region Eventos de controles

    private void Activo_SelectedIndexChanged(object sender, EventArgs e)
    {
        FilterData();
    }

    private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref _ordenColumna, ref _ordenTipo, [DataGridViewColumnNombre]))
        {
            OrderData();
        }
    }

    #endregion

    #region Toolbar principal

    private void Agregar_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.AddVerify(this, DataGridViewMain, _permisoAgregar))
        {
            using FormUserGroup formUsuarioGrupo = new();
            formUsuarioGrupo.LoadAndShow(true, this, 0);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void Ver_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, _entidadNombreSingular, EntidadFemenina))
        {
            using FormUserGroup formUsuarioGrupo = new();
            formUsuarioGrupo.LoadAndShow(false, this, ((Models.UsuarioGrupo)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuarioGrupo);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void Editar_Click(object sender, EventArgs e)
    {
        if (Common.DataGridViews.EditVerify(this, DataGridViewMain, _permisoEditar, _entidadNombreSingular, EntidadFemenina))
        {
            using FormUserGroup formUsuarioGrupo = new();
            formUsuarioGrupo.LoadAndShow(true, this, ((Models.UsuarioGrupo)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuarioGrupo);
            Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
        }
    }

    private void Borrar_Click(object sender, EventArgs e)
    {
        if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, _permisoBorrar, _entidadNombreSingular, EntidadFemenina))
        {
            return;
        }

        var rowData = (Models.UsuarioGrupo)DataGridViewMain.CurrentRow.DataBoundItem;
        var entidadDatos = $"Nombre: {rowData.Nombre}";
        if (!Common.DataGridViews.DeleteConfirm(_entidadNombreSingular, EntidadFemenina, entidadDatos))
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        try
        {
            using Models.CSMapsContext context = new();
            var usuario = context.UsuarioGrupo.Find(rowData.IdUsuarioGrupo);
            context.UsuarioGrupo.Attach(usuario);
            context.UsuarioGrupo.Remove(usuario);
            context.SaveChanges();
        }
        catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
        {
            Common.DBErrors.DbUpdateException(dbUEx, _entidadNombreSingular, EntidadFemenina, Properties.Resources.StringActionDelete);
        }
        catch (Exception ex)
        {
            Common.DBErrors.OtherUpdateException(ex, _entidadNombreSingular, EntidadFemenina, Properties.Resources.StringActionDelete);
        }

        Common.RefreshLists.UsersGroups();
        this.Cursor = Cursors.Default;
    }

    #endregion

}
