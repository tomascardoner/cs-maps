namespace CSMaps.General
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
            ListViewDevices = new ListView();
            ColumnHeaderDescription = new ColumnHeader();
            ColumnHeaderDriveLetter = new ColumnHeader();
            LabelFile = new Label();
            TextBoxFile = new TextBox();
            ButtonFile = new Button();
            GroupBoxStep1.SuspendLayout();
            GroupBoxSummary.SuspendLayout();
            GroupBoxStep2.SuspendLayout();
            SuspendLayout();
            // 
            // RadioButtonPointsAll
            // 
            RadioButtonPointsAll.AutoSize = true;
            RadioButtonPointsAll.Location = new Point(6, 64);
            RadioButtonPointsAll.Name = "RadioButtonPointsAll";
            RadioButtonPointsAll.Size = new Size(56, 19);
            RadioButtonPointsAll.TabIndex = 1;
            RadioButtonPointsAll.Text = "Todos";
            RadioButtonPointsAll.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPointsWithData
            // 
            RadioButtonPointsWithData.AutoSize = true;
            RadioButtonPointsWithData.Checked = true;
            RadioButtonPointsWithData.Location = new Point(6, 39);
            RadioButtonPointsWithData.Name = "RadioButtonPointsWithData";
            RadioButtonPointsWithData.Size = new Size(212, 19);
            RadioButtonPointsWithData.TabIndex = 0;
            RadioButtonPointsWithData.TabStop = true;
            RadioButtonPointsWithData.Text = "Sólo los que tienen datos asociados";
            RadioButtonPointsWithData.UseVisualStyleBackColor = true;
            // 
            // ButtonFinish
            // 
            ButtonFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonFinish.Location = new Point(398, 200);
            ButtonFinish.Name = "ButtonFinish";
            ButtonFinish.Size = new Size(98, 30);
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
            GroupBoxStep1.Location = new Point(12, 12);
            GroupBoxStep1.Name = "GroupBoxStep1";
            GroupBoxStep1.Size = new Size(484, 182);
            GroupBoxStep1.TabIndex = 0;
            GroupBoxStep1.TabStop = false;
            GroupBoxStep1.Text = "Paso 1: seleccione los puntos a incluir";
            // 
            // ButtonNext
            // 
            ButtonNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonNext.Location = new Point(398, 200);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(98, 30);
            ButtonNext.TabIndex = 4;
            ButtonNext.Text = "Siguiente";
            ButtonNext.UseVisualStyleBackColor = true;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonPrevious.Location = new Point(294, 200);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new Size(98, 30);
            ButtonPrevious.TabIndex = 3;
            ButtonPrevious.Text = "Anterior";
            ButtonPrevious.UseVisualStyleBackColor = true;
            ButtonPrevious.Click += ButtonPrevious_Click;
            // 
            // GroupBoxSummary
            // 
            GroupBoxSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxSummary.Controls.Add(LabelSummary);
            GroupBoxSummary.Location = new Point(12, 12);
            GroupBoxSummary.Name = "GroupBoxSummary";
            GroupBoxSummary.Size = new Size(484, 182);
            GroupBoxSummary.TabIndex = 3;
            GroupBoxSummary.TabStop = false;
            GroupBoxSummary.Text = "Paso 3 - Resumen y finalización:";
            // 
            // LabelSummary
            // 
            LabelSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelSummary.Location = new Point(6, 22);
            LabelSummary.Name = "LabelSummary";
            LabelSummary.Size = new Size(472, 163);
            LabelSummary.TabIndex = 0;
            // 
            // GroupBoxStep2
            // 
            GroupBoxStep2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxStep2.Controls.Add(ListViewDevices);
            GroupBoxStep2.Controls.Add(LabelFile);
            GroupBoxStep2.Controls.Add(TextBoxFile);
            GroupBoxStep2.Controls.Add(ButtonFile);
            GroupBoxStep2.Location = new Point(12, 12);
            GroupBoxStep2.Name = "GroupBoxStep2";
            GroupBoxStep2.Size = new Size(484, 182);
            GroupBoxStep2.TabIndex = 1;
            GroupBoxStep2.TabStop = false;
            GroupBoxStep2.Text = "Paso 2 - seleccione el dispositivo de destino:";
            // 
            // ListViewDevices
            // 
            ListViewDevices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListViewDevices.Columns.AddRange(new ColumnHeader[] { ColumnHeaderDescription, ColumnHeaderDriveLetter });
            ListViewDevices.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListViewDevices.FullRowSelect = true;
            ListViewDevices.GridLines = true;
            ListViewDevices.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewDevices.LabelWrap = false;
            ListViewDevices.Location = new Point(6, 22);
            ListViewDevices.MultiSelect = false;
            ListViewDevices.Name = "ListViewDevices";
            ListViewDevices.ShowGroups = false;
            ListViewDevices.Size = new Size(472, 124);
            ListViewDevices.TabIndex = 0;
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
            ColumnHeaderDriveLetter.Width = 110;
            // 
            // LabelFile
            // 
            LabelFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelFile.AutoSize = true;
            LabelFile.Location = new Point(6, 156);
            LabelFile.Name = "LabelFile";
            LabelFile.Size = new Size(136, 15);
            LabelFile.TabIndex = 1;
            LabelFile.Text = "O especifique el archivo:";
            // 
            // TextBoxFile
            // 
            TextBoxFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxFile.Location = new Point(148, 153);
            TextBoxFile.Name = "TextBoxFile";
            TextBoxFile.Size = new Size(294, 23);
            TextBoxFile.TabIndex = 2;
            // 
            // ButtonFile
            // 
            ButtonFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonFile.Location = new Point(448, 152);
            ButtonFile.Name = "ButtonFile";
            ButtonFile.Size = new Size(30, 23);
            ButtonFile.TabIndex = 3;
            ButtonFile.Text = "...";
            ButtonFile.UseVisualStyleBackColor = true;
            ButtonFile.Click += ButtonFile_Click;
            // 
            // FormExportGpsFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 242);
            Controls.Add(GroupBoxStep2);
            Controls.Add(ButtonPrevious);
            Controls.Add(ButtonNext);
            Controls.Add(ButtonFinish);
            Controls.Add(GroupBoxStep1);
            Controls.Add(GroupBoxSummary);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormExportGpsFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exportar datos a archivo de GPS";
            FormClosed += This_FormClosed;
            GroupBoxStep1.ResumeLayout(false);
            GroupBoxStep1.PerformLayout();
            GroupBoxSummary.ResumeLayout(false);
            GroupBoxStep2.ResumeLayout(false);
            GroupBoxStep2.PerformLayout();
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
        private ListView ListViewDevices;
        private TextBox TextBoxFile;
        private Label LabelFile;
        private Button ButtonFile;
        private Label LabelSummary;
        private ColumnHeader ColumnHeaderDescription;
        private ColumnHeader ColumnHeaderDriveLetter;
    }
}