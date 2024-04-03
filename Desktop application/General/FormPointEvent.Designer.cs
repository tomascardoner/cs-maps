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
            TextBoxNotas = new TextBox();
            LabelNotas = new Label();
            TabPageAuditoria = new TabPage();
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
            TabPageAuditoria.SuspendLayout();
            SuspendLayout();
            // 
            // LabelCreacion
            // 
            LabelCreacion.AutoSize = true;
            LabelCreacion.Location = new Point(7, 38);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(57, 15);
            LabelCreacion.TabIndex = 2;
            LabelCreacion.Text = "Creación:";
            // 
            // LabelModificacion
            // 
            LabelModificacion.AutoSize = true;
            LabelModificacion.Location = new Point(7, 67);
            LabelModificacion.Margin = new Padding(4, 0, 4, 0);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new Size(118, 15);
            LabelModificacion.TabIndex = 5;
            LabelModificacion.Text = "Última modificación:";
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonClose, ToolStripButtonEdit, ToolStripButtonCancel, ToolStripButtonSave });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(517, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonClose
            // 
            ToolStripButtonClose.Alignment = ToolStripItemAlignment.Right;
            ToolStripButtonClose.Image = Properties.Resources.ImageClose32;
            ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            ToolStripButtonClose.Name = "ToolStripButtonClose";
            ToolStripButtonClose.Size = new Size(75, 36);
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
            ToolStripButtonEdit.Size = new Size(73, 36);
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
            ToolStripButtonCancel.Size = new Size(89, 36);
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
            ToolStripButtonSave.Size = new Size(85, 36);
            ToolStripButtonSave.Text = "Guardar";
            ToolStripButtonSave.Click += ToolStripButtonSave_Click;
            // 
            // LabelEventoTipo
            // 
            LabelEventoTipo.AutoSize = true;
            LabelEventoTipo.Location = new Point(6, 9);
            LabelEventoTipo.Name = "LabelEventoTipo";
            LabelEventoTipo.Size = new Size(33, 15);
            LabelEventoTipo.TabIndex = 0;
            LabelEventoTipo.Text = "Tipo:";
            // 
            // ComboBoxEventoTipo
            // 
            ComboBoxEventoTipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxEventoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEventoTipo.FormattingEnabled = true;
            ComboBoxEventoTipo.Location = new Point(114, 6);
            ComboBoxEventoTipo.Name = "ComboBoxEventoTipo";
            ComboBoxEventoTipo.Size = new Size(389, 23);
            ComboBoxEventoTipo.TabIndex = 1;
            // 
            // LabelFechaHora
            // 
            LabelFechaHora.AutoSize = true;
            LabelFechaHora.Location = new Point(6, 38);
            LabelFechaHora.Name = "LabelFechaHora";
            LabelFechaHora.Size = new Size(70, 15);
            LabelFechaHora.TabIndex = 2;
            LabelFechaHora.Text = "Fecha-hora:";
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Format = DateTimePickerFormat.Short;
            DateTimePickerFecha.Location = new Point(114, 35);
            DateTimePickerFecha.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            DateTimePickerFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(126, 23);
            DateTimePickerFecha.TabIndex = 3;
            // 
            // DateTimePickerHora
            // 
            DateTimePickerHora.Format = DateTimePickerFormat.Time;
            DateTimePickerHora.Location = new Point(246, 35);
            DateTimePickerHora.Name = "DateTimePickerHora";
            DateTimePickerHora.ShowUpDown = true;
            DateTimePickerHora.Size = new Size(87, 23);
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
            TabControlMain.Size = new Size(517, 200);
            TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TextBoxNotas);
            TabPageGeneral.Controls.Add(LabelNotas);
            TabPageGeneral.Controls.Add(LabelEventoTipo);
            TabPageGeneral.Controls.Add(ComboBoxEventoTipo);
            TabPageGeneral.Controls.Add(LabelFechaHora);
            TabPageGeneral.Controls.Add(DateTimePickerFecha);
            TabPageGeneral.Controls.Add(DateTimePickerHora);
            TabPageGeneral.Location = new Point(4, 27);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(3);
            TabPageGeneral.Size = new Size(509, 169);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TextBoxNotas
            // 
            TextBoxNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNotas.Location = new Point(114, 64);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(388, 99);
            TextBoxNotas.TabIndex = 6;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Location = new Point(7, 67);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(41, 15);
            LabelNotas.TabIndex = 5;
            LabelNotas.Text = "Notas:";
            // 
            // TabPageAuditoria
            // 
            TabPageAuditoria.Controls.Add(LabelId);
            TabPageAuditoria.Controls.Add(TextBoxId);
            TabPageAuditoria.Controls.Add(LabelCreacion);
            TabPageAuditoria.Controls.Add(TextBoxFechaHoraCreacion);
            TabPageAuditoria.Controls.Add(TextBoxUsuarioCreacion);
            TabPageAuditoria.Controls.Add(LabelModificacion);
            TabPageAuditoria.Controls.Add(TextBoxFechaHoraUltimaModificacion);
            TabPageAuditoria.Controls.Add(TextBoxUsuarioUltimaModificacion);
            TabPageAuditoria.Location = new Point(4, 27);
            TabPageAuditoria.Name = "TabPageAuditoria";
            TabPageAuditoria.Padding = new Padding(3);
            TabPageAuditoria.Size = new Size(509, 218);
            TabPageAuditoria.TabIndex = 1;
            TabPageAuditoria.Text = "Auditoría";
            TabPageAuditoria.UseVisualStyleBackColor = true;
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Location = new Point(7, 9);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(20, 15);
            LabelId.TabIndex = 0;
            LabelId.Text = "Id:";
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(133, 6);
            TextBoxId.Margin = new Padding(4, 3, 4, 3);
            TextBoxId.MaxLength = 10;
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(83, 23);
            TextBoxId.TabIndex = 1;
            TextBoxId.TabStop = false;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxFechaHoraCreacion
            // 
            TextBoxFechaHoraCreacion.Location = new Point(133, 35);
            TextBoxFechaHoraCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraCreacion.MaxLength = 0;
            TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            TextBoxFechaHoraCreacion.ReadOnly = true;
            TextBoxFechaHoraCreacion.Size = new Size(140, 23);
            TextBoxFechaHoraCreacion.TabIndex = 3;
            TextBoxFechaHoraCreacion.TabStop = false;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioCreacion.Location = new Point(281, 35);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(221, 23);
            TextBoxUsuarioCreacion.TabIndex = 4;
            TextBoxUsuarioCreacion.TabStop = false;
            // 
            // TextBoxFechaHoraUltimaModificacion
            // 
            TextBoxFechaHoraUltimaModificacion.Location = new Point(133, 64);
            TextBoxFechaHoraUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraUltimaModificacion.MaxLength = 0;
            TextBoxFechaHoraUltimaModificacion.Name = "TextBoxFechaHoraUltimaModificacion";
            TextBoxFechaHoraUltimaModificacion.ReadOnly = true;
            TextBoxFechaHoraUltimaModificacion.Size = new Size(140, 23);
            TextBoxFechaHoraUltimaModificacion.TabIndex = 6;
            TextBoxFechaHoraUltimaModificacion.TabStop = false;
            // 
            // TextBoxUsuarioUltimaModificacion
            // 
            TextBoxUsuarioUltimaModificacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioUltimaModificacion.Location = new Point(281, 64);
            TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            TextBoxUsuarioUltimaModificacion.Size = new Size(221, 23);
            TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            TextBoxUsuarioUltimaModificacion.TabStop = false;
            // 
            // FormPointEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 239);
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
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            TabControlMain.ResumeLayout(false);
            TabPageGeneral.ResumeLayout(false);
            TabPageGeneral.PerformLayout();
            TabPageAuditoria.ResumeLayout(false);
            TabPageAuditoria.PerformLayout();
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
        internal Label LabelId;
        internal TextBox TextBoxId;
        internal TextBox TextBoxFechaHoraCreacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxUsuarioUltimaModificacion;
        internal Label LabelNotas;
        internal TextBox TextBoxNotas;
    }
}