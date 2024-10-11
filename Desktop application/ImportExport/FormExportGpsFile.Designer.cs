namespace CSMaps.ImportExport
{
    partial class FormExportGpsFile
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
            RadioButtonPointsAll = new RadioButton();
            RadioButtonPointsWithData = new RadioButton();
            ButtonFinish = new Button();
            GroupBoxStep1 = new GroupBox();
            ButtonNext = new Button();
            ButtonPrevious = new Button();
            GroupBoxSummary = new GroupBox();
            LabelSummary = new Label();
            GroupBoxStep2 = new GroupBox();
            TableLayoutPanelDevice = new TableLayoutPanel();
            TableLayoutPanelFile = new TableLayoutPanel();
            ButtonFile = new Button();
            TextBoxFile = new TextBox();
            LabelFile = new Label();
            ListViewDevices = new ListView();
            ColumnHeaderDescription = new ColumnHeader();
            ColumnHeaderDriveLetter = new ColumnHeader();
            GroupBoxStep1.SuspendLayout();
            GroupBoxSummary.SuspendLayout();
            GroupBoxStep2.SuspendLayout();
            TableLayoutPanelDevice.SuspendLayout();
            TableLayoutPanelFile.SuspendLayout();
            SuspendLayout();
            // 
            // RadioButtonPointsAll
            // 
            RadioButtonPointsAll.AutoSize = true;
            RadioButtonPointsAll.Location = new Point(8, 80);
            RadioButtonPointsAll.Margin = new Padding(4);
            RadioButtonPointsAll.Name = "RadioButtonPointsAll";
            RadioButtonPointsAll.Size = new Size(70, 24);
            RadioButtonPointsAll.TabIndex = 1;
            RadioButtonPointsAll.Text = "Todos";
            RadioButtonPointsAll.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPointsWithData
            // 
            RadioButtonPointsWithData.AutoSize = true;
            RadioButtonPointsWithData.Checked = true;
            RadioButtonPointsWithData.Location = new Point(8, 49);
            RadioButtonPointsWithData.Margin = new Padding(4);
            RadioButtonPointsWithData.Name = "RadioButtonPointsWithData";
            RadioButtonPointsWithData.Size = new Size(268, 24);
            RadioButtonPointsWithData.TabIndex = 0;
            RadioButtonPointsWithData.TabStop = true;
            RadioButtonPointsWithData.Text = "Sólo los que tienen datos asociados";
            RadioButtonPointsWithData.UseVisualStyleBackColor = true;
            // 
            // ButtonFinish
            // 
            ButtonFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonFinish.Location = new Point(664, 346);
            ButtonFinish.Margin = new Padding(4);
            ButtonFinish.Name = "ButtonFinish";
            ButtonFinish.Size = new Size(122, 38);
            ButtonFinish.TabIndex = 5;
            ButtonFinish.Text = "Finalizar";
            ButtonFinish.UseVisualStyleBackColor = true;
            ButtonFinish.Click += ButtonFinish_Click;
            // 
            // GroupBoxStep1
            // 
            GroupBoxStep1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxStep1.Controls.Add(RadioButtonPointsAll);
            GroupBoxStep1.Controls.Add(RadioButtonPointsWithData);
            GroupBoxStep1.Location = new Point(15, 15);
            GroupBoxStep1.Margin = new Padding(4);
            GroupBoxStep1.Name = "GroupBoxStep1";
            GroupBoxStep1.Padding = new Padding(4);
            GroupBoxStep1.Size = new Size(771, 323);
            GroupBoxStep1.TabIndex = 0;
            GroupBoxStep1.TabStop = false;
            GroupBoxStep1.Text = "Paso 1: seleccione los puntos a incluir";
            // 
            // ButtonNext
            // 
            ButtonNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonNext.Location = new Point(664, 346);
            ButtonNext.Margin = new Padding(4);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(122, 38);
            ButtonNext.TabIndex = 4;
            ButtonNext.Text = "Siguiente";
            ButtonNext.UseVisualStyleBackColor = true;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonPrevious.Location = new Point(534, 346);
            ButtonPrevious.Margin = new Padding(4);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new Size(122, 38);
            ButtonPrevious.TabIndex = 3;
            ButtonPrevious.Text = "Anterior";
            ButtonPrevious.UseVisualStyleBackColor = true;
            ButtonPrevious.Click += ButtonPrevious_Click;
            // 
            // GroupBoxSummary
            // 
            GroupBoxSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxSummary.Controls.Add(LabelSummary);
            GroupBoxSummary.Location = new Point(15, 15);
            GroupBoxSummary.Margin = new Padding(4);
            GroupBoxSummary.Name = "GroupBoxSummary";
            GroupBoxSummary.Padding = new Padding(4);
            GroupBoxSummary.Size = new Size(771, 323);
            GroupBoxSummary.TabIndex = 3;
            GroupBoxSummary.TabStop = false;
            GroupBoxSummary.Text = "Paso 3 - Resumen y finalización:";
            // 
            // LabelSummary
            // 
            LabelSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelSummary.Location = new Point(8, 28);
            LabelSummary.Margin = new Padding(4, 0, 4, 0);
            LabelSummary.Name = "LabelSummary";
            LabelSummary.Size = new Size(756, 300);
            LabelSummary.TabIndex = 0;
            // 
            // GroupBoxStep2
            // 
            GroupBoxStep2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxStep2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GroupBoxStep2.Controls.Add(TableLayoutPanelDevice);
            GroupBoxStep2.Location = new Point(15, 15);
            GroupBoxStep2.Margin = new Padding(4);
            GroupBoxStep2.Name = "GroupBoxStep2";
            GroupBoxStep2.Padding = new Padding(4);
            GroupBoxStep2.Size = new Size(771, 323);
            GroupBoxStep2.TabIndex = 1;
            GroupBoxStep2.TabStop = false;
            GroupBoxStep2.Text = "Paso 2 - seleccione el dispositivo de destino:";
            // 
            // TableLayoutPanelDevice
            // 
            TableLayoutPanelDevice.AutoSize = true;
            TableLayoutPanelDevice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelDevice.ColumnCount = 1;
            TableLayoutPanelDevice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelDevice.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            TableLayoutPanelDevice.Controls.Add(TableLayoutPanelFile, 0, 1);
            TableLayoutPanelDevice.Controls.Add(ListViewDevices, 0, 0);
            TableLayoutPanelDevice.Dock = DockStyle.Fill;
            TableLayoutPanelDevice.Location = new Point(4, 24);
            TableLayoutPanelDevice.Margin = new Padding(4);
            TableLayoutPanelDevice.Name = "TableLayoutPanelDevice";
            TableLayoutPanelDevice.RowCount = 2;
            TableLayoutPanelDevice.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelDevice.RowStyles.Add(new RowStyle());
            TableLayoutPanelDevice.Size = new Size(763, 295);
            TableLayoutPanelDevice.TabIndex = 4;
            // 
            // TableLayoutPanelFile
            // 
            TableLayoutPanelFile.AutoSize = true;
            TableLayoutPanelFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelFile.ColumnCount = 3;
            TableLayoutPanelFile.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelFile.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelFile.Controls.Add(ButtonFile, 2, 0);
            TableLayoutPanelFile.Controls.Add(TextBoxFile, 1, 0);
            TableLayoutPanelFile.Controls.Add(LabelFile, 0, 0);
            TableLayoutPanelFile.Dock = DockStyle.Fill;
            TableLayoutPanelFile.Location = new Point(4, 254);
            TableLayoutPanelFile.Margin = new Padding(4);
            TableLayoutPanelFile.Name = "TableLayoutPanelFile";
            TableLayoutPanelFile.RowCount = 1;
            TableLayoutPanelFile.RowStyles.Add(new RowStyle());
            TableLayoutPanelFile.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            TableLayoutPanelFile.Size = new Size(755, 37);
            TableLayoutPanelFile.TabIndex = 6;
            // 
            // ButtonFile
            // 
            ButtonFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonFile.Location = new Point(713, 4);
            ButtonFile.Margin = new Padding(4);
            ButtonFile.Name = "ButtonFile";
            ButtonFile.Size = new Size(38, 29);
            ButtonFile.TabIndex = 4;
            ButtonFile.Text = "...";
            ButtonFile.UseVisualStyleBackColor = true;
            ButtonFile.Click += ButtonFile_Click;
            // 
            // TextBoxFile
            // 
            TextBoxFile.Dock = DockStyle.Fill;
            TextBoxFile.Location = new Point(183, 4);
            TextBoxFile.Margin = new Padding(4);
            TextBoxFile.Name = "TextBoxFile";
            TextBoxFile.Size = new Size(522, 27);
            TextBoxFile.TabIndex = 3;
            TextBoxFile.Enter += TextBoxFile_Enter;
            // 
            // LabelFile
            // 
            LabelFile.AutoSize = true;
            LabelFile.Dock = DockStyle.Fill;
            LabelFile.Location = new Point(4, 0);
            LabelFile.Margin = new Padding(4, 0, 4, 0);
            LabelFile.Name = "LabelFile";
            LabelFile.Size = new Size(171, 37);
            LabelFile.TabIndex = 2;
            LabelFile.Text = "O especifique el archivo:";
            LabelFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListViewDevices
            // 
            ListViewDevices.Columns.AddRange(new ColumnHeader[] { ColumnHeaderDescription, ColumnHeaderDriveLetter });
            ListViewDevices.Dock = DockStyle.Fill;
            ListViewDevices.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListViewDevices.FullRowSelect = true;
            ListViewDevices.GridLines = true;
            ListViewDevices.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewDevices.LabelWrap = false;
            ListViewDevices.Location = new Point(4, 4);
            ListViewDevices.Margin = new Padding(4);
            ListViewDevices.MultiSelect = false;
            ListViewDevices.Name = "ListViewDevices";
            ListViewDevices.ShowGroups = false;
            ListViewDevices.Size = new Size(755, 242);
            ListViewDevices.TabIndex = 1;
            ListViewDevices.TileSize = new Size(250, 50);
            ListViewDevices.UseCompatibleStateImageBehavior = false;
            ListViewDevices.View = View.Details;
            // 
            // ColumnHeaderDescription
            // 
            ColumnHeaderDescription.Text = "Nombre";
            ColumnHeaderDescription.Width = 330;
            // 
            // ColumnHeaderDriveLetter
            // 
            ColumnHeaderDriveLetter.Text = "Unidad";
            ColumnHeaderDriveLetter.Width = 300;
            // 
            // FormExportGpsFile
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(801, 398);
            Controls.Add(GroupBoxStep2);
            Controls.Add(ButtonPrevious);
            Controls.Add(ButtonNext);
            Controls.Add(ButtonFinish);
            Controls.Add(GroupBoxStep1);
            Controls.Add(GroupBoxSummary);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormExportGpsFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exportar datos a GPS";
            FormClosed += This_FormClosed;
            GroupBoxStep1.ResumeLayout(false);
            GroupBoxStep1.PerformLayout();
            GroupBoxSummary.ResumeLayout(false);
            GroupBoxStep2.ResumeLayout(false);
            GroupBoxStep2.PerformLayout();
            TableLayoutPanelDevice.ResumeLayout(false);
            TableLayoutPanelDevice.PerformLayout();
            TableLayoutPanelFile.ResumeLayout(false);
            TableLayoutPanelFile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton RadioButtonPointsWithData;
        private RadioButton RadioButtonPointsAll;
        private Button ButtonFinish;
        private GroupBox GroupBoxStep1;
        private Button ButtonNext;
        private Button ButtonPrevious;
        private GroupBox GroupBoxSummary;
        private GroupBox GroupBoxStep2;
        private Label LabelSummary;
        private TableLayoutPanel TableLayoutPanelDevice;
        private ListView ListViewDevices;
        private ColumnHeader ColumnHeaderDescription;
        private ColumnHeader ColumnHeaderDriveLetter;
        private TableLayoutPanel TableLayoutPanelFile;
        private Button ButtonFile;
        private TextBox TextBoxFile;
        private Label LabelFile;
    }
}