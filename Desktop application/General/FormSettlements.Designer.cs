namespace CSMaps.General
{
    partial class FormSettlements
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
            this.DataGridViewMain = new DataGridView();
            this.DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnEntidad = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnTelefonoMovil = new DataGridViewTextBoxColumn();
            this.FlowLayoutPanelToolbars = new FlowLayoutPanel();
            this.ToolStripMain = new ToolStrip();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripButtonView = new ToolStripButton();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripNameFilter = new ToolStrip();
            this.ToolStripLabelNameFilter = new ToolStripLabel();
            this.ToolStripComboBoxNameFilterType = new ToolStripComboBox();
            this.ToolStripTextBoxNameFilter = new ToolStripTextBox();
            this.ToolStripButtonNameFilterClear = new ToolStripButton();
            this.ToolStripItemsCounter = new ToolStrip();
            this.ToolStripLabelItemsCounter = new ToolStripLabel();
            this.ToolStripEntityFilter = new ToolStrip();
            this.ToolStripLabelEntityFilter = new ToolStripLabel();
            this.ToolStripComboBoxEntityFilter = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)this.DataGridViewMain).BeginInit();
            this.FlowLayoutPanelToolbars.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.ToolStripNameFilter.SuspendLayout();
            this.ToolStripItemsCounter.SuspendLayout();
            this.ToolStripEntityFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewMain
            // 
            this.DataGridViewMain.AllowUserToAddRows = false;
            this.DataGridViewMain.AllowUserToDeleteRows = false;
            this.DataGridViewMain.AllowUserToResizeColumns = false;
            this.DataGridViewMain.AllowUserToResizeRows = false;
            this.DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewColumnNombre, this.DataGridViewColumnEntidad, this.DataGridViewColumnTelefonoMovil });
            this.DataGridViewMain.Dock = DockStyle.Fill;
            this.DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewMain.Location = new Point(0, 89);
            this.DataGridViewMain.MultiSelect = false;
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.ReadOnly = true;
            this.DataGridViewMain.RowHeadersVisible = false;
            this.DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMain.Size = new Size(730, 244);
            this.DataGridViewMain.TabIndex = 1;
            this.DataGridViewMain.ColumnHeaderMouseClick += this.DataGridViewMain_ColumnHeaderMouseClick;
            this.DataGridViewMain.DoubleClick += this.ToolStripButtonView_Click;
            this.DataGridViewMain.KeyPress += this.DataGridViewMain_KeyPress;
            // 
            // DataGridViewColumnNombre
            // 
            this.DataGridViewColumnNombre.DataPropertyName = "Nombre";
            this.DataGridViewColumnNombre.HeaderText = "Nombre";
            this.DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            this.DataGridViewColumnNombre.ReadOnly = true;
            this.DataGridViewColumnNombre.Width = 76;
            // 
            // DataGridViewColumnEntidad
            // 
            this.DataGridViewColumnEntidad.DataPropertyName = "EntidadNombre";
            this.DataGridViewColumnEntidad.HeaderText = "Entidad";
            this.DataGridViewColumnEntidad.Name = "DataGridViewColumnEntidad";
            this.DataGridViewColumnEntidad.ReadOnly = true;
            this.DataGridViewColumnEntidad.Width = 72;
            // 
            // DataGridViewColumnTelefonoMovil
            // 
            this.DataGridViewColumnTelefonoMovil.DataPropertyName = "TelefonoMovil";
            this.DataGridViewColumnTelefonoMovil.HeaderText = "Teléfono móvil";
            this.DataGridViewColumnTelefonoMovil.Name = "DataGridViewColumnTelefonoMovil";
            this.DataGridViewColumnTelefonoMovil.ReadOnly = true;
            this.DataGridViewColumnTelefonoMovil.Width = 110;
            // 
            // FlowLayoutPanelToolbars
            // 
            this.FlowLayoutPanelToolbars.AutoSize = true;
            this.FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripMain);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripEntityFilter);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripNameFilter);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripItemsCounter);
            this.FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            this.FlowLayoutPanelToolbars.Location = new Point(0, 0);
            this.FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            this.FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            this.FlowLayoutPanelToolbars.Size = new Size(730, 89);
            this.FlowLayoutPanelToolbars.TabIndex = 3;
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Dock = DockStyle.Fill;
            this.ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripMain.Items.AddRange(new ToolStripItem[] { this.ToolStripButtonAdd, this.ToolStripButtonView, this.ToolStripButtonEdit, this.ToolStripButtonDelete });
            this.ToolStripMain.Location = new Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new Size(295, 39);
            this.ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            this.ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(85, 36);
            this.ToolStripButtonAdd.Text = "Agregar";
            this.ToolStripButtonAdd.Click += this.ToolStripButtonAdd_Click;
            // 
            // ToolStripButtonView
            // 
            this.ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            this.ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonView.Name = "ToolStripButtonView";
            this.ToolStripButtonView.Size = new Size(59, 36);
            this.ToolStripButtonView.Text = "Ver";
            this.ToolStripButtonView.Click += this.ToolStripButtonView_Click;
            // 
            // ToolStripButtonEdit
            // 
            this.ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(73, 36);
            this.ToolStripButtonEdit.Text = "Editar";
            this.ToolStripButtonEdit.Click += this.ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonDelete
            // 
            this.ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(75, 36);
            this.ToolStripButtonDelete.Text = "Borrar";
            this.ToolStripButtonDelete.Click += this.ToolStripButtonDelete_Click;
            // 
            // ToolStripNameFilter
            // 
            this.ToolStripNameFilter.Dock = DockStyle.Fill;
            this.ToolStripNameFilter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripNameFilter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelNameFilter, this.ToolStripComboBoxNameFilterType, this.ToolStripTextBoxNameFilter, this.ToolStripButtonNameFilterClear });
            this.ToolStripNameFilter.Location = new Point(0, 64);
            this.ToolStripNameFilter.Name = "ToolStripNameFilter";
            this.ToolStripNameFilter.Size = new Size(412, 25);
            this.ToolStripNameFilter.TabIndex = 1;
            // 
            // ToolStripLabelNameFilter
            // 
            this.ToolStripLabelNameFilter.Name = "ToolStripLabelNameFilter";
            this.ToolStripLabelNameFilter.Size = new Size(111, 22);
            this.ToolStripLabelNameFilter.Text = "Filtrar por nombres:";
            // 
            // ToolStripComboBoxNameFilterType
            // 
            this.ToolStripComboBoxNameFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ToolStripComboBoxNameFilterType.Name = "ToolStripComboBoxNameFilterType";
            this.ToolStripComboBoxNameFilterType.Size = new Size(121, 25);
            this.ToolStripComboBoxNameFilterType.SelectedIndexChanged += this.ToolStripComboBoxNameFilterType_SelectedIndexChanged;
            // 
            // ToolStripTextBoxNameFilter
            // 
            this.ToolStripTextBoxNameFilter.MaxLength = 100;
            this.ToolStripTextBoxNameFilter.Name = "ToolStripTextBoxNameFilter";
            this.ToolStripTextBoxNameFilter.Size = new Size(150, 25);
            this.ToolStripTextBoxNameFilter.Enter += this.ToolStripTextBoxNameFilter_Enter;
            this.ToolStripTextBoxNameFilter.KeyPress += this.ToolStripTextBoxNameFilter_KeyPress;
            // 
            // ToolStripButtonNameFilterClear
            // 
            this.ToolStripButtonNameFilterClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonNameFilterClear.Image = Properties.Resources.ImageClose16;
            this.ToolStripButtonNameFilterClear.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonNameFilterClear.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonNameFilterClear.Name = "ToolStripButtonNameFilterClear";
            this.ToolStripButtonNameFilterClear.Size = new Size(23, 22);
            this.ToolStripButtonNameFilterClear.ToolTipText = "Limpiar búsqueda";
            this.ToolStripButtonNameFilterClear.Click += this.ToolStripButtonNameFilterClear_Click;
            // 
            // ToolStripItemsCounter
            // 
            this.ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            this.ToolStripItemsCounter.Dock = DockStyle.Fill;
            this.ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelItemsCounter });
            this.ToolStripItemsCounter.Location = new Point(412, 64);
            this.ToolStripItemsCounter.Name = "ToolStripItemsCounter";
            this.ToolStripItemsCounter.Size = new Size(3, 25);
            this.ToolStripItemsCounter.TabIndex = 3;
            // 
            // ToolStripLabelItemsCounter
            // 
            this.ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            this.ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            this.ToolStripLabelItemsCounter.Size = new Size(0, 22);
            // 
            // ToolStripEntityFilter
            // 
            this.ToolStripEntityFilter.Dock = DockStyle.Fill;
            this.ToolStripEntityFilter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripEntityFilter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelEntityFilter, this.ToolStripComboBoxEntityFilter });
            this.ToolStripEntityFilter.Location = new Point(0, 39);
            this.ToolStripEntityFilter.Name = "ToolStripEntityFilter";
            this.ToolStripEntityFilter.Size = new Size(440, 25);
            this.ToolStripEntityFilter.TabIndex = 4;
            // 
            // ToolStripLabelEntityFilter
            // 
            this.ToolStripLabelEntityFilter.Name = "ToolStripLabelEntityFilter";
            this.ToolStripLabelEntityFilter.Size = new Size(104, 36);
            this.ToolStripLabelEntityFilter.Text = "Filtrar por entidad:";
            // 
            // ToolStripComboBoxEntityFilter
            // 
            this.ToolStripComboBoxEntityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ToolStripComboBoxEntityFilter.Name = "ToolStripComboBoxEntityFilter";
            this.ToolStripComboBoxEntityFilter.Size = new Size(300, 25);
            this.ToolStripComboBoxEntityFilter.SelectedIndexChanged += this.ToolStripComboBoxEntityFilter_SelectedIndexChanged;
            // 
            // FormSettlements
            // 
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.ClientSize = new Size(730, 333);
            this.Controls.Add(this.DataGridViewMain);
            this.Controls.Add(this.FlowLayoutPanelToolbars);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettlements";
            this.Text = "Establecimientos";
            this.FormClosed += this.This_FormClosed;
            this.Load += this.This_Load;
            ((System.ComponentModel.ISupportInitialize)this.DataGridViewMain).EndInit();
            this.FlowLayoutPanelToolbars.ResumeLayout(false);
            this.FlowLayoutPanelToolbars.PerformLayout();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ToolStripNameFilter.ResumeLayout(false);
            this.ToolStripNameFilter.PerformLayout();
            this.ToolStripItemsCounter.ResumeLayout(false);
            this.ToolStripItemsCounter.PerformLayout();
            this.ToolStripEntityFilter.ResumeLayout(false);
            this.ToolStripEntityFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private DataGridView DataGridViewMain;
        private DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private DataGridViewTextBoxColumn DataGridViewColumnEntidad;
        private DataGridViewTextBoxColumn DataGridViewColumnTelefonoMovil;
        private FlowLayoutPanel FlowLayoutPanelToolbars;
        private ToolStrip ToolStripMain;
        private ToolStripButton ToolStripButtonAdd;
        private ToolStripButton ToolStripButtonView;
        private ToolStripButton ToolStripButtonEdit;
        private ToolStripButton ToolStripButtonDelete;
        private ToolStrip ToolStripNameFilter;
        private ToolStripLabel ToolStripLabelNameFilter;
        private ToolStripComboBox ToolStripComboBoxNameFilterType;
        private ToolStripTextBox ToolStripTextBoxNameFilter;
        internal ToolStripButton ToolStripButtonNameFilterClear;
        private ToolStrip ToolStripItemsCounter;
        private ToolStripLabel ToolStripLabelItemsCounter;
        private ToolStrip ToolStripEntityFilter;
        private ToolStripLabel ToolStripLabelEntityFilter;
        private ToolStripComboBox ToolStripComboBoxEntityFilter;
    }
}