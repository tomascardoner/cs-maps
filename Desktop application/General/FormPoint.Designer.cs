﻿namespace CSMaps.General
{
    partial class FormPoint
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
            components = new System.ComponentModel.Container();
            Label LabelCreacion;
            Label LabelModificacion;
            ToolStripMain = new ToolStrip();
            ToolStripButtonClose = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonCancel = new ToolStripButton();
            ToolStripButtonSave = new ToolStripButton();
            LabelNombre = new Label();
            TextBoxNombre = new TextBox();
            LabelLatitud = new Label();
            DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            LabelLongitud = new Label();
            LabelAltitud = new Label();
            DoubleTextBoxAltitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            TabControlMain = new TabControl();
            TabPageGeneral = new TabPage();
            TableLayoutPanelGeneral = new TableLayoutPanel();
            TabPageAuditoria = new TabPage();
            TableLayoutPanelAuditoria = new TableLayoutPanel();
            LabelId = new Label();
            TextBoxId = new TextBox();
            TextBoxFechaHoraCreacion = new TextBox();
            TextBoxUsuarioCreacion = new TextBox();
            TextBoxFechaHoraUltimaModificacion = new TextBox();
            TextBoxUsuarioUltimaModificacion = new TextBox();
            LabelCreacion = new Label();
            LabelModificacion = new Label();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxAltitud).BeginInit();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TableLayoutPanelGeneral.SuspendLayout();
            TabPageAuditoria.SuspendLayout();
            TableLayoutPanelAuditoria.SuspendLayout();
            SuspendLayout();
            // 
            // LabelCreacion
            // 
            LabelCreacion.AutoSize = true;
            LabelCreacion.Dock = DockStyle.Fill;
            LabelCreacion.Location = new Point(4, 33);
            LabelCreacion.Margin = new Padding(4, 0, 4, 0);
            LabelCreacion.Name = "LabelCreacion";
            LabelCreacion.Size = new Size(147, 33);
            LabelCreacion.TabIndex = 2;
            LabelCreacion.Text = "Creación:";
            LabelCreacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelModificacion
            // 
            LabelModificacion.AutoSize = true;
            LabelModificacion.Dock = DockStyle.Fill;
            LabelModificacion.Location = new Point(4, 66);
            LabelModificacion.Margin = new Padding(4, 0, 4, 0);
            LabelModificacion.Name = "LabelModificacion";
            LabelModificacion.Size = new Size(147, 33);
            LabelModificacion.TabIndex = 5;
            LabelModificacion.Text = "Última modificación:";
            LabelModificacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonClose, ToolStripButtonEdit, ToolStripButtonCancel, ToolStripButtonSave });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(605, 39);
            ToolStripMain.TabIndex = 0;
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
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Location = new Point(3, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(71, 33);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Dock = DockStyle.Fill;
            TextBoxNombre.Location = new Point(80, 3);
            TextBoxNombre.MaxLength = 100;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(508, 27);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelLatitud
            // 
            LabelLatitud.AutoSize = true;
            LabelLatitud.Dock = DockStyle.Fill;
            LabelLatitud.Location = new Point(3, 33);
            LabelLatitud.Name = "LabelLatitud";
            LabelLatitud.Size = new Size(71, 33);
            LabelLatitud.TabIndex = 2;
            LabelLatitud.Text = "Latitud:";
            LabelLatitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DoubleTextBoxLatitud
            // 
            DoubleTextBoxLatitud.AccessibilityEnabled = true;
            DoubleTextBoxLatitud.BeforeTouchSize = new Size(70, 27);
            DoubleTextBoxLatitud.DoubleValue = 0D;
            DoubleTextBoxLatitud.Location = new Point(80, 36);
            DoubleTextBoxLatitud.MaxValue = 90D;
            DoubleTextBoxLatitud.MinValue = -90D;
            DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            DoubleTextBoxLatitud.Size = new Size(100, 27);
            DoubleTextBoxLatitud.TabIndex = 3;
            DoubleTextBoxLatitud.Text = "0,000000";
            DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLongitud
            // 
            DoubleTextBoxLongitud.AccessibilityEnabled = true;
            DoubleTextBoxLongitud.BeforeTouchSize = new Size(70, 27);
            DoubleTextBoxLongitud.DoubleValue = 0D;
            DoubleTextBoxLongitud.Location = new Point(80, 69);
            DoubleTextBoxLongitud.MaxValue = 180D;
            DoubleTextBoxLongitud.MinValue = -180D;
            DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            DoubleTextBoxLongitud.Size = new Size(100, 27);
            DoubleTextBoxLongitud.TabIndex = 5;
            DoubleTextBoxLongitud.Text = "0,000000";
            DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLongitud
            // 
            LabelLongitud.AutoSize = true;
            LabelLongitud.Dock = DockStyle.Fill;
            LabelLongitud.Location = new Point(3, 66);
            LabelLongitud.Name = "LabelLongitud";
            LabelLongitud.Size = new Size(71, 33);
            LabelLongitud.TabIndex = 4;
            LabelLongitud.Text = "Longitud:";
            LabelLongitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAltitud
            // 
            LabelAltitud.AutoSize = true;
            LabelAltitud.Dock = DockStyle.Fill;
            LabelAltitud.Location = new Point(3, 99);
            LabelAltitud.Name = "LabelAltitud";
            LabelAltitud.Size = new Size(71, 33);
            LabelAltitud.TabIndex = 6;
            LabelAltitud.Text = "Altitud:";
            LabelAltitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DoubleTextBoxAltitud
            // 
            DoubleTextBoxAltitud.AccessibilityEnabled = true;
            DoubleTextBoxAltitud.BeforeTouchSize = new Size(70, 27);
            DoubleTextBoxAltitud.DoubleValue = 0D;
            DoubleTextBoxAltitud.Location = new Point(80, 102);
            DoubleTextBoxAltitud.MaxValue = 8849D;
            DoubleTextBoxAltitud.MinValue = -11036D;
            DoubleTextBoxAltitud.Name = "DoubleTextBoxAltitud";
            DoubleTextBoxAltitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxAltitud.Size = new Size(70, 27);
            DoubleTextBoxAltitud.TabIndex = 7;
            DoubleTextBoxAltitud.Text = "0,00";
            DoubleTextBoxAltitud.TextAlign = HorizontalAlignment.Right;
            // 
            // TabControlMain
            // 
            TabControlMain.Appearance = TabAppearance.FlatButtons;
            TabControlMain.Controls.Add(TabPageGeneral);
            TabControlMain.Controls.Add(TabPageAuditoria);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 39);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(605, 199);
            TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TableLayoutPanelGeneral);
            TabPageGeneral.Location = new Point(4, 32);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(3);
            TabPageGeneral.Size = new Size(597, 163);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelGeneral
            // 
            TableLayoutPanelGeneral.AutoSize = true;
            TableLayoutPanelGeneral.ColumnCount = 2;
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.Controls.Add(LabelNombre, 0, 0);
            TableLayoutPanelGeneral.Controls.Add(TextBoxNombre, 1, 0);
            TableLayoutPanelGeneral.Controls.Add(LabelLatitud, 0, 1);
            TableLayoutPanelGeneral.Controls.Add(DoubleTextBoxLatitud, 1, 1);
            TableLayoutPanelGeneral.Controls.Add(LabelLongitud, 0, 2);
            TableLayoutPanelGeneral.Controls.Add(DoubleTextBoxLongitud, 1, 2);
            TableLayoutPanelGeneral.Controls.Add(LabelAltitud, 0, 3);
            TableLayoutPanelGeneral.Controls.Add(DoubleTextBoxAltitud, 1, 3);
            TableLayoutPanelGeneral.Dock = DockStyle.Fill;
            TableLayoutPanelGeneral.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelGeneral.Location = new Point(3, 3);
            TableLayoutPanelGeneral.Name = "TableLayoutPanelGeneral";
            TableLayoutPanelGeneral.RowCount = 5;
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.Size = new Size(591, 157);
            TableLayoutPanelGeneral.TabIndex = 8;
            // 
            // TabPageAuditoria
            // 
            TabPageAuditoria.Controls.Add(TableLayoutPanelAuditoria);
            TabPageAuditoria.Location = new Point(4, 32);
            TabPageAuditoria.Name = "TabPageAuditoria";
            TabPageAuditoria.Padding = new Padding(3);
            TabPageAuditoria.Size = new Size(597, 163);
            TabPageAuditoria.TabIndex = 1;
            TabPageAuditoria.Text = "Auditoría";
            TabPageAuditoria.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelAuditoria
            // 
            TableLayoutPanelAuditoria.AutoSize = true;
            TableLayoutPanelAuditoria.ColumnCount = 3;
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelAuditoria.Controls.Add(LabelId, 0, 0);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxId, 1, 0);
            TableLayoutPanelAuditoria.Controls.Add(LabelCreacion, 0, 1);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxFechaHoraCreacion, 1, 1);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxUsuarioCreacion, 2, 1);
            TableLayoutPanelAuditoria.Controls.Add(LabelModificacion, 0, 2);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxFechaHoraUltimaModificacion, 1, 2);
            TableLayoutPanelAuditoria.Controls.Add(TextBoxUsuarioUltimaModificacion, 2, 2);
            TableLayoutPanelAuditoria.Dock = DockStyle.Fill;
            TableLayoutPanelAuditoria.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelAuditoria.Location = new Point(3, 3);
            TableLayoutPanelAuditoria.Name = "TableLayoutPanelAuditoria";
            TableLayoutPanelAuditoria.RowCount = 4;
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            TableLayoutPanelAuditoria.Size = new Size(591, 157);
            TableLayoutPanelAuditoria.TabIndex = 9;
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Dock = DockStyle.Fill;
            LabelId.Location = new Point(4, 0);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(147, 33);
            LabelId.TabIndex = 0;
            LabelId.Text = "Id:";
            LabelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(159, 3);
            TextBoxId.Margin = new Padding(4, 3, 4, 3);
            TextBoxId.MaxLength = 10;
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(83, 27);
            TextBoxId.TabIndex = 1;
            TextBoxId.TabStop = false;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxFechaHoraCreacion
            // 
            TextBoxFechaHoraCreacion.Location = new Point(159, 36);
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
            TextBoxUsuarioCreacion.Location = new Point(307, 36);
            TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioCreacion.MaxLength = 50;
            TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            TextBoxUsuarioCreacion.ReadOnly = true;
            TextBoxUsuarioCreacion.Size = new Size(280, 27);
            TextBoxUsuarioCreacion.TabIndex = 4;
            TextBoxUsuarioCreacion.TabStop = false;
            // 
            // TextBoxFechaHoraUltimaModificacion
            // 
            TextBoxFechaHoraUltimaModificacion.Location = new Point(159, 69);
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
            TextBoxUsuarioUltimaModificacion.Location = new Point(307, 69);
            TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            TextBoxUsuarioUltimaModificacion.Size = new Size(280, 27);
            TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            TextBoxUsuarioUltimaModificacion.TabStop = false;
            // 
            // FormPoint
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(605, 238);
            Controls.Add(TabControlMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPoint";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Punto";
            FormClosed += This_FormClosed;
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxAltitud).EndInit();
            TabControlMain.ResumeLayout(false);
            TabPageGeneral.ResumeLayout(false);
            TabPageGeneral.PerformLayout();
            TableLayoutPanelGeneral.ResumeLayout(false);
            TableLayoutPanelGeneral.PerformLayout();
            TabPageAuditoria.ResumeLayout(false);
            TabPageAuditoria.PerformLayout();
            TableLayoutPanelAuditoria.ResumeLayout(false);
            TableLayoutPanelAuditoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private Label LabelNombre;
        private TextBox TextBoxNombre;
        private Label LabelLatitud;
        internal ToolStripButton ToolStripButtonClose;
        internal ToolStripButton ToolStripButtonEdit;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSave;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLatitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLongitud;
        private Label LabelLongitud;
        private Label LabelAltitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxAltitud;
        private TabControl TabControlMain;
        private TabPage TabPageGeneral;
        private TabPage TabPageAuditoria;
        private TableLayoutPanel TableLayoutPanelGeneral;
        private TableLayoutPanel TableLayoutPanelAuditoria;
        private Label LabelId;
        private TextBox TextBoxId;
        internal TextBox TextBoxFechaHoraCreacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxUsuarioUltimaModificacion;
    }
}