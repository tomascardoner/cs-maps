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
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            ToolStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(12, 53);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(59, 15);
            LabelNombre.TabIndex = 1;
            LabelNombre.Text = "Nombres:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(207, 50);
            TextBoxNombre.MaxLength = 50;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(185, 23);
            TextBoxNombre.TabIndex = 2;
            TextBoxNombre.Enter += TextBoxNombre_Enter;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Image = Properties.Resources.ImageSearch32;
            ButtonBuscar.Location = new Point(398, 42);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(36, 36);
            ButtonBuscar.TabIndex = 5;
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
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnLatitud, DataGridViewColumnLongitud, DataGridViewColumnAltitud });
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(12, 92);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(422, 169);
            DataGridViewMain.TabIndex = 3;
            DataGridViewMain.CellDoubleClick += DataGridViewMain_CellDoubleClick;
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
            // DataGridViewColumnAltitud
            // 
            DataGridViewColumnAltitud.DataPropertyName = "Altitud";
            DataGridViewColumnAltitud.HeaderText = "Altitud";
            DataGridViewColumnAltitud.Name = "DataGridViewColumnAltitud";
            DataGridViewColumnAltitud.ReadOnly = true;
            DataGridViewColumnAltitud.Width = 68;
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonCancel, ToolStripButtonSelect });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(446, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonCancel
            // 
            ToolStripButtonCancel.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonCancel.Image = Properties.Resources.ImageCancel32;
            ToolStripButtonCancel.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonCancel.ImageTransparentColor = Color.Magenta;
            ToolStripButtonCancel.Name = "ToolStripButtonCancel";
            ToolStripButtonCancel.Size = new Size(89, 36);
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
            ToolStripButtonSelect.Size = new Size(103, 36);
            ToolStripButtonSelect.Text = "Seleccionar";
            ToolStripButtonSelect.Click += ToolStripButtonSelect_Click;
            // 
            // ComboBoxTipoBusqueda
            // 
            ComboBoxTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTipoBusqueda.FormattingEnabled = true;
            ComboBoxTipoBusqueda.Location = new Point(77, 50);
            ComboBoxTipoBusqueda.Name = "ComboBoxTipoBusqueda";
            ComboBoxTipoBusqueda.Size = new Size(124, 23);
            ComboBoxTipoBusqueda.TabIndex = 4;
            // 
            // FormPointFind
            // 
            AcceptButton = ButtonBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 273);
            ControlBox = false;
            Controls.Add(ComboBoxTipoBusqueda);
            Controls.Add(ToolStripMain);
            Controls.Add(DataGridViewMain);
            Controls.Add(ButtonBuscar);
            Controls.Add(TextBoxNombre);
            Controls.Add(LabelNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormPointFind";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar punto";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
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
    }
}