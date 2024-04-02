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
            Label LabelModificacion;
            Label LabelCreacion;
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            LabelNombre = new Label();
            TextBoxNombre = new TextBox();
            LabelLatitud = new Label();
            DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            LabelLongitud = new Label();
            LabelAltitud = new Label();
            DoubleTextBoxAltitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            TabControlMain = new TabControl();
            TabPageGeneral = new TabPage();
            TabPageAuditoria = new TabPage();
            LabelId = new Label();
            TextBoxId = new TextBox();
            TextBoxUsuarioUltimaModificacion = new TextBox();
            TextBoxUsuarioCreacion = new TextBox();
            TextBoxFechaHoraUltimaModificacion = new TextBox();
            TextBoxFechaHoraCreacion = new TextBox();
            LabelModificacion = new Label();
            LabelCreacion = new Label();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxAltitud).BeginInit();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TabPageAuditoria.SuspendLayout();
            SuspendLayout();
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
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonClose, ToolStripButtonEdit, ToolStripButtonCancel, ToolStripButtonSave });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(491, 39);
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
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(7, 9);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(54, 15);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNombre.Location = new Point(70, 6);
            TextBoxNombre.MaxLength = 100;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(405, 23);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelLatitud
            // 
            LabelLatitud.AutoSize = true;
            LabelLatitud.Location = new Point(7, 38);
            LabelLatitud.Name = "LabelLatitud";
            LabelLatitud.Size = new Size(47, 15);
            LabelLatitud.TabIndex = 2;
            LabelLatitud.Text = "Latitud:";
            // 
            // DoubleTextBoxLatitud
            // 
            DoubleTextBoxLatitud.BeforeTouchSize = new Size(61, 23);
            DoubleTextBoxLatitud.DoubleValue = 0D;
            DoubleTextBoxLatitud.Location = new Point(70, 35);
            DoubleTextBoxLatitud.MaxValue = 90D;
            DoubleTextBoxLatitud.MinValue = -90D;
            DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            DoubleTextBoxLatitud.Size = new Size(74, 23);
            DoubleTextBoxLatitud.TabIndex = 3;
            DoubleTextBoxLatitud.Text = "0,000000";
            DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLongitud
            // 
            DoubleTextBoxLongitud.BeforeTouchSize = new Size(61, 23);
            DoubleTextBoxLongitud.DoubleValue = 0D;
            DoubleTextBoxLongitud.Location = new Point(70, 64);
            DoubleTextBoxLongitud.MaxValue = 180D;
            DoubleTextBoxLongitud.MinValue = -180D;
            DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            DoubleTextBoxLongitud.Size = new Size(74, 23);
            DoubleTextBoxLongitud.TabIndex = 5;
            DoubleTextBoxLongitud.Text = "0,000000";
            DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLongitud
            // 
            LabelLongitud.AutoSize = true;
            LabelLongitud.Location = new Point(6, 67);
            LabelLongitud.Name = "LabelLongitud";
            LabelLongitud.Size = new Size(58, 15);
            LabelLongitud.TabIndex = 4;
            LabelLongitud.Text = "Longitud:";
            // 
            // LabelAltitud
            // 
            LabelAltitud.AutoSize = true;
            LabelAltitud.Location = new Point(7, 96);
            LabelAltitud.Name = "LabelAltitud";
            LabelAltitud.Size = new Size(46, 15);
            LabelAltitud.TabIndex = 6;
            LabelAltitud.Text = "Altitud:";
            // 
            // DoubleTextBoxAltitud
            // 
            DoubleTextBoxAltitud.BeforeTouchSize = new Size(61, 23);
            DoubleTextBoxAltitud.DoubleValue = 0D;
            DoubleTextBoxAltitud.Location = new Point(70, 93);
            DoubleTextBoxAltitud.MaxValue = 8849D;
            DoubleTextBoxAltitud.MinValue = -11036D;
            DoubleTextBoxAltitud.Name = "DoubleTextBoxAltitud";
            DoubleTextBoxAltitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxAltitud.Size = new Size(61, 23);
            DoubleTextBoxAltitud.TabIndex = 7;
            DoubleTextBoxAltitud.Text = "0,00";
            DoubleTextBoxAltitud.TextAlign = HorizontalAlignment.Right;
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
            TabControlMain.Size = new Size(491, 156);
            TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(LabelNombre);
            TabPageGeneral.Controls.Add(TextBoxNombre);
            TabPageGeneral.Controls.Add(LabelLatitud);
            TabPageGeneral.Controls.Add(DoubleTextBoxLatitud);
            TabPageGeneral.Controls.Add(LabelLongitud);
            TabPageGeneral.Controls.Add(DoubleTextBoxLongitud);
            TabPageGeneral.Controls.Add(LabelAltitud);
            TabPageGeneral.Controls.Add(DoubleTextBoxAltitud);
            TabPageGeneral.Location = new Point(4, 27);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(3);
            TabPageGeneral.Size = new Size(483, 125);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
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
            TabPageAuditoria.Size = new Size(483, 125);
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
            // TextBoxUsuarioUltimaModificacion
            // 
            TextBoxUsuarioUltimaModificacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioUltimaModificacion.Location = new Point(281, 64);
            TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            TextBoxUsuarioUltimaModificacion.Size = new Size(195, 23);
            TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            TextBoxUsuarioUltimaModificacion.TabStop = false;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioCreacion.Location = new Point(281, 35);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(195, 23);
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
            // FormPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 195);
            Controls.Add(TabControlMain);
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
        private Label LabelNombre;
        private TextBox TextBoxNombre;
        private Label LabelLatitud;
        internal ToolStripButton ToolStripButtonClose;
        internal ToolStripButton ToolStripButtonEdit;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSave;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLatitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLongitud;
        private Label LabelLongitud;
        private Label LabelAltitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxAltitud;
        private TabControl TabControlMain;
        private TabPage TabPageGeneral;
        private TabPage TabPageAuditoria;
        internal Label LabelId;
        internal TextBox TextBoxId;
        internal TextBox TextBoxUsuarioUltimaModificacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxFechaHoraCreacion;
    }
}