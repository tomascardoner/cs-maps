namespace CSMaps.General
{
    partial class FormPointsDataAndEvents
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
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            this.ToolStripMain = new ToolStrip();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripButtonView = new ToolStripButton();
            this.ToolStripButtonViewOnMap = new ToolStripButton();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripButtonPointEventAdd = new ToolStripButton();
            this.ToolStripButtonPointEvents = new ToolStripButton();
            this.DataGridViewMain = new DataGridView();
            this.DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnLatitud = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnLongitud = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnEstablecimiento = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnChapaNumero = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnUltimoEvento = new DataGridViewTextBoxColumn();
            this.DataGridViewColumnFechaHora = new DataGridViewTextBoxColumn();
            this.FlowLayoutPanelToolbars = new FlowLayoutPanel();
            this.ToolStripNameAndSettlementFilter = new ToolStrip();
            this.ToolStripLabelNameAndSettlementFilter = new ToolStripLabel();
            this.ToolStripComboBoxNameAndSettlementFilterType = new ToolStripComboBox();
            this.ToolStripTextBoxNameAndSettlementFilter = new ToolStripTextBox();
            this.ToolStripButtonNameAndSettlementFilterClear = new ToolStripButton();
            this.ToolStripLastEventTypeFilter = new ToolStrip();
            this.ToolStripLabelLastEventTypeFilter = new ToolStripLabel();
            this.ToolStripComboBoxLastEventTypeFilter = new ToolStripComboBox();
            this.ToolStripItemsCounter = new ToolStrip();
            this.ToolStripLabelItemsCounter = new ToolStripLabel();
            this.ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DataGridViewMain).BeginInit();
            this.FlowLayoutPanelToolbars.SuspendLayout();
            this.ToolStripNameAndSettlementFilter.SuspendLayout();
            this.ToolStripLastEventTypeFilter.SuspendLayout();
            this.ToolStripItemsCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Dock = DockStyle.Fill;
            this.ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripMain.ImageScalingSize = new Size(20, 20);
            this.ToolStripMain.Items.AddRange(new ToolStripItem[] { this.ToolStripButtonAdd, this.ToolStripButtonView, this.ToolStripButtonViewOnMap, this.ToolStripButtonEdit, this.ToolStripButtonDelete, this.ToolStripButtonPointEventAdd, this.ToolStripButtonPointEvents });
            this.ToolStripMain.Location = new Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new Size(800, 39);
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
            // ToolStripButtonPointEventAdd
            // 
            this.ToolStripButtonPointEventAdd.Image = Properties.Resources.ImagePuntoEventoAdd32;
            this.ToolStripButtonPointEventAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPointEventAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPointEventAdd.Name = "ToolStripButtonPointEventAdd";
            this.ToolStripButtonPointEventAdd.Size = new Size(148, 36);
            this.ToolStripButtonPointEventAdd.Text = "Agregar evento";
            this.ToolStripButtonPointEventAdd.Click += this.ToolStripButtonPointEventAdd_Click;
            // 
            // ToolStripButtonPointEvents
            // 
            this.ToolStripButtonPointEvents.Image = Properties.Resources.ImagePuntoEvento32;
            this.ToolStripButtonPointEvents.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPointEvents.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPointEvents.Name = "ToolStripButtonPointEvents";
            this.ToolStripButtonPointEvents.Size = new Size(96, 36);
            this.ToolStripButtonPointEvents.Text = "Eventos";
            this.ToolStripButtonPointEvents.Click += this.ToolStripButtonPointEvents_Click;
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
            this.DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewColumnNombre, this.DataGridViewColumnLatitud, this.DataGridViewColumnLongitud, this.DataGridViewColumnEstablecimiento, this.DataGridViewColumnChapaNumero, this.DataGridViewColumnUltimoEvento, this.DataGridViewColumnFechaHora });
            this.DataGridViewMain.Dock = DockStyle.Fill;
            this.DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewMain.Location = new Point(0, 95);
            this.DataGridViewMain.MultiSelect = false;
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.ReadOnly = true;
            this.DataGridViewMain.RowHeadersVisible = false;
            this.DataGridViewMain.RowHeadersWidth = 51;
            this.DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMain.Size = new Size(910, 238);
            this.DataGridViewMain.TabIndex = 1;
            this.DataGridViewMain.CellDoubleClick += this.ToolStripButtonView_Click;
            this.DataGridViewMain.ColumnHeaderMouseClick += this.DataGridViewMain_ColumnHeaderMouseClick;
            // 
            // DataGridViewColumnNombre
            // 
            this.DataGridViewColumnNombre.DataPropertyName = "PuntoNombre";
            this.DataGridViewColumnNombre.HeaderText = "Nombre";
            this.DataGridViewColumnNombre.MinimumWidth = 6;
            this.DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            this.DataGridViewColumnNombre.ReadOnly = true;
            this.DataGridViewColumnNombre.Width = 93;
            // 
            // DataGridViewColumnLatitud
            // 
            this.DataGridViewColumnLatitud.DataPropertyName = "Latitud";
            this.DataGridViewColumnLatitud.HeaderText = "Latitud";
            this.DataGridViewColumnLatitud.MinimumWidth = 6;
            this.DataGridViewColumnLatitud.Name = "DataGridViewColumnLatitud";
            this.DataGridViewColumnLatitud.ReadOnly = true;
            this.DataGridViewColumnLatitud.Width = 84;
            // 
            // DataGridViewColumnLongitud
            // 
            this.DataGridViewColumnLongitud.DataPropertyName = "Longitud";
            this.DataGridViewColumnLongitud.HeaderText = "Longitud";
            this.DataGridViewColumnLongitud.MinimumWidth = 6;
            this.DataGridViewColumnLongitud.Name = "DataGridViewColumnLongitud";
            this.DataGridViewColumnLongitud.ReadOnly = true;
            this.DataGridViewColumnLongitud.Width = 97;
            // 
            // DataGridViewColumnEstablecimiento
            // 
            this.DataGridViewColumnEstablecimiento.DataPropertyName = "EstablecimientoNombre";
            this.DataGridViewColumnEstablecimiento.HeaderText = "Establecimiento";
            this.DataGridViewColumnEstablecimiento.MinimumWidth = 6;
            this.DataGridViewColumnEstablecimiento.Name = "DataGridViewColumnEstablecimiento";
            this.DataGridViewColumnEstablecimiento.ReadOnly = true;
            this.DataGridViewColumnEstablecimiento.Width = 144;
            // 
            // DataGridViewColumnChapaNumero
            // 
            this.DataGridViewColumnChapaNumero.DataPropertyName = "ChapaNumero";
            this.DataGridViewColumnChapaNumero.HeaderText = "Chapa nº";
            this.DataGridViewColumnChapaNumero.MinimumWidth = 6;
            this.DataGridViewColumnChapaNumero.Name = "DataGridViewColumnChapaNumero";
            this.DataGridViewColumnChapaNumero.ReadOnly = true;
            this.DataGridViewColumnChapaNumero.Width = 98;
            // 
            // DataGridViewColumnUltimoEvento
            // 
            this.DataGridViewColumnUltimoEvento.DataPropertyName = "EventoTipoNombre";
            this.DataGridViewColumnUltimoEvento.HeaderText = "Último evento";
            this.DataGridViewColumnUltimoEvento.MinimumWidth = 6;
            this.DataGridViewColumnUltimoEvento.Name = "DataGridViewColumnUltimoEvento";
            this.DataGridViewColumnUltimoEvento.ReadOnly = true;
            this.DataGridViewColumnUltimoEvento.Width = 132;
            // 
            // DataGridViewColumnFechaHora
            // 
            this.DataGridViewColumnFechaHora.DataPropertyName = "FechaHora";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.DataGridViewColumnFechaHora.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewColumnFechaHora.HeaderText = "Fecha y hora";
            this.DataGridViewColumnFechaHora.MinimumWidth = 6;
            this.DataGridViewColumnFechaHora.Name = "DataGridViewColumnFechaHora";
            this.DataGridViewColumnFechaHora.ReadOnly = true;
            this.DataGridViewColumnFechaHora.Width = 121;
            // 
            // FlowLayoutPanelToolbars
            // 
            this.FlowLayoutPanelToolbars.AutoSize = true;
            this.FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripMain);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripNameAndSettlementFilter);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripLastEventTypeFilter);
            this.FlowLayoutPanelToolbars.Controls.Add(this.ToolStripItemsCounter);
            this.FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            this.FlowLayoutPanelToolbars.Location = new Point(0, 0);
            this.FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            this.FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            this.FlowLayoutPanelToolbars.Size = new Size(910, 95);
            this.FlowLayoutPanelToolbars.TabIndex = 2;
            // 
            // ToolStripNameAndSettlementFilter
            // 
            this.ToolStripNameAndSettlementFilter.Dock = DockStyle.Fill;
            this.ToolStripNameAndSettlementFilter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripNameAndSettlementFilter.ImageScalingSize = new Size(20, 20);
            this.ToolStripNameAndSettlementFilter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelNameAndSettlementFilter, this.ToolStripComboBoxNameAndSettlementFilterType, this.ToolStripTextBoxNameAndSettlementFilter, this.ToolStripButtonNameAndSettlementFilterClear });
            this.ToolStripNameAndSettlementFilter.Location = new Point(0, 39);
            this.ToolStripNameAndSettlementFilter.Name = "ToolStripNameAndSettlementFilter";
            this.ToolStripNameAndSettlementFilter.Size = new Size(543, 28);
            this.ToolStripNameAndSettlementFilter.TabIndex = 1;
            // 
            // ToolStripLabelNameAndSettlementFilter
            // 
            this.ToolStripLabelNameAndSettlementFilter.Name = "ToolStripLabelNameAndSettlementFilter";
            this.ToolStripLabelNameAndSettlementFilter.Size = new Size(77, 25);
            this.ToolStripLabelNameAndSettlementFilter.Text = "Filtrar por:";
            // 
            // ToolStripComboBoxNameAndSettlementFilterType
            // 
            this.ToolStripComboBoxNameAndSettlementFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ToolStripComboBoxNameAndSettlementFilterType.Name = "ToolStripComboBoxNameAndSettlementFilterType";
            this.ToolStripComboBoxNameAndSettlementFilterType.Size = new Size(280, 28);
            this.ToolStripComboBoxNameAndSettlementFilterType.SelectedIndexChanged += this.ToolStripComboBoxNameAndSettlementFilterType_SelectedIndexChanged;
            // 
            // ToolStripTextBoxNameAndSettlementFilter
            // 
            this.ToolStripTextBoxNameAndSettlementFilter.MaxLength = 100;
            this.ToolStripTextBoxNameAndSettlementFilter.Name = "ToolStripTextBoxNameAndSettlementFilter";
            this.ToolStripTextBoxNameAndSettlementFilter.Size = new Size(150, 28);
            this.ToolStripTextBoxNameAndSettlementFilter.Enter += this.ToolStripTextBoxNameAndSettlementSearch_Enter;
            this.ToolStripTextBoxNameAndSettlementFilter.KeyPress += this.ToolStripTextBoxNameAndSettlementSearch_KeyPress;
            // 
            // ToolStripButtonNameAndSettlementFilterClear
            // 
            this.ToolStripButtonNameAndSettlementFilterClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonNameAndSettlementFilterClear.Image = Properties.Resources.ImageClose16;
            this.ToolStripButtonNameAndSettlementFilterClear.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonNameAndSettlementFilterClear.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonNameAndSettlementFilterClear.Name = "ToolStripButtonNameAndSettlementFilterClear";
            this.ToolStripButtonNameAndSettlementFilterClear.Size = new Size(29, 25);
            this.ToolStripButtonNameAndSettlementFilterClear.ToolTipText = "Limpiar búsqueda";
            this.ToolStripButtonNameAndSettlementFilterClear.Click += this.ToolStripButtonNameAndSettlementSearchClear_Click;
            // 
            // ToolStripLastEventTypeFilter
            // 
            this.ToolStripLastEventTypeFilter.Dock = DockStyle.Fill;
            this.ToolStripLastEventTypeFilter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripLastEventTypeFilter.ImageScalingSize = new Size(20, 20);
            this.ToolStripLastEventTypeFilter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelLastEventTypeFilter, this.ToolStripComboBoxLastEventTypeFilter });
            this.ToolStripLastEventTypeFilter.Location = new Point(0, 67);
            this.ToolStripLastEventTypeFilter.Name = "ToolStripLastEventTypeFilter";
            this.ToolStripLastEventTypeFilter.Size = new Size(398, 28);
            this.ToolStripLastEventTypeFilter.TabIndex = 3;
            // 
            // ToolStripLabelLastEventTypeFilter
            // 
            this.ToolStripLabelLastEventTypeFilter.Name = "ToolStripLabelLastEventTypeFilter";
            this.ToolStripLabelLastEventTypeFilter.Size = new Size(173, 25);
            this.ToolStripLabelLastEventTypeFilter.Text = "Filtrar por último evento:";
            // 
            // ToolStripComboBoxLastEventTypeFilter
            // 
            this.ToolStripComboBoxLastEventTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ToolStripComboBoxLastEventTypeFilter.Name = "ToolStripComboBoxLastEventTypeFilter";
            this.ToolStripComboBoxLastEventTypeFilter.Size = new Size(220, 28);
            this.ToolStripComboBoxLastEventTypeFilter.SelectedIndexChanged += this.ToolStripComboBoxLastEventTypeFilter_SelectedIndexChanged;
            // 
            // ToolStripItemsCounter
            // 
            this.ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            this.ToolStripItemsCounter.Dock = DockStyle.Fill;
            this.ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripItemsCounter.ImageScalingSize = new Size(20, 20);
            this.ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { this.ToolStripLabelItemsCounter });
            this.ToolStripItemsCounter.Location = new Point(398, 67);
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
            // FormPointsDataAndEvents
            // 
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.ClientSize = new Size(910, 333);
            this.Controls.Add(this.DataGridViewMain);
            this.Controls.Add(this.FlowLayoutPanelToolbars);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPointsDataAndEvents";
            this.Text = "Datos y eventos de los puntos";
            this.FormClosed += this.This_FormClosed;
            this.Load += this.This_Load;
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DataGridViewMain).EndInit();
            this.FlowLayoutPanelToolbars.ResumeLayout(false);
            this.FlowLayoutPanelToolbars.PerformLayout();
            this.ToolStripNameAndSettlementFilter.ResumeLayout(false);
            this.ToolStripNameAndSettlementFilter.PerformLayout();
            this.ToolStripLastEventTypeFilter.ResumeLayout(false);
            this.ToolStripLastEventTypeFilter.PerformLayout();
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
        private ToolStrip ToolStripNameAndSettlementFilter;
        private ToolStripLabel ToolStripLabelNameAndSettlementFilter;
        private ToolStripComboBox ToolStripComboBoxNameAndSettlementFilterType;
        private ToolStripTextBox ToolStripTextBoxNameAndSettlementFilter;
        internal ToolStripButton ToolStripButtonNameAndSettlementFilterClear;
        private ToolStrip ToolStripItemsCounter;
        private ToolStripLabel ToolStripLabelItemsCounter;
        private ToolStrip ToolStripLastEventTypeFilter;
        private ToolStripLabel ToolStripLabelLastEventTypeFilter;
        private ToolStripComboBox ToolStripComboBoxLastEventTypeFilter;
        private DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private DataGridViewTextBoxColumn DataGridViewColumnLatitud;
        private DataGridViewTextBoxColumn DataGridViewColumnLongitud;
        private DataGridViewTextBoxColumn DataGridViewColumnEstablecimiento;
        private DataGridViewTextBoxColumn DataGridViewColumnChapaNumero;
        private DataGridViewTextBoxColumn DataGridViewColumnUltimoEvento;
        private DataGridViewTextBoxColumn DataGridViewColumnFechaHora;
        private ToolStripButton ToolStripButtonPointEvents;
        private ToolStripButton ToolStripButtonPointEventAdd;
        private ToolStripButton ToolStripButtonViewOnMap;
    }
}