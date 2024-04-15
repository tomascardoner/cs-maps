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
            PanelPointData = new Panel();
            TextBoxChapaNumero = new TextBox();
            TextBoxEstablecimiento = new TextBox();
            LabelChapaNumero = new Label();
            LabelEstablecimiento = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            FlowLayoutPanelToolbars.SuspendLayout();
            ToolStripDateFilter.SuspendLayout();
            ToolStripEventTypeFilter.SuspendLayout();
            ToolStripItemsCounter.SuspendLayout();
            ToolStripMain.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            PanelPointEvents.SuspendLayout();
            TableLayoutPanelPointEvents.SuspendLayout();
            PanelPointData.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.AllowUserToAddRows = false;
            DataGridViewMain.AllowUserToDeleteRows = false;
            DataGridViewMain.AllowUserToResizeColumns = false;
            DataGridViewMain.AllowUserToResizeRows = false;
            DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnFechaHora, DataGridViewColumnEventoTipo });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(89, 3);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(430, 243);
            DataGridViewMain.TabIndex = 3;
            DataGridViewMain.DoubleClick += ToolStripButtonView_Click;
            // 
            // DataGridViewColumnFechaHora
            // 
            DataGridViewColumnFechaHora.DataPropertyName = "FechaHora";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            DataGridViewColumnFechaHora.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewColumnFechaHora.HeaderText = "Fecha y hora";
            DataGridViewColumnFechaHora.Name = "DataGridViewColumnFechaHora";
            DataGridViewColumnFechaHora.ReadOnly = true;
            DataGridViewColumnFechaHora.Width = 99;
            // 
            // DataGridViewColumnEventoTipo
            // 
            DataGridViewColumnEventoTipo.DataPropertyName = "EventoTipoNombre";
            DataGridViewColumnEventoTipo.HeaderText = "Tipo";
            DataGridViewColumnEventoTipo.Name = "DataGridViewColumnEventoTipo";
            DataGridViewColumnEventoTipo.ReadOnly = true;
            DataGridViewColumnEventoTipo.Width = 55;
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
            FlowLayoutPanelToolbars.Size = new Size(522, 50);
            FlowLayoutPanelToolbars.TabIndex = 4;
            // 
            // ToolStripDateFilter
            // 
            ToolStripDateFilter.Dock = DockStyle.Fill;
            ToolStripDateFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripDateFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelDateFilter, ToolStripComboBoxDateFilterPeriodType, ToolStripComboBoxDateFilterPeriodValue, ToolStripLabelDateFilterAnd });
            ToolStripDateFilter.Location = new Point(0, 0);
            ToolStripDateFilter.Name = "ToolStripDateFilter";
            ToolStripDateFilter.Size = new Size(173, 25);
            ToolStripDateFilter.TabIndex = 1;
            // 
            // ToolStripLabelDateFilter
            // 
            ToolStripLabelDateFilter.Name = "ToolStripLabelDateFilter";
            ToolStripLabelDateFilter.Size = new Size(93, 22);
            ToolStripLabelDateFilter.Text = "Filtrar por fecha:";
            // 
            // ToolStripComboBoxDateFilterPeriodType
            // 
            ToolStripComboBoxDateFilterPeriodType.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxDateFilterPeriodType.DropDownWidth = 75;
            ToolStripComboBoxDateFilterPeriodType.Name = "ToolStripComboBoxDateFilterPeriodType";
            ToolStripComboBoxDateFilterPeriodType.Size = new Size(75, 25);
            ToolStripComboBoxDateFilterPeriodType.SelectedIndexChanged += ToolStripComboBoxDateFilterPeriodType_SelectedIndexChanged;
            // 
            // ToolStripComboBoxDateFilterPeriodValue
            // 
            ToolStripComboBoxDateFilterPeriodValue.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxDateFilterPeriodValue.Name = "ToolStripComboBoxDateFilterPeriodValue";
            ToolStripComboBoxDateFilterPeriodValue.Size = new Size(100, 25);
            ToolStripComboBoxDateFilterPeriodValue.Visible = false;
            ToolStripComboBoxDateFilterPeriodValue.SelectedIndexChanged += ToolStripComboBoxDateFilterPeriodValue_SelectedIndexChanged;
            // 
            // ToolStripLabelDateFilterAnd
            // 
            ToolStripLabelDateFilterAnd.Name = "ToolStripLabelDateFilterAnd";
            ToolStripLabelDateFilterAnd.Size = new Size(13, 22);
            ToolStripLabelDateFilterAnd.Text = "y";
            ToolStripLabelDateFilterAnd.Visible = false;
            // 
            // ToolStripEventTypeFilter
            // 
            ToolStripEventTypeFilter.Dock = DockStyle.Fill;
            ToolStripEventTypeFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripEventTypeFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelEventTypeFilter, ToolStripComboBoxEventTypeFilter });
            ToolStripEventTypeFilter.Location = new Point(0, 25);
            ToolStripEventTypeFilter.Name = "ToolStripEventTypeFilter";
            ToolStripEventTypeFilter.Size = new Size(385, 25);
            ToolStripEventTypeFilter.TabIndex = 3;
            // 
            // ToolStripLabelEventTypeFilter
            // 
            ToolStripLabelEventTypeFilter.Name = "ToolStripLabelEventTypeFilter";
            ToolStripLabelEventTypeFilter.Size = new Size(140, 22);
            ToolStripLabelEventTypeFilter.Text = "Filtrar por tipo de evento:";
            // 
            // ToolStripComboBoxEventTypeFilter
            // 
            ToolStripComboBoxEventTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxEventTypeFilter.Name = "ToolStripComboBoxEventTypeFilter";
            ToolStripComboBoxEventTypeFilter.Size = new Size(240, 25);
            ToolStripComboBoxEventTypeFilter.SelectedIndexChanged += ToolStripComboBoxEventTypeFilter_SelectedIndexChanged;
            // 
            // ToolStripItemsCounter
            // 
            ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            ToolStripItemsCounter.Dock = DockStyle.Fill;
            ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { ToolStripLabelItemsCounter });
            ToolStripItemsCounter.Location = new Point(385, 25);
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
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Fill;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonAdd, ToolStripButtonView, ToolStripButtonEdit, ToolStripButtonDelete });
            ToolStripMain.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(86, 249);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(84, 36);
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
            ToolStripButtonView.Size = new Size(84, 36);
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
            ToolStripButtonEdit.Size = new Size(84, 36);
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
            ToolStripButtonDelete.Size = new Size(84, 36);
            ToolStripButtonDelete.Text = "Borrar";
            ToolStripButtonDelete.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripButtonDelete.Click += ToolStripButtonDelete_Click;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelMain.Controls.Add(PanelPointEvents, 0, 1);
            TableLayoutPanelMain.Controls.Add(PanelPointData, 0, 0);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.Location = new Point(0, 0);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 2;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1570683F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 79.84293F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelMain.Size = new Size(528, 382);
            TableLayoutPanelMain.TabIndex = 5;
            // 
            // PanelPointEvents
            // 
            PanelPointEvents.Controls.Add(TableLayoutPanelPointEvents);
            PanelPointEvents.Controls.Add(FlowLayoutPanelToolbars);
            PanelPointEvents.Dock = DockStyle.Fill;
            PanelPointEvents.Location = new Point(3, 80);
            PanelPointEvents.Name = "PanelPointEvents";
            PanelPointEvents.Size = new Size(522, 299);
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
            TableLayoutPanelPointEvents.Location = new Point(0, 50);
            TableLayoutPanelPointEvents.Name = "TableLayoutPanelPointEvents";
            TableLayoutPanelPointEvents.RowCount = 1;
            TableLayoutPanelPointEvents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelPointEvents.Size = new Size(522, 249);
            TableLayoutPanelPointEvents.TabIndex = 5;
            // 
            // PanelPointData
            // 
            PanelPointData.Controls.Add(TextBoxChapaNumero);
            PanelPointData.Controls.Add(TextBoxEstablecimiento);
            PanelPointData.Controls.Add(LabelChapaNumero);
            PanelPointData.Controls.Add(LabelEstablecimiento);
            PanelPointData.Dock = DockStyle.Fill;
            PanelPointData.Location = new Point(3, 3);
            PanelPointData.Name = "PanelPointData";
            PanelPointData.Size = new Size(522, 71);
            PanelPointData.TabIndex = 7;
            // 
            // TextBoxChapaNumero
            // 
            TextBoxChapaNumero.Location = new Point(109, 38);
            TextBoxChapaNumero.Name = "TextBoxChapaNumero";
            TextBoxChapaNumero.ReadOnly = true;
            TextBoxChapaNumero.Size = new Size(58, 23);
            TextBoxChapaNumero.TabIndex = 11;
            // 
            // TextBoxEstablecimiento
            // 
            TextBoxEstablecimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxEstablecimiento.Location = new Point(109, 9);
            TextBoxEstablecimiento.Name = "TextBoxEstablecimiento";
            TextBoxEstablecimiento.ReadOnly = true;
            TextBoxEstablecimiento.Size = new Size(404, 23);
            TextBoxEstablecimiento.TabIndex = 10;
            // 
            // LabelChapaNumero
            // 
            LabelChapaNumero.AutoSize = true;
            LabelChapaNumero.Location = new Point(9, 41);
            LabelChapaNumero.Name = "LabelChapaNumero";
            LabelChapaNumero.Size = new Size(75, 15);
            LabelChapaNumero.TabIndex = 8;
            LabelChapaNumero.Text = "Nº de chapa:";
            // 
            // LabelEstablecimiento
            // 
            LabelEstablecimiento.AutoSize = true;
            LabelEstablecimiento.Location = new Point(9, 12);
            LabelEstablecimiento.Name = "LabelEstablecimiento";
            LabelEstablecimiento.Size = new Size(94, 15);
            LabelEstablecimiento.TabIndex = 6;
            LabelEstablecimiento.Text = "Establecimiento:";
            // 
            // FormPointEvents
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(528, 382);
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
            PanelPointEvents.ResumeLayout(false);
            PanelPointEvents.PerformLayout();
            TableLayoutPanelPointEvents.ResumeLayout(false);
            TableLayoutPanelPointEvents.PerformLayout();
            PanelPointData.ResumeLayout(false);
            PanelPointData.PerformLayout();
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
        private Panel PanelPointData;
        private TextBox TextBoxEstablecimiento;
        private Label LabelChapaNumero;
        private Label LabelEstablecimiento;
        private TextBox TextBoxChapaNumero;
        private TableLayoutPanel TableLayoutPanelPointEvents;
        internal ToolStripComboBox ToolStripComboBoxDateFilterPeriodType;
        internal ToolStripComboBox ToolStripComboBoxDateFilterPeriodValue;
        internal ToolStripLabel ToolStripLabelDateFilterAnd;
    }
}