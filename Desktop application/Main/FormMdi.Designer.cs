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
            ToolStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Left;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripDropDownButtonTables, ToolStripButtonEntities, ToolStripButtonSettlements, ToolStripButtonPoints, ToolStripButtonImport });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(133, 315);
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
            ToolStripMenuItemTablesPointsGroups.Size = new Size(180, 22);
            ToolStripMenuItemTablesPointsGroups.Text = "Grupos de puntos";
            // 
            // ToolStripMenuItemTablesEventsTypes
            // 
            ToolStripMenuItemTablesEventsTypes.Name = "ToolStripMenuItemTablesEventsTypes";
            ToolStripMenuItemTablesEventsTypes.Size = new Size(180, 22);
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
            // FormMdi
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(737, 315);
            Controls.Add(ToolStripMain);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMdi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMdi";
            WindowState = FormWindowState.Maximized;
            Load += FormMdi_Load;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
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
    }
}



