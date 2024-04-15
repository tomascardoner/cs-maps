namespace CSMaps.Users
{
    partial class FormUserGroup
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
            Label LabelEsActivo;
            Label LabelModificacion;
            Label LabelCreacion;
            ToolStripMain = new ToolStrip();
            ButtonCerrar = new ToolStripButton();
            ButtonEditar = new ToolStripButton();
            ButtonCancelar = new ToolStripButton();
            ButtonGuardar = new ToolStripButton();
            TabControlMain = new TabControl();
            TabPageGeneral = new TabPage();
            TextBoxNombre = new TextBox();
            LabelNombre = new Label();
            TabPageNotasAuditoria = new TabPage();
            LabelId = new Label();
            CheckBoxEsActivo = new CheckBox();
            TextBoxId = new TextBox();
            TextBoxUsuarioModificacion = new TextBox();
            TextBoxUsuarioCreacion = new TextBox();
            TextBoxFechaHoraModificacion = new TextBox();
            TextBoxFechaHoraCreacion = new TextBox();
            TextBoxNotas = new TextBox();
            LabelNotas = new Label();
            LabelEsActivo = new Label();
            LabelModificacion = new Label();
            LabelCreacion = new Label();
            ToolStripMain.SuspendLayout();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TabPageNotasAuditoria.SuspendLayout();
            SuspendLayout();
            // 
            // LabelEsActivo
            // 
            LabelEsActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelEsActivo.AutoSize = true;
            LabelEsActivo.Location = new Point(12, 56);
            LabelEsActivo.Margin = new Padding(4, 0, 4, 0);
            LabelEsActivo.Name = "LabelEsActivo";
            LabelEsActivo.Size = new Size(44, 15);
            LabelEsActivo.TabIndex = 2;
            LabelEsActivo.Text = "Activo:";
            // 
            // LabelModificacion
            // 
            LabelModificacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelModificacion.AutoSize = true;
            LabelModificacion.Location = new Point(12, 146);
            LabelModificacion.Margin = new Padding(4, 0, 4, 0);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new Size(118, 15);
            LabelModificacion.TabIndex = 9;
            LabelModificacion.Text = "Ultima Modificación:";
            // 
            // LabelCreacion
            // 
            LabelCreacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelCreacion.AutoSize = true;
            LabelCreacion.Location = new Point(12, 116);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(57, 15);
            LabelCreacion.TabIndex = 6;
            LabelCreacion.Text = "Creación:";
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ButtonCerrar, ButtonEditar, ButtonCancelar, ButtonGuardar });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(574, 39);
            ToolStripMain.TabIndex = 1;
            // 
            // ButtonCerrar
            // 
            ButtonCerrar.Alignment = ToolStripItemAlignment.Right;
            ButtonCerrar.Image = Properties.Resources.ImageClose32;
            ButtonCerrar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonCerrar.ImageTransparentColor = Color.Magenta;
            ButtonCerrar.Name = "ButtonCerrar";
            ButtonCerrar.Size = new Size(75, 36);
            ButtonCerrar.Text = "Cerrar";
            ButtonCerrar.Click += Cerrar_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.Alignment = ToolStripItemAlignment.Right;
            ButtonEditar.Image = Properties.Resources.ImageItemEdit32;
            ButtonEditar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonEditar.ImageTransparentColor = Color.Magenta;
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(73, 36);
            ButtonEditar.Text = "Editar";
            ButtonEditar.Click += Editar_Click;
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
            // ButtonGuardar
            // 
            ButtonGuardar.Alignment = ToolStripItemAlignment.Right;
            ButtonGuardar.Image = Properties.Resources.ImageOk32;
            ButtonGuardar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonGuardar.ImageTransparentColor = Color.Magenta;
            ButtonGuardar.Name = "ButtonGuardar";
            ButtonGuardar.Size = new Size(85, 36);
            ButtonGuardar.Text = "Guardar";
            ButtonGuardar.Click += Guardar_Click;
            // 
            // TabControlMain
            // 
            TabControlMain.Appearance = TabAppearance.FlatButtons;
            TabControlMain.Controls.Add(TabPageGeneral);
            TabControlMain.Controls.Add(TabPageNotasAuditoria);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 39);
            TabControlMain.Margin = new Padding(4, 3, 4, 3);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(574, 205);
            TabControlMain.TabIndex = 0;
            TabControlMain.TabStop = false;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TextBoxNombre);
            TabPageGeneral.Controls.Add(LabelNombre);
            TabPageGeneral.Location = new Point(4, 27);
            TabPageGeneral.Margin = new Padding(4, 3, 4, 3);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(4, 3, 4, 3);
            TabPageGeneral.Size = new Size(566, 174);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNombre.Location = new Point(92, 7);
            TextBoxNombre.Margin = new Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 50;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(465, 23);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(8, 10);
            LabelNombre.Margin = new Padding(4, 0, 4, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(54, 15);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            // 
            // TabPageNotasAuditoria
            // 
            TabPageNotasAuditoria.Controls.Add(LabelId);
            TabPageNotasAuditoria.Controls.Add(CheckBoxEsActivo);
            TabPageNotasAuditoria.Controls.Add(TextBoxId);
            TabPageNotasAuditoria.Controls.Add(LabelEsActivo);
            TabPageNotasAuditoria.Controls.Add(TextBoxUsuarioModificacion);
            TabPageNotasAuditoria.Controls.Add(TextBoxUsuarioCreacion);
            TabPageNotasAuditoria.Controls.Add(TextBoxFechaHoraModificacion);
            TabPageNotasAuditoria.Controls.Add(TextBoxFechaHoraCreacion);
            TabPageNotasAuditoria.Controls.Add(LabelModificacion);
            TabPageNotasAuditoria.Controls.Add(LabelCreacion);
            TabPageNotasAuditoria.Controls.Add(TextBoxNotas);
            TabPageNotasAuditoria.Controls.Add(LabelNotas);
            TabPageNotasAuditoria.Location = new Point(4, 27);
            TabPageNotasAuditoria.Margin = new Padding(4, 3, 4, 3);
            TabPageNotasAuditoria.Name = "TabPageNotasAuditoria";
            TabPageNotasAuditoria.Padding = new Padding(4, 3, 4, 3);
            TabPageNotasAuditoria.Size = new Size(566, 174);
            TabPageNotasAuditoria.TabIndex = 1;
            TabPageNotasAuditoria.Text = "Notas y Auditoría";
            TabPageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // LabelId
            // 
            LabelId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelId.AutoSize = true;
            LabelId.Location = new Point(12, 86);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(20, 15);
            LabelId.TabIndex = 4;
            LabelId.Text = "Id:";
            // 
            // CheckBoxEsActivo
            // 
            CheckBoxEsActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CheckBoxEsActivo.AutoSize = true;
            CheckBoxEsActivo.Location = new Point(139, 57);
            CheckBoxEsActivo.Margin = new Padding(4, 3, 4, 3);
            CheckBoxEsActivo.Name = "CheckBoxEsActivo";
            CheckBoxEsActivo.Size = new Size(15, 14);
            CheckBoxEsActivo.TabIndex = 3;
            CheckBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // TextBoxId
            // 
            TextBoxId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxId.Location = new Point(138, 83);
            TextBoxId.Margin = new Padding(4, 3, 4, 3);
            TextBoxId.MaxLength = 10;
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(83, 23);
            TextBoxId.TabIndex = 5;
            TextBoxId.TabStop = false;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxUsuarioModificacion
            // 
            TextBoxUsuarioModificacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioModificacion.Location = new Point(287, 143);
            TextBoxUsuarioModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioModificacion.MaxLength = 50;
            TextBoxUsuarioModificacion.Name = "TextBoxUsuarioModificacion";
            TextBoxUsuarioModificacion.ReadOnly = true;
            TextBoxUsuarioModificacion.Size = new Size(271, 23);
            TextBoxUsuarioModificacion.TabIndex = 11;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioCreacion.Location = new Point(287, 113);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(271, 23);
            TextBoxUsuarioCreacion.TabIndex = 8;
            // 
            // TextBoxFechaHoraModificacion
            // 
            TextBoxFechaHoraModificacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxFechaHoraModificacion.Location = new Point(138, 143);
            TextBoxFechaHoraModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraModificacion.MaxLength = 0;
            TextBoxFechaHoraModificacion.Name = "TextBoxFechaHoraModificacion";
            TextBoxFechaHoraModificacion.ReadOnly = true;
            TextBoxFechaHoraModificacion.Size = new Size(140, 23);
            TextBoxFechaHoraModificacion.TabIndex = 10;
            // 
            // TextBoxFechaHoraCreacion
            // 
            TextBoxFechaHoraCreacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxFechaHoraCreacion.Location = new Point(138, 113);
            TextBoxFechaHoraCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraCreacion.MaxLength = 0;
            TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            TextBoxFechaHoraCreacion.ReadOnly = true;
            TextBoxFechaHoraCreacion.Size = new Size(140, 23);
            TextBoxFechaHoraCreacion.TabIndex = 7;
            // 
            // TextBoxNotas
            // 
            TextBoxNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNotas.Location = new Point(138, 7);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(416, 44);
            TextBoxNotas.TabIndex = 1;
            TextBoxNotas.Enter += TextBoxs_Enter;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Location = new Point(8, 10);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(41, 15);
            LabelNotas.TabIndex = 0;
            LabelNotas.Text = "Notas:";
            // 
            // FormUserGroup
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(574, 244);
            Controls.Add(TabControlMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUserGroup";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Grupo de usuarios";
            FormClosed += This_FormClosed;
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            TabControlMain.ResumeLayout(false);
            TabPageGeneral.ResumeLayout(false);
            TabPageGeneral.PerformLayout();
            TabPageNotasAuditoria.ResumeLayout(false);
            TabPageNotasAuditoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal System.Windows.Forms.ToolStripButton ButtonCerrar;
        internal System.Windows.Forms.ToolStripButton ButtonEditar;
        internal System.Windows.Forms.ToolStripButton ButtonCancelar;
        internal System.Windows.Forms.ToolStripButton ButtonGuardar;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageGeneral;
        internal System.Windows.Forms.TextBox TextBoxNombre;
        internal System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TabPage TabPageNotasAuditoria;
        internal System.Windows.Forms.Label LabelId;
        internal System.Windows.Forms.CheckBox CheckBoxEsActivo;
        internal System.Windows.Forms.TextBox TextBoxId;
        internal System.Windows.Forms.TextBox TextBoxUsuarioModificacion;
        internal System.Windows.Forms.TextBox TextBoxUsuarioCreacion;
        internal System.Windows.Forms.TextBox TextBoxFechaHoraModificacion;
        internal System.Windows.Forms.TextBox TextBoxFechaHoraCreacion;
        internal System.Windows.Forms.TextBox TextBoxNotas;
        internal System.Windows.Forms.Label LabelNotas;
    }
}