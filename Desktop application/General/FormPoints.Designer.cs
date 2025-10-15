namespace CSMaps.General
{
    partial class FormPoints
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
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            var dataGridViewCellStyle5 = new DataGridViewCellStyle();
            var dataGridViewCellStyle6 = new DataGridViewCellStyle();
            this.ToolStripMain = new ToolStrip();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripButtonView = new ToolStripButton();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.DataGridViewMain = new DataGridView();
            this.DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnLatitud = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnLongitud = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnAltitud = new DataGridViewTextBoxColumn();
            this.FlowLayoutPanelToolbars = new FlowLayoutPanel();
            this.ToolStripNameFilter = new ToolStrip();
            this.ToolStripLabelNameFilter = new ToolStripLabel();
            this.ToolStripComboBoxNameFilterType = new ToolStripComboBox();
            this.ToolStripTextBoxNameFilter = new ToolStripTextBox();
            this.ToolStripButtonNameFilterClear = new ToolStripButton();
            this.ToolStripItemsCounter = new ToolStrip();
            this.ToolStripLabelItemsCounter = new ToolStripLabel();
            this.ToolStripButtonViewOnMap = new ToolStripButton();
            this.ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DataGridViewMain).BeginInit();
            this.FlowLayoutPanelToolbars.SuspendLayout();
            this.ToolStripNameFilter.SuspendLayout();
            this.ToolStripItemsCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Dock = DockStyle.Fill;
            this.ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripMain.ImageScalingSize = new Size(20, 20);
            this.ToolStripMain.Items.AddRange(new ToolStripItem[] { this.ToolStripButtonAdd, this.ToolStripButtonView, this.ToolStripButtonViewOnMap, this.ToolStripButtonEdit, this.ToolStripButtonDelete });
            this.ToolStripMain.Location = new Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new Size(556, 39);
            this.ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            this.ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(99, 36);
            this.ToolStripButtonAdd.Text = "Agregar";
            this.ToolStripButtonAdd.Click += this.ToolStripButtonAdd_Click;
            // 
            // ToolStripButtonView
            // 
            this.ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            this.ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonView.Name = "ToolStripButtonView";
            this.ToolStripButtonView.Size = new Size(66, 36);
            this.ToolStripButtonView.Text = "Ver";
            this.ToolStripButtonView.Click += this.ToolStripButtonView_Click;
            // 
            // ToolStripButtonEdit
            // 
            this.ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(84, 36);
            this.ToolStripButtonEdit.Text = "Editar";
            this.ToolStripButtonEdit.Click += this.ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonDelete
            // 
            this.ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(86, 36);
            this.ToolStripButtonDelete.Text = "Borrar";
            this.ToolStripButtonDelete.Click += this.ToolStripButtonDelete_Click;
            // 
            // DataGridViewMain
            // 
            this.DataGridViewMain.AllowUserToAddRows = false;
            this.DataGridViewMain.AllowUserToDeleteRows = false;
            this.DataGridViewMain.AllowUserToResizeColumns = false;
            this.DataGridViewMain.AllowUserToResizeRows = false;
            this.DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewMain.ColumnHeadersHeight = 29;
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewColumnNombre, this.DataGridViewColumnLatitud, this.DataGridViewColumnLongitud, this.DataGridViewColumnAltitud });
            this.DataGridViewMain.Dock = DockStyle.Fill;
            this.DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewMain.Location = new Point(0, 67);
            this.DataGridViewMain.MultiSelect = false;
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.ReadOnly = true;
            this.DataGridViewMain.RowHeadersVisible = false;
            this.DataGridViewMain.RowHeadersWidth = 51;
            this.DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMain.Size = new Size(910, 414);
            this.DataGridViewMain.TabIndex = 1;
            this.DataGridViewMain.ColumnHeaderMouseClick += this.DataGridViewMain_ColumnHeaderMouseClick;
            this.DataGridViewMain.DoubleClick += this.ToolStripButtonView_Click;
            this.DataGridViewMain.KeyPress += this.DataGridViewMain_KeyPress;
            // 
            // DataGridViewColumnNombre
            // 
            this.DataGridViewColumnNombre.DataPropertyName = "Nombre";
            this.DataGridViewColumnNombre.HeaderText = "Nombre";
            this.DataGridViewColumnNombre.MinimumWidth = 6;
            this.DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            this.DataGridViewColumnNombre.ReadOnly = true;
            this.DataGridViewColumnNombre.Width = 93;
            // 
            // DataGridViewColumnLatitud
            // 
            this.DataGridViewColumnLatitud.DataPropertyName = "Latitud";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DataGridViewColumnLatitud.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewColumnLatitud.HeaderText = "Latitud";
            this.DataGridViewColumnLatitud.MinimumWidth = 6;
            this.DataGridViewColumnLatitud.Name = "DataGridViewColumnLatitud";
            this.DataGridViewColumnLatitud.ReadOnly = true;
            this.DataGridViewColumnLatitud.Width = 84;
            // 
            // DataGridViewColumnLongitud
            // 
            this.DataGridViewColumnLongitud.DataPropertyName = "Longitud";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DataGridViewColumnLongitud.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewColumnLongitud.HeaderText = "Longitud";
            this.DataGridViewColumnLongitud.MinimumWidth = 6;
            this.DataGridViewColumnLongitud.Name = "DataGridViewColumnLongitud";
            this.DataGridViewColumnLongitud.ReadOnly = true;
            this.DataGridViewColumnLongitud.Width = 97;
            // 
            // DataGridViewColumnAltitud
            // 
            this.DataGridViewColumnAltitud.DataPropertyName = "Altitud";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DataGridViewColumnAltitud.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewColumnAltitud.HeaderText = "Altitud";
            this.DataGridViewColumnAltitud.MinimumWidth = 6;
            this.DataGridViewColumnAltitud.Name = "DataGridViewColumnAltitud";
            this.DataGridViewColumnAltitud.ReadOnly = true;
            this.DataGridViewColumnAltitud.Width = 83;
            // 
            // FlowLayoutPanelToolbars
            // 
            this.FlowLayoutPanelToolbars.AutoSize = true;
            this.FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripMain);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripNameFilter);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripItemsCounter);
            this.FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            this.FlowLayoutPanelToolbars.Location = new Point(0, 0);
            this.FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            this.FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            this.FlowLayoutPanelToolbars.Size = new Size(910, 67);
            this.FlowLayoutPanelToolbars.TabIndex = 2;
            // 
            // ToolStripNameFilter
            // 
            this.ToolStripNameFilter.Dock = DockStyle.Fill;
            this.ToolStripNameFilter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripNameFilter.ImageScalingSize = new Size(20, 20);
            this.ToolStripNameFilter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelNameFilter, this.ToolStripComboBoxNameFilterType, this.ToolStripTextBoxNameFilter, this.ToolStripButtonNameFilterClear });
            this.ToolStripNameFilter.Location = new Point(0, 39);
            this.ToolStripNameFilter.Name = "ToolStripNameFilter";
            this.ToolStripNameFilter.Size = new Size(446, 28);
            this.ToolStripNameFilter.TabIndex = 1;
            // 
            // ToolStripLabelNameFilter
            // 
            this.ToolStripLabelNameFilter.Name = "ToolStripLabelNameFilter";
            this.ToolStripLabelNameFilter.Size = new Size(139, 25);
            this.ToolStripLabelNameFilter.Text = "Filtrar por nombres:";
            // 
            // ToolStripComboBoxNameFilterType
            // 
            this.ToolStripComboBoxNameFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ToolStripComboBoxNameFilterType.Name = "ToolStripComboBoxNameFilterType";
            this.ToolStripComboBoxNameFilterType.Size = new Size(121, 28);
            this.ToolStripComboBoxNameFilterType.SelectedIndexChanged += this.ToolStripComboBoxFilterType_SelectedIndexChanged;
            // 
            // ToolStripTextBoxNameFilter
            // 
            this.ToolStripTextBoxNameFilter.MaxLength = 100;
            this.ToolStripTextBoxNameFilter.Name = "ToolStripTextBoxNameFilter";
            this.ToolStripTextBoxNameFilter.Size = new Size(150, 28);
            this.ToolStripTextBoxNameFilter.Enter += this.ToolStripTextBoxSearch_Enter;
            this.ToolStripTextBoxNameFilter.KeyPress += this.ToolStripTextBoxSearch_KeyPress;
            // 
            // ToolStripButtonNameFilterClear
            // 
            this.ToolStripButtonNameFilterClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonNameFilterClear.Image = Properties.Resources.ImageClose16;
            this.ToolStripButtonNameFilterClear.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonNameFilterClear.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonNameFilterClear.Name = "ToolStripButtonNameFilterClear";
            this.ToolStripButtonNameFilterClear.Size = new Size(29, 25);
            this.ToolStripButtonNameFilterClear.ToolTipText = "Limpiar búsqueda";
            this.ToolStripButtonNameFilterClear.Click += this.ToolStripButtonSearchClear_Click;
            // 
            // ToolStripItemsCounter
            // 
            this.ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            this.ToolStripItemsCounter.Dock = DockStyle.Fill;
            this.ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripItemsCounter.ImageScalingSize = new Size(20, 20);
            this.ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelItemsCounter });
            this.ToolStripItemsCounter.Location = new Point(446, 39);
            this.ToolStripItemsCounter.Name = "ToolStripItemsCounter";
            this.ToolStripItemsCounter.Size = new Size(3, 28);
            this.ToolStripItemsCounter.TabIndex = 2;
            // 
            // ToolStripLabelItemsCounter
            // 
            this.ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            this.ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            this.ToolStripLabelItemsCounter.Size = new Size(0, 25);
            // 
            // ToolStripButtonViewOnMap
            // 
            this.ToolStripButtonViewOnMap.Image = Properties.Resources.ImagePunto32;
            this.ToolStripButtonViewOnMap.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewOnMap.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewOnMap.Name = "ToolStripButtonViewOnMap";
            this.ToolStripButtonViewOnMap.Size = new Size(179, 36);
            this.ToolStripButtonViewOnMap.Text = "Ver en Google Maps";
            this.ToolStripButtonViewOnMap.Click += this.ToolStripButtonViewOnMap_Click;
            // 
            // FormPoints
            // 
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.ClientSize = new Size(910, 481);
            this.Controls.Add(this.DataGridViewMain);
            this.Controls.Add(this.FlowLayoutPanelToolbars);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPoints";
            this.Text = "Puntos";
            this.FormClosed += this.This_FormClosed;
            this.Load += this.This_Load;
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DataGridViewMain).EndInit();
            this.FlowLayoutPanelToolbars.ResumeLayout(false);
            this.FlowLayoutPanelToolbars.PerformLayout();
            this.ToolStripNameFilter.ResumeLayout(false);
            this.ToolStripNameFilter.PerformLayout();
            this.ToolStripItemsCounter.ResumeLayout(false);
            this.ToolStripItemsCounter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private ToolStripButton ToolStripButtonAdd;
        private ToolStripButton ToolStripButtonEdit;
        private ToolStripButton ToolStripButtonDelete;
        private DataGridView DataGridViewMain;
        private ToolStripButton ToolStripButtonView;
        private FlowLayoutPanel FlowLayoutPanelToolbars;
        private ToolStrip ToolStripNameFilter;
        private ToolStripLabel ToolStripLabelNameFilter;
        private ToolStripComboBox ToolStripComboBoxNameFilterType;
        private ToolStripTextBox ToolStripTextBoxNameFilter;
        internal ToolStripButton ToolStripButtonNameFilterClear;
        private ToolStrip ToolStripItemsCounter;
        private ToolStripLabel ToolStripLabelItemsCounter;
        private DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private DataGridViewTextBoxColumn DataGridViewColumnLatitud;
        private DataGridViewTextBoxColumn DataGridViewColumnLongitud;
        private DataGridViewTextBoxColumn DataGridViewColumnAltitud;
        private ToolStripButton ToolStripButtonViewOnMap;
    }
}