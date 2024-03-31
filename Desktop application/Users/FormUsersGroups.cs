using CardonerSistemas.Framework.Base;

namespace CSMaps.Users
{
    public partial class FormUsersGroups : Form
    {

        #region Declaraciones específicas

        #endregion

        #region Declaraciones comunes

        private List<Models.UsuarioGrupo> listaBase;
        private List<Models.UsuarioGrupo> listaFiltradaYOrdenada;

        private readonly string entidadNombrePlural = "grupos de usuarios";
        private readonly string entidadNombreSingular = "grupo de usuarios";
        private readonly bool entidadFemenina = false;

        private readonly Permissions.Actions permisoAgregar = Permissions.Actions.UserGroupAdd;
        private readonly Permissions.Actions permisoEditar = Permissions.Actions.UserGroupEdit;
        private readonly Permissions.Actions permisoBorrar = Permissions.Actions.UserGroupDelete;

        private readonly bool skipFilterData;

        private DataGridViewColumn ordenColumna;
        private SortOrder ordenTipo;

        #endregion

        #region Cosas del form

        public FormUsersGroups()
        {
            InitializeComponent();

            SetAppearance();

            skipFilterData = true;

            Common.Lists.GetAllYesNo(ToolStripComboBoxActiveFilter.ComboBox, 1);

            skipFilterData = false;

            ordenColumna = DataGridViewColumnNombre;
            ordenTipo = SortOrder.Ascending;

            RefreshData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageTablas32);
            this.Text = entidadNombrePlural.FirstCharToUpperCase();
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetControlsDataGridViews(this.Controls, false);
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            listaBase = null;
            listaFiltradaYOrdenada = null;
            Program.FormMdi.FormUsersGroups = null;
        }

        #endregion

        #region Leer y mostrar datos

        internal void RefreshData(short positionIdUsuario = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using Models.CSMapsContext context = new();
                listaBase = [.. context.UsuarioGrupos.Where(ug => ug.IdUsuarioGrupo != Constants.UserGroupAdministratorsId)];
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
                if (DataGridViewMain.CurrentRow == null)
                {
                    positionIdUsuario = 0;
                }
                else
                {
                    positionIdUsuario = ((Models.UsuarioGrupo)DataGridViewMain.SelectedRows[0].DataBoundItem).IdUsuarioGrupo;
                }
            }

            FilterData();

            if (positionIdUsuario != 0)
            {
                foreach (DataGridViewRow row  in DataGridViewMain.Rows)
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
            if (!skipFilterData)
            {
                this.Cursor = Cursors.WaitCursor;

                try
                {
                    listaFiltradaYOrdenada = listaBase;

                    // Filtro por Activo
                    switch (ToolStripComboBoxActiveFilter.SelectedIndex)
                    {
                        case 0:     // Todos
                            break;
                        case 1:     // Sí
                            listaFiltradaYOrdenada = listaFiltradaYOrdenada.Where(u => u.EsActivo).ToList();
                            break;
                        case 2:     // No
                            listaFiltradaYOrdenada = listaFiltradaYOrdenada.Where(u => !u.EsActivo).ToList();
                            break;
                        default:
                            break;
                    }

                    ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(entidadNombreSingular, entidadNombrePlural, listaFiltradaYOrdenada.Count);

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
            if (ordenColumna.Name == DataGridViewColumnNombre.Name)
            {
                if (ordenTipo == SortOrder.Ascending)
                {
                    listaFiltradaYOrdenada = [.. listaFiltradaYOrdenada.OrderBy(u => u.Nombre)];
                }
                else
                {
                    listaFiltradaYOrdenada = [.. listaFiltradaYOrdenada.OrderByDescending(u => u.Nombre)];
                }
            }

            DataGridViewMain.AutoGenerateColumns = false;
            DataGridViewMain.DataSource = listaFiltradaYOrdenada;

            //  Muestro el ícono de orden en la columna correspondiente
            ordenColumna.HeaderCell.SortGlyphDirection = ordenTipo;
        }

        #endregion

        #region Eventos de controles

        private void Activo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref ordenColumna, ref ordenTipo, [DataGridViewColumnNombre]))
            {
                OrderData();
            }
        }

        #endregion

        #region Toolbar principal

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain, permisoAgregar))
            {
                using FormUserGroup formUsuarioGrupo = new();
                formUsuarioGrupo.LoadAndShow(true, this, 0);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entidadNombreSingular, entidadFemenina))
            {
                using FormUserGroup formUsuarioGrupo = new();
                formUsuarioGrupo.LoadAndShow(false, this, ((Models.UsuarioGrupo)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuarioGrupo);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, permisoEditar, entidadNombreSingular, entidadFemenina))
            {
                using FormUserGroup formUsuarioGrupo = new();
                formUsuarioGrupo.LoadAndShow(true, this, ((Models.UsuarioGrupo)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuarioGrupo);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, permisoBorrar, entidadNombreSingular, entidadFemenina))
            {
                return;
            }

            Models.UsuarioGrupo rowData = (Models.UsuarioGrupo)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Nombre: {rowData.Nombre}";
            if (!Common.DataGridViews.DeleteConfirm(entidadNombreSingular, entidadFemenina, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.UsuarioGrupo usuario = context.UsuarioGrupos.Find(rowData.IdUsuarioGrupo);
                context.UsuarioGrupos.Attach(usuario);
                context.UsuarioGrupos.Remove(usuario);
                context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                Common.DBErrors.DbUpdateException(dbUEx, entidadNombreSingular, entidadFemenina, Properties.Resources.StringActionDelete);
            }
            catch (Exception ex)
            {
                Common.DBErrors.OtherUpdateException(ex, entidadNombreSingular, entidadFemenina, Properties.Resources.StringActionDelete);
            }

            RefreshData();
            this.Cursor = Cursors.Default;
        }

        #endregion

    }
}
