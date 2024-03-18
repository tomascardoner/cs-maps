namespace CSMaps.General
{
    partial class FormSettlement
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
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            LabelIdEstablecimiento = new Label();
            TextBoxIdEstablecimiento = new TextBox();
            LabelNombre = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefonoMovil = new TextBox();
            LabelTelefonoMovil = new Label();
            TextBoxUltimaActualizacion = new TextBox();
            LabelUltimaActualizacion = new Label();
            ComboBoxEntidad = new ComboBox();
            LabelEntidad = new Label();
            ToolStripMain.SuspendLayout();
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
            // LabelIdEstablecimiento
            // 
            LabelIdEstablecimiento.AutoSize = true;
            LabelIdEstablecimiento.Location = new Point(12, 70);
            LabelIdEstablecimiento.Name = "LabelIdEstablecimiento";
            LabelIdEstablecimiento.Size = new Size(20, 15);
            LabelIdEstablecimiento.TabIndex = 1;
            LabelIdEstablecimiento.Text = "Id:";
            // 
            // TextBoxIdEstablecimiento
            // 
            TextBoxIdEstablecimiento.Location = new Point(135, 67);
            TextBoxIdEstablecimiento.Name = "TextBoxIdEstablecimiento";
            TextBoxIdEstablecimiento.ReadOnly = true;
            TextBoxIdEstablecimiento.Size = new Size(61, 23);
            TextBoxIdEstablecimiento.TabIndex = 2;
            TextBoxIdEstablecimiento.TabStop = false;
            TextBoxIdEstablecimiento.TextAlign = HorizontalAlignment.Center;
            TextBoxIdEstablecimiento.Enter += TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(12, 99);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(54, 15);
            LabelNombre.TabIndex = 3;
            LabelNombre.Text = "Nombre:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNombre.Location = new Point(135, 96);
            TextBoxNombre.MaxLength = 100;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(370, 23);
            TextBoxNombre.TabIndex = 4;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // TextBoxTelefonoMovil
            // 
            TextBoxTelefonoMovil.Location = new Point(135, 155);
            TextBoxTelefonoMovil.MaxLength = 20;
            TextBoxTelefonoMovil.Name = "TextBoxTelefonoMovil";
            TextBoxTelefonoMovil.Size = new Size(149, 23);
            TextBoxTelefonoMovil.TabIndex = 8;
            TextBoxTelefonoMovil.Enter += TextBoxs_Enter;
            // 
            // LabelTelefonoMovil
            // 
            LabelTelefonoMovil.AutoSize = true;
            LabelTelefonoMovil.Location = new Point(12, 158);
            LabelTelefonoMovil.Name = "LabelTelefonoMovil";
            LabelTelefonoMovil.Size = new Size(88, 15);
            LabelTelefonoMovil.TabIndex = 7;
            LabelTelefonoMovil.Text = "Teléfono móvil:";
            // 
            // TextBoxUltimaActualizacion
            // 
            TextBoxUltimaActualizacion.Location = new Point(135, 184);
            TextBoxUltimaActualizacion.Name = "TextBoxUltimaActualizacion";
            TextBoxUltimaActualizacion.ReadOnly = true;
            TextBoxUltimaActualizacion.Size = new Size(149, 23);
            TextBoxUltimaActualizacion.TabIndex = 10;
            TextBoxUltimaActualizacion.TabStop = false;
            TextBoxUltimaActualizacion.Enter += TextBoxs_Enter;
            // 
            // LabelUltimaActualizacion
            // 
            LabelUltimaActualizacion.AutoSize = true;
            LabelUltimaActualizacion.Location = new Point(12, 187);
            LabelUltimaActualizacion.Name = "LabelUltimaActualizacion";
            LabelUltimaActualizacion.Size = new Size(117, 15);
            LabelUltimaActualizacion.TabIndex = 9;
            LabelUltimaActualizacion.Text = "Última actualización:";
            // 
            // ComboBoxEntidad
            // 
            ComboBoxEntidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEntidad.FormattingEnabled = true;
            ComboBoxEntidad.Location = new Point(135, 125);
            ComboBoxEntidad.Name = "ComboBoxEntidad";
            ComboBoxEntidad.Size = new Size(370, 23);
            ComboBoxEntidad.TabIndex = 6;
            // 
            // LabelEntidad
            // 
            LabelEntidad.AutoSize = true;
            LabelEntidad.Location = new Point(12, 128);
            LabelEntidad.Name = "LabelEntidad";
            LabelEntidad.Size = new Size(50, 15);
            LabelEntidad.TabIndex = 5;
            LabelEntidad.Text = "Entidad:";
            // 
            // FormSettlement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 221);
            Controls.Add(LabelEntidad);
            Controls.Add(ComboBoxEntidad);
            Controls.Add(TextBoxUltimaActualizacion);
            Controls.Add(LabelUltimaActualizacion);
            Controls.Add(TextBoxTelefonoMovil);
            Controls.Add(LabelTelefonoMovil);
            Controls.Add(TextBoxNombre);
            Controls.Add(LabelNombre);
            Controls.Add(TextBoxIdEstablecimiento);
            Controls.Add(LabelIdEstablecimiento);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettlement";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Establecimiento";
            KeyPress += FormEntity_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private Label LabelIdEstablecimiento;
        private TextBox TextBoxIdEstablecimiento;
        private Label LabelNombre;
        private TextBox TextBoxNombre;
        private TextBox TextBoxTelefonoMovil;
        private Label LabelTelefonoMovil;
        private TextBox TextBoxUltimaActualizacion;
        private Label LabelUltimaActualizacion;
        internal ToolStripButton ToolStripButtonClose;
        internal ToolStripButton ToolStripButtonEdit;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSave;
        private ComboBox ComboBoxEntidad;
        private Label LabelEntidad;
    }
}