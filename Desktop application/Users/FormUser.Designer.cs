namespace CSMaps.Users
{
    partial class FormUser
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
            Label LabelGenero;
            Label LabelUsuarioGrupo;
            Label LabelEsActivo;
            Label LabelModificacion;
            Label LabelCreacion;
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            TabControlMain = new TabControl();
            TabPageGeneral = new TabPage();
            ComboBoxGenero = new ComboBox();
            TextBoxPassword = new TextBox();
            LabelPassword = new Label();
            TextBoxDescripcion = new TextBox();
            LabelDescripcion = new Label();
            ComboBoxUsuarioGrupo = new ComboBox();
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
            LabelGenero = new Label();
            LabelUsuarioGrupo = new Label();
            LabelEsActivo = new Label();
            LabelModificacion = new Label();
            LabelCreacion = new Label();
            ToolStripMain.SuspendLayout();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TabPageNotasAuditoria.SuspendLayout();
            SuspendLayout();
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Location = new Point(8, 100);
            LabelGenero.Margin = new Padding(4, 0, 4, 0);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(48, 15);
            LabelGenero.TabIndex = 6;
            LabelGenero.Text = "Género:";
            // 
            // LabelUsuarioGrupo
            // 
            LabelUsuarioGrupo.AutoSize = true;
            LabelUsuarioGrupo.Location = new Point(8, 131);
            LabelUsuarioGrupo.Margin = new Padding(4, 0, 4, 0);
            LabelUsuarioGrupo.Name = "LabelUsuarioGrupo";
            LabelUsuarioGrupo.Size = new Size(43, 15);
            LabelUsuarioGrupo.TabIndex = 8;
            LabelUsuarioGrupo.Text = "Grupo:";
            // 
            // LabelEsActivo
            // 
            LabelEsActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelEsActivo.AutoSize = true;
            LabelEsActivo.Location = new Point(8, 78);
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
            LabelModificacion.Location = new Point(8, 168);
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
            LabelCreacion.Location = new Point(8, 138);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(57, 15);
            LabelCreacion.TabIndex = 6;
            LabelCreacion.Text = "Creación:";
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonClose, ToolStripButtonEdit, ToolStripButtonCancel, ToolStripButtonSave });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(574, 39);
            ToolStripMain.TabIndex = 1;
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
            TabControlMain.Size = new Size(574, 225);
            TabControlMain.TabIndex = 0;
            TabControlMain.TabStop = false;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(ComboBoxGenero);
            TabPageGeneral.Controls.Add(LabelGenero);
            TabPageGeneral.Controls.Add(TextBoxPassword);
            TabPageGeneral.Controls.Add(LabelPassword);
            TabPageGeneral.Controls.Add(TextBoxDescripcion);
            TabPageGeneral.Controls.Add(LabelDescripcion);
            TabPageGeneral.Controls.Add(ComboBoxUsuarioGrupo);
            TabPageGeneral.Controls.Add(LabelUsuarioGrupo);
            TabPageGeneral.Controls.Add(TextBoxNombre);
            TabPageGeneral.Controls.Add(LabelNombre);
            TabPageGeneral.Location = new Point(4, 27);
            TabPageGeneral.Margin = new Padding(4, 3, 4, 3);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(4, 3, 4, 3);
            TabPageGeneral.Size = new Size(566, 194);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(92, 97);
            ComboBoxGenero.Margin = new Padding(4, 3, 4, 3);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(118, 23);
            ComboBoxGenero.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(92, 67);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.MaxLength = 30;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(296, 23);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.Enter += TextBoxs_Enter;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(8, 70);
            LabelPassword.Margin = new Padding(4, 0, 4, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(70, 15);
            LabelPassword.TabIndex = 4;
            LabelPassword.Text = "Contraseña:";
            // 
            // TextBoxDescripcion
            // 
            TextBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxDescripcion.Location = new Point(92, 37);
            TextBoxDescripcion.Margin = new Padding(4, 3, 4, 3);
            TextBoxDescripcion.MaxLength = 50;
            TextBoxDescripcion.Name = "TextBoxDescripcion";
            TextBoxDescripcion.Size = new Size(462, 23);
            TextBoxDescripcion.TabIndex = 3;
            TextBoxDescripcion.Enter += TextBoxs_Enter;
            // 
            // LabelDescripcion
            // 
            LabelDescripcion.AutoSize = true;
            LabelDescripcion.Location = new Point(8, 40);
            LabelDescripcion.Margin = new Padding(4, 0, 4, 0);
            LabelDescripcion.Name = "LabelDescripcion";
            LabelDescripcion.Size = new Size(72, 15);
            LabelDescripcion.TabIndex = 2;
            LabelDescripcion.Text = "Descripción:";
            // 
            // ComboBoxUsuarioGrupo
            // 
            ComboBoxUsuarioGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxUsuarioGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUsuarioGrupo.FormattingEnabled = true;
            ComboBoxUsuarioGrupo.Location = new Point(92, 128);
            ComboBoxUsuarioGrupo.Margin = new Padding(4, 3, 4, 3);
            ComboBoxUsuarioGrupo.Name = "ComboBoxUsuarioGrupo";
            ComboBoxUsuarioGrupo.Size = new Size(462, 23);
            ComboBoxUsuarioGrupo.TabIndex = 9;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.CharacterCasing = CharacterCasing.Lower;
            TextBoxNombre.Location = new Point(92, 7);
            TextBoxNombre.Margin = new Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 30;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(223, 23);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            TextBoxNombre.Leave += TextboxNombre_Leave;
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
            TabPageNotasAuditoria.Size = new Size(566, 194);
            TabPageNotasAuditoria.TabIndex = 1;
            TabPageNotasAuditoria.Text = "Notas y Auditoría";
            TabPageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // LabelId
            // 
            LabelId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelId.AutoSize = true;
            LabelId.Location = new Point(8, 108);
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
            CheckBoxEsActivo.Location = new Point(134, 79);
            CheckBoxEsActivo.Margin = new Padding(4, 3, 4, 3);
            CheckBoxEsActivo.Name = "CheckBoxEsActivo";
            CheckBoxEsActivo.Size = new Size(15, 14);
            CheckBoxEsActivo.TabIndex = 3;
            CheckBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // TextBoxId
            // 
            TextBoxId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxId.Location = new Point(134, 105);
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
            TextBoxUsuarioModificacion.Location = new Point(282, 165);
            TextBoxUsuarioModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioModificacion.MaxLength = 50;
            TextBoxUsuarioModificacion.Name = "TextBoxUsuarioModificacion";
            TextBoxUsuarioModificacion.ReadOnly = true;
            TextBoxUsuarioModificacion.Size = new Size(276, 23);
            TextBoxUsuarioModificacion.TabIndex = 11;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUsuarioCreacion.Location = new Point(282, 135);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(276, 23);
            TextBoxUsuarioCreacion.TabIndex = 8;
            // 
            // TextBoxFechaHoraModificacion
            // 
            TextBoxFechaHoraModificacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxFechaHoraModificacion.Location = new Point(134, 165);
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
            TextBoxFechaHoraCreacion.Location = new Point(134, 135);
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
            TextBoxNotas.Location = new Point(134, 7);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(424, 66);
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
            // FormUser
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(574, 264);
            Controls.Add(TabControlMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUser";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
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
        internal System.Windows.Forms.ToolStripButton ToolStripButtonClose;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonEdit;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonCancel;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonSave;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageGeneral;
        internal System.Windows.Forms.ComboBox ComboBoxGenero;
        internal System.Windows.Forms.TextBox TextBoxPassword;
        internal System.Windows.Forms.Label LabelPassword;
        internal System.Windows.Forms.TextBox TextBoxDescripcion;
        internal System.Windows.Forms.Label LabelDescripcion;
        internal System.Windows.Forms.ComboBox ComboBoxUsuarioGrupo;
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