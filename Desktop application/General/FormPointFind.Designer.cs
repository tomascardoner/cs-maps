namespace CSMaps.General
{
    partial class FormPointFind
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
            LabelNombre = new Label();
            TextBoxNombre = new TextBox();
            ButtonBuscar = new Button();
            DataGridViewMain = new DataGridView();
            DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            DataGridViewColumnLatitud = new DataGridViewTextBoxColumn();
            DataGridViewColumnLongitud = new DataGridViewTextBoxColumn();
            DataGridViewColumnAltitud = new DataGridViewTextBoxColumn();
            ToolStripMain = new ToolStrip();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSelect = new ToolStripButton();
            ComboBoxTipoBusqueda = new ComboBox();
            TableLayoutPanelMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            ToolStripMain.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Location = new Point(3, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(73, 34);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombres:";
            LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Dock = DockStyle.Fill;
            TextBoxNombre.Location = new Point(238, 3);
            TextBoxNombre.MaxLength = 50;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(318, 27);
            TextBoxNombre.TabIndex = 2;
            TextBoxNombre.Enter += TextBoxNombre_Enter;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Dock = DockStyle.Fill;
            ButtonBuscar.Image = Properties.Resources.ImageSearch16;
            ButtonBuscar.Location = new Point(562, 3);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(27, 28);
            ButtonBuscar.TabIndex = 3;
            ButtonBuscar.UseVisualStyleBackColor = true;
            ButtonBuscar.Click += ButtonBuscarPunto_Click;
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
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnLatitud, DataGridViewColumnLongitud, DataGridViewColumnAltitud });
            TableLayoutPanelMain.SetColumnSpan(DataGridViewMain, 4);
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(3, 37);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(586, 347);
            DataGridViewMain.TabIndex = 4;
            DataGridViewMain.CellDoubleClick += DataGridViewMain_CellDoubleClick;
            // 
            // DataGridViewColumnNombre
            // 
            DataGridViewColumnNombre.DataPropertyName = "Nombre";
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
            // DataGridViewColumnAltitud
            // 
            DataGridViewColumnAltitud.DataPropertyName = "Altitud";
            DataGridViewColumnAltitud.HeaderText = "Altitud";
            DataGridViewColumnAltitud.MinimumWidth = 6;
            DataGridViewColumnAltitud.Name = "DataGridViewColumnAltitud";
            DataGridViewColumnAltitud.ReadOnly = true;
            DataGridViewColumnAltitud.Width = 83;
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonCancel, ToolStripButtonSelect });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(592, 39);
            ToolStripMain.TabIndex = 1;
            // 
            // ToolStripButtonCancel
            // 
            ToolStripButtonCancel.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonCancel.Image = Properties.Resources.ImageCancel32;
            ToolStripButtonCancel.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonCancel.ImageTransparentColor = Color.Magenta;
            ToolStripButtonCancel.Name = "ToolStripButtonCancel";
            ToolStripButtonCancel.Size = new Size(102, 36);
            ToolStripButtonCancel.Text = "Cancelar";
            ToolStripButtonCancel.Click += ToolStripButtonCancel_Click;
            // 
            // ToolStripButtonSelect
            // 
            ToolStripButtonSelect.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonSelect.Image = Properties.Resources.ImageOk32;
            ToolStripButtonSelect.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonSelect.ImageTransparentColor = Color.Magenta;
            ToolStripButtonSelect.Name = "ToolStripButtonSelect";
            ToolStripButtonSelect.Size = new Size(121, 36);
            ToolStripButtonSelect.Text = "Seleccionar";
            ToolStripButtonSelect.Click += ToolStripButtonSelect_Click;
            // 
            // ComboBoxTipoBusqueda
            // 
            ComboBoxTipoBusqueda.Dock = DockStyle.Fill;
            ComboBoxTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTipoBusqueda.FormattingEnabled = true;
            ComboBoxTipoBusqueda.Location = new Point(82, 3);
            ComboBoxTipoBusqueda.Name = "ComboBoxTipoBusqueda";
            ComboBoxTipoBusqueda.Size = new Size(150, 28);
            ComboBoxTipoBusqueda.TabIndex = 1;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.AutoSize = true;
            TableLayoutPanelMain.ColumnCount = 4;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelMain.Controls.Add(LabelNombre, 0, 0);
            TableLayoutPanelMain.Controls.Add(ComboBoxTipoBusqueda, 1, 0);
            TableLayoutPanelMain.Controls.Add(TextBoxNombre, 2, 0);
            TableLayoutPanelMain.Controls.Add(ButtonBuscar, 3, 0);
            TableLayoutPanelMain.Controls.Add(DataGridViewMain, 0, 1);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelMain.Location = new Point(0, 39);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 2;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Size = new Size(592, 387);
            TableLayoutPanelMain.TabIndex = 0;
            // 
            // FormPointFind
            // 
            AcceptButton = ButtonBuscar;
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(592, 426);
            ControlBox = false;
            Controls.Add(TableLayoutPanelMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormPointFind";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar punto";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNombre;
        private TextBox TextBoxNombre;
        private Button ButtonBuscar;
        private DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private DataGridViewTextBoxColumn DataGridViewColumnLatitud;
        private DataGridViewTextBoxColumn DataGridViewColumnLongitud;
        private DataGridViewTextBoxColumn DataGridViewColumnAltitud;
        private ToolStrip ToolStripMain;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSelect;
        private ComboBox ComboBoxTipoBusqueda;
        internal DataGridView DataGridViewMain;
        private TableLayoutPanel TableLayoutPanelMain;
    }
}