using CardonerSistemas.Framework.Base;

namespace CSMaps.Users
{
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

        private const string entityNameSingle = "usuario";
        private const string entityNamePlural = "usuarios";
        private const bool entityIsFemale = false;

        private List<DataGridRowData> entitiesAll;
        private List<DataGridRowData> entitiesFiltered;

        private readonly Permissions.Actions addPermission = Permissions.Actions.UserAdd;
        private readonly Permissions.Actions editPermission = Permissions.Actions.UserEdit;
        private readonly Permissions.Actions deletePermission = Permissions.Actions.UserDelete;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

        #endregion

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
            sortedColumn = DataGridViewColumnNombre;
            sortOrder = SortOrder.Ascending;

            skipFilterApply = false;
            ReadData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageTablas32);
            this.Text = entityNamePlural.FirstCharToUpperCase();
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetDataGrid(DataGridViewMain);
        }

        private void This_Load(object sender, EventArgs e)
        {
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            entitiesAll = null;
            entitiesFiltered = null;
        }

        #endregion

        #region User interface data

        internal void ReadData(short idUsuario = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                entitiesAll = [.. from u in context.Usuarios
                                  join ug in context.UsuarioGrupos on u.IdUsuarioGrupo equals ug.IdUsuarioGrupo
                                  where u.IdUsuario != Constants.UserAdministratorId
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
                if (DataGridViewMain.CurrentRow == null)
                {
                    idUsuario = 0;
                }
                else
                {
                    idUsuario = ((DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuario;
                }
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
            if (skipFilterApply)
            {
                return;
            }

            entitiesFiltered = entitiesAll;

            if (ToolStripComboBoxUserGroupFilter.SelectedIndex > 0)
            {
                entitiesFiltered = [.. entitiesFiltered.Where(u => u.IdUsuarioGrupo == ((Models.UsuarioGrupo)ToolStripComboBoxUserGroupFilter.SelectedItem).IdUsuarioGrupo)];
            }

            entitiesFiltered = ToolStripComboBoxActiveFilter.ComboBox.SelectedIndex switch
            {
                1 => [.. entitiesFiltered.Where(u => u.EsActivo)],
                2 => [.. entitiesFiltered.Where(u => !u.EsActivo)],
                _ => entitiesFiltered
            };

            ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(entityNameSingle, entityNamePlural, entitiesFiltered.Count);

            OrderData();
        }

        private void OrderData()
        {
            if (sortedColumn == DataGridViewColumnNombre)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(u => u.Nombre)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(u => u.Nombre)];
                }
            }
            DataGridViewMain.AutoGenerateColumns = false;
            DataGridViewMain.DataSource = entitiesFiltered;
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
            this.Cursor = Cursors.Default;
        }

        #endregion

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
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnNombre]))
            {
                OrderData();
            }
        }

        private void DataGridViewMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sortedColumn == DataGridViewColumnNombre)
            {
                Common.DataGridViews.SearchByKeyPress(e, DataGridViewMain, DataGridViewColumnNombre);
            }
        }

        #endregion

        #region Main toolbar

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain, addPermission))
            {
                using FormUser formUser = new(true, 0);
                formUser.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                using FormUser formUser = new(false, ((DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuario);
                formUser.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, editPermission, entityNameSingle, entityIsFemale))
            {
                using FormUser formUser = new(true, ((DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdUsuario);
                formUser.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, deletePermission, entityNameSingle, entityIsFemale))
            {
                return;
            }

            DataGridRowData rowData = (DataGridRowData)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Nombre: {rowData.Nombre}\nDescripción: {rowData.Descripcion}\nGrupo: {rowData.UsuarioGrupoNombre}";
            if (!Common.DataGridViews.DeleteConfirm(entityNameSingle, entityIsFemale, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.Usuario usuario = context.Usuarios.Find(rowData.IdUsuario);
                context.Usuarios.Attach(usuario);
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                Common.DBErrors.DbUpdateException(dbUEx, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }
            catch (Exception ex)
            {
                Common.DBErrors.OtherUpdateException(ex, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }

            Common.RefreshLists.Users();
            this.Cursor = Cursors.Default;
        }

        #endregion

    }
}
