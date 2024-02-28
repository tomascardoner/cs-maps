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
            ToolStripDropDownButtonTablas = new ToolStripDropDownButton();
            ToolStripMenuItemTablasGruposPuntos = new ToolStripMenuItem();
            ToolStripMenuItemTablasTiposEventos = new ToolStripMenuItem();
            ToolStripButtonEntidades = new ToolStripButton();
            ToolStripButtonEstablecimientos = new ToolStripButton();
            ToolStripButtonPuntos = new ToolStripButton();
            ToolStripButtonImport = new ToolStripButton();
            ToolStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Left;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripDropDownButtonTablas, ToolStripButtonEntidades, ToolStripButtonEstablecimientos, ToolStripButtonPuntos, ToolStripButtonImport });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(133, 315);
            ToolStripMain.TabIndex = 1;
            // 
            // ToolStripDropDownButtonTablas
            // 
            ToolStripDropDownButtonTablas.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemTablasGruposPuntos, ToolStripMenuItemTablasTiposEventos });
            ToolStripDropDownButtonTablas.Image = Properties.Resources.ImageTablas32;
            ToolStripDropDownButtonTablas.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripDropDownButtonTablas.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripDropDownButtonTablas.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButtonTablas.Name = "ToolStripDropDownButtonTablas";
            ToolStripDropDownButtonTablas.Size = new Size(130, 36);
            ToolStripDropDownButtonTablas.Text = "Tablas";
            // 
            // ToolStripMenuItemTablasGruposPuntos
            // 
            ToolStripMenuItemTablasGruposPuntos.Name = "ToolStripMenuItemTablasGruposPuntos";
            ToolStripMenuItemTablasGruposPuntos.Size = new Size(168, 22);
            ToolStripMenuItemTablasGruposPuntos.Text = "Grupos de puntos";
            // 
            // ToolStripMenuItemTablasTiposEventos
            // 
            ToolStripMenuItemTablasTiposEventos.Name = "ToolStripMenuItemTablasTiposEventos";
            ToolStripMenuItemTablasTiposEventos.Size = new Size(168, 22);
            ToolStripMenuItemTablasTiposEventos.Text = "Tipos de eventos";
            // 
            // ToolStripButtonEntidades
            // 
            ToolStripButtonEntidades.Image = Properties.Resources.ImageEntidad32;
            ToolStripButtonEntidades.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEntidades.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEntidades.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEntidades.Name = "ToolStripButtonEntidades";
            ToolStripButtonEntidades.Size = new Size(130, 36);
            ToolStripButtonEntidades.Text = "Entidades";
            ToolStripButtonEntidades.Click += ToolStripButtonEntidades_Click;
            // 
            // ToolStripButtonEstablecimientos
            // 
            ToolStripButtonEstablecimientos.Image = Properties.Resources.ImageEstablecimiento32;
            ToolStripButtonEstablecimientos.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEstablecimientos.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEstablecimientos.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEstablecimientos.Name = "ToolStripButtonEstablecimientos";
            ToolStripButtonEstablecimientos.Size = new Size(130, 36);
            ToolStripButtonEstablecimientos.Text = "Establecimientos";
            // 
            // ToolStripButtonPuntos
            // 
            ToolStripButtonPuntos.Image = Properties.Resources.ImagePunto32;
            ToolStripButtonPuntos.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonPuntos.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonPuntos.ImageTransparentColor = Color.Magenta;
            ToolStripButtonPuntos.Name = "ToolStripButtonPuntos";
            ToolStripButtonPuntos.Size = new Size(130, 36);
            ToolStripButtonPuntos.Text = "Puntos";
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
        private ToolStripButton ToolStripButtonEntidades;
        private ToolStripButton ToolStripButtonEstablecimientos;
        private ToolStripDropDownButton ToolStripDropDownButtonTablas;
        private ToolStripMenuItem ToolStripMenuItemTablasGruposPuntos;
        private ToolStripMenuItem ToolStripMenuItemTablasTiposEventos;
        private ToolStripButton ToolStripButtonPuntos;
    }
}



