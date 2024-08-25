using CardonerSistemas.Framework.Base;

namespace CSMaps.Users
{
    public partial class FormUsersGroupsPermissions : Form
    {

        #region Declarations

        private Models.CSMapsContext context = new();
        private readonly bool isLoading;
        private readonly bool PermitidoEstablecer;

        #endregion

        #region Form stuff

        public FormUsersGroupsPermissions()
        {
            InitializeComponent();

            isLoading = true;

            SetAppearance();

            Common.Lists.GetUsersGroups(ComboBoxUsuarioGrupo, context, false, false, false, false);
            Permissions.LoadPermissionsTree(context, TreeViewPermisos);

            PermitidoEstablecer = Permissions.Verify(Permissions.Actions.UserGroupPermissionSet, false);

            isLoading = false;

            this.Cursor = Cursors.WaitCursor;
            Permissions.ShowEstablishedPermissions(context, TreeViewPermisos, (byte)ComboBoxUsuarioGrupo.SelectedValue);
            this.Cursor = Cursors.Default;
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageTablas32);

            Forms.SetFont(this, Program.AppearanceConfig.Font);
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
        }

        #endregion

        #region Controls behavior

        private void ComboboxUsuarioGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            Permissions.ShowEstablishedPermissions(context, TreeViewPermisos, (byte)ComboBoxUsuarioGrupo.SelectedValue);
            this.Cursor = Cursors.Default;
        }

        private void TreeviewPermisos_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard) && !PermitidoEstablecer)
            {
                e.Cancel = true;
            }

        }

        private void TreeviewPermisos_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.ByMouse && e.Action != TreeViewAction.ByKeyboard)
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
                    context.UsuarioGrupoPermisos.Add(
                        new Models.UsuarioGrupoPermiso()
                        {
                            IdUsuarioGrupo = (byte)ComboBoxUsuarioGrupo.SelectedValue,
                            IdPermiso = short.Parse(e.Node.Name[Permissions.PermissionPrefix.Length..]),
                            IdUsuarioCreacion = Program.Usuario.IdUsuario
                        }
                    );
                    context.SaveChanges();
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
                    Models.UsuarioGrupoPermiso permiso = context.UsuarioGrupoPermisos.Find((byte)ComboBoxUsuarioGrupo.SelectedValue, short.Parse(e.Node.Name[Permissions.PermissionPrefix.Length..]));
                    if (permiso != null)
                    {
                        context.UsuarioGrupoPermisos.Remove(permiso);
                        context.SaveChanges();
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
}
