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
            this.components = new System.ComponentModel.Container();
            Label LabelCreacion;
            Label LabelModificacion;
            this.ToolStripMain = new ToolStrip();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripButtonCancel = new ToolStripButton();
            this.ToolStripButtonSave = new ToolStripButton();
            this.ButtonBuscarPunto = new Button();
            this.LabelLongitud = new Label();
            this.DoubleTextBoxLongitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.DoubleTextBoxLatitud = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.LabelLatitud = new Label();
            this.TextBoxNombre = new TextBox();
            this.LabelNombre = new Label();
            this.LabelEstablecimiento = new Label();
            this.ComboBoxEstablecimiento = new ComboBox();
            this.LabelChapaNumero = new Label();
            this.IntegerTextBoxChapaNumero = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.ButtonChapaNumeroObtenerDesdeNombre = new Button();
            this.GroupBoxAgregarEvento = new GroupBox();
            this.ComboBoxEventoAgregar = new ComboBox();
            this.CheckBoxEventoAgregar = new CheckBox();
            this.TabControlMain = new TabControl();
            this.TabPageGeneral = new TabPage();
            this.TableLayoutPanelGeneral = new TableLayoutPanel();
            this.TableLayoutPanelPunto = new TableLayoutPanel();
            this.TableLayoutPanelDatos = new TableLayoutPanel();
            this.LabelNotas = new Label();
            this.TextBoxNotas = new TextBox();
            this.TableLayoutPanelEventoAgregar = new TableLayoutPanel();
            this.TabPageAuditoria = new TabPage();
            this.TableLayoutPanelAuditoria = new TableLayoutPanel();
            this.LabelId = new Label();
            this.TextBoxId = new TextBox();
            this.TextBoxFechaHoraCreacion = new TextBox();
            this.TextBoxUsuarioCreacion = new TextBox();
            this.TextBoxFechaHoraUltimaModificacion = new TextBox();
            this.TextBoxUsuarioUltimaModificacion = new TextBox();
            LabelCreacion = new Label();
            LabelModificacion = new Label();
            this.ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DoubleTextBoxLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.DoubleTextBoxLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.IntegerTextBoxChapaNumero).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.TabPageGeneral.SuspendLayout();
            this.TableLayoutPanelGeneral.SuspendLayout();
            this.TableLayoutPanelPunto.SuspendLayout();
            this.TableLayoutPanelDatos.SuspendLayout();
            this.TableLayoutPanelEventoAgregar.SuspendLayout();
            this.TabPageAuditoria.SuspendLayout();
            this.TableLayoutPanelAuditoria.SuspendLayout();
            this.SuspendLayout();
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
            this.ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripMain.ImageScalingSize = new Size(20, 20);
            this.ToolStripMain.Items.AddRange(new ToolStripItem[] { this.ToolStripButtonClose, this.ToolStripButtonEdit, this.ToolStripButtonCancel, this.ToolStripButtonSave });
            this.ToolStripMain.Location = new Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new Size(797, 39);
            this.ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonClose
            // 
            this.ToolStripButtonClose.Alignment = ToolStripItemAlignment.Right;
            this.ToolStripButtonClose.Image = Properties.Resources.ImageClose32;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(85, 36);
            this.ToolStripButtonClose.Text = "Cerrar";
            this.ToolStripButtonClose.Click += this.ToolStripButtonClose_Click;
            // 
            // ToolStripButtonEdit
            // 
            this.ToolStripButtonEdit.Alignment = ToolStripItemAlignment.Right;
            this.ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(84, 36);
            this.ToolStripButtonEdit.Text = "Editar";
            this.ToolStripButtonEdit.Click += this.ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonCancel
            // 
            this.ToolStripButtonCancel.Alignment = ToolStripItemAlignment.Right;
            this.ToolStripButtonCancel.Image = Properties.Resources.ImageCancel32;
            this.ToolStripButtonCancel.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCancel.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCancel.Name = "ToolStripButtonCancel";
            this.ToolStripButtonCancel.Size = new Size(102, 36);
            this.ToolStripButtonCancel.Text = "Cancelar";
            this.ToolStripButtonCancel.Click += this.ToolStripButtonCancel_Click;
            // 
            // ToolStripButtonSave
            // 
            this.ToolStripButtonSave.Alignment = ToolStripItemAlignment.Right;
            this.ToolStripButtonSave.Image = Properties.Resources.ImageOk32;
            this.ToolStripButtonSave.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonSave.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonSave.Name = "ToolStripButtonSave";
            this.ToolStripButtonSave.Size = new Size(98, 36);
            this.ToolStripButtonSave.Text = "Guardar";
            this.ToolStripButtonSave.Click += this.ToolStripButtonSave_Click;
            // 
            // ButtonBuscarPunto
            // 
            this.ButtonBuscarPunto.AutoSize = true;
            this.ButtonBuscarPunto.Dock = DockStyle.Fill;
            this.ButtonBuscarPunto.Location = new Point(658, 3);
            this.ButtonBuscarPunto.Name = "ButtonBuscarPunto";
            this.ButtonBuscarPunto.Size = new Size(114, 30);
            this.ButtonBuscarPunto.TabIndex = 2;
            this.ButtonBuscarPunto.Text = "Buscar punto...";
            this.ButtonBuscarPunto.UseVisualStyleBackColor = true;
            this.ButtonBuscarPunto.Click += this.ButtonBuscarPunto_Click;
            // 
            // LabelLongitud
            // 
            this.LabelLongitud.AutoSize = true;
            this.LabelLongitud.Dock = DockStyle.Fill;
            this.LabelLongitud.Location = new Point(3, 69);
            this.LabelLongitud.Name = "LabelLongitud";
            this.LabelLongitud.Size = new Size(71, 33);
            this.LabelLongitud.TabIndex = 5;
            this.LabelLongitud.Text = "Longitud:";
            this.LabelLongitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DoubleTextBoxLongitud
            // 
            this.DoubleTextBoxLongitud.AccessibilityEnabled = true;
            this.DoubleTextBoxLongitud.BeforeTouchSize = new Size(100, 27);
            this.DoubleTextBoxLongitud.DoubleValue = 0D;
            this.DoubleTextBoxLongitud.HideTrailingZeros = false;
            this.DoubleTextBoxLongitud.Location = new Point(80, 72);
            this.DoubleTextBoxLongitud.MaxValue = 180D;
            this.DoubleTextBoxLongitud.MinValue = -180D;
            this.DoubleTextBoxLongitud.Name = "DoubleTextBoxLongitud";
            this.DoubleTextBoxLongitud.NegativeColor = SystemColors.ControlText;
            this.DoubleTextBoxLongitud.NumberDecimalDigits = 6;
            this.DoubleTextBoxLongitud.ReadOnly = true;
            this.DoubleTextBoxLongitud.Size = new Size(100, 27);
            this.DoubleTextBoxLongitud.TabIndex = 6;
            this.DoubleTextBoxLongitud.TabStop = false;
            this.DoubleTextBoxLongitud.Text = "0,000000";
            this.DoubleTextBoxLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // DoubleTextBoxLatitud
            // 
            this.DoubleTextBoxLatitud.AccessibilityEnabled = true;
            this.DoubleTextBoxLatitud.BeforeTouchSize = new Size(100, 27);
            this.DoubleTextBoxLatitud.DoubleValue = 0D;
            this.DoubleTextBoxLatitud.HideTrailingZeros = false;
            this.DoubleTextBoxLatitud.Location = new Point(80, 39);
            this.DoubleTextBoxLatitud.MaxValue = 90D;
            this.DoubleTextBoxLatitud.MinValue = -90D;
            this.DoubleTextBoxLatitud.Name = "DoubleTextBoxLatitud";
            this.DoubleTextBoxLatitud.NegativeColor = SystemColors.ControlText;
            this.DoubleTextBoxLatitud.NumberDecimalDigits = 6;
            this.DoubleTextBoxLatitud.ReadOnly = true;
            this.DoubleTextBoxLatitud.Size = new Size(100, 27);
            this.DoubleTextBoxLatitud.TabIndex = 4;
            this.DoubleTextBoxLatitud.TabStop = false;
            this.DoubleTextBoxLatitud.Text = "0,000000";
            this.DoubleTextBoxLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelLatitud
            // 
            this.LabelLatitud.AutoSize = true;
            this.LabelLatitud.Dock = DockStyle.Fill;
            this.LabelLatitud.Location = new Point(3, 36);
            this.LabelLatitud.Name = "LabelLatitud";
            this.LabelLatitud.Size = new Size(71, 33);
            this.LabelLatitud.TabIndex = 3;
            this.LabelLatitud.Text = "Latitud:";
            this.LabelLatitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Dock = DockStyle.Fill;
            this.TextBoxNombre.Location = new Point(80, 3);
            this.TextBoxNombre.MaxLength = 100;
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.ReadOnly = true;
            this.TextBoxNombre.Size = new Size(572, 27);
            this.TextBoxNombre.TabIndex = 1;
            this.TextBoxNombre.TabStop = false;
            this.TextBoxNombre.Enter += this.TextBoxs_Enter;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Dock = DockStyle.Fill;
            this.LabelNombre.Location = new Point(3, 0);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new Size(71, 36);
            this.LabelNombre.TabIndex = 0;
            this.LabelNombre.Text = "Nombre:";
            this.LabelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelEstablecimiento
            // 
            this.LabelEstablecimiento.AutoSize = true;
            this.LabelEstablecimiento.Dock = DockStyle.Fill;
            this.LabelEstablecimiento.Location = new Point(3, 0);
            this.LabelEstablecimiento.Name = "LabelEstablecimiento";
            this.LabelEstablecimiento.Size = new Size(118, 34);
            this.LabelEstablecimiento.TabIndex = 1;
            this.LabelEstablecimiento.Text = "Establecimiento:";
            this.LabelEstablecimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComboBoxEstablecimiento
            // 
            this.TableLayoutPanelDatos.SetColumnSpan(this.ComboBoxEstablecimiento, 2);
            this.ComboBoxEstablecimiento.Dock = DockStyle.Fill;
            this.ComboBoxEstablecimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxEstablecimiento.FormattingEnabled = true;
            this.ComboBoxEstablecimiento.Location = new Point(127, 3);
            this.ComboBoxEstablecimiento.Name = "ComboBoxEstablecimiento";
            this.ComboBoxEstablecimiento.Size = new Size(645, 28);
            this.ComboBoxEstablecimiento.TabIndex = 2;
            // 
            // LabelChapaNumero
            // 
            this.LabelChapaNumero.AutoSize = true;
            this.LabelChapaNumero.Dock = DockStyle.Fill;
            this.LabelChapaNumero.Location = new Point(3, 34);
            this.LabelChapaNumero.Name = "LabelChapaNumero";
            this.LabelChapaNumero.Size = new Size(118, 36);
            this.LabelChapaNumero.TabIndex = 3;
            this.LabelChapaNumero.Text = "Nº de chapa:";
            this.LabelChapaNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IntegerTextBoxChapaNumero
            // 
            this.IntegerTextBoxChapaNumero.AccessibilityEnabled = true;
            this.IntegerTextBoxChapaNumero.AllowNull = true;
            this.IntegerTextBoxChapaNumero.BeforeTouchSize = new Size(100, 27);
            this.IntegerTextBoxChapaNumero.IntegerValue = 1L;
            this.IntegerTextBoxChapaNumero.Location = new Point(127, 37);
            this.IntegerTextBoxChapaNumero.MaxValue = 109999L;
            this.IntegerTextBoxChapaNumero.MinValue = 1L;
            this.IntegerTextBoxChapaNumero.Name = "IntegerTextBoxChapaNumero";
            this.IntegerTextBoxChapaNumero.NegativeColor = SystemColors.ControlText;
            this.IntegerTextBoxChapaNumero.Size = new Size(100, 27);
            this.IntegerTextBoxChapaNumero.TabIndex = 4;
            this.IntegerTextBoxChapaNumero.Text = "1";
            this.IntegerTextBoxChapaNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonChapaNumeroObtenerDesdeNombre
            // 
            this.ButtonChapaNumeroObtenerDesdeNombre.AutoSize = true;
            this.ButtonChapaNumeroObtenerDesdeNombre.Location = new Point(233, 37);
            this.ButtonChapaNumeroObtenerDesdeNombre.Name = "ButtonChapaNumeroObtenerDesdeNombre";
            this.ButtonChapaNumeroObtenerDesdeNombre.Size = new Size(207, 30);
            this.ButtonChapaNumeroObtenerDesdeNombre.TabIndex = 5;
            this.ButtonChapaNumeroObtenerDesdeNombre.Text = "<<< Obtener desde nombre";
            this.ButtonChapaNumeroObtenerDesdeNombre.UseVisualStyleBackColor = true;
            this.ButtonChapaNumeroObtenerDesdeNombre.Click += this.ButtonChapaNumeroObtenerDesdeNombre_Click;
            // 
            // GroupBoxAgregarEvento
            // 
            this.GroupBoxAgregarEvento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.GroupBoxAgregarEvento.Location = new Point(6, 500);
            this.GroupBoxAgregarEvento.Name = "GroupBoxAgregarEvento";
            this.GroupBoxAgregarEvento.Size = new Size(777, 52);
            this.GroupBoxAgregarEvento.TabIndex = 8;
            this.GroupBoxAgregarEvento.TabStop = false;
            // 
            // ComboBoxEventoAgregar
            // 
            this.ComboBoxEventoAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ComboBoxEventoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxEventoAgregar.FormattingEnabled = true;
            this.ComboBoxEventoAgregar.Location = new Point(146, 3);
            this.ComboBoxEventoAgregar.Name = "ComboBoxEventoAgregar";
            this.ComboBoxEventoAgregar.Size = new Size(626, 28);
            this.ComboBoxEventoAgregar.TabIndex = 1;
            // 
            // CheckBoxEventoAgregar
            // 
            this.CheckBoxEventoAgregar.AutoSize = true;
            this.CheckBoxEventoAgregar.Location = new Point(3, 3);
            this.CheckBoxEventoAgregar.Name = "CheckBoxEventoAgregar";
            this.CheckBoxEventoAgregar.Size = new Size(137, 24);
            this.CheckBoxEventoAgregar.TabIndex = 0;
            this.CheckBoxEventoAgregar.Text = "Agregar evento:";
            this.CheckBoxEventoAgregar.UseVisualStyleBackColor = true;
            this.CheckBoxEventoAgregar.CheckedChanged += this.CheckBoxEventoAgregar_CheckedChanged;
            // 
            // TabControlMain
            // 
            this.TabControlMain.Appearance = TabAppearance.FlatButtons;
            this.TabControlMain.Controls.Add(this.TabPageGeneral);
            this.TabControlMain.Controls.Add(this.TabPageAuditoria);
            this.TabControlMain.Dock = DockStyle.Fill;
            this.TabControlMain.Location = new Point(0, 39);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new Size(797, 594);
            this.TabControlMain.TabIndex = 1;
            // 
            // TabPageGeneral
            // 
            this.TabPageGeneral.Controls.Add(this.TableLayoutPanelGeneral);
            this.TabPageGeneral.Controls.Add(this.GroupBoxAgregarEvento);
            this.TabPageGeneral.Location = new Point(4, 32);
            this.TabPageGeneral.Name = "TabPageGeneral";
            this.TabPageGeneral.Padding = new Padding(3);
            this.TabPageGeneral.Size = new Size(789, 558);
            this.TabPageGeneral.TabIndex = 0;
            this.TabPageGeneral.Text = "General";
            this.TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelGeneral
            // 
            this.TableLayoutPanelGeneral.AutoSize = true;
            this.TableLayoutPanelGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelGeneral.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanelGeneral.ColumnCount = 1;
            this.TableLayoutPanelGeneral.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelGeneral.Controls.Add(this.TableLayoutPanelPunto, 0, 0);
            this.TableLayoutPanelGeneral.Controls.Add(this.TableLayoutPanelDatos, 0, 1);
            this.TableLayoutPanelGeneral.Controls.Add(this.TableLayoutPanelEventoAgregar, 0, 2);
            this.TableLayoutPanelGeneral.Dock = DockStyle.Fill;
            this.TableLayoutPanelGeneral.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelGeneral.Location = new Point(3, 3);
            this.TableLayoutPanelGeneral.Name = "TableLayoutPanelGeneral";
            this.TableLayoutPanelGeneral.RowCount = 3;
            this.TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.TableLayoutPanelGeneral.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelGeneral.Size = new Size(783, 552);
            this.TableLayoutPanelGeneral.TabIndex = 10;
            // 
            // TableLayoutPanelPunto
            // 
            this.TableLayoutPanelPunto.AutoSize = true;
            this.TableLayoutPanelPunto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelPunto.ColumnCount = 3;
            this.TableLayoutPanelPunto.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelPunto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TableLayoutPanelPunto.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelPunto.Controls.Add(this.LabelNombre, 0, 0);
            this.TableLayoutPanelPunto.Controls.Add(this.TextBoxNombre, 1, 0);
            this.TableLayoutPanelPunto.Controls.Add(this.ButtonBuscarPunto, 2, 0);
            this.TableLayoutPanelPunto.Controls.Add(this.LabelLatitud, 0, 1);
            this.TableLayoutPanelPunto.Controls.Add(this.DoubleTextBoxLatitud, 1, 1);
            this.TableLayoutPanelPunto.Controls.Add(this.LabelLongitud, 0, 2);
            this.TableLayoutPanelPunto.Controls.Add(this.DoubleTextBoxLongitud, 1, 2);
            this.TableLayoutPanelPunto.Dock = DockStyle.Fill;
            this.TableLayoutPanelPunto.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelPunto.Location = new Point(4, 4);
            this.TableLayoutPanelPunto.Name = "TableLayoutPanelPunto";
            this.TableLayoutPanelPunto.RowCount = 3;
            this.TableLayoutPanelPunto.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelPunto.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelPunto.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelPunto.Size = new Size(775, 102);
            this.TableLayoutPanelPunto.TabIndex = 7;
            // 
            // TableLayoutPanelDatos
            // 
            this.TableLayoutPanelDatos.ColumnCount = 3;
            this.TableLayoutPanelDatos.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelDatos.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TableLayoutPanelDatos.Controls.Add(this.LabelEstablecimiento, 0, 0);
            this.TableLayoutPanelDatos.Controls.Add(this.ComboBoxEstablecimiento, 1, 0);
            this.TableLayoutPanelDatos.Controls.Add(this.LabelChapaNumero, 0, 1);
            this.TableLayoutPanelDatos.Controls.Add(this.IntegerTextBoxChapaNumero, 1, 1);
            this.TableLayoutPanelDatos.Controls.Add(this.ButtonChapaNumeroObtenerDesdeNombre, 2, 1);
            this.TableLayoutPanelDatos.Controls.Add(this.LabelNotas, 0, 2);
            this.TableLayoutPanelDatos.Controls.Add(this.TextBoxNotas, 1, 2);
            this.TableLayoutPanelDatos.Dock = DockStyle.Fill;
            this.TableLayoutPanelDatos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelDatos.Location = new Point(4, 113);
            this.TableLayoutPanelDatos.Name = "TableLayoutPanelDatos";
            this.TableLayoutPanelDatos.RowCount = 3;
            this.TableLayoutPanelDatos.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelDatos.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.TableLayoutPanelDatos.Size = new Size(775, 394);
            this.TableLayoutPanelDatos.TabIndex = 9;
            // 
            // LabelNotas
            // 
            this.LabelNotas.AutoSize = true;
            this.LabelNotas.Dock = DockStyle.Fill;
            this.LabelNotas.Location = new Point(4, 70);
            this.LabelNotas.Margin = new Padding(4, 0, 4, 0);
            this.LabelNotas.Name = "LabelNotas";
            this.LabelNotas.Size = new Size(116, 324);
            this.LabelNotas.TabIndex = 6;
            this.LabelNotas.Text = "Notas:";
            // 
            // TextBoxNotas
            // 
            this.TableLayoutPanelDatos.SetColumnSpan(this.TextBoxNotas, 2);
            this.TextBoxNotas.Dock = DockStyle.Fill;
            this.TextBoxNotas.Location = new Point(128, 73);
            this.TextBoxNotas.Margin = new Padding(4, 3, 4, 3);
            this.TextBoxNotas.MaxLength = 0;
            this.TextBoxNotas.Multiline = true;
            this.TextBoxNotas.Name = "TextBoxNotas";
            this.TextBoxNotas.ScrollBars = ScrollBars.Vertical;
            this.TextBoxNotas.Size = new Size(643, 318);
            this.TextBoxNotas.TabIndex = 7;
            // 
            // TableLayoutPanelEventoAgregar
            // 
            this.TableLayoutPanelEventoAgregar.AutoSize = true;
            this.TableLayoutPanelEventoAgregar.ColumnCount = 2;
            this.TableLayoutPanelEventoAgregar.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelEventoAgregar.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelEventoAgregar.Controls.Add(this.CheckBoxEventoAgregar, 0, 0);
            this.TableLayoutPanelEventoAgregar.Controls.Add(this.ComboBoxEventoAgregar, 1, 0);
            this.TableLayoutPanelEventoAgregar.Dock = DockStyle.Fill;
            this.TableLayoutPanelEventoAgregar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelEventoAgregar.Location = new Point(4, 514);
            this.TableLayoutPanelEventoAgregar.Name = "TableLayoutPanelEventoAgregar";
            this.TableLayoutPanelEventoAgregar.RowCount = 1;
            this.TableLayoutPanelEventoAgregar.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelEventoAgregar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.TableLayoutPanelEventoAgregar.Size = new Size(775, 34);
            this.TableLayoutPanelEventoAgregar.TabIndex = 11;
            // 
            // TabPageAuditoria
            // 
            this.TabPageAuditoria.Controls.Add(this.TableLayoutPanelAuditoria);
            this.TabPageAuditoria.Location = new Point(4, 32);
            this.TabPageAuditoria.Name = "TabPageAuditoria";
            this.TabPageAuditoria.Padding = new Padding(3);
            this.TabPageAuditoria.Size = new Size(789, 558);
            this.TabPageAuditoria.TabIndex = 1;
            this.TabPageAuditoria.Text = "Auditoría";
            this.TabPageAuditoria.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelAuditoria
            // 
            this.TableLayoutPanelAuditoria.AutoSize = true;
            this.TableLayoutPanelAuditoria.ColumnCount = 3;
            this.TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelAuditoria.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanelAuditoria.Controls.Add(this.LabelId, 0, 0);
            this.TableLayoutPanelAuditoria.Controls.Add(this.TextBoxId, 1, 0);
            this.TableLayoutPanelAuditoria.Controls.Add(LabelCreacion, 0, 1);
            this.TableLayoutPanelAuditoria.Controls.Add(this.TextBoxFechaHoraCreacion, 1, 1);
            this.TableLayoutPanelAuditoria.Controls.Add(this.TextBoxUsuarioCreacion, 2, 1);
            this.TableLayoutPanelAuditoria.Controls.Add(LabelModificacion, 0, 2);
            this.TableLayoutPanelAuditoria.Controls.Add(this.TextBoxFechaHoraUltimaModificacion, 1, 2);
            this.TableLayoutPanelAuditoria.Controls.Add(this.TextBoxUsuarioUltimaModificacion, 2, 2);
            this.TableLayoutPanelAuditoria.Dock = DockStyle.Fill;
            this.TableLayoutPanelAuditoria.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutPanelAuditoria.Location = new Point(3, 3);
            this.TableLayoutPanelAuditoria.Name = "TableLayoutPanelAuditoria";
            this.TableLayoutPanelAuditoria.RowCount = 4;
            this.TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelAuditoria.RowStyles.Add(new RowStyle());
            this.TableLayoutPanelAuditoria.Size = new Size(783, 552);
            this.TableLayoutPanelAuditoria.TabIndex = 9;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Dock = DockStyle.Fill;
            this.LabelId.Location = new Point(4, 0);
            this.LabelId.Margin = new Padding(4, 0, 4, 0);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new Size(147, 33);
            this.LabelId.TabIndex = 0;
            this.LabelId.Text = "Id:";
            this.LabelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new Point(159, 3);
            this.TextBoxId.Margin = new Padding(4, 3, 4, 3);
            this.TextBoxId.MaxLength = 10;
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new Size(83, 27);
            this.TextBoxId.TabIndex = 1;
            this.TextBoxId.TabStop = false;
            this.TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxFechaHoraCreacion
            // 
            this.TextBoxFechaHoraCreacion.Location = new Point(159, 36);
            this.TextBoxFechaHoraCreacion.Margin = new Padding(4, 3, 4, 3);
            this.TextBoxFechaHoraCreacion.MaxLength = 0;
            this.TextBoxFechaHoraCreacion.Name = "TextBoxFechaHoraCreacion";
            this.TextBoxFechaHoraCreacion.ReadOnly = true;
            this.TextBoxFechaHoraCreacion.Size = new Size(140, 27);
            this.TextBoxFechaHoraCreacion.TabIndex = 3;
            this.TextBoxFechaHoraCreacion.TabStop = false;
            // 
            // TextBoxUsuarioCreacion
            // 
            this.TextBoxUsuarioCreacion.Dock = DockStyle.Fill;
            this.TextBoxUsuarioCreacion.Location = new Point(307, 36);
            this.TextBoxUsuarioCreacion.Margin = new Padding(4, 3, 4, 3);
            this.TextBoxUsuarioCreacion.MaxLength = 50;
            this.TextBoxUsuarioCreacion.Name = "TextBoxUsuarioCreacion";
            this.TextBoxUsuarioCreacion.ReadOnly = true;
            this.TextBoxUsuarioCreacion.Size = new Size(472, 27);
            this.TextBoxUsuarioCreacion.TabIndex = 4;
            this.TextBoxUsuarioCreacion.TabStop = false;
            // 
            // TextBoxFechaHoraUltimaModificacion
            // 
            this.TextBoxFechaHoraUltimaModificacion.Location = new Point(159, 69);
            this.TextBoxFechaHoraUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            this.TextBoxFechaHoraUltimaModificacion.MaxLength = 0;
            this.TextBoxFechaHoraUltimaModificacion.Name = "TextBoxFechaHoraUltimaModificacion";
            this.TextBoxFechaHoraUltimaModificacion.ReadOnly = true;
            this.TextBoxFechaHoraUltimaModificacion.Size = new Size(140, 27);
            this.TextBoxFechaHoraUltimaModificacion.TabIndex = 6;
            this.TextBoxFechaHoraUltimaModificacion.TabStop = false;
            // 
            // TextBoxUsuarioUltimaModificacion
            // 
            this.TextBoxUsuarioUltimaModificacion.Dock = DockStyle.Fill;
            this.TextBoxUsuarioUltimaModificacion.Location = new Point(307, 69);
            this.TextBoxUsuarioUltimaModificacion.Margin = new Padding(4, 3, 4, 3);
            this.TextBoxUsuarioUltimaModificacion.MaxLength = 50;
            this.TextBoxUsuarioUltimaModificacion.Name = "TextBoxUsuarioUltimaModificacion";
            this.TextBoxUsuarioUltimaModificacion.ReadOnly = true;
            this.TextBoxUsuarioUltimaModificacion.Size = new Size(472, 27);
            this.TextBoxUsuarioUltimaModificacion.TabIndex = 7;
            this.TextBoxUsuarioUltimaModificacion.TabStop = false;
            // 
            // FormPointData
            // 
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.ClientSize = new Size(797, 633);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.ToolStripMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPointData";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Datos del punto";
            this.KeyPress += this.This_KeyPress;
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DoubleTextBoxLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.DoubleTextBoxLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.IntegerTextBoxChapaNumero).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.TabPageGeneral.ResumeLayout(false);
            this.TabPageGeneral.PerformLayout();
            this.TableLayoutPanelGeneral.ResumeLayout(false);
            this.TableLayoutPanelGeneral.PerformLayout();
            this.TableLayoutPanelPunto.ResumeLayout(false);
            this.TableLayoutPanelPunto.PerformLayout();
            this.TableLayoutPanelDatos.ResumeLayout(false);
            this.TableLayoutPanelDatos.PerformLayout();
            this.TableLayoutPanelEventoAgregar.ResumeLayout(false);
            this.TableLayoutPanelEventoAgregar.PerformLayout();
            this.TabPageAuditoria.ResumeLayout(false);
            this.TabPageAuditoria.PerformLayout();
            this.TableLayoutPanelAuditoria.ResumeLayout(false);
            this.TableLayoutPanelAuditoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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