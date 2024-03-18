namespace CSMaps.General
{
    partial class FormEntity
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
            LabelIdEntidad = new Label();
            TextBoxIdEntidad = new TextBox();
            LabelNombre = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefonoMovil = new TextBox();
            LabelTelefonoMovil = new Label();
            TextBoxUltimaActualizacion = new TextBox();
            LabelUltimaActualizacion = new Label();
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
            // LabelIdEntidad
            // 
            LabelIdEntidad.AutoSize = true;
            LabelIdEntidad.Location = new Point(12, 70);
            LabelIdEntidad.Name = "LabelIdEntidad";
            LabelIdEntidad.Size = new Size(20, 15);
            LabelIdEntidad.TabIndex = 1;
            LabelIdEntidad.Text = "Id:";
            // 
            // TextBoxIdEntidad
            // 
            TextBoxIdEntidad.Location = new Point(135, 67);
            TextBoxIdEntidad.Name = "TextBoxIdEntidad";
            TextBoxIdEntidad.ReadOnly = true;
            TextBoxIdEntidad.Size = new Size(61, 23);
            TextBoxIdEntidad.TabIndex = 2;
            TextBoxIdEntidad.TabStop = false;
            TextBoxIdEntidad.TextAlign = HorizontalAlignment.Center;
            TextBoxIdEntidad.Enter += TextBoxs_Enter;
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
            TextBoxTelefonoMovil.Location = new Point(135, 125);
            TextBoxTelefonoMovil.MaxLength = 20;
            TextBoxTelefonoMovil.Name = "TextBoxTelefonoMovil";
            TextBoxTelefonoMovil.Size = new Size(149, 23);
            TextBoxTelefonoMovil.TabIndex = 6;
            TextBoxTelefonoMovil.Enter += TextBoxs_Enter;
            // 
            // LabelTelefonoMovil
            // 
            LabelTelefonoMovil.AutoSize = true;
            LabelTelefonoMovil.Location = new Point(12, 128);
            LabelTelefonoMovil.Name = "LabelTelefonoMovil";
            LabelTelefonoMovil.Size = new Size(88, 15);
            LabelTelefonoMovil.TabIndex = 5;
            LabelTelefonoMovil.Text = "Teléfono móvil:";
            // 
            // TextBoxUltimaActualizacion
            // 
            TextBoxUltimaActualizacion.Location = new Point(135, 154);
            TextBoxUltimaActualizacion.Name = "TextBoxUltimaActualizacion";
            TextBoxUltimaActualizacion.ReadOnly = true;
            TextBoxUltimaActualizacion.Size = new Size(149, 23);
            TextBoxUltimaActualizacion.TabIndex = 8;
            TextBoxUltimaActualizacion.TabStop = false;
            TextBoxUltimaActualizacion.Enter += TextBoxs_Enter;
            // 
            // LabelUltimaActualizacion
            // 
            LabelUltimaActualizacion.AutoSize = true;
            LabelUltimaActualizacion.Location = new Point(12, 157);
            LabelUltimaActualizacion.Name = "LabelUltimaActualizacion";
            LabelUltimaActualizacion.Size = new Size(117, 15);
            LabelUltimaActualizacion.TabIndex = 7;
            LabelUltimaActualizacion.Text = "Última actualización:";
            // 
            // FormEntity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 190);
            Controls.Add(TextBoxUltimaActualizacion);
            Controls.Add(LabelUltimaActualizacion);
            Controls.Add(TextBoxTelefonoMovil);
            Controls.Add(LabelTelefonoMovil);
            Controls.Add(TextBoxNombre);
            Controls.Add(LabelNombre);
            Controls.Add(TextBoxIdEntidad);
            Controls.Add(LabelIdEntidad);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEntity";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Entidad";
            KeyPress += FormEntity_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private Label LabelIdEntidad;
        private TextBox TextBoxIdEntidad;
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
    }
}