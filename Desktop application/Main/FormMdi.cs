using CardonerSistemas.Framework.Base;

namespace CSMaps.Main
{
    public partial class FormMdi : Form
    {

        #region Declarations

        internal General.FormPoints FormPoints;
        internal Users.FormUsersGroups FormUsersGroups;
        internal Users.FormUsersGroupsPermissions FormUsersGroupsPermissions;
        internal Users.FormUsers FormUsers;

        internal General.FormEntities FormEntities;
        internal General.FormSettlements FormSettlements;
        internal General.FormPointsDataAndEvents FormPointsDataAndEvents;
        internal General.FormImport FormImport;

        #endregion

        #region Form stuff

        public FormMdi()
        {
            InitializeComponent();
        }

        private void SetAppearance()
        {
            this.Icon = Properties.Resources.IconApplication;
            this.Text = $"{Program.ApplicationTitle} - Licenciado a: {Program.LicensedCompany.ToUpper()}";
            ToolStripMenuItemHelpAbout.Text = $"&Acerca de {Program.ApplicationTitle}...";
        }

        private void This_Load(object sender, EventArgs e)
        {
            SetAppearance();
        }

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            if (!(e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown))
            {
#pragma warning disable S1066 // If statement merge
                if (MessageBox.Show("¿Desea salir de la aplicación?", Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
#pragma warning restore S1066 // If statement merge
            }
            Program.TerminateApplication();
        }

        #endregion

        #region Menu commands

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemFileCloseUserSession_Click(object sender, EventArgs e)
        {
            Users.Users.LogOut();
        }

        private void ToolStripMenuItemFileChangeUserPassword_Click(object sender, EventArgs e)
        {
            Users.FormUserChangePassword formUserChangePassword = new();
            formUserChangePassword.ShowDialog(this);
            formUserChangePassword.Dispose();
        }

        private void ToolStripMenuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ToolStripMenuItemHelpAbout_Click(object sender, EventArgs e)
        {
            FormAboutBox formAboutBox = new();
            formAboutBox.ShowDialog(this);
            formAboutBox.Dispose();
        }

        #endregion

        #region Toolbar commands

        private void ToolStripMenuItemTablesPoints_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointView))
            {
                FormPoints ??= new();
                ShowMdiForm(FormPoints);
            }
        }

        private void ToolStripMenuItemTablesPointsGroups_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }

        private void ToolStripMenuItemTablesEventsTypes_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }

        private void ToolStripMenuItemTablesUsersGroups_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.UserGroupView))
            {
                FormUsersGroups ??= new();
                ShowMdiForm(FormUsersGroups);
            }
        }

        private void ToolStripMenuItemTablesUsersGroupsPermissions_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.UserGroupPermissionView))
            {
                FormUsersGroupsPermissions ??= new();
                ShowMdiForm(FormUsersGroupsPermissions);
            }
        }

        private void ToolStripMenuItemTablesUsers_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.UserView))
            {
                FormUsers ??= new();
                ShowMdiForm(FormUsers);
            }
        }

        private void ToolStripButtonEntities_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.EntityView))
            {
                FormEntities ??= new();
                ShowMdiForm(FormEntities);
            }
        }

        private void ToolStripButtonSettlements_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.SettlementView))
            {
                FormSettlements ??= new();
                ShowMdiForm(FormSettlements);
            }
        }

        private void ToolStripButtonPuntosDatosYEventos_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointDataView))
            {
                FormPointsDataAndEvents ??= new();
                ShowMdiForm(FormPointsDataAndEvents);
            }
        }

        private void ToolStripButtonImport_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointImport))
            {
                FormImport ??= new() { MdiParent = this };
                FormImport.Show();
            }
        }

        private void ToolStripButtonExport_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointExport))
            {
                //FormImport ??= new() { MdiParent = this };
                //FormImport.Show();
            }
        }

        #endregion

        #region Extra stuff

        private void ShowMdiForm(Form form)
        {
            Application.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            Forms.MdiChildPositionAndSizeToFit(this, form);
            form.Show();
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            form.Focus();

            this.Cursor = Cursors.Default;
            Application.UseWaitCursor = false;
            Application.DoEvents();
        }

        #endregion

    }
}
