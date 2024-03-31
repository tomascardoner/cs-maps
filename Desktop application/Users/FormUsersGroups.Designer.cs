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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            FlowLayoutPanelToolbars = new FlowLayoutPanel();
            ToolStripMain = new ToolStrip();
            ToolStripButtonAdd = new ToolStripButton();
            ToolStripButtonView = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonDelete = new ToolStripButton();
            ToolStripActiveFilter = new ToolStrip();
            ToolStripLabelActiveFilter = new ToolStripLabel();
            ToolStripComboBoxActiveFilter = new ToolStripComboBox();
            DataGridViewMain = new DataGridView();
            DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            DataGridViewColumnEsActivo = new DataGridViewCheckBoxColumn();
            ToolStripItemsCounter = new ToolStrip();
            ToolStripLabelItemsCounter = new ToolStripLabel();
            FlowLayoutPanelToolbars.SuspendLayout();
            ToolStripMain.SuspendLayout();
            ToolStripActiveFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            ToolStripItemsCounter.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanelToolbars
            // 
            FlowLayoutPanelToolbars.AutoSize = true;
            FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanelToolbars.Controls.Add(ToolStripMain);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripActiveFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripItemsCounter);
            FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            FlowLayoutPanelToolbars.Location = new Point(0, 0);
            FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            FlowLayoutPanelToolbars.Size = new Size(1002, 39);
            FlowLayoutPanelToolbars.TabIndex = 3;
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Fill;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonAdd, ToolStripButtonView, ToolStripButtonEdit, ToolStripButtonDelete });
            ToolStripMain.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(295, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(85, 36);
            ToolStripButtonAdd.Text = "Agregar";
            ToolStripButtonAdd.Click += Agregar_Click;
            // 
            // ToolStripButtonView
            // 
            ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            ToolStripButtonView.Name = "ToolStripButtonView";
            ToolStripButtonView.Size = new Size(59, 36);
            ToolStripButtonView.Text = "Ver";
            ToolStripButtonView.Click += Ver_Click;
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(73, 36);
            ToolStripButtonEdit.Text = "Editar";
            ToolStripButtonEdit.Click += Editar_Click;
            // 
            // ToolStripButtonDelete
            // 
            ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            ToolStripButtonDelete.Size = new Size(75, 36);
            ToolStripButtonDelete.Text = "Borrar";
            ToolStripButtonDelete.Click += Borrar_Click;
            // 
            // ToolStripActiveFilter
            // 
            ToolStripActiveFilter.Dock = DockStyle.Fill;
            ToolStripActiveFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripActiveFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelActiveFilter, ToolStripComboBoxActiveFilter });
            ToolStripActiveFilter.Location = new Point(295, 0);
            ToolStripActiveFilter.Name = "ToolStripActiveFilter";
            ToolStripActiveFilter.Size = new Size(188, 39);
            ToolStripActiveFilter.TabIndex = 13;
            // 
            // ToolStripLabelActiveFilter
            // 
            ToolStripLabelActiveFilter.Name = "ToolStripLabelActiveFilter";
            ToolStripLabelActiveFilter.Size = new Size(96, 36);
            ToolStripLabelActiveFilter.Text = "Filtrar por activo:";
            // 
            // ToolStripComboBoxActiveFilter
            // 
            ToolStripComboBoxActiveFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxActiveFilter.Name = "ToolStripComboBoxActiveFilter";
            ToolStripComboBoxActiveFilter.Size = new Size(87, 39);
            ToolStripComboBoxActiveFilter.SelectedIndexChanged += Activo_SelectedIndexChanged;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.AllowUserToAddRows = false;
            DataGridViewMain.AllowUserToDeleteRows = false;
            DataGridViewMain.AllowUserToOrderColumns = true;
            DataGridViewMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            DataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnEsActivo });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.Location = new Point(0, 39);
            DataGridViewMain.Margin = new Padding(4, 3, 4, 3);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(1002, 391);
            DataGridViewMain.TabIndex = 5;
            DataGridViewMain.ColumnHeaderMouseClick += Grid_ColumnHeaderMouseClick;
            DataGridViewMain.DoubleClick += Ver_Click;
            // 
            // DataGridViewColumnNombre
            // 
            DataGridViewColumnNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewColumnNombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewColumnNombre.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewColumnNombre.HeaderText = "Nombre";
            DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            DataGridViewColumnNombre.ReadOnly = true;
            DataGridViewColumnNombre.Width = 76;
            // 
            // DataGridViewColumnEsActivo
            // 
            DataGridViewColumnEsActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewColumnEsActivo.DataPropertyName = "EsActivo";
            DataGridViewColumnEsActivo.HeaderText = "Activo";
            DataGridViewColumnEsActivo.Name = "DataGridViewColumnEsActivo";
            DataGridViewColumnEsActivo.ReadOnly = true;
            DataGridViewColumnEsActivo.Width = 47;
            // 
            // ToolStripItemsCounter
            // 
            ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            ToolStripItemsCounter.Dock = DockStyle.Fill;
            ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { ToolStripLabelItemsCounter });
            ToolStripItemsCounter.Location = new Point(483, 0);
            ToolStripItemsCounter.Name = "ToolStripItemsCounter";
            ToolStripItemsCounter.Size = new Size(3, 39);
            ToolStripItemsCounter.TabIndex = 18;
            // 
            // ToolStripLabelItemsCounter
            // 
            ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            ToolStripLabelItemsCounter.Size = new Size(0, 36);
            // 
            // FormUsersGroups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 430);
            Controls.Add(DataGridViewMain);
            Controls.Add(FlowLayoutPanelToolbars);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsersGroups";
            ShowInTaskbar = false;
            Text = "Grupos de usuarios";
            FormClosed += This_FormClosed;
            FlowLayoutPanelToolbars.ResumeLayout(false);
            FlowLayoutPanelToolbars.PerformLayout();
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ToolStripActiveFilter.ResumeLayout(false);
            ToolStripActiveFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            ToolStripItemsCounter.ResumeLayout(false);
            ToolStripItemsCounter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelToolbars;
        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonAdd;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonEdit;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonDelete;
        internal System.Windows.Forms.DataGridView DataGridViewMain;
        internal System.Windows.Forms.ToolStrip ToolStripActiveFilter;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabelActiveFilter;
        internal System.Windows.Forms.ToolStripComboBox ToolStripComboBoxActiveFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewColumnEsActivo;
        private System.Windows.Forms.ToolStripButton ToolStripButtonView;
        private ToolStrip ToolStripItemsCounter;
        private ToolStripLabel ToolStripLabelItemsCounter;
    }
}