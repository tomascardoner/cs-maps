namespace CSMaps.Main
{
    public partial class FormMdi : Form
    {

        #region Form stuff

        public FormMdi()
        {
            InitializeComponent();
        }

        private void SetAppearance()
        {
            this.Icon = Properties.Resources.IconApplication;
            this.Text = $"{Program.Info.Title} - Licenciado a: {Program.LicensedCompany.ToUpper()}";
            ToolStripMenuItemHelpAbout.Text = string.Format(Properties.Resources.StringAbout, Program.Info.Title);
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
                if (MessageBox.Show("¿Desea salir de la aplicación?", Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

        private void ToolStripMenuItemTablesPointsGroups_Click(object sender, EventArgs e)
        {
            //throw new NotSupportedException();
        }

        private void ToolStripMenuItemTablesEventsTypes_Click(object sender, EventArgs e)
        {
            //throw new NotSupportedException();
        }

        private void ToolStripMenuItemTablesUsersGroups_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.UserGroupView))
            {
                ShowMdiForm(Common.Forms.GetUsersGroupsOrNew(), true);
            }
        }

        private void ToolStripMenuItemTablesUsersGroupsPermissions_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.UserGroupPermissionView))
            {
                ShowMdiForm(Common.Forms.GetUsersGroupsPermissionsOrNew(), true);
            }
        }

        private void ToolStripMenuItemTablesUsers_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.UserView))
            {
                ShowMdiForm(Common.Forms.GetUsersOrNew(), true);
            }
        }

        private void ToolStripButtonEntities_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.EntityView))
            {
                ShowMdiForm(Common.Forms.GetEntitiesOrNew(), true);
            }
        }

        private void ToolStripButtonSettlements_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.SettlementView))
            {
                ShowMdiForm(Common.Forms.GetSettlementsOrNew(), true);
            }
        }

        private void ToolStripButtonPuntos_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointView))
            {
                ShowMdiForm(Common.Forms.GetPointsOrNew(), true);
            }
        }

        private void ToolStripButtonPuntosDatosYEventos_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointDataView))
            {
                ShowMdiForm(Common.Forms.GetPointsDataAndEventsOrNew(), true);
            }
        }

        private void ToolStripMenuItemImportGpsFile_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointImportFromGpsFile))
            {
                ShowMdiForm(Common.Forms.GetImportGpsFileOrNew(), false);
            }
        }

        private void ToolStripMenuItemImportGoogleEarthFile_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointImportFromGoogleEarthFile))
            {
                ShowMdiForm(Common.Forms.GetImportGoogleEarthFileOrNew(), false);
            }
        }

        private void ToolStripMenuItemExportGpsFile_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointExportToGpsFile))
            {
                ShowMdiForm(Common.Forms.GetExportGpsFileOrNew(), false);
            }
        }

        private void ToolStripMenuItemExportGoogleEarthFile_Click(object sender, EventArgs e)
        {
            if (Users.Permissions.Verify(Users.Permissions.Actions.PointExportToGoogleEarthFile))
            {
                ShowMdiForm(Common.Forms.GetExportGoogleEarthFileOrNew(), false);
            }
        }

        #endregion

        #region Extra stuff

        private void ShowMdiForm(Form form, bool fitOnMdiClient)
        {
            Application.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            form.MdiParent = this;
            form.WindowState = FormWindowState.Normal;
            form.Dock = fitOnMdiClient ? DockStyle.Fill : DockStyle.None;
            form.Show();
            form.Focus();

            this.Cursor = Cursors.Default;
            Application.UseWaitCursor = false;
            Application.DoEvents();
        }

        #endregion

    }
}
