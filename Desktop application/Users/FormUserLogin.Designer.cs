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
            TextBoxPassword = new TextBox();
            TextBoxNombre = new TextBox();
            LabelPassword = new Label();
            LabelNombre = new Label();
            PictureBoxMain = new PictureBox();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ButtonCancelar, ButtonAceptar });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(379, 39);
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
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(182, 90);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(184, 23);
            TextBoxPassword.TabIndex = 3;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.Enter += TextBoxs_Enter;
            TextBoxPassword.Leave += TextBoxs_Leave;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(182, 52);
            TextBoxNombre.Margin = new Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 30;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(184, 23);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            TextBoxNombre.Leave += TextBoxs_Leave;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(96, 94);
            LabelPassword.Margin = new Padding(4, 0, 4, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(70, 15);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Contraseña:";
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(96, 56);
            LabelNombre.Margin = new Padding(4, 0, 4, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(50, 15);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Usuario:";
            // 
            // PictureBoxMain
            // 
            PictureBoxMain.Image = Properties.Resources.ImageLogin48;
            PictureBoxMain.Location = new Point(13, 60);
            PictureBoxMain.Margin = new Padding(4, 3, 4, 3);
            PictureBoxMain.Name = "PictureBoxMain";
            PictureBoxMain.Size = new Size(48, 48);
            PictureBoxMain.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxMain.TabIndex = 6;
            PictureBoxMain.TabStop = false;
            // 
            // FormUserLogin
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(379, 127);
            ControlBox = false;
            Controls.Add(ToolStripMain);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxNombre);
            Controls.Add(LabelPassword);
            Controls.Add(LabelNombre);
            Controls.Add(PictureBoxMain);
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
            ((System.ComponentModel.ISupportInitialize)PictureBoxMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal System.Windows.Forms.ToolStripButton ButtonCancelar;
        internal System.Windows.Forms.ToolStripButton ButtonAceptar;
        internal System.Windows.Forms.TextBox TextBoxPassword;
        internal System.Windows.Forms.TextBox TextBoxNombre;
        internal System.Windows.Forms.Label LabelPassword;
        internal System.Windows.Forms.Label LabelNombre;
        internal System.Windows.Forms.PictureBox PictureBoxMain;
    }
}