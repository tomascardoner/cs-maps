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
            Label LabelCreacion;
            Label LabelModificacion;
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
            TableLayoutPanelAuditoria = new TableLayoutPanel();
            LabelNotas = new Label();
            TextBoxNotas = new TextBox();
            CheckBoxEsActivo = new CheckBox();
            LabelId = new Label();
            TextBoxId = new TextBox();
            TextBoxFechaHoraCreacion = new TextBox();
            TextBoxUsuarioCreacion = new TextBox();
            TextBoxFechaHoraUltimaModificacion = new TextBox();
            TextBoxUsuarioUltimaModificacion = new TextBox();
            TableLayoutPanelGeneral = new TableLayoutPanel();
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
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ButtonCerrar, ButtonEditar, ButtonCancelar, ButtonGuardar });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(590, 39);
            ToolStripMain.TabIndex = 1;
            // 
            // ButtonCerrar
            // 
            ButtonCerrar.Alignment = ToolStripItemAlignment.Right;
            ButtonCerrar.Image = Properties.Resources.ImageClose32;
            ButtonCerrar.ImageScaling = ToolStripItemImageScaling.None;
            ButtonCerrar.ImageTransparentColor = Color.Magenta;
            ButtonCerrar.Name = "ButtonCerrar";
            ButtonCerrar.Size = new Size(85, 36);
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
            ButtonEditar.Size = new Size(84, 36);
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
            ButtonCancelar.Size = new Size(102, 36);
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
            ButtonGuardar.Size = new Size(98, 36);
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
            TabControlMain.Size = new Size(590, 229);
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
            TabPageGeneral.Size = new Size(582, 193);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Dock = DockStyle.Fill;
            TextBoxNombre.Location = new Point(79, 3);
            TextBoxNombre.Margin = new Padding(4, 3, 4, 3);
            TextBoxNombre.MaxLength = 50;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(491, 27);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Location = new Point(4, 0);
            LabelNombre.Margin = new Padding(4, 0, 4, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(67, 33);
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
            TabPageNotasAuditoria.Size = new Size(582, 193);
            TabPageNotasAuditoria.TabIndex = 1;
            TabPageNotasAuditoria.Text = "Notas y Auditoría";
            TabPageNotasAuditoria.UseVisualStyleBackColor = true;
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
            TableLayoutPanelAuditoria.Size = new Size(574, 187);
            TableLayoutPanelAuditoria.TabIndex = 0;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Dock = DockStyle.Fill;
            LabelNotas.Location = new Point(4, 0);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(147, 65);
            LabelNotas.TabIndex = 0;
            LabelNotas.Text = "Notas:";
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
            TextBoxNotas.Size = new Size(411, 59);
            TextBoxNotas.TabIndex = 1;
            // 
            // LabelEsActivo
            // 
            LabelEsActivo.AutoSize = true;
            LabelEsActivo.Dock = DockStyle.Fill;
            LabelEsActivo.Location = new Point(4, 65);
            LabelEsActivo.Margin = new Padding(4, 0, 4, 0);
            LabelEsActivo.Name = "LabelEsActivo";
            LabelEsActivo.Size = new Size(147, 23);
            LabelEsActivo.TabIndex = 2;
            LabelEsActivo.Text = "Activo:";
            LabelEsActivo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CheckBoxEsActivo
            // 
            CheckBoxEsActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CheckBoxEsActivo.AutoSize = true;
            CheckBoxEsActivo.Location = new Point(159, 68);
            CheckBoxEsActivo.Margin = new Padding(4, 3, 4, 3);
            CheckBoxEsActivo.Name = "CheckBoxEsActivo";
            CheckBoxEsActivo.Size = new Size(18, 17);
            CheckBoxEsActivo.TabIndex = 3;
            CheckBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Dock = DockStyle.Fill;
            LabelId.Location = new Point(4, 88);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(147, 33);
            LabelId.TabIndex = 4;
            LabelId.Text = "Id:";
            LabelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(159, 91);
            TextBoxId.Margin = new Padding(4, 3, 4, 3);
            TextBoxId.MaxLength = 10;
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(83, 27);
            TextBoxId.TabIndex = 5;
            TextBoxId.TabStop = false;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelCreacion
            // 
            LabelCreacion.AutoSize = true;
            LabelCreacion.Dock = DockStyle.Fill;
            LabelCreacion.Location = new Point(4, 121);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(147, 33);
            LabelCreacion.TabIndex = 6;
            LabelCreacion.Text = "Creación:";
            LabelCreacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxFechaHoraCreacion
            // 
            TextBoxFechaHoraCreacion.Location = new Point(159, 124);
            TextBoxFechaHoraCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraCreacion.MaxLength = 0;
            TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            TextBoxFechaHoraCreacion.ReadOnly = true;
            TextBoxFechaHoraCreacion.Size = new Size(140, 27);
            TextBoxFechaHoraCreacion.TabIndex = 7;
            TextBoxFechaHoraCreacion.TabStop = false;
            // 
            // TextBoxUsuarioCreacion
            // 
            TextBoxUsuarioCreacion.Dock = DockStyle.Fill;
            TextBoxUsuarioCreacion.Location = new Point(307, 124);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(263, 27);
            TextBoxUsuarioCreacion.TabIndex = 8;
            TextBoxUsuarioCreacion.TabStop = false;
            // 
            // LabelModificacion
            // 
            LabelModificacion.AutoSize = true;
            LabelModificacion.Dock = DockStyle.Fill;
            LabelModificacion.Location = new Point(4, 154);
            LabelModificacion.Margin = new Padding(4, 0, 4, 0);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new Size(147, 33);
            LabelModificacion.TabIndex = 9;
            LabelModificacion.Text = "Última modificación:";
            LabelModificacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxFechaHoraUltimaModificacion
            // 
            TextBoxFechaHoraUltimaModificacion.Location = new Point(159, 157);
            TextBoxFechaHoraUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxFechaHoraUltimaModificacion.MaxLength = 0;
            TextBoxFechaHoraUltimaModificacion.Name = "TextBoxFechaHoraUltimaModificacion";
            TextBoxFechaHoraUltimaModificacion.ReadOnly = true;
            TextBoxFechaHoraUltimaModificacion.Size = new Size(140, 27);
            TextBoxFechaHoraUltimaModificacion.TabIndex = 10;
            TextBoxFechaHoraUltimaModificacion.TabStop = false;
            // 
            // TextBoxUsuarioUltimaModificacion
            // 
            TextBoxUsuarioUltimaModificacion.Dock = DockStyle.Fill;
            TextBoxUsuarioUltimaModificacion.Location = new Point(307, 157);
            TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            TextBoxUsuarioUltimaModificacion.Size = new Size(263, 27);
            TextBoxUsuarioUltimaModificacion.TabIndex = 11;
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
            TableLayoutPanelGeneral.Dock = DockStyle.Fill;
            TableLayoutPanelGeneral.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelGeneral.Location = new Point(4, 3);
            TableLayoutPanelGeneral.Name = "TableLayoutPanelGeneral";
            TableLayoutPanelGeneral.RowCount = 2;
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelGeneral.Size = new Size(574, 187);
            TableLayoutPanelGeneral.TabIndex = 2;
            // 
            // FormUserGroup
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(590, 268);
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
            TableLayoutPanelAuditoria.ResumeLayout(false);
            TableLayoutPanelAuditoria.PerformLayout();
            TableLayoutPanelGeneral.ResumeLayout(false);
            TableLayoutPanelGeneral.PerformLayout();
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
        private TableLayoutPanel TableLayoutPanelAuditoria;
        internal Label LabelNotas;
        internal TextBox TextBoxNotas;
        internal CheckBox CheckBoxEsActivo;
        private Label LabelId;
        private TextBox TextBoxId;
        internal TextBox TextBoxFechaHoraCreacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxUsuarioUltimaModificacion;
        private TableLayoutPanel TableLayoutPanelGeneral;
    }
}