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
            System.Windows.Forms.Label LabelEsActivo;
            System.Windows.Forms.Label LabelModificacion;
            System.Windows.Forms.Label LabelCreacion;
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ButtonCerrar = new System.Windows.Forms.ToolStripButton();
            this.ButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.ButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.ButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageGeneral = new System.Windows.Forms.TabPage();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TabPageNotasAuditoria = new System.Windows.Forms.TabPage();
            this.LabelId = new System.Windows.Forms.Label();
            this.CheckBoxEsActivo = new System.Windows.Forms.CheckBox();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.TextBoxUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.TextBoxUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.TextBoxFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.TextBoxFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.TextBoxNotas = new System.Windows.Forms.TextBox();
            this.LabelNotas = new System.Windows.Forms.Label();
            LabelEsActivo = new System.Windows.Forms.Label();
            LabelModificacion = new System.Windows.Forms.Label();
            LabelCreacion = new System.Windows.Forms.Label();
            this.ToolStripMain.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            this.TabPageGeneral.SuspendLayout();
            this.TabPageNotasAuditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelEsActivo
            // 
            LabelEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LabelEsActivo.AutoSize = true;
            LabelEsActivo.Location = new System.Drawing.Point(8, 81);
            LabelEsActivo.Name = "LabelEsActivo";
            LabelEsActivo.Size = new System.Drawing.Size(40, 13);
            LabelEsActivo.TabIndex = 2;
            LabelEsActivo.Text = "Activo:";
            // 
            // LabelModificacion
            // 
            LabelModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LabelModificacion.AutoSize = true;
            LabelModificacion.Location = new System.Drawing.Point(8, 159);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new System.Drawing.Size(102, 13);
            LabelModificacion.TabIndex = 9;
            LabelModificacion.Text = "Ultima Modificación:";
            // 
            // LabelCreacion
            // 
            LabelCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LabelCreacion.AutoSize = true;
            LabelCreacion.Location = new System.Drawing.Point(8, 133);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new System.Drawing.Size(52, 13);
            LabelCreacion.TabIndex = 6;
            LabelCreacion.Text = "Creación:";
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCerrar,
            this.ButtonEditar,
            this.ButtonCancelar,
            this.ButtonGuardar});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(492, 54);
            this.ToolStripMain.TabIndex = 1;
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonCerrar.Image = global::CSMaps.Properties.Resources.ImageClose32;
            this.ButtonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(43, 51);
            this.ButtonCerrar.Text = "Cerrar";
            this.ButtonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonEditar.Image = global::CSMaps.Properties.Resources.ImageItemEdit32;
            this.ButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(41, 51);
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonCancelar.Image = global::CSMaps.Properties.Resources.ImageCancel32;
            this.ButtonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(57, 51);
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonGuardar.Image = global::CSMaps.Properties.Resources.ImageOk32;
            this.ButtonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(53, 51);
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonGuardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlMain.Controls.Add(this.TabPageGeneral);
            this.TabControlMain.Controls.Add(this.TabPageNotasAuditoria);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(0, 54);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(492, 215);
            this.TabControlMain.TabIndex = 0;
            this.TabControlMain.TabStop = false;
            // 
            // TabPageGeneral
            // 
            this.TabPageGeneral.Controls.Add(this.TextBoxNombre);
            this.TabPageGeneral.Controls.Add(this.LabelNombre);
            this.TabPageGeneral.Location = new System.Drawing.Point(4, 25);
            this.TabPageGeneral.Name = "TabPageGeneral";
            this.TabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageGeneral.Size = new System.Drawing.Size(484, 186);
            this.TabPageGeneral.TabIndex = 0;
            this.TabPageGeneral.Text = "General";
            this.TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNombre.Location = new System.Drawing.Point(79, 6);
            this.TextBoxNombre.MaxLength = 50;
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(399, 20);
            this.TextBoxNombre.TabIndex = 1;
            this.TextBoxNombre.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(7, 9);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(47, 13);
            this.LabelNombre.TabIndex = 0;
            this.LabelNombre.Text = "Nombre:";
            // 
            // TabPageNotasAuditoria
            // 
            this.TabPageNotasAuditoria.Controls.Add(this.LabelId);
            this.TabPageNotasAuditoria.Controls.Add(this.CheckBoxEsActivo);
            this.TabPageNotasAuditoria.Controls.Add(this.TextBoxId);
            this.TabPageNotasAuditoria.Controls.Add(LabelEsActivo);
            this.TabPageNotasAuditoria.Controls.Add(this.TextBoxUsuarioModificacion);
            this.TabPageNotasAuditoria.Controls.Add(this.TextBoxUsuarioCreacion);
            this.TabPageNotasAuditoria.Controls.Add(this.TextBoxFechaHoraModificacion);
            this.TabPageNotasAuditoria.Controls.Add(this.TextBoxFechaHoraCreacion);
            this.TabPageNotasAuditoria.Controls.Add(LabelModificacion);
            this.TabPageNotasAuditoria.Controls.Add(LabelCreacion);
            this.TabPageNotasAuditoria.Controls.Add(this.TextBoxNotas);
            this.TabPageNotasAuditoria.Controls.Add(this.LabelNotas);
            this.TabPageNotasAuditoria.Location = new System.Drawing.Point(4, 25);
            this.TabPageNotasAuditoria.Name = "TabPageNotasAuditoria";
            this.TabPageNotasAuditoria.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNotasAuditoria.Size = new System.Drawing.Size(484, 186);
            this.TabPageNotasAuditoria.TabIndex = 1;
            this.TabPageNotasAuditoria.Text = "Notas y Auditoría";
            this.TabPageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // LabelId
            // 
            this.LabelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(8, 107);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(19, 13);
            this.LabelId.TabIndex = 4;
            this.LabelId.Text = "Id:";
            // 
            // CheckBoxEsActivo
            // 
            this.CheckBoxEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckBoxEsActivo.AutoSize = true;
            this.CheckBoxEsActivo.Location = new System.Drawing.Point(117, 80);
            this.CheckBoxEsActivo.Name = "CheckBoxEsActivo";
            this.CheckBoxEsActivo.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxEsActivo.TabIndex = 3;
            this.CheckBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // TextBoxId
            // 
            this.TextBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxId.Location = new System.Drawing.Point(116, 104);
            this.TextBoxId.MaxLength = 10;
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(72, 20);
            this.TextBoxId.TabIndex = 5;
            this.TextBoxId.TabStop = false;
            this.TextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxUsuarioModificacion
            // 
            this.TextBoxUsuarioModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsuarioModificacion.Location = new System.Drawing.Point(243, 156);
            this.TextBoxUsuarioModificacion.MaxLength = 50;
            this.TextBoxUsuarioModificacion.Name = "TextBoxUsuarioModificacion";
            this.TextBoxUsuarioModificacion.ReadOnly = true;
            this.TextBoxUsuarioModificacion.Size = new System.Drawing.Size(233, 20);
            this.TextBoxUsuarioModificacion.TabIndex = 11;
            // 
            // TextBoxUsuarioCreacion
            // 
            this.TextBoxUsuarioCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsuarioCreacion.Location = new System.Drawing.Point(243, 130);
            this.TextBoxUsuarioCreacion.MaxLength = 50;
            this.TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            this.TextBoxUsuarioCreacion.ReadOnly = true;
            this.TextBoxUsuarioCreacion.Size = new System.Drawing.Size(233, 20);
            this.TextBoxUsuarioCreacion.TabIndex = 8;
            // 
            // TextBoxFechaHoraModificacion
            // 
            this.TextBoxFechaHoraModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxFechaHoraModificacion.Location = new System.Drawing.Point(116, 156);
            this.TextBoxFechaHoraModificacion.MaxLength = 0;
            this.TextBoxFechaHoraModificacion.Name = "TextBoxFechaHoraModificacion";
            this.TextBoxFechaHoraModificacion.ReadOnly = true;
            this.TextBoxFechaHoraModificacion.Size = new System.Drawing.Size(121, 20);
            this.TextBoxFechaHoraModificacion.TabIndex = 10;
            // 
            // TextBoxFechaHoraCreacion
            // 
            this.TextBoxFechaHoraCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxFechaHoraCreacion.Location = new System.Drawing.Point(116, 130);
            this.TextBoxFechaHoraCreacion.MaxLength = 0;
            this.TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            this.TextBoxFechaHoraCreacion.ReadOnly = true;
            this.TextBoxFechaHoraCreacion.Size = new System.Drawing.Size(121, 20);
            this.TextBoxFechaHoraCreacion.TabIndex = 7;
            // 
            // TextBoxNotas
            // 
            this.TextBoxNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNotas.Location = new System.Drawing.Point(117, 6);
            this.TextBoxNotas.MaxLength = 0;
            this.TextBoxNotas.Multiline = true;
            this.TextBoxNotas.Name = "TextBoxNotas";
            this.TextBoxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxNotas.Size = new System.Drawing.Size(359, 68);
            this.TextBoxNotas.TabIndex = 1;
            this.TextBoxNotas.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // LabelNotas
            // 
            this.LabelNotas.AutoSize = true;
            this.LabelNotas.Location = new System.Drawing.Point(7, 9);
            this.LabelNotas.Name = "LabelNotas";
            this.LabelNotas.Size = new System.Drawing.Size(38, 13);
            this.LabelNotas.TabIndex = 0;
            this.LabelNotas.Text = "Notas:";
            // 
            // FormUsuarioGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 269);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.ToolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarioGrupo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grupo de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.This_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.This_KeyPress);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.TabControlMain.ResumeLayout(false);
            this.TabPageGeneral.ResumeLayout(false);
            this.TabPageGeneral.PerformLayout();
            this.TabPageNotasAuditoria.ResumeLayout(false);
            this.TabPageNotasAuditoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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