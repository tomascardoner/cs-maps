namespace CSMaps.General
{
    partial class FormPointEvent
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
            Label LabelCreacion;
            Label LabelModificacion;
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            LabelEventoTipo = new Label();
            ComboBoxEventoTipo = new ComboBox();
            LabelFechaHora = new Label();
            DateTimePickerFecha = new DateTimePicker();
            DateTimePickerHora = new DateTimePicker();
            TabControlMain = new TabControl();
            TabPageGeneral = new TabPage();
            TableLayoutPanelGeneral = new TableLayoutPanel();
            TextBoxNotas = new TextBox();
            LabelNotas = new Label();
            TabPageAuditoria = new TabPage();
            TableLayoutPanelAuditoria = new TableLayoutPanel();
            LabelId = new Label();
            TextBoxId = new TextBox();
            TextBoxFechaHoraCreacion = new TextBox();
            TextBoxUsuarioCreacion = new TextBox();
            TextBoxFechaHoraUltimaModificacion = new TextBox();
            TextBoxUsuarioUltimaModificacion = new TextBox();
            LabelCreacion = new Label();
            LabelModificacion = new Label();
            ToolStripMain.SuspendLayout();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TableLayoutPanelGeneral.SuspendLayout();
            TabPageAuditoria.SuspendLayout();
            TableLayoutPanelAuditoria.SuspendLayout();
            SuspendLayout();
            // 
            // LabelCreacion
            // 
            LabelCreacion.AutoSize = true;
            LabelCreacion.Dock = DockStyle.Fill;
            LabelCreacion.Location = new Point(4, 33);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(147, 33);
            LabelCreacion.TabIndex = 2;
            LabelCreacion.Text = "Creación:";
            LabelCreacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelModificacion
            // 
            LabelModificacion.AutoSize = true;
            LabelModificacion.Dock = DockStyle.Fill;
            LabelModificacion.Location = new Point(4, 66);
            LabelModificacion.Margin = new Padding(4, 0, 4, 0);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new Size(147, 33);
            LabelModificacion.TabIndex = 5;
            LabelModificacion.Text = "Última modificación:";
            LabelModificacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonClose, ToolStripButtonEdit, ToolStripButtonCancel, ToolStripButtonSave });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(619, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonClose
            // 
            ToolStripButtonClose.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonClose.Image = Properties.Resources.ImageClose32;
            ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            ToolStripButtonClose.Name = "ToolStripButtonClose";
            ToolStripButtonClose.Size = new Size(85, 36);
            ToolStripButtonClose.Text = "Cerrar";
            ToolStripButtonClose.Click += ToolStripButtonClose_Click;
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(84, 36);
            ToolStripButtonEdit.Text = "Editar";
            ToolStripButtonEdit.Click += ToolStripButtonEdit_Click;
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
            // ToolStripButtonSave
            // 
            ToolStripButtonSave.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonSave.Image = Properties.Resources.ImageOk32;
            ToolStripButtonSave.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonSave.ImageTransparentColor = Color.Magenta;
            ToolStripButtonSave.Name = "ToolStripButtonSave";
            ToolStripButtonSave.Size = new Size(98, 36);
            ToolStripButtonSave.Text = "Guardar";
            ToolStripButtonSave.Click += ToolStripButtonSave_Click;
            // 
            // LabelEventoTipo
            // 
            LabelEventoTipo.AutoSize = true;
            LabelEventoTipo.Dock = DockStyle.Fill;
            LabelEventoTipo.Location = new Point(3, 0);
            LabelEventoTipo.Name = "LabelEventoTipo";
            LabelEventoTipo.Size = new Size(86, 34);
            LabelEventoTipo.TabIndex = 0;
            LabelEventoTipo.Text = "Tipo:";
            LabelEventoTipo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComboBoxEventoTipo
            // 
            TableLayoutPanelGeneral.SetColumnSpan(ComboBoxEventoTipo, 2);
            ComboBoxEventoTipo.Dock = DockStyle.Fill;
            ComboBoxEventoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEventoTipo.FormattingEnabled = true;
            ComboBoxEventoTipo.Location = new Point(95, 3);
            ComboBoxEventoTipo.Name = "ComboBoxEventoTipo";
            ComboBoxEventoTipo.Size = new Size(507, 28);
            ComboBoxEventoTipo.TabIndex = 1;
            // 
            // LabelFechaHora
            // 
            LabelFechaHora.AutoSize = true;
            LabelFechaHora.Dock = DockStyle.Fill;
            LabelFechaHora.Location = new Point(3, 34);
            LabelFechaHora.Name = "LabelFechaHora";
            LabelFechaHora.Size = new Size(86, 33);
            LabelFechaHora.TabIndex = 2;
            LabelFechaHora.Text = "Fecha-hora:";
            LabelFechaHora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Format = DateTimePickerFormat.Short;
            DateTimePickerFecha.Location = new Point(95, 37);
            DateTimePickerFecha.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            DateTimePickerFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(126, 27);
            DateTimePickerFecha.TabIndex = 3;
            // 
            // DateTimePickerHora
            // 
            DateTimePickerHora.Format = DateTimePickerFormat.Time;
            DateTimePickerHora.Location = new Point(227, 37);
            DateTimePickerHora.Name = "DateTimePickerHora";
            DateTimePickerHora.ShowUpDown = true;
            DateTimePickerHora.Size = new Size(87, 27);
            DateTimePickerHora.TabIndex = 4;
            // 
            // TabControlMain
            // 
            TabControlMain.Appearance = TabAppearance.FlatButtons;
            TabControlMain.Controls.Add(TabPageGeneral);
            TabControlMain.Controls.Add(TabPageAuditoria);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 39);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(619, 263);
            TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TableLayoutPanelGeneral);
            TabPageGeneral.Location = new Point(4, 32);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(3);
            TabPageGeneral.Size = new Size(611, 227);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelGeneral
            // 
            TableLayoutPanelGeneral.AutoSize = true;
            TableLayoutPanelGeneral.ColumnCount = 3;
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.Controls.Add(LabelEventoTipo, 0, 0);
            TableLayoutPanelGeneral.Controls.Add(ComboBoxEventoTipo, 1, 0);
            TableLayoutPanelGeneral.Controls.Add(LabelFechaHora, 0, 1);
            TableLayoutPanelGeneral.Controls.Add(DateTimePickerFecha, 1, 1);
            TableLayoutPanelGeneral.Controls.Add(DateTimePickerHora, 2, 1);
            TableLayoutPanelGeneral.Controls.Add(LabelNotas, 0, 2);
            TableLayoutPanelGeneral.Controls.Add(TextBoxNotas, 1, 2);
            TableLayoutPanelGeneral.Dock = DockStyle.Fill;
            TableLayoutPanelGeneral.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelGeneral.Location = new Point(3, 3);
            TableLayoutPanelGeneral.Name = "TableLayoutPanelGeneral";
            TableLayoutPanelGeneral.RowCount = 3;
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelGeneral.Size = new Size(605, 221);
            TableLayoutPanelGeneral.TabIndex = 7;
            // 
            // TextBoxNotas
            // 
            TableLayoutPanelGeneral.SetColumnSpan(TextBoxNotas, 2);
            TextBoxNotas.Dock = DockStyle.Fill;
            TextBoxNotas.Location = new Point(96, 70);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(505, 148);
            TextBoxNotas.TabIndex = 6;
            TextBoxNotas.Enter += TextBoxs_Enter;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Dock = DockStyle.Fill;
            LabelNotas.Location = new Point(4, 67);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(84, 154);
            LabelNotas.TabIndex = 5;
            LabelNotas.Text = "Notas:";
            // 
            // TabPageAuditoria
            // 
            TabPageAuditoria.Controls.Add(TableLayoutPanelAuditoria);
            TabPageAuditoria.Location = new Point(4, 32);
            TabPageAuditoria.Name = "TabPageAuditoria";
            TabPageAuditoria.Padding = new Padding(3);
            TabPageAuditoria.Size = new Size(611, 227);
            TabPageAuditoria.TabIndex = 1;
            TabPageAuditoria.Text = "Auditoría";
            TabPageAuditoria.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelAuditoria
            // 
            TableLayoutPanelAuditoria.AutoSize = true;
            TableLayoutPanelAuditoria.ColumnCount = 3;
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.Controls.Add(LabelId, 0, 0);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxId, 1, 0);
            TableLayoutPanelAuditoria.Controls.Add(LabelCreacion, 0, 1);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxFechaHoraCreacion, 1, 1);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxUsuarioCreacion, 2, 1);
            TableLayoutPanelAuditoria.Controls.Add(LabelModificacion, 0, 2);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxFechaHoraUltimaModificacion, 1, 2);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxUsuarioUltimaModificacion, 2, 2);
            TableLayoutPanelAuditoria.Dock = DockStyle.Fill;
            TableLayoutPanelAuditoria.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelAuditoria.Location = new Point(3, 3);
            TableLayoutPanelAuditoria.Name = "TableLayoutPanelAuditoria";
            TableLayoutPanelAuditoria.RowCount = 4;
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.Size = new Size(605, 221);
            TableLayoutPanelAuditoria.TabIndex = 9;
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Dock = DockStyle.Fill;
            LabelId.Location = new Point(4, 0);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(147, 33);
            LabelId.TabIndex = 0;
            LabelId.Text = "Id:";
            LabelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(159, 3);
            TextBoxId.Margin = new Padding(4, 3, 4, 3);
            TextBoxId.MaxLength = 10;
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(83, 27);
            TextBoxId.TabIndex = 1;
            TextBoxId.TabStop = false;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            TextBoxId.Enter += TextBoxs_Enter;
            // 
            // TextBoxFechaHoraCreacion
            // 
            TextBoxFechaHoraCreacion.Location = new Point(159, 36);
            TextBoxFechaHoraCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraCreacion.MaxLength = 0;
            TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            TextBoxFechaHoraCreacion.ReadOnly = true;
            TextBoxFechaHoraCreacion.Size = new Size(140, 27);
            TextBoxFechaHoraCreacion.TabIndex = 3;
            TextBoxFechaHoraCreacion.TabStop = false;
            TextBoxFechaHoraCreacion.Enter += TextBoxs_Enter;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Dock = DockStyle.Fill;
            TextBoxUsuarioCreacion.Location = new Point(307, 36);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(294, 27);
            TextBoxUsuarioCreacion.TabIndex = 4;
            TextBoxUsuarioCreacion.TabStop = false;
            TextBoxUsuarioCreacion.Enter += TextBoxs_Enter;
            // 
            // TextBoxFechaHoraUltimaModificacion
            // 
            TextBoxFechaHoraUltimaModificacion.Location = new Point(159, 69);
            TextBoxFechaHoraUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraUltimaModificacion.MaxLength = 0;
            TextBoxFechaHoraUltimaModificacion.Name = "TextBoxFechaHoraUltimaModificacion";
            TextBoxFechaHoraUltimaModificacion.ReadOnly = true;
            TextBoxFechaHoraUltimaModificacion.Size = new Size(140, 27);
            TextBoxFechaHoraUltimaModificacion.TabIndex = 6;
            TextBoxFechaHoraUltimaModificacion.TabStop = false;
            TextBoxFechaHoraUltimaModificacion.Enter += TextBoxs_Enter;
            // 
            // TextBoxUsuarioUltimaModificacion
            // 
            TextBoxUsuarioUltimaModificacion.Dock = DockStyle.Fill;
            TextBoxUsuarioUltimaModificacion.Location = new Point(307, 69);
            TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            TextBoxUsuarioUltimaModificacion.Size = new Size(294, 27);
            TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            TextBoxUsuarioUltimaModificacion.TabStop = false;
            TextBoxUsuarioUltimaModificacion.Enter += TextBoxs_Enter;
            // 
            // FormPointEvent
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(619, 302);
            Controls.Add(TabControlMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPointEvent";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Evento del punto";
            FormClosed += This_FormClosed;
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            TabControlMain.ResumeLayout(false);
            TabPageGeneral.ResumeLayout(false);
            TabPageGeneral.PerformLayout();
            TableLayoutPanelGeneral.ResumeLayout(false);
            TableLayoutPanelGeneral.PerformLayout();
            TabPageAuditoria.ResumeLayout(false);
            TabPageAuditoria.PerformLayout();
            TableLayoutPanelAuditoria.ResumeLayout(false);
            TableLayoutPanelAuditoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        internal ToolStripButton ToolStripButtonClose;
        internal ToolStripButton ToolStripButtonEdit;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSave;
        private Label LabelEventoTipo;
        private ComboBox ComboBoxEventoTipo;
        private Label LabelFechaHora;
        private DateTimePicker DateTimePickerFecha;
        private DateTimePicker DateTimePickerHora;
        private TabControl TabControlMain;
        private TabPage TabPageGeneral;
        private TabPage TabPageAuditoria;
        internal Label LabelNotas;
        internal TextBox TextBoxNotas;
        private TableLayoutPanel TableLayoutPanelGeneral;
        private TableLayoutPanel TableLayoutPanelAuditoria;
        private Label LabelId;
        private TextBox TextBoxId;
        internal TextBox TextBoxFechaHoraCreacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxUsuarioUltimaModificacion;
    }
}