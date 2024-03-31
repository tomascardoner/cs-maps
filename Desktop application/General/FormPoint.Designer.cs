namespace CSMaps.General
{
    partial class FormPoint
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
            LabelIdPunto = new Label();
            TextBoxIdPunto = new TextBox();
            LabelNombre = new Label();
            TextBoxNombre = new TextBox();
            LabelLatitud = new Label();
            TextBoxUltimaActualizacion = new TextBox();
            LabelUltimaActualizacion = new Label();
            DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            LabelLongitud = new Label();
            LabelAltitud = new Label();
            DoubleTextBoxAltitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxAltitud).BeginInit();
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
            // LabelIdPunto
            // 
            LabelIdPunto.AutoSize = true;
            LabelIdPunto.Location = new Point(12, 70);
            LabelIdPunto.Name = "LabelIdPunto";
            LabelIdPunto.Size = new Size(20, 15);
            LabelIdPunto.TabIndex = 1;
            LabelIdPunto.Text = "Id:";
            // 
            // TextBoxIdPunto
            // 
            TextBoxIdPunto.Location = new Point(135, 67);
            TextBoxIdPunto.Name = "TextBoxIdPunto";
            TextBoxIdPunto.ReadOnly = true;
            TextBoxIdPunto.Size = new Size(61, 23);
            TextBoxIdPunto.TabIndex = 2;
            TextBoxIdPunto.TabStop = false;
            TextBoxIdPunto.TextAlign = HorizontalAlignment.Center;
            TextBoxIdPunto.Enter += TextBoxs_Enter;
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
            // LabelLatitud
            // 
            LabelLatitud.AutoSize = true;
            LabelLatitud.Location = new Point(12, 128);
            LabelLatitud.Name = "LabelLatitud";
            LabelLatitud.Size = new Size(47, 15);
            LabelLatitud.TabIndex = 5;
            LabelLatitud.Text = "Latitud:";
            // 
            // TextBoxUltimaActualizacion
            // 
            TextBoxUltimaActualizacion.Location = new Point(135, 212);
            TextBoxUltimaActualizacion.Name = "TextBoxUltimaActualizacion";
            TextBoxUltimaActualizacion.ReadOnly = true;
            TextBoxUltimaActualizacion.Size = new Size(149, 23);
            TextBoxUltimaActualizacion.TabIndex = 12;
            TextBoxUltimaActualizacion.TabStop = false;
            TextBoxUltimaActualizacion.Enter += TextBoxs_Enter;
            // 
            // LabelUltimaActualizacion
            // 
            LabelUltimaActualizacion.AutoSize = true;
            LabelUltimaActualizacion.Location = new Point(12, 215);
            LabelUltimaActualizacion.Name = "LabelUltimaActualizacion";
            LabelUltimaActualizacion.Size = new Size(117, 15);
            LabelUltimaActualizacion.TabIndex = 11;
            LabelUltimaActualizacion.Text = "Última actualización:";
            // 
            // DoubleTextBoxLatitud
            // 
            DoubleTextBoxLatitud.BeforeTouchSize = new Size(61, 23);
            DoubleTextBoxLatitud.DoubleValue = 0D;
            DoubleTextBoxLatitud.Location = new Point(135, 125);
            DoubleTextBoxLatitud.MaxValue = 90D;
            DoubleTextBoxLatitud.MinValue = -90D;
            DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            DoubleTextBoxLatitud.Size = new Size(74, 23);
            DoubleTextBoxLatitud.TabIndex = 6;
            DoubleTextBoxLatitud.Text = "0,000000";
            DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLongitud
            // 
            DoubleTextBoxLongitud.BeforeTouchSize = new Size(61, 23);
            DoubleTextBoxLongitud.DoubleValue = 0D;
            DoubleTextBoxLongitud.Location = new Point(135, 154);
            DoubleTextBoxLongitud.MaxValue = 180D;
            DoubleTextBoxLongitud.MinValue = -180D;
            DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            DoubleTextBoxLongitud.Size = new Size(74, 23);
            DoubleTextBoxLongitud.TabIndex = 8;
            DoubleTextBoxLongitud.Text = "0,000000";
            DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLongitud
            // 
            LabelLongitud.AutoSize = true;
            LabelLongitud.Location = new Point(12, 157);
            LabelLongitud.Name = "LabelLongitud";
            LabelLongitud.Size = new Size(58, 15);
            LabelLongitud.TabIndex = 7;
            LabelLongitud.Text = "Longitud:";
            // 
            // LabelAltitud
            // 
            LabelAltitud.AutoSize = true;
            LabelAltitud.Location = new Point(12, 186);
            LabelAltitud.Name = "LabelAltitud";
            LabelAltitud.Size = new Size(46, 15);
            LabelAltitud.TabIndex = 9;
            LabelAltitud.Text = "Altitud:";
            // 
            // DoubleTextBoxAltitud
            // 
            DoubleTextBoxAltitud.BeforeTouchSize = new Size(61, 23);
            DoubleTextBoxAltitud.DoubleValue = 0D;
            DoubleTextBoxAltitud.Location = new Point(135, 183);
            DoubleTextBoxAltitud.MaxValue = 8849D;
            DoubleTextBoxAltitud.MinValue = -11036D;
            DoubleTextBoxAltitud.Name = "DoubleTextBoxAltitud";
            DoubleTextBoxAltitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxAltitud.Size = new Size(61, 23);
            DoubleTextBoxAltitud.TabIndex = 10;
            DoubleTextBoxAltitud.Text = "0,00";
            DoubleTextBoxAltitud.TextAlign = HorizontalAlignment.Right;
            // 
            // FormPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 249);
            Controls.Add(LabelAltitud);
            Controls.Add(DoubleTextBoxAltitud);
            Controls.Add(LabelLongitud);
            Controls.Add(DoubleTextBoxLongitud);
            Controls.Add(DoubleTextBoxLatitud);
            Controls.Add(TextBoxUltimaActualizacion);
            Controls.Add(LabelUltimaActualizacion);
            Controls.Add(LabelLatitud);
            Controls.Add(TextBoxNombre);
            Controls.Add(LabelNombre);
            Controls.Add(TextBoxIdPunto);
            Controls.Add(LabelIdPunto);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPoint";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Punto";
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxAltitud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private Label LabelIdPunto;
        private TextBox TextBoxIdPunto;
        private Label LabelNombre;
        private TextBox TextBoxNombre;
        private Label LabelLatitud;
        private TextBox TextBoxUltimaActualizacion;
        private Label LabelUltimaActualizacion;
        internal ToolStripButton ToolStripButtonClose;
        internal ToolStripButton ToolStripButtonEdit;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSave;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLatitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLongitud;
        private Label LabelLongitud;
        private Label LabelAltitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxAltitud;
    }
}