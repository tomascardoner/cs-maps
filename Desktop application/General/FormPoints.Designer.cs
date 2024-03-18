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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPoints));
            ToolStripMain = new ToolStrip();
            ToolStripButtonShowButtons = new ToolStripButton();
            ToolStripButtonAdd = new ToolStripButton();
            ToolStripButtonView = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonDelete = new ToolStripButton();
            ToolStripButtonDataComplete = new ToolStripButton();
            ToolStripButtonDataDelete = new ToolStripButton();
            DataGridViewMain = new DataGridView();
            DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            DataGridViewColumnLatitud = new DataGridViewTextBoxColumn();
            DataGridViewColumnLongitud = new DataGridViewTextBoxColumn();
            DataGridViewColumnEstablecimiento = new DataGridViewTextBoxColumn();
            DataGridViewColumnChapaNumero = new DataGridViewTextBoxColumn();
            FlowLayoutPanelToolbars = new FlowLayoutPanel();
            ToolStripNameFilter = new ToolStrip();
            ToolStripLabelNameFilter = new ToolStripLabel();
            ToolStripComboBoxNameFilterType = new ToolStripComboBox();
            ToolStripTextBoxNameFilter = new ToolStripTextBox();
            ToolStripButtonNameFilterClear = new ToolStripButton();
            ToolStripDataExistFilter = new ToolStrip();
            ToolStripLabelDataExistFilter = new ToolStripLabel();
            ToolStripComboBoxDataExistFilter = new ToolStripComboBox();
            ToolStripItemsCounter = new ToolStrip();
            ToolStripLabelItemsCounter = new ToolStripLabel();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            FlowLayoutPanelToolbars.SuspendLayout();
            ToolStripNameFilter.SuspendLayout();
            ToolStripDataExistFilter.SuspendLayout();
            ToolStripItemsCounter.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Fill;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonShowButtons, ToolStripButtonAdd, ToolStripButtonView, ToolStripButtonEdit, ToolStripButtonDelete, ToolStripButtonDataComplete, ToolStripButtonDataDelete });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(347, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonShowButtons
            // 
            ToolStripButtonShowButtons.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonShowButtons.Image = (Image)resources.GetObject("ToolStripButtonShowButtons.Image");
            ToolStripButtonShowButtons.ImageTransparentColor = Color.Magenta;
            ToolStripButtonShowButtons.Name = "ToolStripButtonShowButtons";
            ToolStripButtonShowButtons.Size = new Size(98, 36);
            ToolStripButtonShowButtons.Text = "Mostrar botones";
            ToolStripButtonShowButtons.Click += ToolStripButtonShowButtons_Click;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(85, 36);
            ToolStripButtonAdd.Text = "Agregar";
            ToolStripButtonAdd.Visible = false;
            ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
            // 
            // ToolStripButtonView
            // 
            ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            ToolStripButtonView.Name = "ToolStripButtonView";
            ToolStripButtonView.Size = new Size(59, 36);
            ToolStripButtonView.Text = "Ver";
            ToolStripButtonView.Visible = false;
            ToolStripButtonView.Click += ToolStripButtonView_Click;
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(73, 36);
            ToolStripButtonEdit.Text = "Editar";
            ToolStripButtonEdit.Visible = false;
            ToolStripButtonEdit.Click += ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonDelete
            // 
            ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            ToolStripButtonDelete.Size = new Size(75, 36);
            ToolStripButtonDelete.Text = "Borrar";
            ToolStripButtonDelete.Visible = false;
            ToolStripButtonDelete.Click += ToolStripButtonDelete_Click;
            // 
            // ToolStripButtonDataComplete
            // 
            ToolStripButtonDataComplete.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonDataComplete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDataComplete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDataComplete.Name = "ToolStripButtonDataComplete";
            ToolStripButtonDataComplete.Size = new Size(131, 36);
            ToolStripButtonDataComplete.Text = "Completar datos";
            ToolStripButtonDataComplete.Click += ToolStripButtonDataComplete_Click;
            // 
            // ToolStripButtonDataDelete
            // 
            ToolStripButtonDataDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDataDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDataDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDataDelete.Name = "ToolStripButtonDataDelete";
            ToolStripButtonDataDelete.Size = new Size(115, 36);
            ToolStripButtonDataDelete.Text = "Limpiar datos";
            ToolStripButtonDataDelete.Click += ToolStripButtonDataDelete_Click;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.AllowUserToAddRows = false;
            DataGridViewMain.AllowUserToDeleteRows = false;
            DataGridViewMain.AllowUserToResizeColumns = false;
            DataGridViewMain.AllowUserToResizeRows = false;
            DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnLatitud, DataGridViewColumnLongitud, DataGridViewColumnEstablecimiento, DataGridViewColumnChapaNumero });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(0, 64);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(910, 269);
            DataGridViewMain.TabIndex = 1;
            DataGridViewMain.ColumnHeaderMouseClick += DataGridViewMain_ColumnHeaderMouseClick;
            DataGridViewMain.DoubleClick += ToolStripButtonView_Click;
            DataGridViewMain.KeyPress += DataGridViewMain_KeyPress;
            // 
            // DataGridViewColumnNombre
            // 
            DataGridViewColumnNombre.DataPropertyName = "Nombre";
            DataGridViewColumnNombre.HeaderText = "Nombre";
            DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            DataGridViewColumnNombre.ReadOnly = true;
            DataGridViewColumnNombre.Width = 76;
            // 
            // DataGridViewColumnLatitud
            // 
            DataGridViewColumnLatitud.DataPropertyName = "Latitud";
            DataGridViewColumnLatitud.HeaderText = "Latitud";
            DataGridViewColumnLatitud.Name = "DataGridViewColumnLatitud";
            DataGridViewColumnLatitud.ReadOnly = true;
            DataGridViewColumnLatitud.Width = 69;
            // 
            // DataGridViewColumnLongitud
            // 
            DataGridViewColumnLongitud.DataPropertyName = "Longitud";
            DataGridViewColumnLongitud.HeaderText = "Longitud";
            DataGridViewColumnLongitud.Name = "DataGridViewColumnLongitud";
            DataGridViewColumnLongitud.ReadOnly = true;
            DataGridViewColumnLongitud.Width = 80;
            // 
            // DataGridViewColumnEstablecimiento
            // 
            DataGridViewColumnEstablecimiento.DataPropertyName = "EstablecimientoNombre";
            DataGridViewColumnEstablecimiento.HeaderText = "Establecimiento";
            DataGridViewColumnEstablecimiento.Name = "DataGridViewColumnEstablecimiento";
            DataGridViewColumnEstablecimiento.ReadOnly = true;
            DataGridViewColumnEstablecimiento.Width = 116;
            // 
            // DataGridViewColumnChapaNumero
            // 
            DataGridViewColumnChapaNumero.DataPropertyName = "ChapaNumero";
            DataGridViewColumnChapaNumero.HeaderText = "Chapa nº";
            DataGridViewColumnChapaNumero.Name = "DataGridViewColumnChapaNumero";
            DataGridViewColumnChapaNumero.ReadOnly = true;
            DataGridViewColumnChapaNumero.Width = 81;
            // 
            // FlowLayoutPanelToolbars
            // 
            FlowLayoutPanelToolbars.AutoSize = true;
            FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanelToolbars.Controls.Add(ToolStripMain);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripNameFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripDataExistFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripItemsCounter);
            FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            FlowLayoutPanelToolbars.Location = new Point(0, 0);
            FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            FlowLayoutPanelToolbars.Size = new Size(910, 64);
            FlowLayoutPanelToolbars.TabIndex = 2;
            // 
            // ToolStripNameFilter
            // 
            ToolStripNameFilter.Dock = DockStyle.Fill;
            ToolStripNameFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripNameFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelNameFilter, ToolStripComboBoxNameFilterType, ToolStripTextBoxNameFilter, ToolStripButtonNameFilterClear });
            ToolStripNameFilter.Location = new Point(347, 0);
            ToolStripNameFilter.Name = "ToolStripNameFilter";
            ToolStripNameFilter.Size = new Size(412, 39);
            ToolStripNameFilter.TabIndex = 1;
            // 
            // ToolStripLabelNameFilter
            // 
            ToolStripLabelNameFilter.Name = "ToolStripLabelNameFilter";
            ToolStripLabelNameFilter.Size = new Size(111, 36);
            ToolStripLabelNameFilter.Text = "Filtrar por nombres:";
            // 
            // ToolStripComboBoxNameFilterType
            // 
            ToolStripComboBoxNameFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxNameFilterType.Name = "ToolStripComboBoxNameFilterType";
            ToolStripComboBoxNameFilterType.Size = new Size(121, 39);
            ToolStripComboBoxNameFilterType.SelectedIndexChanged += ToolStripComboBoxFilterType_SelectedIndexChanged;
            // 
            // ToolStripTextBoxNameFilter
            // 
            ToolStripTextBoxNameFilter.MaxLength = 100;
            ToolStripTextBoxNameFilter.Name = "ToolStripTextBoxNameFilter";
            ToolStripTextBoxNameFilter.Size = new Size(150, 39);
            ToolStripTextBoxNameFilter.Enter += ToolStripTextBoxSearch_Enter;
            ToolStripTextBoxNameFilter.KeyPress += ToolStripTextBoxSearch_KeyPress;
            // 
            // ToolStripButtonNameFilterClear
            // 
            ToolStripButtonNameFilterClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonNameFilterClear.Image = Properties.Resources.ImageClose16;
            ToolStripButtonNameFilterClear.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonNameFilterClear.ImageTransparentColor = Color.Magenta;
            ToolStripButtonNameFilterClear.Name = "ToolStripButtonNameFilterClear";
            ToolStripButtonNameFilterClear.Size = new Size(23, 36);
            ToolStripButtonNameFilterClear.ToolTipText = "Limpiar búsqueda";
            ToolStripButtonNameFilterClear.Click += ToolStripButtonSearchClear_Click;
            // 
            // ToolStripDataExistFilter
            // 
            ToolStripDataExistFilter.Dock = DockStyle.Fill;
            ToolStripDataExistFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripDataExistFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelDataExistFilter, ToolStripComboBoxDataExistFilter });
            ToolStripDataExistFilter.Location = new Point(0, 39);
            ToolStripDataExistFilter.Name = "ToolStripDataExistFilter";
            ToolStripDataExistFilter.Size = new Size(170, 25);
            ToolStripDataExistFilter.TabIndex = 3;
            // 
            // ToolStripLabelDataExistFilter
            // 
            ToolStripLabelDataExistFilter.Name = "ToolStripLabelDataExistFilter";
            ToolStripLabelDataExistFilter.Size = new Size(90, 22);
            ToolStripLabelDataExistFilter.Text = "Contiene datos:";
            // 
            // ToolStripComboBoxDataExistFilter
            // 
            ToolStripComboBoxDataExistFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxDataExistFilter.Name = "ToolStripComboBoxDataExistFilter";
            ToolStripComboBoxDataExistFilter.Size = new Size(75, 25);
            ToolStripComboBoxDataExistFilter.SelectedIndexChanged += ToolStripComboBoxDataExistFilter_SelectedIndexChanged;
            // 
            // ToolStripItemsCounter
            // 
            ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            ToolStripItemsCounter.Dock = DockStyle.Fill;
            ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { ToolStripLabelItemsCounter });
            ToolStripItemsCounter.Location = new Point(170, 39);
            ToolStripItemsCounter.Name = "ToolStripItemsCounter";
            ToolStripItemsCounter.Size = new Size(3, 25);
            ToolStripItemsCounter.TabIndex = 2;
            // 
            // ToolStripLabelItemsCounter
            // 
            ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            ToolStripLabelItemsCounter.Size = new Size(0, 22);
            // 
            // FormPoints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 333);
            Controls.Add(DataGridViewMain);
            Controls.Add(FlowLayoutPanelToolbars);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPoints";
            Text = "Puntos";
            FormClosed += This_FormClosed;
            Load += This_Load;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            FlowLayoutPanelToolbars.ResumeLayout(false);
            FlowLayoutPanelToolbars.PerformLayout();
            ToolStripNameFilter.ResumeLayout(false);
            ToolStripNameFilter.PerformLayout();
            ToolStripDataExistFilter.ResumeLayout(false);
            ToolStripDataExistFilter.PerformLayout();
            ToolStripItemsCounter.ResumeLayout(false);
            ToolStripItemsCounter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn DataGridViewColumnEstablecimiento;
        private DataGridViewTextBoxColumn DataGridViewColumnChapaNumero;
        private ToolStrip ToolStripDataExistFilter;
        private ToolStripLabel ToolStripLabelDataExistFilter;
        private ToolStripComboBox ToolStripComboBoxDataExistFilter;
        private ToolStripButton ToolStripButtonDataComplete;
        private ToolStripButton ToolStripButtonDataDelete;
        private ToolStripButton ToolStripButtonShowButtons;
    }
}