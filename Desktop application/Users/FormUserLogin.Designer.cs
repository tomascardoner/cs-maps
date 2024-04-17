namespace CSMaps.Users
{
    partial class FormUserLogin
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
            ButtonCancelar = new ToolStripButton();
            ButtonAceptar = new ToolStripButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBoxPassword = new TextBox();
            LabelPassword = new Label();
            TextBoxNombre = new TextBox();
            LabelNombre = new Label();
            PictureBoxMain = new PictureBox();
            ToolStripMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ButtonCancelar, ButtonAceptar });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(385, 39);
            ToolStripMain.TabIndex = 4;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Alignment = ToolStripItemAlignment.Right;
            ButtonCancelar.Image = Properties.Resources.ImageCancel32;
            ButtonCancelar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonCancelar.ImageTransparentColor = Color.Magenta;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(89, 36);
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Click += Cancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Alignment = ToolStripItemAlignment.Right;
            ButtonAceptar.Image = Properties.Resources.ImageOk32;
            ButtonAceptar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonAceptar.ImageTransparentColor = Color.Magenta;
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 36);
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.Click += Aceptar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 3, 1);
            tableLayoutPanel2.Controls.Add(PictureBoxMain, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(0, 39);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(385, 81);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TextBoxPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(LabelPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(TextBoxNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(LabelNombre, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(88, 8);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(288, 65);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Dock = DockStyle.Fill;
            TextBoxPassword.Location = new Point(82, 39);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(202, 23);
            TextBoxPassword.TabIndex = 4;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.Enter += TextBoxs_Enter;
            TextBoxPassword.Leave += TextBoxs_Leave;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Dock = DockStyle.Fill;
            LabelPassword.Location = new Point(4, 36);
            LabelPassword.Margin = new Padding(4, 0, 4, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(70, 29);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Contraseña:";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Dock = DockStyle.Fill;
            TextBoxNombre.Location = new Point(82, 3);
            TextBoxNombre.Margin = new Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 30;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(202, 23);
            TextBoxNombre.TabIndex = 2;
            TextBoxNombre.Enter += TextBoxs_Enter;
            TextBoxNombre.Leave += TextBoxs_Leave;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Location = new Point(4, 0);
            LabelNombre.Margin = new Padding(4, 0, 4, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(70, 29);
            LabelNombre.TabIndex = 1;
            LabelNombre.Text = "Usuario:";
            LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBoxMain
            // 
            PictureBoxMain.Dock = DockStyle.Fill;
            PictureBoxMain.Image = Properties.Resources.ImageLogin48;
            PictureBoxMain.Location = new Point(8, 8);
            PictureBoxMain.Margin = new Padding(0);
            PictureBoxMain.Name = "PictureBoxMain";
            PictureBoxMain.Size = new Size(72, 65);
            PictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMain.TabIndex = 7;
            PictureBoxMain.TabStop = false;
            // 
            // FormUserLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(385, 120);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUserLogin";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inicio de sesión";
            FormClosed += This_FormClosed;
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal System.Windows.Forms.ToolStripButton ButtonCancelar;
        internal System.Windows.Forms.ToolStripButton ButtonAceptar;
        private TableLayoutPanel tableLayoutPanel2;
        internal PictureBox PictureBoxMain;
        private TableLayoutPanel tableLayoutPanel1;
        internal TextBox TextBoxPassword;
        internal Label LabelPassword;
        internal TextBox TextBoxNombre;
        internal Label LabelNombre;
    }
}