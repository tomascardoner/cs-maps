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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ToolStripMain = new ToolStrip();
            ToolStripButtonAdd = new ToolStripButton();
            ToolStripButtonView = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonDelete = new ToolStripButton();
            ToolStripButtonPointEventAdd = new ToolStripButton();
            ToolStripButtonPointEvents = new ToolStripButton();
            DataGridViewMain = new DataGridView();
            DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            DataGridViewColumnLatitud = new DataGridViewTextBoxColumn();
            DataGridViewColumnLongitud = new DataGridViewTextBoxColumn();
            DataGridViewColumnEstablecimiento = new DataGridViewTextBoxColumn();
            DataGridViewColumnChapaNumero = new DataGridViewTextBoxColumn();
            DataGridViewColumnUltimoEvento = new DataGridViewTextBoxColumn();
            DataGridViewColumnFechaHora = new DataGridViewTextBoxColumn();
            FlowLayoutPanelToolbars = new FlowLayoutPanel();
            ToolStripNameAndSettlementFilter = new ToolStrip();
            ToolStripLabelNameAndSettlementFilter = new ToolStripLabel();
            ToolStripComboBoxNameAndSettlementFilterType = new ToolStripComboBox();
            ToolStripTextBoxNameAndSettlementFilter = new ToolStripTextBox();
            ToolStripButtonNameAndSettlementFilterClear = new ToolStripButton();
            ToolStripLastEventTypeFilter = new ToolStrip();
            ToolStripLabelLastEventTypeFilter = new ToolStripLabel();
            ToolStripComboBoxLastEventTypeFilter = new ToolStripComboBox();
            ToolStripItemsCounter = new ToolStrip();
            ToolStripLabelItemsCounter = new ToolStripLabel();
            ToolStripButtonViewOnMap = new ToolStripButton();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            FlowLayoutPanelToolbars.SuspendLayout();
            ToolStripNameAndSettlementFilter.SuspendLayout();
            ToolStripLastEventTypeFilter.SuspendLayout();
            ToolStripItemsCounter.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Fill;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonAdd, ToolStripButtonView, ToolStripButtonViewOnMap, ToolStripButtonEdit, ToolStripButtonDelete, ToolStripButtonPointEventAdd, ToolStripButtonPointEvents });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(749, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(99, 36);
            ToolStripButtonAdd.Text = "Agregar";
            ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
            // 
            // ToolStripButtonView
            // 
            ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            ToolStripButtonView.Name = "ToolStripButtonView";
            ToolStripButtonView.Size = new Size(66, 36);
            ToolStripButtonView.Text = "Ver";
            ToolStripButtonView.Click += ToolStripButtonView_Click;
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(84, 36);
            ToolStripButtonEdit.Text = "Editar";
            ToolStripButtonEdit.Click += ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonDelete
            // 
            ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            ToolStripButtonDelete.Size = new Size(86, 36);
            ToolStripButtonDelete.Text = "Borrar";
            ToolStripButtonDelete.Click += ToolStripButtonDelete_Click;
            // 
            // ToolStripButtonPointEventAdd
            // 
            ToolStripButtonPointEventAdd.Image = Properties.Resources.ImagePuntoEventoAdd32;
            ToolStripButtonPointEventAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonPointEventAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonPointEventAdd.Name = "ToolStripButtonPointEventAdd";
            ToolStripButtonPointEventAdd.Size = new Size(148, 36);
            ToolStripButtonPointEventAdd.Text = "Agregar evento";
            ToolStripButtonPointEventAdd.Click += ToolStripButtonPointEventAdd_Click;
            // 
            // ToolStripButtonPointEvents
            // 
            ToolStripButtonPointEvents.Image = Properties.Resources.ImagePuntoEvento32;
            ToolStripButtonPointEvents.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonPointEvents.ImageTransparentColor = Color.Magenta;
            ToolStripButtonPointEvents.Name = "ToolStripButtonPointEvents";
            ToolStripButtonPointEvents.Size = new Size(96, 36);
            ToolStripButtonPointEvents.Text = "Eventos";
            ToolStripButtonPointEvents.Click += ToolStripButtonPointEvents_Click;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.AllowUserToAddRows = false;
            DataGridViewMain.AllowUserToDeleteRows = false;
            DataGridViewMain.AllowUserToResizeColumns = false;
            DataGridViewMain.AllowUserToResizeRows = false;
            DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewMain.ColumnHeadersHeight = 29;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnLatitud, DataGridViewColumnLongitud, DataGridViewColumnEstablecimiento, DataGridViewColumnChapaNumero, DataGridViewColumnUltimoEvento, DataGridViewColumnFechaHora });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(0, 95);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(910, 238);
            DataGridViewMain.TabIndex = 1;
            DataGridViewMain.CellDoubleClick += ToolStripButtonView_Click;
            DataGridViewMain.ColumnHeaderMouseClick += DataGridViewMain_ColumnHeaderMouseClick;
            // 
            // DataGridViewColumnNombre
            // 
            DataGridViewColumnNombre.DataPropertyName = "PuntoNombre";
            DataGridViewColumnNombre.HeaderText = "Nombre";
            DataGridViewColumnNombre.MinimumWidth = 6;
            DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            DataGridViewColumnNombre.ReadOnly = true;
            DataGridViewColumnNombre.Width = 93;
            // 
            // DataGridViewColumnLatitud
            // 
            DataGridViewColumnLatitud.DataPropertyName = "Latitud";
            DataGridViewColumnLatitud.HeaderText = "Latitud";
            DataGridViewColumnLatitud.MinimumWidth = 6;
            DataGridViewColumnLatitud.Name = "DataGridViewColumnLatitud";
            DataGridViewColumnLatitud.ReadOnly = true;
            DataGridViewColumnLatitud.Width = 84;
            // 
            // DataGridViewColumnLongitud
            // 
            DataGridViewColumnLongitud.DataPropertyName = "Longitud";
            DataGridViewColumnLongitud.HeaderText = "Longitud";
            DataGridViewColumnLongitud.MinimumWidth = 6;
            DataGridViewColumnLongitud.Name = "DataGridViewColumnLongitud";
            DataGridViewColumnLongitud.ReadOnly = true;
            DataGridViewColumnLongitud.Width = 97;
            // 
            // DataGridViewColumnEstablecimiento
            // 
            DataGridViewColumnEstablecimiento.DataPropertyName = "EstablecimientoNombre";
            DataGridViewColumnEstablecimiento.HeaderText = "Establecimiento";
            DataGridViewColumnEstablecimiento.MinimumWidth = 6;
            DataGridViewColumnEstablecimiento.Name = "DataGridViewColumnEstablecimiento";
            DataGridViewColumnEstablecimiento.ReadOnly = true;
            DataGridViewColumnEstablecimiento.Width = 144;
            // 
            // DataGridViewColumnChapaNumero
            // 
            DataGridViewColumnChapaNumero.DataPropertyName = "ChapaNumero";
            DataGridViewColumnChapaNumero.HeaderText = "Chapa nº";
            DataGridViewColumnChapaNumero.MinimumWidth = 6;
            DataGridViewColumnChapaNumero.Name = "DataGridViewColumnChapaNumero";
            DataGridViewColumnChapaNumero.ReadOnly = true;
            DataGridViewColumnChapaNumero.Width = 98;
            // 
            // DataGridViewColumnUltimoEvento
            // 
            DataGridViewColumnUltimoEvento.DataPropertyName = "EventoTipoNombre";
            DataGridViewColumnUltimoEvento.HeaderText = "Último evento";
            DataGridViewColumnUltimoEvento.MinimumWidth = 6;
            DataGridViewColumnUltimoEvento.Name = "DataGridViewColumnUltimoEvento";
            DataGridViewColumnUltimoEvento.ReadOnly = true;
            DataGridViewColumnUltimoEvento.Width = 132;
            // 
            // DataGridViewColumnFechaHora
            // 
            DataGridViewColumnFechaHora.DataPropertyName = "FechaHora";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            DataGridViewColumnFechaHora.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewColumnFechaHora.HeaderText = "Fecha y hora";
            DataGridViewColumnFechaHora.MinimumWidth = 6;
            DataGridViewColumnFechaHora.Name = "DataGridViewColumnFechaHora";
            DataGridViewColumnFechaHora.ReadOnly = true;
            DataGridViewColumnFechaHora.Width = 121;
            // 
            // FlowLayoutPanelToolbars
            // 
            FlowLayoutPanelToolbars.AutoSize = true;
            FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanelToolbars.Controls.Add(ToolStripMain);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripNameAndSettlementFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripLastEventTypeFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripItemsCounter);
            FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            FlowLayoutPanelToolbars.Location = new Point(0, 0);
            FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            FlowLayoutPanelToolbars.Size = new Size(910, 95);
            FlowLayoutPanelToolbars.TabIndex = 2;
            // 
            // ToolStripNameAndSettlementFilter
            // 
            ToolStripNameAndSettlementFilter.Dock = DockStyle.Fill;
            ToolStripNameAndSettlementFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripNameAndSettlementFilter.ImageScalingSize = new Size(20, 20);
            ToolStripNameAndSettlementFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelNameAndSettlementFilter, ToolStripComboBoxNameAndSettlementFilterType, ToolStripTextBoxNameAndSettlementFilter, ToolStripButtonNameAndSettlementFilterClear });
            ToolStripNameAndSettlementFilter.Location = new Point(0, 39);
            ToolStripNameAndSettlementFilter.Name = "ToolStripNameAndSettlementFilter";
            ToolStripNameAndSettlementFilter.Size = new Size(543, 28);
            ToolStripNameAndSettlementFilter.TabIndex = 1;
            // 
            // ToolStripLabelNameAndSettlementFilter
            // 
            ToolStripLabelNameAndSettlementFilter.Name = "ToolStripLabelNameAndSettlementFilter";
            ToolStripLabelNameAndSettlementFilter.Size = new Size(77, 25);
            ToolStripLabelNameAndSettlementFilter.Text = "Filtrar por:";
            // 
            // ToolStripComboBoxNameAndSettlementFilterType
            // 
            ToolStripComboBoxNameAndSettlementFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxNameAndSettlementFilterType.Name = "ToolStripComboBoxNameAndSettlementFilterType";
            ToolStripComboBoxNameAndSettlementFilterType.Size = new Size(280, 28);
            ToolStripComboBoxNameAndSettlementFilterType.SelectedIndexChanged += ToolStripComboBoxNameAndSettlementFilterType_SelectedIndexChanged;
            // 
            // ToolStripTextBoxNameAndSettlementFilter
            // 
            ToolStripTextBoxNameAndSettlementFilter.MaxLength = 100;
            ToolStripTextBoxNameAndSettlementFilter.Name = "ToolStripTextBoxNameAndSettlementFilter";
            ToolStripTextBoxNameAndSettlementFilter.Size = new Size(150, 28);
            ToolStripTextBoxNameAndSettlementFilter.Enter += ToolStripTextBoxNameAndSettlementSearch_Enter;
            ToolStripTextBoxNameAndSettlementFilter.KeyPress += ToolStripTextBoxNameAndSettlementSearch_KeyPress;
            // 
            // ToolStripButtonNameAndSettlementFilterClear
            // 
            ToolStripButtonNameAndSettlementFilterClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonNameAndSettlementFilterClear.Image = Properties.Resources.ImageClose16;
            ToolStripButtonNameAndSettlementFilterClear.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonNameAndSettlementFilterClear.ImageTransparentColor = Color.Magenta;
            ToolStripButtonNameAndSettlementFilterClear.Name = "ToolStripButtonNameAndSettlementFilterClear";
            ToolStripButtonNameAndSettlementFilterClear.Size = new Size(29, 25);
            ToolStripButtonNameAndSettlementFilterClear.ToolTipText = "Limpiar búsqueda";
            ToolStripButtonNameAndSettlementFilterClear.Click += ToolStripButtonNameAndSettlementSearchClear_Click;
            // 
            // ToolStripLastEventTypeFilter
            // 
            ToolStripLastEventTypeFilter.Dock = DockStyle.Fill;
            ToolStripLastEventTypeFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripLastEventTypeFilter.ImageScalingSize = new Size(20, 20);
            ToolStripLastEventTypeFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelLastEventTypeFilter, ToolStripComboBoxLastEventTypeFilter });
            ToolStripLastEventTypeFilter.Location = new Point(0, 67);
            ToolStripLastEventTypeFilter.Name = "ToolStripLastEventTypeFilter";
            ToolStripLastEventTypeFilter.Size = new Size(398, 28);
            ToolStripLastEventTypeFilter.TabIndex = 3;
            // 
            // ToolStripLabelLastEventTypeFilter
            // 
            ToolStripLabelLastEventTypeFilter.Name = "ToolStripLabelLastEventTypeFilter";
            ToolStripLabelLastEventTypeFilter.Size = new Size(173, 25);
            ToolStripLabelLastEventTypeFilter.Text = "Filtrar por último evento:";
            // 
            // ToolStripComboBoxLastEventTypeFilter
            // 
            ToolStripComboBoxLastEventTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxLastEventTypeFilter.Name = "ToolStripComboBoxLastEventTypeFilter";
            ToolStripComboBoxLastEventTypeFilter.Size = new Size(220, 28);
            ToolStripComboBoxLastEventTypeFilter.SelectedIndexChanged += ToolStripComboBoxLastEventTypeFilter_SelectedIndexChanged;
            // 
            // ToolStripItemsCounter
            // 
            ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            ToolStripItemsCounter.Dock = DockStyle.Fill;
            ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItemsCounter.ImageScalingSize = new Size(20, 20);
            ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { ToolStripLabelItemsCounter });
            ToolStripItemsCounter.Location = new Point(398, 67);
            ToolStripItemsCounter.Name = "ToolStripItemsCounter";
            ToolStripItemsCounter.Size = new Size(3, 28);
            ToolStripItemsCounter.TabIndex = 2;
            // 
            // ToolStripLabelItemsCounter
            // 
            ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            ToolStripLabelItemsCounter.Size = new Size(0, 25);
            // 
            // ToolStripButtonViewOnMap
            // 
            ToolStripButtonViewOnMap.Image = Properties.Resources.ImagePunto32;
            ToolStripButtonViewOnMap.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonViewOnMap.ImageTransparentColor = Color.Magenta;
            ToolStripButtonViewOnMap.Name = "ToolStripButtonViewOnMap";
            ToolStripButtonViewOnMap.Size = new Size(128, 36);
            ToolStripButtonViewOnMap.Text = "Ver en mapa";
            ToolStripButtonViewOnMap.Click += ToolStripButtonViewOnMap_Click;
            // 
            // FormPointsDataAndEvents
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(910, 333);
            Controls.Add(DataGridViewMain);
            Controls.Add(FlowLayoutPanelToolbars);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPointsDataAndEvents";
            Text = "Datos y eventos de los puntos";
            FormClosed += This_FormClosed;
            Load += This_Load;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            FlowLayoutPanelToolbars.ResumeLayout(false);
            FlowLayoutPanelToolbars.PerformLayout();
            ToolStripNameAndSettlementFilter.ResumeLayout(false);
            ToolStripNameAndSettlementFilter.PerformLayout();
            ToolStripLastEventTypeFilter.ResumeLayout(false);
            ToolStripLastEventTypeFilter.PerformLayout();
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