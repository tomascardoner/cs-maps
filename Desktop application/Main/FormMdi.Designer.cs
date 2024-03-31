namespace CSMaps.Main
{
    partial class FormMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToolStripMain = new ToolStrip();
            ToolStripDropDownButtonTables = new ToolStripDropDownButton();
            ToolStripMenuItemTablesPoints = new ToolStripMenuItem();
            ToolStripMenuItemTablesPointsGroups = new ToolStripMenuItem();
            ToolStripMenuItemTablesEventsTypes = new ToolStripMenuItem();
            ToolStripSeparatorTablesUsers = new ToolStripSeparator();
            ToolStripMenuItemTablesUsersGroups = new ToolStripMenuItem();
            ToolStripMenuItemTablesUsersGroupsPermissions = new ToolStripMenuItem();
            ToolStripMenuItemTablesUsers = new ToolStripMenuItem();
            ToolStripButtonEntities = new ToolStripButton();
            ToolStripButtonSettlements = new ToolStripButton();
            ToolStripButtonPuntosDatosYEventos = new ToolStripButton();
            ToolStripButtonImport = new ToolStripButton();
            ToolStripLabelUser = new ToolStripLabel();
            ToolStripButtonExport = new ToolStripButton();
            MenuStripMain = new MenuStrip();
            ToolStripMenuItemFile = new ToolStripMenuItem();
            ToolStripMenuItemFileCloseUserSession = new ToolStripMenuItem();
            ToolStripMenuItemFileChangeUserPassword = new ToolStripMenuItem();
            ToolStripMenuItemFileSeparatorExit = new ToolStripSeparator();
            ToolStripMenuItemFileExit = new ToolStripMenuItem();
            ToolStripMenuItemWindow = new ToolStripMenuItem();
            ToolStripMenuItemWindowCloseAll = new ToolStripMenuItem();
            ToolStripSeparatorWindowList = new ToolStripSeparator();
            ToolStripMenuItemHelp = new ToolStripMenuItem();
            ToolStripMenuItemHelpAbout = new ToolStripMenuItem();
            ToolStripMain.SuspendLayout();
            MenuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Left;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripDropDownButtonTables, ToolStripButtonEntities, ToolStripButtonSettlements, ToolStripButtonPuntosDatosYEventos, ToolStripButtonImport, ToolStripLabelUser, ToolStripButtonExport });
            ToolStripMain.Location = new Point(0, 24);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(169, 376);
            ToolStripMain.TabIndex = 1;
            // 
            // ToolStripDropDownButtonTables
            // 
            ToolStripDropDownButtonTables.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemTablesPoints, ToolStripMenuItemTablesPointsGroups, ToolStripMenuItemTablesEventsTypes, ToolStripSeparatorTablesUsers, ToolStripMenuItemTablesUsersGroups, ToolStripMenuItemTablesUsersGroupsPermissions, ToolStripMenuItemTablesUsers });
            ToolStripDropDownButtonTables.Image = Properties.Resources.ImageTablas32;
            ToolStripDropDownButtonTables.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripDropDownButtonTables.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripDropDownButtonTables.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButtonTables.Name = "ToolStripDropDownButtonTables";
            ToolStripDropDownButtonTables.Size = new Size(166, 36);
            ToolStripDropDownButtonTables.Text = "Tablas";
            ToolStripDropDownButtonTables.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToolStripMenuItemTablesPoints
            // 
            ToolStripMenuItemTablesPoints.Name = "ToolStripMenuItemTablesPoints";
            ToolStripMenuItemTablesPoints.Size = new Size(241, 22);
            ToolStripMenuItemTablesPoints.Text = "Puntos";
            ToolStripMenuItemTablesPoints.Click += ToolStripMenuItemTablesPoints_Click;
            // 
            // ToolStripMenuItemTablesPointsGroups
            // 
            ToolStripMenuItemTablesPointsGroups.Name = "ToolStripMenuItemTablesPointsGroups";
            ToolStripMenuItemTablesPointsGroups.Size = new Size(241, 22);
            ToolStripMenuItemTablesPointsGroups.Text = "Grupos de puntos";
            ToolStripMenuItemTablesPointsGroups.Click += ToolStripMenuItemTablesPointsGroups_Click;
            // 
            // ToolStripMenuItemTablesEventsTypes
            // 
            ToolStripMenuItemTablesEventsTypes.Name = "ToolStripMenuItemTablesEventsTypes";
            ToolStripMenuItemTablesEventsTypes.Size = new Size(241, 22);
            ToolStripMenuItemTablesEventsTypes.Text = "Tipos de eventos";
            ToolStripMenuItemTablesEventsTypes.Click += ToolStripMenuItemTablesEventsTypes_Click;
            // 
            // ToolStripSeparatorTablesUsers
            // 
            ToolStripSeparatorTablesUsers.Name = "ToolStripSeparatorTablesUsers";
            ToolStripSeparatorTablesUsers.Size = new Size(238, 6);
            // 
            // ToolStripMenuItemTablesUsersGroups
            // 
            ToolStripMenuItemTablesUsersGroups.Name = "ToolStripMenuItemTablesUsersGroups";
            ToolStripMenuItemTablesUsersGroups.Size = new Size(241, 22);
            ToolStripMenuItemTablesUsersGroups.Text = "Grupos de usuarios";
            ToolStripMenuItemTablesUsersGroups.Click += ToolStripMenuItemTablesUsersGroups_Click;
            // 
            // ToolStripMenuItemTablesUsersGroupsPermissions
            // 
            ToolStripMenuItemTablesUsersGroupsPermissions.Name = "ToolStripMenuItemTablesUsersGroupsPermissions";
            ToolStripMenuItemTablesUsersGroupsPermissions.Size = new Size(241, 22);
            ToolStripMenuItemTablesUsersGroupsPermissions.Text = "Permisos de grupos de usuarios";
            ToolStripMenuItemTablesUsersGroupsPermissions.Click += ToolStripMenuItemTablesUsersGroupsPermissions_Click;
            // 
            // ToolStripMenuItemTablesUsers
            // 
            ToolStripMenuItemTablesUsers.Name = "ToolStripMenuItemTablesUsers";
            ToolStripMenuItemTablesUsers.Size = new Size(241, 22);
            ToolStripMenuItemTablesUsers.Text = "Usuarios";
            ToolStripMenuItemTablesUsers.Click += ToolStripMenuItemTablesUsers_Click;
            // 
            // ToolStripButtonEntities
            // 
            ToolStripButtonEntities.Image = Properties.Resources.ImageEntidad32;
            ToolStripButtonEntities.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEntities.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEntities.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEntities.Name = "ToolStripButtonEntities";
            ToolStripButtonEntities.Size = new Size(166, 36);
            ToolStripButtonEntities.Text = "Entidades";
            ToolStripButtonEntities.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEntities.Click += ToolStripButtonEntities_Click;
            // 
            // ToolStripButtonSettlements
            // 
            ToolStripButtonSettlements.Image = Properties.Resources.ImageEstablecimiento32;
            ToolStripButtonSettlements.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonSettlements.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonSettlements.ImageTransparentColor = Color.Magenta;
            ToolStripButtonSettlements.Name = "ToolStripButtonSettlements";
            ToolStripButtonSettlements.Size = new Size(166, 36);
            ToolStripButtonSettlements.Text = "Establecimientos";
            ToolStripButtonSettlements.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonSettlements.Click += ToolStripButtonSettlements_Click;
            // 
            // ToolStripButtonPuntosDatosYEventos
            // 
            ToolStripButtonPuntosDatosYEventos.Image = Properties.Resources.ImagePunto32;
            ToolStripButtonPuntosDatosYEventos.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonPuntosDatosYEventos.ImageTransparentColor = Color.Magenta;
            ToolStripButtonPuntosDatosYEventos.Name = "ToolStripButtonPuntosDatosYEventos";
            ToolStripButtonPuntosDatosYEventos.Size = new Size(166, 36);
            ToolStripButtonPuntosDatosYEventos.Text = "Puntos: datos y eventos";
            ToolStripButtonPuntosDatosYEventos.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonPuntosDatosYEventos.Click += ToolStripButtonPuntosDatosYEventos_Click;
            // 
            // ToolStripButtonImport
            // 
            ToolStripButtonImport.Image = Properties.Resources.ImageImport32;
            ToolStripButtonImport.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonImport.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonImport.ImageTransparentColor = Color.Magenta;
            ToolStripButtonImport.Name = "ToolStripButtonImport";
            ToolStripButtonImport.Size = new Size(166, 36);
            ToolStripButtonImport.Text = "Importar";
            ToolStripButtonImport.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonImport.Click += ToolStripButtonImport_Click;
            // 
            // ToolStripLabelUser
            // 
            ToolStripLabelUser.Alignment = ToolStripItemAlignment.Right;
            ToolStripLabelUser.Name = "ToolStripLabelUser";
            ToolStripLabelUser.Size = new Size(166, 0);
            ToolStripLabelUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToolStripButtonExport
            // 
            ToolStripButtonExport.Image = Properties.Resources.ImageExport32;
            ToolStripButtonExport.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonExport.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonExport.ImageTransparentColor = Color.Magenta;
            ToolStripButtonExport.Name = "ToolStripButtonExport";
            ToolStripButtonExport.Size = new Size(166, 36);
            ToolStripButtonExport.Text = "Exportar";
            ToolStripButtonExport.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MenuStripMain
            // 
            MenuStripMain.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile, ToolStripMenuItemWindow, ToolStripMenuItemHelp });
            MenuStripMain.Location = new Point(0, 0);
            MenuStripMain.MdiWindowListItem = ToolStripMenuItemWindow;
            MenuStripMain.Name = "MenuStripMain";
            MenuStripMain.Size = new Size(737, 24);
            MenuStripMain.TabIndex = 3;
            // 
            // ToolStripMenuItemFile
            // 
            ToolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemFileCloseUserSession, ToolStripMenuItemFileChangeUserPassword, ToolStripMenuItemFileSeparatorExit, ToolStripMenuItemFileExit });
            ToolStripMenuItemFile.ImageTransparentColor = SystemColors.ActiveBorder;
            ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            ToolStripMenuItemFile.Size = new Size(60, 20);
            ToolStripMenuItemFile.Text = "&Archivo";
            // 
            // ToolStripMenuItemFileCloseUserSession
            // 
            ToolStripMenuItemFileCloseUserSession.Name = "ToolStripMenuItemFileCloseUserSession";
            ToolStripMenuItemFileCloseUserSession.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItemFileCloseUserSession.Size = new Size(280, 22);
            ToolStripMenuItemFileCloseUserSession.Text = "Cerrar sesión del usuario";
            ToolStripMenuItemFileCloseUserSession.Click += ToolStripMenuItemFileCloseUserSession_Click;
            // 
            // ToolStripMenuItemFileChangeUserPassword
            // 
            ToolStripMenuItemFileChangeUserPassword.Name = "ToolStripMenuItemFileChangeUserPassword";
            ToolStripMenuItemFileChangeUserPassword.Size = new Size(280, 22);
            ToolStripMenuItemFileChangeUserPassword.Text = "Cambiar contraseña de inicio de sesión";
            ToolStripMenuItemFileChangeUserPassword.Click += ToolStripMenuItemFileChangeUserPassword_Click;
            // 
            // ToolStripMenuItemFileSeparatorExit
            // 
            ToolStripMenuItemFileSeparatorExit.Name = "ToolStripMenuItemFileSeparatorExit";
            ToolStripMenuItemFileSeparatorExit.Size = new Size(277, 6);
            // 
            // ToolStripMenuItemFileExit
            // 
            ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            ToolStripMenuItemFileExit.Size = new Size(280, 22);
            ToolStripMenuItemFileExit.Text = "&Salir";
            // 
            // ToolStripMenuItemWindow
            // 
            ToolStripMenuItemWindow.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemWindowCloseAll, ToolStripSeparatorWindowList });
            ToolStripMenuItemWindow.Name = "ToolStripMenuItemWindow";
            ToolStripMenuItemWindow.Size = new Size(61, 20);
            ToolStripMenuItemWindow.Text = "&Ventana";
            // 
            // ToolStripMenuItemWindowCloseAll
            // 
            ToolStripMenuItemWindowCloseAll.Name = "ToolStripMenuItemWindowCloseAll";
            ToolStripMenuItemWindowCloseAll.Size = new Size(138, 22);
            ToolStripMenuItemWindowCloseAll.Text = "Cerrar todas";
            ToolStripMenuItemWindowCloseAll.Click += ToolStripMenuItemWindowCloseAll_Click;
            // 
            // ToolStripSeparatorWindowList
            // 
            ToolStripSeparatorWindowList.Name = "ToolStripSeparatorWindowList";
            ToolStripSeparatorWindowList.Size = new Size(135, 6);
            // 
            // ToolStripMenuItemHelp
            // 
            ToolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemHelpAbout });
            ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            ToolStripMenuItemHelp.Size = new Size(53, 20);
            ToolStripMenuItemHelp.Text = "A&yuda";
            // 
            // ToolStripMenuItemHelpAbout
            // 
            ToolStripMenuItemHelpAbout.Name = "ToolStripMenuItemHelpAbout";
            ToolStripMenuItemHelpAbout.Size = new Size(135, 22);
            ToolStripMenuItemHelpAbout.Text = "&Acerca de...";
            ToolStripMenuItemHelpAbout.Click += ToolStripMenuItemHelpAbout_Click;
            // 
            // FormMdi
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(737, 400);
            Controls.Add(ToolStripMain);
            Controls.Add(MenuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = MenuStripMain;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMdi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMdi";
            WindowState = FormWindowState.Maximized;
            FormClosing += This_Closing;
            Load += This_Load;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            MenuStripMain.ResumeLayout(false);
            MenuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private ToolStripButton ToolStripButtonImport;
        private ToolStripButton ToolStripButtonEntities;
        private ToolStripButton ToolStripButtonSettlements;
        private ToolStripDropDownButton ToolStripDropDownButtonTables;
        private ToolStripMenuItem ToolStripMenuItemTablesPointsGroups;
        private ToolStripMenuItem ToolStripMenuItemTablesEventsTypes;
        private MenuStrip MenuStripMain;
        private ToolStripMenuItem ToolStripMenuItemWindow;
        private ToolStripMenuItem ToolStripMenuItemWindowCloseAll;
        private ToolStripSeparator ToolStripSeparatorWindowList;
        private ToolStripMenuItem ToolStripMenuItemHelp;
        private ToolStripMenuItem ToolStripMenuItemHelpAbout;
        private ToolStripButton ToolStripButtonPuntosDatosYEventos;
        internal ToolStripLabel ToolStripLabelUser;
        private ToolStripMenuItem ToolStripMenuItemFile;
        private ToolStripMenuItem ToolStripMenuItemFileCloseUserSession;
        private ToolStripMenuItem ToolStripMenuItemFileChangeUserPassword;
        private ToolStripSeparator ToolStripMenuItemFileSeparatorExit;
        private ToolStripMenuItem ToolStripMenuItemFileExit;
        private ToolStripMenuItem ToolStripMenuItemTablesPoints;
        private ToolStripSeparator ToolStripSeparatorTablesUsers;
        private ToolStripMenuItem ToolStripMenuItemTablesUsersGroups;
        private ToolStripMenuItem ToolStripMenuItemTablesUsersGroupsPermissions;
        private ToolStripMenuItem ToolStripMenuItemTablesUsers;
        private ToolStripButton ToolStripButtonExport;
    }
}



