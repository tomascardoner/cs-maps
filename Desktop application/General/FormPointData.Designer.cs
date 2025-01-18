namespace CSMaps.General
{
    partial class FormPointData
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
            ButtonBuscarPunto = new Button();
            LabelLongitud = new Label();
            DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            LabelLatitud = new Label();
            TextBoxNombre = new TextBox();
            LabelNombre = new Label();
            LabelEstablecimiento = new Label();
            ComboBoxEstablecimiento = new ComboBox();
            LabelChapaNumero = new Label();
            IntegerTextBoxChapaNumero = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ButtonChapaNumeroObtenerDesdeNombre = new Button();
            GroupBoxAgregarEvento = new GroupBox();
            ComboBoxEventoAgregar = new ComboBox();
            CheckBoxEventoAgregar = new CheckBox();
            TabControlMain = new TabControl();
            TabPageGeneral = new TabPage();
            TableLayoutPanelGeneral = new TableLayoutPanel();
            TableLayoutPanelPunto = new TableLayoutPanel();
            TableLayoutPanelDatos = new TableLayoutPanel();
            LabelNotas = new Label();
            TextBoxNotas = new TextBox();
            TableLayoutPanelEventoAgregar = new TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntegerTextBoxChapaNumero).BeginInit();
            TabControlMain.SuspendLayout();
            TabPageGeneral.SuspendLayout();
            TableLayoutPanelGeneral.SuspendLayout();
            TableLayoutPanelPunto.SuspendLayout();
            TableLayoutPanelDatos.SuspendLayout();
            TableLayoutPanelEventoAgregar.SuspendLayout();
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
            ToolStripMain.Size = new Size(797, 39);
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
            // ButtonBuscarPunto
            // 
            ButtonBuscarPunto.AutoSize = true;
            ButtonBuscarPunto.Dock = DockStyle.Fill;
            ButtonBuscarPunto.Location = new Point(658, 3);
            ButtonBuscarPunto.Name = "ButtonBuscarPunto";
            ButtonBuscarPunto.Size = new Size(114, 30);
            ButtonBuscarPunto.TabIndex = 2;
            ButtonBuscarPunto.Text = "Buscar punto...";
            ButtonBuscarPunto.UseVisualStyleBackColor = true;
            ButtonBuscarPunto.Click += ButtonBuscarPunto_Click;
            // 
            // LabelLongitud
            // 
            LabelLongitud.AutoSize = true;
            LabelLongitud.Dock = DockStyle.Fill;
            LabelLongitud.Location = new Point(3, 69);
            LabelLongitud.Name = "LabelLongitud";
            LabelLongitud.Size = new Size(71, 33);
            LabelLongitud.TabIndex = 5;
            LabelLongitud.Text = "Longitud:";
            LabelLongitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DoubleTextBoxLongitud
            // 
            DoubleTextBoxLongitud.AccessibilityEnabled = true;
            DoubleTextBoxLongitud.BeforeTouchSize = new Size(100, 27);
            DoubleTextBoxLongitud.DoubleValue = 0D;
            DoubleTextBoxLongitud.Location = new Point(80, 72);
            DoubleTextBoxLongitud.MaxValue = 180D;
            DoubleTextBoxLongitud.MinValue = -180D;
            DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            DoubleTextBoxLongitud.ReadOnly = true;
            DoubleTextBoxLongitud.Size = new Size(100, 27);
            DoubleTextBoxLongitud.TabIndex = 6;
            DoubleTextBoxLongitud.TabStop = false;
            DoubleTextBoxLongitud.Text = "0,000000";
            DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLatitud
            // 
            DoubleTextBoxLatitud.AccessibilityEnabled = true;
            DoubleTextBoxLatitud.BeforeTouchSize = new Size(100, 27);
            DoubleTextBoxLatitud.DoubleValue = 0D;
            DoubleTextBoxLatitud.Location = new Point(80, 39);
            DoubleTextBoxLatitud.MaxValue = 90D;
            DoubleTextBoxLatitud.MinValue = -90D;
            DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            DoubleTextBoxLatitud.ReadOnly = true;
            DoubleTextBoxLatitud.Size = new Size(100, 27);
            DoubleTextBoxLatitud.TabIndex = 4;
            DoubleTextBoxLatitud.TabStop = false;
            DoubleTextBoxLatitud.Text = "0,000000";
            DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLatitud
            // 
            LabelLatitud.AutoSize = true;
            LabelLatitud.Dock = DockStyle.Fill;
            LabelLatitud.Location = new Point(3, 36);
            LabelLatitud.Name = "LabelLatitud";
            LabelLatitud.Size = new Size(71, 33);
            LabelLatitud.TabIndex = 3;
            LabelLatitud.Text = "Latitud:";
            LabelLatitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Dock = DockStyle.Fill;
            TextBoxNombre.Location = new Point(80, 3);
            TextBoxNombre.MaxLength = 100;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.ReadOnly = true;
            TextBoxNombre.Size = new Size(572, 27);
            TextBoxNombre.TabIndex = 1;
            TextBoxNombre.TabStop = false;
            TextBoxNombre.Enter += TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Dock = DockStyle.Fill;
            LabelNombre.Location = new Point(3, 0);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(71, 36);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelEstablecimiento
            // 
            LabelEstablecimiento.AutoSize = true;
            LabelEstablecimiento.Dock = DockStyle.Fill;
            LabelEstablecimiento.Location = new Point(3, 0);
            LabelEstablecimiento.Name = "LabelEstablecimiento";
            LabelEstablecimiento.Size = new Size(118, 34);
            LabelEstablecimiento.TabIndex = 1;
            LabelEstablecimiento.Text = "Establecimiento:";
            LabelEstablecimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComboBoxEstablecimiento
            // 
            TableLayoutPanelDatos.SetColumnSpan(ComboBoxEstablecimiento, 2);
            ComboBoxEstablecimiento.Dock = DockStyle.Fill;
            ComboBoxEstablecimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstablecimiento.FormattingEnabled = true;
            ComboBoxEstablecimiento.Location = new Point(127, 3);
            ComboBoxEstablecimiento.Name = "ComboBoxEstablecimiento";
            ComboBoxEstablecimiento.Size = new Size(645, 28);
            ComboBoxEstablecimiento.TabIndex = 2;
            // 
            // LabelChapaNumero
            // 
            LabelChapaNumero.AutoSize = true;
            LabelChapaNumero.Dock = DockStyle.Fill;
            LabelChapaNumero.Location = new Point(3, 34);
            LabelChapaNumero.Name = "LabelChapaNumero";
            LabelChapaNumero.Size = new Size(118, 36);
            LabelChapaNumero.TabIndex = 3;
            LabelChapaNumero.Text = "Nº de chapa:";
            LabelChapaNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IntegerTextBoxChapaNumero
            // 
            IntegerTextBoxChapaNumero.AccessibilityEnabled = true;
            IntegerTextBoxChapaNumero.AllowNull = true;
            IntegerTextBoxChapaNumero.BeforeTouchSize = new Size(100, 27);
            IntegerTextBoxChapaNumero.IntegerValue = 1L;
            IntegerTextBoxChapaNumero.Location = new Point(127, 37);
            IntegerTextBoxChapaNumero.MaxValue = 109999L;
            IntegerTextBoxChapaNumero.MinValue = 1L;
            IntegerTextBoxChapaNumero.Name = "IntegerTextBoxChapaNumero";
            IntegerTextBoxChapaNumero.NegativeColor = SystemColors.ControlText;
            IntegerTextBoxChapaNumero.Size = new Size(100, 27);
            IntegerTextBoxChapaNumero.TabIndex = 4;
            IntegerTextBoxChapaNumero.Text = "1";
            IntegerTextBoxChapaNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonChapaNumeroObtenerDesdeNombre
            // 
            ButtonChapaNumeroObtenerDesdeNombre.AutoSize = true;
            ButtonChapaNumeroObtenerDesdeNombre.Location = new Point(233, 37);
            ButtonChapaNumeroObtenerDesdeNombre.Name = "ButtonChapaNumeroObtenerDesdeNombre";
            ButtonChapaNumeroObtenerDesdeNombre.Size = new Size(207, 30);
            ButtonChapaNumeroObtenerDesdeNombre.TabIndex = 5;
            ButtonChapaNumeroObtenerDesdeNombre.Text = "<<< Obtener desde nombre";
            ButtonChapaNumeroObtenerDesdeNombre.UseVisualStyleBackColor = true;
            ButtonChapaNumeroObtenerDesdeNombre.Click += ButtonChapaNumeroObtenerDesdeNombre_Click;
            // 
            // GroupBoxAgregarEvento
            // 
            GroupBoxAgregarEvento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxAgregarEvento.Location = new Point(6, 500);
            GroupBoxAgregarEvento.Name = "GroupBoxAgregarEvento";
            GroupBoxAgregarEvento.Size = new Size(777, 52);
            GroupBoxAgregarEvento.TabIndex = 8;
            GroupBoxAgregarEvento.TabStop = false;
            // 
            // ComboBoxEventoAgregar
            // 
            ComboBoxEventoAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxEventoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEventoAgregar.FormattingEnabled = true;
            ComboBoxEventoAgregar.Location = new Point(146, 3);
            ComboBoxEventoAgregar.Name = "ComboBoxEventoAgregar";
            ComboBoxEventoAgregar.Size = new Size(626, 28);
            ComboBoxEventoAgregar.TabIndex = 1;
            // 
            // CheckBoxEventoAgregar
            // 
            CheckBoxEventoAgregar.AutoSize = true;
            CheckBoxEventoAgregar.Location = new Point(3, 3);
            CheckBoxEventoAgregar.Name = "CheckBoxEventoAgregar";
            CheckBoxEventoAgregar.Size = new Size(137, 24);
            CheckBoxEventoAgregar.TabIndex = 0;
            CheckBoxEventoAgregar.Text = "Agregar evento:";
            CheckBoxEventoAgregar.UseVisualStyleBackColor = true;
            CheckBoxEventoAgregar.CheckedChanged += CheckBoxEventoAgregar_CheckedChanged;
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
            TabControlMain.Size = new Size(797, 594);
            TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            TabPageGeneral.Controls.Add(TableLayoutPanelGeneral);
            TabPageGeneral.Controls.Add(GroupBoxAgregarEvento);
            TabPageGeneral.Location = new Point(4, 32);
            TabPageGeneral.Name = "TabPageGeneral";
            TabPageGeneral.Padding = new Padding(3);
            TabPageGeneral.Size = new Size(789, 558);
            TabPageGeneral.TabIndex = 0;
            TabPageGeneral.Text = "General";
            TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelGeneral
            // 
            TableLayoutPanelGeneral.AutoSize = true;
            TableLayoutPanelGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelGeneral.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanelGeneral.ColumnCount = 1;
            TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelGeneral.Controls.Add(TableLayoutPanelPunto, 0, 0);
            TableLayoutPanelGeneral.Controls.Add(TableLayoutPanelDatos, 0, 1);
            TableLayoutPanelGeneral.Controls.Add(TableLayoutPanelEventoAgregar, 0, 2);
            TableLayoutPanelGeneral.Dock = DockStyle.Fill;
            TableLayoutPanelGeneral.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelGeneral.Location = new Point(3, 3);
            TableLayoutPanelGeneral.Name = "TableLayoutPanelGeneral";
            TableLayoutPanelGeneral.RowCount = 3;
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            TableLayoutPanelGeneral.Size = new Size(783, 552);
            TableLayoutPanelGeneral.TabIndex = 10;
            // 
            // TableLayoutPanelPunto
            // 
            TableLayoutPanelPunto.AutoSize = true;
            TableLayoutPanelPunto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelPunto.ColumnCount = 3;
            TableLayoutPanelPunto.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelPunto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelPunto.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelPunto.Controls.Add(LabelNombre, 0, 0);
            TableLayoutPanelPunto.Controls.Add(TextBoxNombre, 1, 0);
            TableLayoutPanelPunto.Controls.Add(ButtonBuscarPunto, 2, 0);
            TableLayoutPanelPunto.Controls.Add(LabelLatitud, 0, 1);
            TableLayoutPanelPunto.Controls.Add(DoubleTextBoxLatitud, 1, 1);
            TableLayoutPanelPunto.Controls.Add(LabelLongitud, 0, 2);
            TableLayoutPanelPunto.Controls.Add(DoubleTextBoxLongitud, 1, 2);
            TableLayoutPanelPunto.Dock = DockStyle.Fill;
            TableLayoutPanelPunto.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelPunto.Location = new Point(4, 4);
            TableLayoutPanelPunto.Name = "TableLayoutPanelPunto";
            TableLayoutPanelPunto.RowCount = 3;
            TableLayoutPanelPunto.RowStyles.Add(new RowStyle());
            TableLayoutPanelPunto.RowStyles.Add(new RowStyle());
            TableLayoutPanelPunto.RowStyles.Add(new RowStyle());
            TableLayoutPanelPunto.Size = new Size(775, 102);
            TableLayoutPanelPunto.TabIndex = 7;
            // 
            // TableLayoutPanelDatos
            // 
            TableLayoutPanelDatos.ColumnCount = 3;
            TableLayoutPanelDatos.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelDatos.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelDatos.Controls.Add(LabelEstablecimiento, 0, 0);
            TableLayoutPanelDatos.Controls.Add(ComboBoxEstablecimiento, 1, 0);
            TableLayoutPanelDatos.Controls.Add(LabelChapaNumero, 0, 1);
            TableLayoutPanelDatos.Controls.Add(IntegerTextBoxChapaNumero, 1, 1);
            TableLayoutPanelDatos.Controls.Add(ButtonChapaNumeroObtenerDesdeNombre, 2, 1);
            TableLayoutPanelDatos.Controls.Add(LabelNotas, 0, 2);
            TableLayoutPanelDatos.Controls.Add(TextBoxNotas, 1, 2);
            TableLayoutPanelDatos.Dock = DockStyle.Fill;
            TableLayoutPanelDatos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelDatos.Location = new Point(4, 113);
            TableLayoutPanelDatos.Name = "TableLayoutPanelDatos";
            TableLayoutPanelDatos.RowCount = 3;
            TableLayoutPanelDatos.RowStyles.Add(new RowStyle());
            TableLayoutPanelDatos.RowStyles.Add(new RowStyle());
            TableLayoutPanelDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelDatos.Size = new Size(775, 394);
            TableLayoutPanelDatos.TabIndex = 9;
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Dock = DockStyle.Fill;
            LabelNotas.Location = new Point(4, 70);
            LabelNotas.Margin = new Padding(4, 0, 4, 0);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(116, 324);
            LabelNotas.TabIndex = 6;
            LabelNotas.Text = "Notas:";
            // 
            // TextBoxNotas
            // 
            TableLayoutPanelDatos.SetColumnSpan(TextBoxNotas, 2);
            TextBoxNotas.Dock = DockStyle.Fill;
            TextBoxNotas.Location = new Point(128, 73);
            TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            TextBoxNotas.MaxLength = 0;
            TextBoxNotas.Multiline = true;
            TextBoxNotas.Name = "TextBoxNotas";
            TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            TextBoxNotas.Size = new Size(643, 318);
            TextBoxNotas.TabIndex = 7;
            // 
            // TableLayoutPanelEventoAgregar
            // 
            TableLayoutPanelEventoAgregar.AutoSize = true;
            TableLayoutPanelEventoAgregar.ColumnCount = 2;
            TableLayoutPanelEventoAgregar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelEventoAgregar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelEventoAgregar.Controls.Add(CheckBoxEventoAgregar, 0, 0);
            TableLayoutPanelEventoAgregar.Controls.Add(ComboBoxEventoAgregar, 1, 0);
            TableLayoutPanelEventoAgregar.Dock = DockStyle.Fill;
            TableLayoutPanelEventoAgregar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelEventoAgregar.Location = new Point(4, 514);
            TableLayoutPanelEventoAgregar.Name = "TableLayoutPanelEventoAgregar";
            TableLayoutPanelEventoAgregar.RowCount = 1;
            TableLayoutPanelEventoAgregar.RowStyles.Add(new RowStyle());
            TableLayoutPanelEventoAgregar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelEventoAgregar.Size = new Size(775, 34);
            TableLayoutPanelEventoAgregar.TabIndex = 11;
            // 
            // TabPageAuditoria
            // 
            TabPageAuditoria.Controls.Add(TableLayoutPanelAuditoria);
            TabPageAuditoria.Location = new Point(4, 32);
            TabPageAuditoria.Name = "TabPageAuditoria";
            TabPageAuditoria.Padding = new Padding(3);
            TabPageAuditoria.Size = new Size(789, 558);
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
            TableLayoutPanelAuditoria.Size = new Size(783, 552);
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
            TextBoxUsuarioCreacion.Size = new Size(472, 27);
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
            TextBoxUsuarioUltimaModificacion.Size = new Size(472, 27);
            TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            TextBoxUsuarioUltimaModificacion.TabStop = false;
            // 
            // FormPointData
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(797, 633);
            Controls.Add(TabControlMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPointData";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Datos del punto";
            FormClosed += This_FormClosed;
            KeyPress += This_KeyPress;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoubleTextBoxLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntegerTextBoxChapaNumero).EndInit();
            TabControlMain.ResumeLayout(false);
            TabPageGeneral.ResumeLayout(false);
            TabPageGeneral.PerformLayout();
            TableLayoutPanelGeneral.ResumeLayout(false);
            TableLayoutPanelGeneral.PerformLayout();
            TableLayoutPanelPunto.ResumeLayout(false);
            TableLayoutPanelPunto.PerformLayout();
            TableLayoutPanelDatos.ResumeLayout(false);
            TableLayoutPanelDatos.PerformLayout();
            TableLayoutPanelEventoAgregar.ResumeLayout(false);
            TableLayoutPanelEventoAgregar.PerformLayout();
            TabPageAuditoria.ResumeLayout(false);
            TabPageAuditoria.PerformLayout();
            TableLayoutPanelAuditoria.ResumeLayout(false);
            TableLayoutPanelAuditoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        internal ToolStripButton ToolStripButtonClose;
        internal ToolStripButton ToolStripButtonEdit;
        internal ToolStripButton ToolStripButtonCancel;
        internal ToolStripButton ToolStripButtonSave;
        private Label LabelLongitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLongitud;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox DoubleTextBoxLatitud;
        private Label LabelLatitud;
        private TextBox TextBoxNombre;
        private Label LabelNombre;
        private Label LabelEstablecimiento;
        private ComboBox ComboBoxEstablecimiento;
        private Label LabelChapaNumero;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox IntegerTextBoxChapaNumero;
        private Button ButtonBuscarPunto;
        private Button ButtonChapaNumeroObtenerDesdeNombre;
        private GroupBox GroupBoxAgregarEvento;
        private ComboBox ComboBoxEventoAgregar;
        private CheckBox CheckBoxEventoAgregar;
        private TabControl TabControlMain;
        private TabPage TabPageGeneral;
        private TabPage TabPageAuditoria;
        internal Label LabelNotas;
        private TableLayoutPanel TableLayoutPanelAuditoria;
        private Label LabelId;
        private TextBox TextBoxId;
        internal TextBox TextBoxFechaHoraCreacion;
        internal TextBox TextBoxUsuarioCreacion;
        internal TextBox TextBoxFechaHoraUltimaModificacion;
        internal TextBox TextBoxUsuarioUltimaModificacion;
        private TableLayoutPanel TableLayoutPanelPunto;
        private TableLayoutPanel TableLayoutPanelDatos;
        private TableLayoutPanel TableLayoutPanelEventoAgregar;
        private TableLayoutPanel TableLayoutPanelGeneral;
        private TextBox TextBoxNotas;
    }
}