namespace CSMaps.General
{
    partial class FormPointData
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
            components = new System.ComponentModel.Container();
            Label LabelCreacion;
            Label LabelModificacion;
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            GroupBoxPunto = new GroupBox();
            ButtonBuscarPunto = new Button();
            LabelLongitud = new Label();
            DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            LabelLatitud = new Label();
            TextBoxNombre = new TextBox();
            LabelNombre = new Label();
            LabelEstablecimiento = new Label();
            ComboBoxEstablecimiento = new ComboBox();
            LabelChapaNumero = new Label();
            IntegerTextBoxChapaNumero = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ButtonChapaNumeroObtenerDesdeNombre = new Button();
            GroupBoxAgregarEvento = new GroupBox();
            ComboBoxEventoAgregar = new ComboBox();
            CheckBoxEventoAgregar = new CheckBox();
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
            GroupBoxPunto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntegerTextBoxChapaNumero).BeginInit();
            GroupBoxAgregarEvento.SuspendLayout();
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
            // GroupBoxPunto
            // 
            GroupBoxPunto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxPunto.Controls.Add(ButtonBuscarPunto);
            GroupBoxPunto.Controls.Add(LabelLongitud);
            GroupBoxPunto.Controls.Add(DoubleTextBoxLongitud);
            GroupBoxPunto.Controls.Add(DoubleTextBoxLatitud);
            GroupBoxPunto.Controls.Add(LabelLatitud);
            GroupBoxPunto.Controls.Add(TextBoxNombre);
            GroupBoxPunto.Controls.Add(LabelNombre);
            GroupBoxPunto.Location = new Point(6, 6);
            GroupBoxPunto.Name = "GroupBoxPunto";
            GroupBoxPunto.Size = new Size(497, 113);
            GroupBoxPunto.TabIndex = 0;
            GroupBoxPunto.TabStop = false;
            // 
            // ButtonBuscarPunto
            // 
            ButtonBuscarPunto.Location = new Point(386, 22);
            ButtonBuscarPunto.Name = "ButtonBuscarPunto";
            ButtonBuscarPunto.Size = new Size(105, 24);
            ButtonBuscarPunto.TabIndex = 2;
            ButtonBuscarPunto.Text = "Buscar punto...";
            ButtonBuscarPunto.UseVisualStyleBackColor = true;
            ButtonBuscarPunto.Click += ButtonBuscarPunto_Click;
            // 
            // LabelLongitud
            // 
            LabelLongitud.AutoSize = true;
            LabelLongitud.Location = new Point(6, 83);
            LabelLongitud.Name = "LabelLongitud";
            LabelLongitud.Size = new Size(58, 15);
            LabelLongitud.TabIndex = 5;
            LabelLongitud.Text = "Longitud:";
            // 
            // DoubleTextBoxLongitud
            // 
            DoubleTextBoxLongitud.BeforeTouchSize = new Size(56, 23);
            DoubleTextBoxLongitud.DoubleValue = 0D;
            DoubleTextBoxLongitud.Location = new Point(70, 80);
            DoubleTextBoxLongitud.MaxValue = 180D;
            DoubleTextBoxLongitud.MinValue = -180D;
            DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            DoubleTextBoxLongitud.ReadOnly = true;
            DoubleTextBoxLongitud.Size = new Size(74, 23);
            DoubleTextBoxLongitud.TabIndex = 6;
            DoubleTextBoxLongitud.TabStop = false;
            DoubleTextBoxLongitud.Text = "0,000000";
            DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLatitud
            // 
            DoubleTextBoxLatitud.BeforeTouchSize = new Size(56, 23);
            DoubleTextBoxLatitud.DoubleValue = 0D;
            DoubleTextBoxLatitud.Location = new Point(70, 51);
            DoubleTextBoxLatitud.MaxValue = 90D;
            DoubleTextBoxLatitud.MinValue = -90D;
            DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            DoubleTextBoxLatitud.ReadOnly = true;
            DoubleTextBoxLatitud.Size = new Size(74, 23);
            DoubleTextBoxLatitud.TabIndex = 4;
            DoubleTextBoxLatitud.TabStop = false;
            DoubleTextBoxLatitud.Text = "0,000000";
            DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLatitud
            // 
            LabelLatitud.AutoSize = true;
            LabelLatitud.Location = new Point(6, 54);
            LabelLatitud.Name = "LabelLatitud";
            LabelLatitud.Size = new Size(47, 15);
            LabelLatitud.TabIndex = 3;
            LabelLatitud.Text = "Latitud:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNombre.Location = new Point(70, 22);
            TextBoxNombre.MaxLength = 100;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.ReadOnly = true;
            TextBoxNombre.Size = new Size(310, 23);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.TabStop = false;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(6, 25);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(54, 15);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            // 
            // LabelEstablecimiento
            // 
            LabelEstablecimiento.AutoSize = true;
            LabelEstablecimiento.Location = new Point(6, 128);
            LabelEstablecimiento.Name = "LabelEstablecimiento";
            LabelEstablecimiento.Size = new Size(94, 15);
            LabelEstablecimiento.TabIndex = 1;
            LabelEstablecimiento.Text = "Establecimiento:";
            // 
            // ComboBoxEstablecimiento
            // 
            ComboBoxEstablecimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxEstablecimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstablecimiento.FormattingEnabled = true;
            ComboBoxEstablecimiento.Location = new Point(106, 125);
            ComboBoxEstablecimiento.Name = "ComboBoxEstablecimiento";
            ComboBoxEstablecimiento.Size = new Size(397, 23);
            ComboBoxEstablecimiento.TabIndex = 2;
            // 
            // LabelChapaNumero
            // 
            LabelChapaNumero.AutoSize = true;
            LabelChapaNumero.Location = new Point(6, 159);
            LabelChapaNumero.Name = "LabelChapaNumero";
            LabelChapaNumero.Size = new Size(75, 15);
            LabelChapaNumero.TabIndex = 3;
            LabelChapaNumero.Text = "Nº de chapa:";
            // 
            // IntegerTextBoxChapaNumero
            // 
            IntegerTextBoxChapaNumero.AllowNull = true;
            IntegerTextBoxChapaNumero.BeforeTouchSize = new Size(56, 23);
            IntegerTextBoxChapaNumero.IntegerValue = 1L;
            IntegerTextBoxChapaNumero.Location = new Point(106, 154);
            IntegerTextBoxChapaNumero.MaxValue = 109999L;
            IntegerTextBoxChapaNumero.MinValue = 1L;
            IntegerTextBoxChapaNumero.Name = "IntegerTextBoxChapaNumero";
            IntegerTextBoxChapaNumero.NegativeColor = SystemColors.ControlText;
            IntegerTextBoxChapaNumero.Size = new Size(56, 23);
            IntegerTextBoxChapaNumero.TabIndex = 4;
            IntegerTextBoxChapaNumero.Text = "1";
            IntegerTextBoxChapaNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonChapaNumeroObtenerDesdeNombre
            // 
            ButtonChapaNumeroObtenerDesdeNombre.Location = new Point(168, 154);
            ButtonChapaNumeroObtenerDesdeNombre.Name = "ButtonChapaNumeroObtenerDesdeNombre";
            ButtonChapaNumeroObtenerDesdeNombre.Size = new Size(179, 24);
            ButtonChapaNumeroObtenerDesdeNombre.TabIndex = 5;
            ButtonChapaNumeroObtenerDesdeNombre.Text = "<<< Obtener desde nombre";
            ButtonChapaNumeroObtenerDesdeNombre.UseVisualStyleBackColor = true;
            ButtonChapaNumeroObtenerDesdeNombre.Click += ButtonChapaNumeroObtenerDesdeNombre_Click;
            // 
            // GroupBoxAgregarEvento
            // 
            GroupBoxAgregarEvento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxAgregarEvento.Controls.Add(ComboBoxEventoAgregar);
            GroupBoxAgregarEvento.Controls.Add(CheckBoxEventoAgregar);
            GroupBoxAgregarEvento.Location = new Point(6, 285);
            GroupBoxAgregarEvento.Name = "GroupBoxAgregarEvento";
            GroupBoxAgregarEvento.Size = new Size(497, 52);
            GroupBoxAgregarEvento.TabIndex = 8;
            GroupBoxAgregarEvento.TabStop = false;
            // 
            // ComboBoxEventoAgregar
            // 
            ComboBoxEventoAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxEventoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEventoAgregar.FormattingEnabled = true;
            ComboBoxEventoAgregar.Location = new Point(117, 20);
            ComboBoxEventoAgregar.Name = "ComboBoxEventoAgregar";
            ComboBoxEventoAgregar.Size = new Size(374, 23);
            ComboBoxEventoAgregar.TabIndex = 1;
            // 
            // CheckBoxEventoAgregar
            // 
            CheckBoxEventoAgregar.AutoSize = true;
            CheckBoxEventoAgregar.Location = new Point(6, 22);
            CheckBoxEventoAgregar.Name = "CheckBoxEventoAgregar";
            CheckBoxEventoAgregar.Size = new Size(110, 19);
            CheckBoxEventoAgregar.TabIndex = 0;
            CheckBoxEventoAgregar.Text = "Agregar evento:";
            CheckBoxEventoAgregar.UseVisualStyleBackColor = true;
            CheckBoxEventoAgregar.CheckedChanged += CheckBoxEventoAgregar_CheckedChanged;
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
            TabControlMain.Size = new Size(517, 374);
            TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TextBoxNotas);
            TabPageGeneral.Controls.Add(LabelNotas);
            TabPageGeneral.Controls.Add(GroupBoxPunto);
            TabPageGeneral.Controls.Add(LabelEstablecimiento);
            TabPageGeneral.Controls.Add(ComboBoxEstablecimiento);
            TabPageGeneral.Controls.Add(LabelChapaNumero);
            TabPageGeneral.Controls.Add(IntegerTextBoxChapaNumero);
            TabPageGeneral.Controls.Add(ButtonChapaNumeroObtenerDesdeNombre);
            TabPageGeneral.Controls.Add(GroupBoxAgregarEvento);
            TabPageGeneral.Location = new Point(4, 27);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(3);
            TabPageGeneral.Size = new Size(509, 343);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TextBoxNotas
            // 
            TextBoxNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNotas.Location = new Point(106, 184);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(396, 95);
            TextBoxNotas.TabIndex = 7;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Location = new Point(7, 187);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(41, 15);
            LabelNotas.TabIndex = 6;
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
            TabPageAuditoria.Size = new Size(509, 343);
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
            // FormPointData
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(517, 413);
            Controls.Add(TabControlMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPointData";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Datos del punto";
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            GroupBoxPunto.ResumeLayout(false);
            GroupBoxPunto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntegerTextBoxChapaNumero).EndInit();
            GroupBoxAgregarEvento.ResumeLayout(false);
            GroupBoxAgregarEvento.PerformLayout();
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
        private GroupBox GroupBoxPunto;
        private Label LabelLongitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLongitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLatitud;
        private Label LabelLatitud;
        private TextBox TextBoxNombre;
        private Label LabelNombre;
        private Label LabelEstablecimiento;
        private ComboBox ComboBoxEstablecimiento;
        private Label LabelChapaNumero;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox IntegerTextBoxChapaNumero;
        private Button ButtonBuscarPunto;
        private Button ButtonChapaNumeroObtenerDesdeNombre;
        private GroupBox GroupBoxAgregarEvento;
        private ComboBox ComboBoxEventoAgregar;
        private CheckBox CheckBoxEventoAgregar;
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