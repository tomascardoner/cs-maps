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
            Label LabelCreacion;
            Label LabelModificacion;
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
            CheckBoxEsActivo = new CheckBox();
            TextBoxNotas = new TextBox();
            LabelNotas = new Label();
            TableLayoutPanelAuditoria = new TableLayoutPanel();
            LabelId = new Label();
            TextBoxId = new TextBox();
            TextBoxFechaHoraCreacion = new TextBox();
            TextBoxUsuarioCreacion = new TextBox();
            TextBoxFechaHoraUltimaModificacion = new TextBox();
            TextBoxUsuarioUltimaModificacion = new TextBox();
            TableLayoutPanelGeneral = new TableLayoutPanel();
            LabelGenero = new Label();
            LabelUsuarioGrupo = new Label();
            LabelEsActivo = new Label();
            LabelCreacion = new Label();
            LabelModificacion = new Label();
            ToolStripMain.SuspendLayout();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TabPageNotasAuditoria.SuspendLayout();
            TableLayoutPanelAuditoria.SuspendLayout();
            TableLayoutPanelGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Dock = DockStyle.Fill;
            LabelGenero.Location = new Point(4, 99);
            LabelGenero.Margin = new Padding(4, 0, 4, 0);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(90, 34);
            LabelGenero.TabIndex = 6;
            LabelGenero.Text = "Género:";
            LabelGenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelUsuarioGrupo
            // 
            LabelUsuarioGrupo.AutoSize = true;
            LabelUsuarioGrupo.Dock = DockStyle.Fill;
            LabelUsuarioGrupo.Location = new Point(4, 133);
            LabelUsuarioGrupo.Margin = new Padding(4, 0, 4, 0);
            LabelUsuarioGrupo.Name = "LabelUsuarioGrupo";
            LabelUsuarioGrupo.Size = new Size(90, 34);
            LabelUsuarioGrupo.TabIndex = 8;
            LabelUsuarioGrupo.Text = "Grupo:";
            LabelUsuarioGrupo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelEsActivo
            // 
            LabelEsActivo.AutoSize = true;
            LabelEsActivo.Dock = DockStyle.Fill;
            LabelEsActivo.Location = new Point(4, 147);
            LabelEsActivo.Margin = new Padding(4, 0, 4, 0);
            LabelEsActivo.Name = "LabelEsActivo";
            LabelEsActivo.Size = new Size(147, 23);
            LabelEsActivo.TabIndex = 2;
            LabelEsActivo.Text = "Activo:";
            LabelEsActivo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
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
            ToolStripButtonClose.Size = new Size(85, 36);
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
            ToolStripButtonEdit.Size = new Size(84, 36);
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
            ToolStripButtonCancel.Size = new Size(102, 36);
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
            ToolStripButtonSave.Size = new Size(98, 36);
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
            TabControlMain.Size = new Size(574, 311);
            TabControlMain.TabIndex = 0;
            TabControlMain.TabStop = false;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TableLayoutPanelGeneral);
            TabPageGeneral.Location = new Point(4, 32);
            TabPageGeneral.Margin = new Padding(4, 3, 4, 3);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(4, 3, 4, 3);
            TabPageGeneral.Size = new Size(566, 275);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(102, 102);
            ComboBoxGenero.Margin = new Padding(4, 3, 4, 3);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(118, 28);
            ComboBoxGenero.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Dock = DockStyle.Fill;
            TextBoxPassword.Location = new Point(102, 69);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.MaxLength = 30;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(452, 27);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.Enter += TextBoxs_Enter;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Dock = DockStyle.Fill;
            LabelPassword.Location = new Point(4, 66);
            LabelPassword.Margin = new Padding(4, 0, 4, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(90, 33);
            LabelPassword.TabIndex = 4;
            LabelPassword.Text = "Contraseña:";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxDescripcion
            // 
            TextBoxDescripcion.Dock = DockStyle.Fill;
            TextBoxDescripcion.Location = new Point(102, 36);
            TextBoxDescripcion.Margin = new Padding(4, 3, 4, 3);
            TextBoxDescripcion.MaxLength = 50;
            TextBoxDescripcion.Name = "TextBoxDescripcion";
            TextBoxDescripcion.Size = new Size(452, 27);
            TextBoxDescripcion.TabIndex = 3;
            TextBoxDescripcion.Enter += TextBoxs_Enter;
            // 
            // LabelDescripcion
            // 
            LabelDescripcion.AutoSize = true;
            LabelDescripcion.Dock = DockStyle.Fill;
            LabelDescripcion.Location = new Point(4, 33);
            LabelDescripcion.Margin = new Padding(4, 0, 4, 0);
            LabelDescripcion.Name = "LabelDescripcion";
            LabelDescripcion.Size = new Size(90, 33);
            LabelDescripcion.TabIndex = 2;
            LabelDescripcion.Text = "Descripción:";
            LabelDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComboBoxUsuarioGrupo
            // 
            ComboBoxUsuarioGrupo.Dock = DockStyle.Fill;
            ComboBoxUsuarioGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUsuarioGrupo.FormattingEnabled = true;
            ComboBoxUsuarioGrupo.Location = new Point(102, 136);
            ComboBoxUsuarioGrupo.Margin = new Padding(4, 3, 4, 3);
            ComboBoxUsuarioGrupo.Name = "ComboBoxUsuarioGrupo";
            ComboBoxUsuarioGrupo.Size = new Size(452, 28);
            ComboBoxUsuarioGrupo.TabIndex = 9;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.CharacterCasing = CharacterCasing.Lower;
            TextBoxNombre.Dock = DockStyle.Fill;
            TextBoxNombre.Location = new Point(102, 3);
            TextBoxNombre.Margin = new Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 30;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(452, 27);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            TextBoxNombre.Leave += TextboxNombre_Leave;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Location = new Point(4, 0);
            LabelNombre.Margin = new Padding(4, 0, 4, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(90, 33);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TabPageNotasAuditoria
            // 
            TabPageNotasAuditoria.Controls.Add(TableLayoutPanelAuditoria);
            TabPageNotasAuditoria.Location = new Point(4, 32);
            TabPageNotasAuditoria.Margin = new Padding(4, 3, 4, 3);
            TabPageNotasAuditoria.Name = "TabPageNotasAuditoria";
            TabPageNotasAuditoria.Padding = new Padding(4, 3, 4, 3);
            TabPageNotasAuditoria.Size = new Size(566, 275);
            TabPageNotasAuditoria.TabIndex = 1;
            TabPageNotasAuditoria.Text = "Notas y Auditoría";
            TabPageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // CheckBoxEsActivo
            // 
            CheckBoxEsActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CheckBoxEsActivo.AutoSize = true;
            CheckBoxEsActivo.Location = new Point(159, 150);
            CheckBoxEsActivo.Margin = new Padding(4, 3, 4, 3);
            CheckBoxEsActivo.Name = "CheckBoxEsActivo";
            CheckBoxEsActivo.Size = new Size(18, 17);
            CheckBoxEsActivo.TabIndex = 3;
            CheckBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // TextBoxNotas
            // 
            TableLayoutPanelAuditoria.SetColumnSpan(TextBoxNotas, 2);
            TextBoxNotas.Dock = DockStyle.Fill;
            TextBoxNotas.Location = new Point(159, 3);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(395, 141);
            TextBoxNotas.TabIndex = 1;
            TextBoxNotas.Enter += TextBoxs_Enter;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Dock = DockStyle.Fill;
            LabelNotas.Location = new Point(4, 0);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(147, 147);
            LabelNotas.TabIndex = 0;
            LabelNotas.Text = "Notas:";
            // 
            // TableLayoutPanelAuditoria
            // 
            TableLayoutPanelAuditoria.AutoSize = true;
            TableLayoutPanelAuditoria.ColumnCount = 3;
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.Controls.Add(LabelNotas, 0, 0);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxNotas, 1, 0);
            TableLayoutPanelAuditoria.Controls.Add(LabelEsActivo, 0, 1);
            TableLayoutPanelAuditoria.Controls.Add(CheckBoxEsActivo, 1, 1);
            TableLayoutPanelAuditoria.Controls.Add(LabelId, 0, 2);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxId, 1, 2);
            TableLayoutPanelAuditoria.Controls.Add(LabelCreacion, 0, 3);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxFechaHoraCreacion, 1, 3);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxUsuarioCreacion, 2, 3);
            TableLayoutPanelAuditoria.Controls.Add(LabelModificacion, 0, 4);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxFechaHoraUltimaModificacion, 1, 4);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxUsuarioUltimaModificacion, 2, 4);
            TableLayoutPanelAuditoria.Dock = DockStyle.Fill;
            TableLayoutPanelAuditoria.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelAuditoria.Location = new Point(4, 3);
            TableLayoutPanelAuditoria.Name = "TableLayoutPanelAuditoria";
            TableLayoutPanelAuditoria.RowCount = 5;
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.Size = new Size(558, 269);
            TableLayoutPanelAuditoria.TabIndex = 9;
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Dock = DockStyle.Fill;
            LabelId.Location = new Point(4, 170);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(147, 33);
            LabelId.TabIndex = 0;
            LabelId.Text = "Id:";
            LabelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(159, 173);
            TextBoxId.Margin = new Padding(4, 3, 4, 3);
            TextBoxId.MaxLength = 10;
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(83, 27);
            TextBoxId.TabIndex = 1;
            TextBoxId.TabStop = false;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelCreacion
            // 
            LabelCreacion.AutoSize = true;
            LabelCreacion.Dock = DockStyle.Fill;
            LabelCreacion.Location = new Point(4, 203);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(147, 33);
            LabelCreacion.TabIndex = 2;
            LabelCreacion.Text = "Creación:";
            LabelCreacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxFechaHoraCreacion
            // 
            TextBoxFechaHoraCreacion.Location = new Point(159, 206);
            TextBoxFechaHoraCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraCreacion.MaxLength = 0;
            TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            TextBoxFechaHoraCreacion.ReadOnly = true;
            TextBoxFechaHoraCreacion.Size = new Size(140, 27);
            TextBoxFechaHoraCreacion.TabIndex = 3;
            TextBoxFechaHoraCreacion.TabStop = false;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Dock = DockStyle.Fill;
            TextBoxUsuarioCreacion.Location = new Point(307, 206);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(247, 27);
            TextBoxUsuarioCreacion.TabIndex = 4;
            TextBoxUsuarioCreacion.TabStop = false;
            // 
            // LabelModificacion
            // 
            LabelModificacion.AutoSize = true;
            LabelModificacion.Dock = DockStyle.Fill;
            LabelModificacion.Location = new Point(4, 236);
            LabelModificacion.Margin = new Padding(4, 0, 4, 0);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new Size(147, 33);
            LabelModificacion.TabIndex = 5;
            LabelModificacion.Text = "Última modificación:";
            LabelModificacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxFechaHoraUltimaModificacion
            // 
            TextBoxFechaHoraUltimaModificacion.Location = new Point(159, 239);
            TextBoxFechaHoraUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraUltimaModificacion.MaxLength = 0;
            TextBoxFechaHoraUltimaModificacion.Name = "TextBoxFechaHoraUltimaModificacion";
            TextBoxFechaHoraUltimaModificacion.ReadOnly = true;
            TextBoxFechaHoraUltimaModificacion.Size = new Size(140, 27);
            TextBoxFechaHoraUltimaModificacion.TabIndex = 6;
            TextBoxFechaHoraUltimaModificacion.TabStop = false;
            // 
            // TextBoxUsuarioUltimaModificacion
            // 
            TextBoxUsuarioUltimaModificacion.Dock = DockStyle.Fill;
            TextBoxUsuarioUltimaModificacion.Location = new Point(307, 239);
            TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            TextBoxUsuarioUltimaModificacion.Size = new Size(247, 27);
            TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            TextBoxUsuarioUltimaModificacion.TabStop = false;
            // 
            // TableLayoutPanelGeneral
            // 
            TableLayoutPanelGeneral.AutoSize = true;
            TableLayoutPanelGeneral.ColumnCount = 2;
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelGeneral.Controls.Add(LabelNombre, 0, 0);
            TableLayoutPanelGeneral.Controls.Add(TextBoxNombre, 1, 0);
            TableLayoutPanelGeneral.Controls.Add(LabelDescripcion, 0, 1);
            TableLayoutPanelGeneral.Controls.Add(TextBoxDescripcion, 1, 1);
            TableLayoutPanelGeneral.Controls.Add(LabelPassword, 0, 2);
            TableLayoutPanelGeneral.Controls.Add(TextBoxPassword, 1, 2);
            TableLayoutPanelGeneral.Controls.Add(LabelGenero, 0, 3);
            TableLayoutPanelGeneral.Controls.Add(ComboBoxGenero, 1, 3);
            TableLayoutPanelGeneral.Controls.Add(LabelUsuarioGrupo, 0, 4);
            TableLayoutPanelGeneral.Controls.Add(ComboBoxUsuarioGrupo, 1, 4);
            TableLayoutPanelGeneral.Dock = DockStyle.Fill;
            TableLayoutPanelGeneral.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelGeneral.Location = new Point(4, 3);
            TableLayoutPanelGeneral.Name = "TableLayoutPanelGeneral";
            TableLayoutPanelGeneral.RowCount = 6;
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelGeneral.Size = new Size(558, 269);
            TableLayoutPanelGeneral.TabIndex = 10;
            // 
            // FormUser
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(574, 350);
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
            TableLayoutPanelAuditoria.ResumeLayout(false);
            TableLayoutPanelAuditoria.PerformLayout();
            TableLayoutPanelGeneral.ResumeLayout(false);
            TableLayoutPanelGeneral.PerformLayout();
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
        internal System.Windows.Forms.CheckBox CheckBoxEsActivo;
        internal System.Windows.Forms.TextBox TextBoxNotas;
        internal System.Windows.Forms.Label LabelNotas;
        private TableLayoutPanel TableLayoutPanelAuditoria;
        private Label LabelId;
        private TextBox TextBoxId;
        internal TextBox TextBoxFechaHoraCreacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxUsuarioUltimaModificacion;
        private TableLayoutPanel TableLayoutPanelGeneral;
    }
}