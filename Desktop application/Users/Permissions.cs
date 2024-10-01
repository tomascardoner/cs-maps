using CardonerSistemas.Framework.Base;
using Microsoft.EntityFrameworkCore;

namespace CSMaps.Users
{
    static class Permissions
    {

        #region Declarations

        private const string GroupPrefix = "G";
        internal const string PermissionPrefix = "P";

        internal enum Actions : short
        {
            // Users
            UserView = 1,
            UserAdd = 2,
            UserEdit = 3,
            UserDelete = 4,

            // Users groups
            UserGroupView = 5,
            UserGroupAdd = 6,
            UserGroupEdit = 7,
            UserGroupDelete = 8,

            // Users groups permissions
            UserGroupPermissionView = 9,
            UserGroupPermissionSet = 10,

            // Entities
            EntityView = 11,
            EntityAdd = 12,
            EntityEdit = 13,
            EntityDelete = 14,

            // Settlements
            SettlementView = 15,
            SettlementAdd = 16,
            SettlementEdit = 17,
            SettlementDelete = 18,

            // Points
            PointView = 19,
            PointAdd = 20,
            PointEdit = 21,
            PointDelete = 22,
            PointImportFromGpsFile = 31,
            PointImportFromGoogleEarthFile = 32,
            PointExportToGpsFile = 33,
            PointExportToGoogleEarthFile = 34,

            // Points: data
            PointDataView = 23,
            PointDataAdd = 24,
            PointDataEdit = 25,
            PointDataDelete = 26,

            // Points: events
            PointEventView = 27,
            PointEventAdd = 28,
            PointEventEdit = 29,
            PointEventDelete = 30,
        }

        #endregion

        #region Load

        static internal bool Load()
        {
            using Models.CSMapsContext context = new();
            try
            {
                Program.Permisos = [.. context.UsuarioGrupoPermisos.Where(ugp => ugp.IdUsuarioGrupo == Program.Usuario.IdUsuarioGrupo)];
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al leer los permisos desde la base de datos.");
                return false;
            }
        }

        #endregion

        #region Verification

        static internal bool Verify(Actions action, bool showMessage = true)
        {
            byte IdUsuarioGrupo = Program.Usuario.IdUsuarioGrupo;

            if (IdUsuarioGrupo == Constants.UserGroupAdministratorsId)
            {
                return true;
            }
            else
            {
                if (Program.Permisos.Find(p => p.IdUsuarioGrupo == IdUsuarioGrupo && p.IdPermiso == ((short)action)) == null)
                {
                    if (showMessage)
                    {
                        MessageBox.Show(Properties.Resources.StringNotPermission, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        #endregion

        #region Assignement

        static internal void LoadPermissionsTree(Models.CSMapsContext context, TreeView arbol)
        {
            TreeNode treeNodeGroup;

            arbol.SuspendLayout();
            Application.DoEvents();

            arbol.Nodes.Clear();

            try
            {
                foreach (Models.PermisoGrupo permisoGrupo in context.PermisoGrupos
                                                                .Include(pg => pg.Permisos)
                                                                .ThenInclude(p => p.IdPermisoTipoNavigation)
                                                                .OrderBy(pg => pg.Orden)
                                                                .ThenBy(pg => pg.Nombre))
                {
                    // Creo el nodo del grupo de permisos
                    treeNodeGroup = arbol.Nodes.Add(GroupPrefix + permisoGrupo.IdPermisoGrupo.ToString(), permisoGrupo.Nombre);

                    foreach (Models.Permiso permiso in permisoGrupo.Permisos
                                                            .Where(p => p.IdPermisoGrupo == permisoGrupo.IdPermisoGrupo)
                                                            .OrderBy(p => p.IdPermisoTipoNavigation.Orden)
                                                            .ThenBy(p => p.Orden)
                                                            .ThenBy(p => p.IdPermisoTipoNavigation.Nombre))
                    {
                        // Creo el nodo de cada permiso
                        treeNodeGroup.Nodes.Add(PermissionPrefix + permiso.IdPermiso.ToString(), permiso.IdPermisoTipoNavigation.Nombre);
                    }
                }
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al mostrar los permisos en el árbol.");
                return;
            }

            if (arbol.Nodes.Count > 0)
            {
                arbol.TopNode = arbol.Nodes[0];
            }
            arbol.ResumeLayout();
        }

        static internal void ShowEstablishedPermissions(Models.CSMapsContext context, TreeView arbol, byte idUserGroup)
        {
            arbol.SuspendLayout();
            Application.DoEvents();

            // desmarco todos los nodos
            foreach (TreeNode node in arbol.Nodes)
            {
                node.Checked = false;
                foreach (TreeNode childNode in node.Nodes)
                {
                    childNode.Checked = false;
                }
            }

            try
            {
                foreach (Models.UsuarioGrupoPermiso permiso in context.UsuarioGrupoPermisos.Where(ugp => ugp.IdUsuarioGrupo == idUserGroup))
                {
                    arbol.Nodes.Find(PermissionPrefix + permiso.IdPermiso.ToString(), true)[0].Checked = true;
                }
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al mostrar los permisos estabecidos en el árbol.");
            }
            arbol.ResumeLayout();
        }

        #endregion

    }
}
