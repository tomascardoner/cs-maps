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
            GroupBoxIncludedPoints = new GroupBox();
            RadioButtonPointsAll = new RadioButton();
            RadioButtonPointsWithData = new RadioButton();
            ButtonStart = new Button();
            ButtonFile = new Button();
            TextBoxFile = new TextBox();
            LabelFile = new Label();
            ButtonFileFindGps = new Button();
            GroupBoxIncludedPoints.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxIncludedPoints
            // 
            GroupBoxIncludedPoints.Controls.Add(RadioButtonPointsAll);
            GroupBoxIncludedPoints.Controls.Add(RadioButtonPointsWithData);
            GroupBoxIncludedPoints.Location = new Point(12, 12);
            GroupBoxIncludedPoints.Name = "GroupBoxIncludedPoints";
            GroupBoxIncludedPoints.Size = new Size(318, 77);
            GroupBoxIncludedPoints.TabIndex = 0;
            GroupBoxIncludedPoints.TabStop = false;
            GroupBoxIncludedPoints.Text = "Puntos a incluir:";
            // 
            // RadioButtonPointsAll
            // 
            RadioButtonPointsAll.AutoSize = true;
            RadioButtonPointsAll.Location = new Point(6, 47);
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
            RadioButtonPointsWithData.Location = new Point(6, 22);
            RadioButtonPointsWithData.Name = "RadioButtonPointsWithData";
            RadioButtonPointsWithData.Size = new Size(212, 19);
            RadioButtonPointsWithData.TabIndex = 0;
            RadioButtonPointsWithData.TabStop = true;
            RadioButtonPointsWithData.Text = "Sólo los que tienen datos asociados";
            RadioButtonPointsWithData.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(672, 166);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(93, 34);
            ButtonStart.TabIndex = 5;
            ButtonStart.Text = "Iniciar...";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonFile
            // 
            ButtonFile.Location = new Point(635, 109);
            ButtonFile.Name = "ButtonFile";
            ButtonFile.Size = new Size(30, 23);
            ButtonFile.TabIndex = 3;
            ButtonFile.Text = "...";
            ButtonFile.UseVisualStyleBackColor = true;
            ButtonFile.Click += ButtonFile_Click;
            // 
            // TextBoxFile
            // 
            TextBoxFile.Location = new Point(130, 110);
            TextBoxFile.Name = "TextBoxFile";
            TextBoxFile.Size = new Size(499, 23);
            TextBoxFile.TabIndex = 2;
            TextBoxFile.Enter += TextBoxFile_Enter;
            // 
            // LabelFile
            // 
            LabelFile.AutoSize = true;
            LabelFile.Location = new Point(15, 114);
            LabelFile.Name = "LabelFile";
            LabelFile.Size = new Size(109, 15);
            LabelFile.TabIndex = 1;
            LabelFile.Text = "Archivo de destino:";
            // 
            // ButtonFileFindGps
            // 
            ButtonFileFindGps.Location = new Point(671, 109);
            ButtonFileFindGps.Name = "ButtonFileFindGps";
            ButtonFileFindGps.Size = new Size(91, 23);
            ButtonFileFindGps.TabIndex = 4;
            ButtonFileFindGps.Text = "Buscar GPS";
            ButtonFileFindGps.UseVisualStyleBackColor = true;
            ButtonFileFindGps.Click += ButtonFileFindGps_Click;
            // 
            // FormExportGpsFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 214);
            Controls.Add(ButtonFileFindGps);
            Controls.Add(ButtonStart);
            Controls.Add(ButtonFile);
            Controls.Add(TextBoxFile);
            Controls.Add(LabelFile);
            Controls.Add(GroupBoxIncludedPoints);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormExportGpsFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exportar datos a archivo de GPS";
            FormClosed += This_FormClosed;
            GroupBoxIncludedPoints.ResumeLayout(false);
            GroupBoxIncludedPoints.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox GroupBoxIncludedPoints;
        private RadioButton RadioButtonPointsWithData;
        private RadioButton RadioButtonPointsAll;
        private Button ButtonStart;
        private Button ButtonFile;
        private TextBox TextBoxFile;
        private Label LabelFile;
        private Button ButtonFileFindGps;
    }
}