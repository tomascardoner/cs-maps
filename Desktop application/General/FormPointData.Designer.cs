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
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            TextBoxUltimaModificacion = new TextBox();
            LabelUltimaModificacion = new Label();
            GroupBoxPunto = new GroupBox();
            ButtonBuscarPunto = new Button();
            LabelLongitud = new Label();
            DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            LabelLatitud = new Label();
            TextBoxNombre = new TextBox();
            LabelNombre = new Label();
            TextBoxIdPunto = new TextBox();
            LabelIdPunto = new Label();
            LabelEstablecimiento = new Label();
            ComboBoxEstablecimiento = new ComboBox();
            LabelChapaNumero = new Label();
            IntegerTextBoxChapaNumero = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ButtonChapaNumeroObtenerDesdeNombre = new Button();
            GroupBoxAgregarEvento = new GroupBox();
            ComboBoxEventoAgregar = new ComboBox();
            CheckBoxEventoAgregar = new CheckBox();
            ToolStripMain.SuspendLayout();
            GroupBoxPunto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntegerTextBoxChapaNumero).BeginInit();
            GroupBoxAgregarEvento.SuspendLayout();
            SuspendLayout();
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
            // TextBoxUltimaModificacion
            // 
            TextBoxUltimaModificacion.Location = new Point(135, 257);
            TextBoxUltimaModificacion.Name = "TextBoxUltimaModificacion";
            TextBoxUltimaModificacion.ReadOnly = true;
            TextBoxUltimaModificacion.Size = new Size(149, 23);
            TextBoxUltimaModificacion.TabIndex = 7;
            TextBoxUltimaModificacion.TabStop = false;
            TextBoxUltimaModificacion.Enter += TextBoxs_Enter;
            // 
            // LabelUltimaModificacion
            // 
            LabelUltimaModificacion.AutoSize = true;
            LabelUltimaModificacion.Location = new Point(12, 260);
            LabelUltimaModificacion.Name = "LabelUltimaModificacion";
            LabelUltimaModificacion.Size = new Size(118, 15);
            LabelUltimaModificacion.TabIndex = 6;
            LabelUltimaModificacion.Text = "Última modificación:";
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
            GroupBoxPunto.Controls.Add(TextBoxIdPunto);
            GroupBoxPunto.Controls.Add(LabelIdPunto);
            GroupBoxPunto.Location = new Point(12, 42);
            GroupBoxPunto.Name = "GroupBoxPunto";
            GroupBoxPunto.Size = new Size(493, 142);
            GroupBoxPunto.TabIndex = 1;
            GroupBoxPunto.TabStop = false;
            // 
            // ButtonBuscarPunto
            // 
            ButtonBuscarPunto.Location = new Point(162, 21);
            ButtonBuscarPunto.Name = "ButtonBuscarPunto";
            ButtonBuscarPunto.Size = new Size(133, 24);
            ButtonBuscarPunto.TabIndex = 8;
            ButtonBuscarPunto.Text = "Buscar...";
            ButtonBuscarPunto.UseVisualStyleBackColor = true;
            ButtonBuscarPunto.Click += ButtonBuscarPunto_Click;
            // 
            // LabelLongitud
            // 
            LabelLongitud.AutoSize = true;
            LabelLongitud.Location = new Point(6, 112);
            LabelLongitud.Name = "LabelLongitud";
            LabelLongitud.Size = new Size(58, 15);
            LabelLongitud.TabIndex = 6;
            LabelLongitud.Text = "Longitud:";
            // 
            // DoubleTextBoxLongitud
            // 
            DoubleTextBoxLongitud.BeforeTouchSize = new Size(56, 23);
            DoubleTextBoxLongitud.DoubleValue = 0D;
            DoubleTextBoxLongitud.Location = new Point(70, 109);
            DoubleTextBoxLongitud.MaxValue = 180D;
            DoubleTextBoxLongitud.MinValue = -180D;
            DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            DoubleTextBoxLongitud.ReadOnly = true;
            DoubleTextBoxLongitud.Size = new Size(74, 23);
            DoubleTextBoxLongitud.TabIndex = 7;
            DoubleTextBoxLongitud.TabStop = false;
            DoubleTextBoxLongitud.Text = "0,000000";
            DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLatitud
            // 
            DoubleTextBoxLatitud.BeforeTouchSize = new Size(56, 23);
            DoubleTextBoxLatitud.DoubleValue = 0D;
            DoubleTextBoxLatitud.Location = new Point(70, 80);
            DoubleTextBoxLatitud.MaxValue = 90D;
            DoubleTextBoxLatitud.MinValue = -90D;
            DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            DoubleTextBoxLatitud.ReadOnly = true;
            DoubleTextBoxLatitud.Size = new Size(74, 23);
            DoubleTextBoxLatitud.TabIndex = 5;
            DoubleTextBoxLatitud.TabStop = false;
            DoubleTextBoxLatitud.Text = "0,000000";
            DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLatitud
            // 
            LabelLatitud.AutoSize = true;
            LabelLatitud.Location = new Point(6, 83);
            LabelLatitud.Name = "LabelLatitud";
            LabelLatitud.Size = new Size(47, 15);
            LabelLatitud.TabIndex = 4;
            LabelLatitud.Text = "Latitud:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNombre.Location = new Point(70, 51);
            TextBoxNombre.MaxLength = 100;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.ReadOnly = true;
            TextBoxNombre.Size = new Size(417, 23);
            TextBoxNombre.TabIndex = 3;
            TextBoxNombre.TabStop = false;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(6, 54);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(54, 15);
            LabelNombre.TabIndex = 2;
            LabelNombre.Text = "Nombre:";
            // 
            // TextBoxIdPunto
            // 
            TextBoxIdPunto.Location = new Point(70, 22);
            TextBoxIdPunto.Name = "TextBoxIdPunto";
            TextBoxIdPunto.ReadOnly = true;
            TextBoxIdPunto.Size = new Size(61, 23);
            TextBoxIdPunto.TabIndex = 1;
            TextBoxIdPunto.TabStop = false;
            TextBoxIdPunto.TextAlign = HorizontalAlignment.Center;
            TextBoxIdPunto.Enter += TextBoxs_Enter;
            // 
            // LabelIdPunto
            // 
            LabelIdPunto.AutoSize = true;
            LabelIdPunto.Location = new Point(6, 25);
            LabelIdPunto.Name = "LabelIdPunto";
            LabelIdPunto.Size = new Size(20, 15);
            LabelIdPunto.TabIndex = 0;
            LabelIdPunto.Text = "Id:";
            // 
            // LabelEstablecimiento
            // 
            LabelEstablecimiento.AutoSize = true;
            LabelEstablecimiento.Location = new Point(12, 202);
            LabelEstablecimiento.Name = "LabelEstablecimiento";
            LabelEstablecimiento.Size = new Size(94, 15);
            LabelEstablecimiento.TabIndex = 2;
            LabelEstablecimiento.Text = "Establecimiento:";
            // 
            // ComboBoxEstablecimiento
            // 
            ComboBoxEstablecimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxEstablecimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstablecimiento.FormattingEnabled = true;
            ComboBoxEstablecimiento.Location = new Point(135, 199);
            ComboBoxEstablecimiento.Name = "ComboBoxEstablecimiento";
            ComboBoxEstablecimiento.Size = new Size(370, 23);
            ComboBoxEstablecimiento.TabIndex = 3;
            // 
            // LabelChapaNumero
            // 
            LabelChapaNumero.AutoSize = true;
            LabelChapaNumero.Location = new Point(12, 231);
            LabelChapaNumero.Name = "LabelChapaNumero";
            LabelChapaNumero.Size = new Size(75, 15);
            LabelChapaNumero.TabIndex = 4;
            LabelChapaNumero.Text = "Nº de chapa:";
            // 
            // IntegerTextBoxChapaNumero
            // 
            IntegerTextBoxChapaNumero.AllowNull = true;
            IntegerTextBoxChapaNumero.BeforeTouchSize = new Size(56, 23);
            IntegerTextBoxChapaNumero.IntegerValue = 1L;
            IntegerTextBoxChapaNumero.Location = new Point(135, 228);
            IntegerTextBoxChapaNumero.MaxValue = 109999L;
            IntegerTextBoxChapaNumero.MinValue = 1L;
            IntegerTextBoxChapaNumero.Name = "IntegerTextBoxChapaNumero";
            IntegerTextBoxChapaNumero.NegativeColor = SystemColors.ControlText;
            IntegerTextBoxChapaNumero.Size = new Size(56, 23);
            IntegerTextBoxChapaNumero.TabIndex = 5;
            IntegerTextBoxChapaNumero.Text = "1";
            IntegerTextBoxChapaNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonChapaNumeroObtenerDesdeNombre
            // 
            ButtonChapaNumeroObtenerDesdeNombre.Location = new Point(197, 227);
            ButtonChapaNumeroObtenerDesdeNombre.Name = "ButtonChapaNumeroObtenerDesdeNombre";
            ButtonChapaNumeroObtenerDesdeNombre.Size = new Size(179, 24);
            ButtonChapaNumeroObtenerDesdeNombre.TabIndex = 8;
            ButtonChapaNumeroObtenerDesdeNombre.Text = "<<< Obtener desde nombre";
            ButtonChapaNumeroObtenerDesdeNombre.UseVisualStyleBackColor = true;
            ButtonChapaNumeroObtenerDesdeNombre.Click += ButtonChapaNumeroObtenerDesdeNombre_Click;
            // 
            // GroupBoxAgregarEvento
            // 
            GroupBoxAgregarEvento.Controls.Add(ComboBoxEventoAgregar);
            GroupBoxAgregarEvento.Controls.Add(CheckBoxEventoAgregar);
            GroupBoxAgregarEvento.Location = new Point(12, 287);
            GroupBoxAgregarEvento.Name = "GroupBoxAgregarEvento";
            GroupBoxAgregarEvento.Size = new Size(493, 56);
            GroupBoxAgregarEvento.TabIndex = 9;
            GroupBoxAgregarEvento.TabStop = false;
            // 
            // ComboBoxEventoAgregar
            // 
            ComboBoxEventoAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxEventoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEventoAgregar.FormattingEnabled = true;
            ComboBoxEventoAgregar.Location = new Point(117, 20);
            ComboBoxEventoAgregar.Name = "ComboBoxEventoAgregar";
            ComboBoxEventoAgregar.Size = new Size(370, 23);
            ComboBoxEventoAgregar.TabIndex = 4;
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
            // FormPointData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 352);
            Controls.Add(GroupBoxAgregarEvento);
            Controls.Add(ButtonChapaNumeroObtenerDesdeNombre);
            Controls.Add(IntegerTextBoxChapaNumero);
            Controls.Add(LabelChapaNumero);
            Controls.Add(LabelEstablecimiento);
            Controls.Add(ComboBoxEstablecimiento);
            Controls.Add(GroupBoxPunto);
            Controls.Add(TextBoxUltimaModificacion);
            Controls.Add(LabelUltimaModificacion);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private TextBox TextBoxUltimaModificacion;
        private Label LabelUltimaModificacion;
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
        private TextBox TextBoxIdPunto;
        private Label LabelIdPunto;
        private Label LabelEstablecimiento;
        private ComboBox ComboBoxEstablecimiento;
        private Label LabelChapaNumero;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox IntegerTextBoxChapaNumero;
        private Button ButtonBuscarPunto;
        private Button ButtonChapaNumeroObtenerDesdeNombre;
        private GroupBox GroupBoxAgregarEvento;
        private ComboBox ComboBoxEventoAgregar;
        private CheckBox CheckBoxEventoAgregar;
    }
}