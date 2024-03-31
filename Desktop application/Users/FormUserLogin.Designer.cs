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
            ToolStripMain = new System.Windows.Forms.ToolStrip();
            ButtonCancelar = new System.Windows.Forms.ToolStripButton();
            ButtonAceptar = new System.Windows.Forms.ToolStripButton();
            TextBoxPassword = new System.Windows.Forms.TextBox();
            TextBoxNombre = new System.Windows.Forms.TextBox();
            LabelPassword = new System.Windows.Forms.Label();
            LabelNombre = new System.Windows.Forms.Label();
            PictureBoxMain = new System.Windows.Forms.PictureBox();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ButtonCancelar, ButtonAceptar });
            ToolStripMain.Location = new System.Drawing.Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new System.Drawing.Size(379, 54);
            ToolStripMain.TabIndex = 4;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ButtonCancelar.Image = Properties.Resources.ImageCancel32;
            ButtonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            ButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new System.Drawing.Size(57, 51);
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ButtonCancelar.Click += Cancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ButtonAceptar.Image = Properties.Resources.ImageOk32;
            ButtonAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            ButtonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new System.Drawing.Size(52, 51);
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ButtonAceptar.Click += Aceptar_Click;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new System.Drawing.Point(178, 115);
            TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new System.Drawing.Size(184, 23);
            TextBoxPassword.TabIndex = 3;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.Enter += TextBoxs_Enter;
            TextBoxPassword.Leave += TextBoxs_Leave;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new System.Drawing.Point(178, 77);
            TextBoxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 30;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new System.Drawing.Size(184, 23);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            TextBoxNombre.Leave += TextBoxs_Leave;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new System.Drawing.Point(92, 119);
            LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new System.Drawing.Size(70, 15);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Contraseña:";
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new System.Drawing.Point(92, 81);
            LabelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new System.Drawing.Size(50, 15);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Usuario:";
            // 
            // PictureBoxMain
            // 
            PictureBoxMain.Image = Properties.Resources.ImageLogin48;
            PictureBoxMain.Location = new System.Drawing.Point(14, 78);
            PictureBoxMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PictureBoxMain.Name = "PictureBoxMain";
            PictureBoxMain.Size = new System.Drawing.Size(48, 48);
            PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            PictureBoxMain.TabIndex = 6;
            PictureBoxMain.TabStop = false;
            // 
            // FormUsuarioInicioSesion
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(379, 153);
            ControlBox = false;
            Controls.Add(ToolStripMain);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxNombre);
            Controls.Add(LabelPassword);
            Controls.Add(LabelNombre);
            Controls.Add(PictureBoxMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsuarioInicioSesion";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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