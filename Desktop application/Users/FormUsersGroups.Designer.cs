namespace CSMaps.Users
{
    partial class FormUsersGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelToolbars = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolStripButtons = new System.Windows.Forms.ToolStrip();
            this.ButtonVer = new System.Windows.Forms.ToolStripButton();
            this.ButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.ButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.ButtonBorrar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripActivo = new System.Windows.Forms.ToolStrip();
            this.LabelActivo = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxActivo = new System.Windows.Forms.ToolStripComboBox();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.StatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelToolbars.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripActivo.SuspendLayout();
            this.StatusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelToolbars
            // 
            this.PanelToolbars.AutoSize = true;
            this.PanelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelToolbars.Controls.Add(this.ToolStripButtons);
            this.PanelToolbars.Controls.Add(this.ToolStripActivo);
            this.PanelToolbars.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelToolbars.Location = new System.Drawing.Point(0, 0);
            this.PanelToolbars.Name = "PanelToolbars";
            this.PanelToolbars.Size = new System.Drawing.Size(859, 54);
            this.PanelToolbars.TabIndex = 3;
            // 
            // ToolStripButtons
            // 
            this.ToolStripButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAgregar,
            this.ButtonVer,
            this.ButtonEditar,
            this.ButtonBorrar});
            this.ToolStripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStripButtons.Location = new System.Drawing.Point(0, 0);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new System.Drawing.Size(176, 54);
            this.ToolStripButtons.TabIndex = 0;
            // 
            // ButtonVer
            // 
            this.ButtonVer.Image = global::CSMaps.Properties.Resources.ImageItemView32;
            this.ButtonVer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonVer.Name = "ButtonVer";
            this.ButtonVer.Size = new System.Drawing.Size(36, 51);
            this.ButtonVer.Text = "Ver";
            this.ButtonVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonVer.Click += new System.EventHandler(this.Ver_Click);
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.Image = global::CSMaps.Properties.Resources.ImageItemAdd32;
            this.ButtonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(53, 51);
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonAgregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Image = global::CSMaps.Properties.Resources.ImageItemEdit32;
            this.ButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(41, 51);
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.Image = global::CSMaps.Properties.Resources.ImageItemDelete32;
            this.ButtonBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(43, 51);
            this.ButtonBorrar.Text = "Borrar";
            this.ButtonBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonBorrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // ToolStripActivo
            // 
            this.ToolStripActivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripActivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelActivo,
            this.ComboBoxActivo});
            this.ToolStripActivo.Location = new System.Drawing.Point(176, 0);
            this.ToolStripActivo.Name = "ToolStripActivo";
            this.ToolStripActivo.Size = new System.Drawing.Size(124, 54);
            this.ToolStripActivo.TabIndex = 13;
            // 
            // LabelActivo
            // 
            this.LabelActivo.Name = "LabelActivo";
            this.LabelActivo.Size = new System.Drawing.Size(44, 51);
            this.LabelActivo.Text = "Activo:";
            // 
            // ComboBoxActivo
            // 
            this.ComboBoxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxActivo.Name = "ComboBoxActivo";
            this.ComboBoxActivo.Size = new System.Drawing.Size(75, 54);
            this.ComboBoxActivo.SelectedIndexChanged += new System.EventHandler(this.Activo_SelectedIndexChanged);
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelMain});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 351);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(859, 22);
            this.StatusStripMain.TabIndex = 4;
            // 
            // StatusLabelMain
            // 
            this.StatusLabelMain.Name = "StatusLabelMain";
            this.StatusLabelMain.Size = new System.Drawing.Size(844, 17);
            this.StatusLabelMain.Spring = true;
            this.StatusLabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridViewMain
            // 
            this.DataGridViewMain.AllowUserToAddRows = false;
            this.DataGridViewMain.AllowUserToDeleteRows = false;
            this.DataGridViewMain.AllowUserToOrderColumns = true;
            this.DataGridViewMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnEsActivo});
            this.DataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMain.Location = new System.Drawing.Point(0, 54);
            this.DataGridViewMain.MultiSelect = false;
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.ReadOnly = true;
            this.DataGridViewMain.RowHeadersVisible = false;
            this.DataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMain.Size = new System.Drawing.Size(859, 297);
            this.DataGridViewMain.TabIndex = 5;
            this.DataGridViewMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_ColumnHeaderMouseClick);
            this.DataGridViewMain.DoubleClick += new System.EventHandler(this.Ver_Click);
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnNombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 69;
            // 
            // ColumnEsActivo
            // 
            this.ColumnEsActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEsActivo.DataPropertyName = "EsActivo";
            this.ColumnEsActivo.HeaderText = "Activo";
            this.ColumnEsActivo.Name = "ColumnEsActivo";
            this.ColumnEsActivo.ReadOnly = true;
            this.ColumnEsActivo.Width = 43;
            // 
            // FormUsuariosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 373);
            this.Controls.Add(this.DataGridViewMain);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.PanelToolbars);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuariosGrupos";
            this.ShowInTaskbar = false;
            this.Text = "Grupos de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.This_FormClosed);
            this.PanelToolbars.ResumeLayout(false);
            this.PanelToolbars.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripActivo.ResumeLayout(false);
            this.ToolStripActivo.PerformLayout();
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel PanelToolbars;
        internal System.Windows.Forms.ToolStrip ToolStripButtons;
        internal System.Windows.Forms.ToolStripButton ButtonAgregar;
        internal System.Windows.Forms.ToolStripButton ButtonEditar;
        internal System.Windows.Forms.ToolStripButton ButtonBorrar;
        internal System.Windows.Forms.StatusStrip StatusStripMain;
        internal System.Windows.Forms.ToolStripStatusLabel StatusLabelMain;
        internal System.Windows.Forms.DataGridView DataGridViewMain;
        internal System.Windows.Forms.ToolStrip ToolStripActivo;
        internal System.Windows.Forms.ToolStripLabel LabelActivo;
        internal System.Windows.Forms.ToolStripComboBox ComboBoxActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEsActivo;
        private System.Windows.Forms.ToolStripButton ButtonVer;
    }
}