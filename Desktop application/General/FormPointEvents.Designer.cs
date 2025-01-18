namespace CSMaps.General
{
    partial class FormPointEvents
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
            DataGridViewMain = new DataGridView();
            DataGridViewColumnFechaHora = new DataGridViewTextBoxColumn();
            DataGridViewColumnEventoTipo = new DataGridViewTextBoxColumn();
            FlowLayoutPanelToolbars = new FlowLayoutPanel();
            ToolStripDateFilter = new ToolStrip();
            ToolStripLabelDateFilter = new ToolStripLabel();
            ToolStripComboBoxDateFilterPeriodType = new ToolStripComboBox();
            ToolStripComboBoxDateFilterPeriodValue = new ToolStripComboBox();
            ToolStripLabelDateFilterAnd = new ToolStripLabel();
            ToolStripEventTypeFilter = new ToolStrip();
            ToolStripLabelEventTypeFilter = new ToolStripLabel();
            ToolStripComboBoxEventTypeFilter = new ToolStripComboBox();
            ToolStripItemsCounter = new ToolStrip();
            ToolStripLabelItemsCounter = new ToolStripLabel();
            ToolStripMain = new ToolStrip();
            ToolStripButtonAdd = new ToolStripButton();
            ToolStripButtonView = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonDelete = new ToolStripButton();
            TableLayoutPanelMain = new TableLayoutPanel();
            PanelPointEvents = new Panel();
            TableLayoutPanelPointEvents = new TableLayoutPanel();
            TableLayoutPanelEstablecimiento = new TableLayoutPanel();
            LabelEstablecimiento = new Label();
            TextBoxEstablecimiento = new TextBox();
            LabelChapaNumero = new Label();
            TextBoxChapaNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            FlowLayoutPanelToolbars.SuspendLayout();
            ToolStripDateFilter.SuspendLayout();
            ToolStripEventTypeFilter.SuspendLayout();
            ToolStripItemsCounter.SuspendLayout();
            ToolStripMain.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            PanelPointEvents.SuspendLayout();
            TableLayoutPanelPointEvents.SuspendLayout();
            TableLayoutPanelEstablecimiento.SuspendLayout();
            SuspendLayout();
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
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnFechaHora, DataGridViewColumnEventoTipo });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(103, 3);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(508, 326);
            DataGridViewMain.TabIndex = 3;
            DataGridViewMain.ColumnHeaderMouseClick += DataGridViewMain_ColumnHeaderMouseClick;
            DataGridViewMain.DoubleClick += ToolStripButtonView_Click;
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
            // DataGridViewColumnEventoTipo
            // 
            DataGridViewColumnEventoTipo.DataPropertyName = "EventoTipoNombre";
            DataGridViewColumnEventoTipo.HeaderText = "Tipo";
            DataGridViewColumnEventoTipo.MinimumWidth = 6;
            DataGridViewColumnEventoTipo.Name = "DataGridViewColumnEventoTipo";
            DataGridViewColumnEventoTipo.ReadOnly = true;
            DataGridViewColumnEventoTipo.Width = 68;
            // 
            // FlowLayoutPanelToolbars
            // 
            FlowLayoutPanelToolbars.AutoSize = true;
            FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanelToolbars.Controls.Add(ToolStripDateFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripEventTypeFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripItemsCounter);
            FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            FlowLayoutPanelToolbars.Location = new Point(0, 0);
            FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            FlowLayoutPanelToolbars.Size = new Size(614, 56);
            FlowLayoutPanelToolbars.TabIndex = 4;
            // 
            // ToolStripDateFilter
            // 
            ToolStripDateFilter.Dock = DockStyle.Fill;
            ToolStripDateFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripDateFilter.ImageScalingSize = new Size(20, 20);
            ToolStripDateFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelDateFilter, ToolStripComboBoxDateFilterPeriodType, ToolStripComboBoxDateFilterPeriodValue, ToolStripLabelDateFilterAnd });
            ToolStripDateFilter.Location = new Point(0, 0);
            ToolStripDateFilter.Name = "ToolStripDateFilter";
            ToolStripDateFilter.Size = new Size(197, 28);
            ToolStripDateFilter.TabIndex = 1;
            // 
            // ToolStripLabelDateFilter
            // 
            ToolStripLabelDateFilter.Name = "ToolStripLabelDateFilter";
            ToolStripLabelDateFilter.Size = new Size(117, 25);
            ToolStripLabelDateFilter.Text = "Filtrar por fecha:";
            // 
            // ToolStripComboBoxDateFilterPeriodType
            // 
            ToolStripComboBoxDateFilterPeriodType.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxDateFilterPeriodType.DropDownWidth = 75;
            ToolStripComboBoxDateFilterPeriodType.Name = "ToolStripComboBoxDateFilterPeriodType";
            ToolStripComboBoxDateFilterPeriodType.Size = new Size(75, 28);
            ToolStripComboBoxDateFilterPeriodType.SelectedIndexChanged += ToolStripComboBoxDateFilterPeriodType_SelectedIndexChanged;
            // 
            // ToolStripComboBoxDateFilterPeriodValue
            // 
            ToolStripComboBoxDateFilterPeriodValue.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxDateFilterPeriodValue.Name = "ToolStripComboBoxDateFilterPeriodValue";
            ToolStripComboBoxDateFilterPeriodValue.Size = new Size(100, 28);
            ToolStripComboBoxDateFilterPeriodValue.Visible = false;
            ToolStripComboBoxDateFilterPeriodValue.SelectedIndexChanged += ToolStripComboBoxDateFilterPeriodValue_SelectedIndexChanged;
            // 
            // ToolStripLabelDateFilterAnd
            // 
            ToolStripLabelDateFilterAnd.Name = "ToolStripLabelDateFilterAnd";
            ToolStripLabelDateFilterAnd.Size = new Size(16, 25);
            ToolStripLabelDateFilterAnd.Text = "y";
            ToolStripLabelDateFilterAnd.Visible = false;
            // 
            // ToolStripEventTypeFilter
            // 
            ToolStripEventTypeFilter.Dock = DockStyle.Fill;
            ToolStripEventTypeFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripEventTypeFilter.ImageScalingSize = new Size(20, 20);
            ToolStripEventTypeFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelEventTypeFilter, ToolStripComboBoxEventTypeFilter });
            ToolStripEventTypeFilter.Location = new Point(0, 28);
            ToolStripEventTypeFilter.Name = "ToolStripEventTypeFilter";
            ToolStripEventTypeFilter.Size = new Size(423, 28);
            ToolStripEventTypeFilter.TabIndex = 3;
            // 
            // ToolStripLabelEventTypeFilter
            // 
            ToolStripLabelEventTypeFilter.Name = "ToolStripLabelEventTypeFilter";
            ToolStripLabelEventTypeFilter.Size = new Size(178, 25);
            ToolStripLabelEventTypeFilter.Text = "Filtrar por tipo de evento:";
            // 
            // ToolStripComboBoxEventTypeFilter
            // 
            ToolStripComboBoxEventTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxEventTypeFilter.Name = "ToolStripComboBoxEventTypeFilter";
            ToolStripComboBoxEventTypeFilter.Size = new Size(240, 28);
            ToolStripComboBoxEventTypeFilter.SelectedIndexChanged += ToolStripComboBoxEventTypeFilter_SelectedIndexChanged;
            // 
            // ToolStripItemsCounter
            // 
            ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            ToolStripItemsCounter.Dock = DockStyle.Fill;
            ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItemsCounter.ImageScalingSize = new Size(20, 20);
            ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { ToolStripLabelItemsCounter });
            ToolStripItemsCounter.Location = new Point(423, 28);
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
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Fill;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonAdd, ToolStripButtonView, ToolStripButtonEdit, ToolStripButtonDelete });
            ToolStripMain.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(100, 332);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(98, 36);
            ToolStripButtonAdd.Text = "Agregar";
            ToolStripButtonAdd.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
            // 
            // ToolStripButtonView
            // 
            ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            ToolStripButtonView.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            ToolStripButtonView.Name = "ToolStripButtonView";
            ToolStripButtonView.Size = new Size(98, 36);
            ToolStripButtonView.Text = "Ver";
            ToolStripButtonView.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonView.Click += ToolStripButtonView_Click;
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(98, 36);
            ToolStripButtonEdit.Text = "Editar";
            ToolStripButtonEdit.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonEdit.Click += ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonDelete
            // 
            ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            ToolStripButtonDelete.Size = new Size(98, 36);
            ToolStripButtonDelete.Text = "Borrar";
            ToolStripButtonDelete.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonDelete.Click += ToolStripButtonDelete_Click;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(PanelPointEvents, 0, 1);
            TableLayoutPanelMain.Controls.Add(TableLayoutPanelEstablecimiento, 0, 0);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.Location = new Point(0, 0);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 2;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.Size = new Size(620, 466);
            TableLayoutPanelMain.TabIndex = 5;
            // 
            // PanelPointEvents
            // 
            PanelPointEvents.Controls.Add(TableLayoutPanelPointEvents);
            PanelPointEvents.Controls.Add(FlowLayoutPanelToolbars);
            PanelPointEvents.Dock = DockStyle.Fill;
            PanelPointEvents.Location = new Point(3, 75);
            PanelPointEvents.Name = "PanelPointEvents";
            PanelPointEvents.Size = new Size(614, 388);
            PanelPointEvents.TabIndex = 6;
            // 
            // TableLayoutPanelPointEvents
            // 
            TableLayoutPanelPointEvents.ColumnCount = 2;
            TableLayoutPanelPointEvents.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelPointEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelPointEvents.Controls.Add(ToolStripMain, 0, 0);
            TableLayoutPanelPointEvents.Controls.Add(DataGridViewMain, 1, 0);
            TableLayoutPanelPointEvents.Dock = DockStyle.Fill;
            TableLayoutPanelPointEvents.Location = new Point(0, 56);
            TableLayoutPanelPointEvents.Name = "TableLayoutPanelPointEvents";
            TableLayoutPanelPointEvents.RowCount = 1;
            TableLayoutPanelPointEvents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelPointEvents.Size = new Size(614, 332);
            TableLayoutPanelPointEvents.TabIndex = 5;
            // 
            // TableLayoutPanelEstablecimiento
            // 
            TableLayoutPanelEstablecimiento.AutoSize = true;
            TableLayoutPanelEstablecimiento.ColumnCount = 2;
            TableLayoutPanelEstablecimiento.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelEstablecimiento.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelEstablecimiento.Controls.Add(LabelEstablecimiento, 0, 0);
            TableLayoutPanelEstablecimiento.Controls.Add(TextBoxEstablecimiento, 1, 0);
            TableLayoutPanelEstablecimiento.Controls.Add(LabelChapaNumero, 0, 1);
            TableLayoutPanelEstablecimiento.Controls.Add(TextBoxChapaNumero, 1, 1);
            TableLayoutPanelEstablecimiento.Dock = DockStyle.Fill;
            TableLayoutPanelEstablecimiento.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelEstablecimiento.Location = new Point(3, 3);
            TableLayoutPanelEstablecimiento.Name = "TableLayoutPanelEstablecimiento";
            TableLayoutPanelEstablecimiento.RowCount = 2;
            TableLayoutPanelEstablecimiento.RowStyles.Add(new RowStyle());
            TableLayoutPanelEstablecimiento.RowStyles.Add(new RowStyle());
            TableLayoutPanelEstablecimiento.Size = new Size(614, 66);
            TableLayoutPanelEstablecimiento.TabIndex = 6;
            // 
            // LabelEstablecimiento
            // 
            LabelEstablecimiento.Dock = DockStyle.Fill;
            LabelEstablecimiento.Location = new Point(3, 0);
            LabelEstablecimiento.Name = "LabelEstablecimiento";
            LabelEstablecimiento.Size = new Size(118, 33);
            LabelEstablecimiento.TabIndex = 6;
            LabelEstablecimiento.Text = "Establecimiento:";
            LabelEstablecimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxEstablecimiento
            // 
            TextBoxEstablecimiento.Dock = DockStyle.Fill;
            TextBoxEstablecimiento.Location = new Point(127, 3);
            TextBoxEstablecimiento.Name = "TextBoxEstablecimiento";
            TextBoxEstablecimiento.ReadOnly = true;
            TextBoxEstablecimiento.Size = new Size(484, 27);
            TextBoxEstablecimiento.TabIndex = 10;
            // 
            // LabelChapaNumero
            // 
            LabelChapaNumero.Dock = DockStyle.Fill;
            LabelChapaNumero.Location = new Point(3, 33);
            LabelChapaNumero.Name = "LabelChapaNumero";
            LabelChapaNumero.Size = new Size(118, 33);
            LabelChapaNumero.TabIndex = 8;
            LabelChapaNumero.Text = "Nº de chapa:";
            LabelChapaNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxChapaNumero
            // 
            TextBoxChapaNumero.Location = new Point(127, 36);
            TextBoxChapaNumero.Name = "TextBoxChapaNumero";
            TextBoxChapaNumero.ReadOnly = true;
            TextBoxChapaNumero.Size = new Size(58, 27);
            TextBoxChapaNumero.TabIndex = 11;
            // 
            // FormPointEvents
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(620, 466);
            Controls.Add(TableLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPointEvents";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Eventos del punto";
            FormClosed += This_FormClosed;
            Load += This_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            FlowLayoutPanelToolbars.ResumeLayout(false);
            FlowLayoutPanelToolbars.PerformLayout();
            ToolStripDateFilter.ResumeLayout(false);
            ToolStripDateFilter.PerformLayout();
            ToolStripEventTypeFilter.ResumeLayout(false);
            ToolStripEventTypeFilter.PerformLayout();
            ToolStripItemsCounter.ResumeLayout(false);
            ToolStripItemsCounter.PerformLayout();
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            PanelPointEvents.ResumeLayout(false);
            PanelPointEvents.PerformLayout();
            TableLayoutPanelPointEvents.ResumeLayout(false);
            TableLayoutPanelPointEvents.PerformLayout();
            TableLayoutPanelEstablecimiento.ResumeLayout(false);
            TableLayoutPanelEstablecimiento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewMain;
        private DataGridViewTextBoxColumn DataGridViewColumnFechaHora;
        private DataGridViewTextBoxColumn DataGridViewColumnEventoTipo;
        private FlowLayoutPanel FlowLayoutPanelToolbars;
        private ToolStrip ToolStripMain;
        private ToolStripButton ToolStripButtonAdd;
        private ToolStripButton ToolStripButtonView;
        private ToolStripButton ToolStripButtonEdit;
        private ToolStripButton ToolStripButtonDelete;
        private ToolStrip ToolStripDateFilter;
        private ToolStripLabel ToolStripLabelDateFilter;
        private ToolStrip ToolStripEventTypeFilter;
        private ToolStripLabel ToolStripLabelEventTypeFilter;
        private ToolStripComboBox ToolStripComboBoxEventTypeFilter;
        private ToolStrip ToolStripItemsCounter;
        private ToolStripLabel ToolStripLabelItemsCounter;
        private TableLayoutPanel TableLayoutPanelMain;
        private Panel PanelPointEvents;
        private TextBox TextBoxEstablecimiento;
        private Label LabelChapaNumero;
        private Label LabelEstablecimiento;
        private TextBox TextBoxChapaNumero;
        private TableLayoutPanel TableLayoutPanelPointEvents;
        internal ToolStripComboBox ToolStripComboBoxDateFilterPeriodType;
        internal ToolStripComboBox ToolStripComboBoxDateFilterPeriodValue;
        internal ToolStripLabel ToolStripLabelDateFilterAnd;
        private TableLayoutPanel TableLayoutPanelEstablecimiento;
    }
}