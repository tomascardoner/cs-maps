namespace CSMaps.Users
{
    partial class FormUserChangePassword
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
            TextBoxPasswordNueva = new TextBox();
            TextBoxPasswordAnterior = new TextBox();
            LabelPassword = new Label();
            LabelPasswordAnterior = new Label();
            TextBoxPasswordConfirma = new TextBox();
            LabelPasswordConfirma = new Label();
            ToolStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ButtonCancelar, ButtonAceptar });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(410, 39);
            ToolStripMain.TabIndex = 6;
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
            // TextBoxPasswordNueva
            // 
            TextBoxPasswordNueva.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxPasswordNueva.Location = new Point(98, 90);
            TextBoxPasswordNueva.Margin = new Padding(4, 3, 4, 3);
            TextBoxPasswordNueva.MaxLength = 30;
            TextBoxPasswordNueva.Name = "TextBoxPasswordNueva";
            TextBoxPasswordNueva.Size = new Size(299, 23);
            TextBoxPasswordNueva.TabIndex = 3;
            TextBoxPasswordNueva.UseSystemPasswordChar = true;
            TextBoxPasswordNueva.Enter += TextBoxs_Enter;
            TextBoxPasswordNueva.Leave += TextBoxs_Leave;
            // 
            // TextBoxPasswordAnterior
            // 
            TextBoxPasswordAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxPasswordAnterior.Location = new Point(98, 52);
            TextBoxPasswordAnterior.Margin = new Padding(4, 3, 4, 3);
            TextBoxPasswordAnterior.MaxLength = 30;
            TextBoxPasswordAnterior.Name = "TextBoxPasswordAnterior";
            TextBoxPasswordAnterior.Size = new Size(299, 23);
            TextBoxPasswordAnterior.TabIndex = 1;
            TextBoxPasswordAnterior.UseSystemPasswordChar = true;
            TextBoxPasswordAnterior.Enter += TextBoxs_Enter;
            TextBoxPasswordAnterior.Leave += TextBoxs_Leave;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(18, 93);
            LabelPassword.Margin = new Padding(4, 0, 4, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(44, 15);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Nueva:";
            // 
            // LabelPasswordAnterior
            // 
            LabelPasswordAnterior.AutoSize = true;
            LabelPasswordAnterior.Location = new Point(18, 55);
            LabelPasswordAnterior.Margin = new Padding(4, 0, 4, 0);
            LabelPasswordAnterior.Name = "LabelPasswordAnterior";
            LabelPasswordAnterior.Size = new Size(53, 15);
            LabelPasswordAnterior.TabIndex = 0;
            LabelPasswordAnterior.Text = "Anterior:";
            // 
            // TextBoxPasswordConfirma
            // 
            TextBoxPasswordConfirma.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxPasswordConfirma.Location = new Point(100, 128);
            TextBoxPasswordConfirma.Margin = new Padding(4, 3, 4, 3);
            TextBoxPasswordConfirma.MaxLength = 30;
            TextBoxPasswordConfirma.Name = "TextBoxPasswordConfirma";
            TextBoxPasswordConfirma.Size = new Size(299, 23);
            TextBoxPasswordConfirma.TabIndex = 5;
            TextBoxPasswordConfirma.UseSystemPasswordChar = true;
            TextBoxPasswordConfirma.Enter += TextBoxs_Enter;
            TextBoxPasswordConfirma.Leave += TextBoxs_Leave;
            // 
            // LabelPasswordConfirma
            // 
            LabelPasswordConfirma.AutoSize = true;
            LabelPasswordConfirma.Location = new Point(18, 131);
            LabelPasswordConfirma.Margin = new Padding(4, 0, 4, 0);
            LabelPasswordConfirma.Name = "LabelPasswordConfirma";
            LabelPasswordConfirma.Size = new Size(60, 15);
            LabelPasswordConfirma.TabIndex = 4;
            LabelPasswordConfirma.Text = "Confirma:";
            // 
            // FormUserChangePassword
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(410, 166);
            ControlBox = false;
            Controls.Add(TextBoxPasswordConfirma);
            Controls.Add(LabelPasswordConfirma);
            Controls.Add(ToolStripMain);
            Controls.Add(TextBoxPasswordNueva);
            Controls.Add(TextBoxPasswordAnterior);
            Controls.Add(LabelPassword);
            Controls.Add(LabelPasswordAnterior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormUserChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cambio de contraseña";
            FormClosed += This_FormClosed;
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal System.Windows.Forms.ToolStripButton ButtonCancelar;
        internal System.Windows.Forms.ToolStripButton ButtonAceptar;
        internal System.Windows.Forms.TextBox TextBoxPasswordNueva;
        internal System.Windows.Forms.TextBox TextBoxPasswordAnterior;
        internal System.Windows.Forms.Label LabelPassword;
        internal System.Windows.Forms.Label LabelPasswordAnterior;
        internal System.Windows.Forms.TextBox TextBoxPasswordConfirma;
        internal System.Windows.Forms.Label LabelPasswordConfirma;
    }
}