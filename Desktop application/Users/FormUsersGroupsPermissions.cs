using System.Globalization;
using CardonerSistemas.Framework.Base;
using CSMaps.Main;

namespace CSMaps.Users;

public partial class FormUsersGroupsPermissions : Form
{

    #region Declarations

    private readonly Models.CSMapsContext _context = new();
    private readonly bool _isLoading;
    private readonly bool _permitidoEstablecer;

    #endregion

    #region Form stuff

    public FormUsersGroupsPermissions()
    {
        InitializeComponent();

        _isLoading = true;

        SetAppearance();

        Common.Lists.GetUsersGroups(ComboBoxUsuarioGrupo, _context, false, false, false, false);
        Permissions.LoadPermissionsTree(_context, TreeViewPermisos);

        _permitidoEstablecer = Permissions.Verify(Permissions.Actions.UserGroupPermissionSet, false);

        _isLoading = false;

        Permissions.ShowEstablishedPermissions(_context, TreeViewPermisos, (byte)ComboBoxUsuarioGrupo.SelectedValue);
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageTablas32);

        Forms.SetFont(this, Program.AppearanceConfig.Font);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _context?.Dispose();
        this.Dispose();
    }

    #endregion

    #region Controls behavior

    private void ComboboxUsuarioGrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_isLoading)
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        Permissions.ShowEstablishedPermissions(_context, TreeViewPermisos, (byte)ComboBoxUsuarioGrupo.SelectedValue);
        this.Cursor = Cursors.Default;
    }

    private void TreeviewPermisos_BeforeCheck(object sender, TreeViewCancelEventArgs e)
    {
        if ((e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard) && !_permitidoEstablecer)
        {
            e.Cancel = true;
        }
    }

    private void TreeviewPermisos_AfterCheck(object sender, TreeViewEventArgs e)
    {
        if (e.Action is not TreeViewAction.ByMouse and not TreeViewAction.ByKeyboard)
        {
            return;
        }

        if (e.Node.Level == 0)
        {
            return;
        }

        if (e.Node.Checked)
        {
            // Agregar permiso
            try
            {
                _context.UsuarioGrupoPermiso.Add(
                    new Models.UsuarioGrupoPermiso()
                    {
                        IdUsuarioGrupo = (byte)ComboBoxUsuarioGrupo.SelectedValue,
                        IdPermiso = short.Parse(e.Node.Name[Permissions.PermissionPrefix.Length..], CultureInfo.CurrentCulture),
                        IdUsuarioCreacion = Program.Usuario.IdUsuario
                    }
                );
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al establecer el Permiso.");
            }
        }
        else
        {
            // Quitar permiso
            try
            {
                var permiso = _context.UsuarioGrupoPermiso.Find((byte)ComboBoxUsuarioGrupo.SelectedValue, short.Parse(e.Node.Name[Permissions.PermissionPrefix.Length..], CultureInfo.CurrentCulture));
                if (permiso != null)
                {
                    _context.UsuarioGrupoPermiso.Remove(permiso);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al quitar el Permiso.");
            }
        }
    }

    #endregion

}
