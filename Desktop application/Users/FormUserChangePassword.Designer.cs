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
            LabelPasswordNueva = new Label();
            LabelPasswordAnterior = new Label();
            TextBoxPasswordConfirma = new TextBox();
            LabelPasswordConfirma = new Label();
            TableLayoutPanelMain = new TableLayoutPanel();
            ToolStripMain.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ButtonCancelar, ButtonAceptar });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(419, 39);
            ToolStripMain.TabIndex = 1;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Alignment = ToolStripItemAlignment.Right;
            ButtonCancelar.Image = Properties.Resources.ImageCancel32;
            ButtonCancelar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonCancelar.ImageTransparentColor = Color.Magenta;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(102, 36);
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
            ButtonAceptar.Size = new Size(97, 36);
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.Click += Aceptar_Click;
            // 
            // TextBoxPasswordNueva
            // 
            TextBoxPasswordNueva.Dock = DockStyle.Fill;
            TextBoxPasswordNueva.Location = new Point(85, 54);
            TextBoxPasswordNueva.Margin = new Padding(4, 3, 4, 3);
            TextBoxPasswordNueva.MaxLength = 30;
            TextBoxPasswordNueva.Name = "TextBoxPasswordNueva";
            TextBoxPasswordNueva.Size = new Size(330, 27);
            TextBoxPasswordNueva.TabIndex = 3;
            TextBoxPasswordNueva.UseSystemPasswordChar = true;
            TextBoxPasswordNueva.Enter += TextBoxs_Enter;
            TextBoxPasswordNueva.Leave += TextBoxs_Leave;
            // 
            // TextBoxPasswordAnterior
            // 
            TextBoxPasswordAnterior.Dock = DockStyle.Fill;
            TextBoxPasswordAnterior.Location = new Point(85, 3);
            TextBoxPasswordAnterior.Margin = new Padding(4, 3, 4, 3);
            TextBoxPasswordAnterior.MaxLength = 30;
            TextBoxPasswordAnterior.Name = "TextBoxPasswordAnterior";
            TextBoxPasswordAnterior.Size = new Size(330, 27);
            TextBoxPasswordAnterior.TabIndex = 1;
            TextBoxPasswordAnterior.UseSystemPasswordChar = true;
            TextBoxPasswordAnterior.Enter += TextBoxs_Enter;
            TextBoxPasswordAnterior.Leave += TextBoxs_Leave;
            // 
            // LabelPasswordNueva
            // 
            LabelPasswordNueva.AutoSize = true;
            LabelPasswordNueva.Dock = DockStyle.Fill;
            LabelPasswordNueva.Location = new Point(4, 51);
            LabelPasswordNueva.Margin = new Padding(4, 0, 4, 0);
            LabelPasswordNueva.Name = "LabelPasswordNueva";
            LabelPasswordNueva.Size = new Size(73, 51);
            LabelPasswordNueva.TabIndex = 2;
            LabelPasswordNueva.Text = "Nueva:";
            // 
            // LabelPasswordAnterior
            // 
            LabelPasswordAnterior.AutoSize = true;
            LabelPasswordAnterior.Dock = DockStyle.Fill;
            LabelPasswordAnterior.Location = new Point(4, 0);
            LabelPasswordAnterior.Margin = new Padding(4, 0, 4, 0);
            LabelPasswordAnterior.Name = "LabelPasswordAnterior";
            LabelPasswordAnterior.Size = new Size(73, 51);
            LabelPasswordAnterior.TabIndex = 0;
            LabelPasswordAnterior.Text = "Anterior:";
            // 
            // TextBoxPasswordConfirma
            // 
            TextBoxPasswordConfirma.Dock = DockStyle.Fill;
            TextBoxPasswordConfirma.Location = new Point(85, 105);
            TextBoxPasswordConfirma.Margin = new Padding(4, 3, 4, 3);
            TextBoxPasswordConfirma.MaxLength = 30;
            TextBoxPasswordConfirma.Name = "TextBoxPasswordConfirma";
            TextBoxPasswordConfirma.Size = new Size(330, 27);
            TextBoxPasswordConfirma.TabIndex = 5;
            TextBoxPasswordConfirma.UseSystemPasswordChar = true;
            TextBoxPasswordConfirma.Enter += TextBoxs_Enter;
            TextBoxPasswordConfirma.Leave += TextBoxs_Leave;
            // 
            // LabelPasswordConfirma
            // 
            LabelPasswordConfirma.AutoSize = true;
            LabelPasswordConfirma.Dock = DockStyle.Fill;
            LabelPasswordConfirma.Location = new Point(4, 102);
            LabelPasswordConfirma.Margin = new Padding(4, 0, 4, 0);
            LabelPasswordConfirma.Name = "LabelPasswordConfirma";
            LabelPasswordConfirma.Size = new Size(73, 55);
            LabelPasswordConfirma.TabIndex = 4;
            LabelPasswordConfirma.Text = "Confirma:";
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.AutoSize = true;
            TableLayoutPanelMain.ColumnCount = 2;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(LabelPasswordAnterior, 0, 0);
            TableLayoutPanelMain.Controls.Add(TextBoxPasswordAnterior, 1, 0);
            TableLayoutPanelMain.Controls.Add(LabelPasswordNueva, 0, 1);
            TableLayoutPanelMain.Controls.Add(TextBoxPasswordNueva, 1, 1);
            TableLayoutPanelMain.Controls.Add(LabelPasswordConfirma, 0, 2);
            TableLayoutPanelMain.Controls.Add(TextBoxPasswordConfirma, 1, 2);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelMain.Location = new Point(0, 39);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 3;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            TableLayoutPanelMain.Size = new Size(419, 157);
            TableLayoutPanelMain.TabIndex = 0;
            // 
            // FormUserChangePassword
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(419, 196);
            ControlBox = false;
            Controls.Add(TableLayoutPanelMain);
            Controls.Add(ToolStripMain);
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
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal System.Windows.Forms.ToolStripButton ButtonCancelar;
        internal System.Windows.Forms.ToolStripButton ButtonAceptar;
        internal System.Windows.Forms.Label LabelPasswordNueva;
        internal System.Windows.Forms.Label LabelPasswordAnterior;
        internal System.Windows.Forms.Label LabelPasswordConfirma;
        private TableLayoutPanel TableLayoutPanelMain;
        private TextBox TextBoxPasswordNueva;
        private TextBox TextBoxPasswordAnterior;
        private TextBox TextBoxPasswordConfirma;
    }
}