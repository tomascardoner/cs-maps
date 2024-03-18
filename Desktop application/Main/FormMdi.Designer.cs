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
            ToolStripMenuItemTablesPointsGroups = new ToolStripMenuItem();
            ToolStripMenuItemTablesEventsTypes = new ToolStripMenuItem();
            ToolStripButtonEntities = new ToolStripButton();
            ToolStripButtonSettlements = new ToolStripButton();
            ToolStripButtonPoints = new ToolStripButton();
            ToolStripButtonImport = new ToolStripButton();
            MenuStripMain = new MenuStrip();
            ToolStripMenuItemFile = new ToolStripMenuItem();
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
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripDropDownButtonTables, ToolStripButtonEntities, ToolStripButtonSettlements, ToolStripButtonPoints, ToolStripButtonImport });
            ToolStripMain.Location = new Point(0, 24);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(133, 291);
            ToolStripMain.TabIndex = 1;
            // 
            // ToolStripDropDownButtonTables
            // 
            ToolStripDropDownButtonTables.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemTablesPointsGroups, ToolStripMenuItemTablesEventsTypes });
            ToolStripDropDownButtonTables.Image = Properties.Resources.ImageTablas32;
            ToolStripDropDownButtonTables.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripDropDownButtonTables.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripDropDownButtonTables.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButtonTables.Name = "ToolStripDropDownButtonTables";
            ToolStripDropDownButtonTables.Size = new Size(130, 36);
            ToolStripDropDownButtonTables.Text = "Tablas";
            // 
            // ToolStripMenuItemTablesPointsGroups
            // 
            ToolStripMenuItemTablesPointsGroups.Name = "ToolStripMenuItemTablesPointsGroups";
            ToolStripMenuItemTablesPointsGroups.Size = new Size(168, 22);
            ToolStripMenuItemTablesPointsGroups.Text = "Grupos de puntos";
            // 
            // ToolStripMenuItemTablesEventsTypes
            // 
            ToolStripMenuItemTablesEventsTypes.Name = "ToolStripMenuItemTablesEventsTypes";
            ToolStripMenuItemTablesEventsTypes.Size = new Size(168, 22);
            ToolStripMenuItemTablesEventsTypes.Text = "Tipos de eventos";
            // 
            // ToolStripButtonEntities
            // 
            ToolStripButtonEntities.Image = Properties.Resources.ImageEntidad32;
            ToolStripButtonEntities.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEntities.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEntities.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEntities.Name = "ToolStripButtonEntities";
            ToolStripButtonEntities.Size = new Size(130, 36);
            ToolStripButtonEntities.Text = "Entidades";
            ToolStripButtonEntities.Click += ToolStripButtonEntities_Click;
            // 
            // ToolStripButtonSettlements
            // 
            ToolStripButtonSettlements.Image = Properties.Resources.ImageEstablecimiento32;
            ToolStripButtonSettlements.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonSettlements.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonSettlements.ImageTransparentColor = Color.Magenta;
            ToolStripButtonSettlements.Name = "ToolStripButtonSettlements";
            ToolStripButtonSettlements.Size = new Size(130, 36);
            ToolStripButtonSettlements.Text = "Establecimientos";
            ToolStripButtonSettlements.Click += ToolStripButtonSettlements_Click;
            // 
            // ToolStripButtonPoints
            // 
            ToolStripButtonPoints.Image = Properties.Resources.ImagePunto32;
            ToolStripButtonPoints.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonPoints.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonPoints.ImageTransparentColor = Color.Magenta;
            ToolStripButtonPoints.Name = "ToolStripButtonPoints";
            ToolStripButtonPoints.Size = new Size(130, 36);
            ToolStripButtonPoints.Text = "Puntos";
            ToolStripButtonPoints.Click += ToolStripButtonPoints_Click;
            // 
            // ToolStripButtonImport
            // 
            ToolStripButtonImport.Image = Properties.Resources.ImageImport32;
            ToolStripButtonImport.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonImport.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonImport.ImageTransparentColor = Color.Magenta;
            ToolStripButtonImport.Name = "ToolStripButtonImport";
            ToolStripButtonImport.Size = new Size(130, 36);
            ToolStripButtonImport.Text = "Importar";
            ToolStripButtonImport.Click += ToolStripButtonImport_Click;
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
            ToolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemFileExit });
            ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            ToolStripMenuItemFile.Size = new Size(60, 20);
            ToolStripMenuItemFile.Text = "&Archivo";
            // 
            // ToolStripMenuItemFileExit
            // 
            ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            ToolStripMenuItemFileExit.Size = new Size(96, 22);
            ToolStripMenuItemFileExit.Text = "Salir";
            ToolStripMenuItemFileExit.Click += ToolStripMenuItemFileExit_Click;
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
            ClientSize = new Size(737, 315);
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
        private ToolStripButton ToolStripButtonPoints;
        private MenuStrip MenuStripMain;
        private ToolStripMenuItem ToolStripMenuItemFile;
        private ToolStripMenuItem ToolStripMenuItemFileExit;
        private ToolStripMenuItem ToolStripMenuItemWindow;
        private ToolStripMenuItem ToolStripMenuItemWindowCloseAll;
        private ToolStripSeparator ToolStripSeparatorWindowList;
        private ToolStripMenuItem ToolStripMenuItemHelp;
        private ToolStripMenuItem ToolStripMenuItemHelpAbout;
    }
}



