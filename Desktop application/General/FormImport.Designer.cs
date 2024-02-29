namespace CSMaps
{
    partial class FormImport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RadioButtonGoogleEarthFile = new RadioButton();
            LabelGoogleEarthFile = new Label();
            TextBoxGoogleEarthFile = new TextBox();
            ButtonGoogleEarthFile = new Button();
            ButtonStart = new Button();
            SuspendLayout();
            // 
            // RadioButtonGoogleEarthFile
            // 
            RadioButtonGoogleEarthFile.AutoSize = true;
            RadioButtonGoogleEarthFile.Checked = true;
            RadioButtonGoogleEarthFile.Location = new Point(12, 12);
            RadioButtonGoogleEarthFile.Name = "RadioButtonGoogleEarthFile";
            RadioButtonGoogleEarthFile.Size = new Size(225, 19);
            RadioButtonGoogleEarthFile.TabIndex = 0;
            RadioButtonGoogleEarthFile.TabStop = true;
            RadioButtonGoogleEarthFile.Text = "Puntos desde archivo de Google Earth";
            RadioButtonGoogleEarthFile.UseVisualStyleBackColor = true;
            // 
            // LabelGoogleEarthFile
            // 
            LabelGoogleEarthFile.AutoSize = true;
            LabelGoogleEarthFile.Location = new Point(38, 44);
            LabelGoogleEarthFile.Name = "LabelGoogleEarthFile";
            LabelGoogleEarthFile.Size = new Size(51, 15);
            LabelGoogleEarthFile.TabIndex = 1;
            LabelGoogleEarthFile.Text = "Archivo:";
            // 
            // TextBoxGoogleEarthFile
            // 
            TextBoxGoogleEarthFile.Location = new Point(95, 41);
            TextBoxGoogleEarthFile.Name = "TextBoxGoogleEarthFile";
            TextBoxGoogleEarthFile.Size = new Size(657, 23);
            TextBoxGoogleEarthFile.TabIndex = 2;
            // 
            // ButtonGoogleEarthFile
            // 
            ButtonGoogleEarthFile.Location = new Point(758, 41);
            ButtonGoogleEarthFile.Name = "ButtonGoogleEarthFile";
            ButtonGoogleEarthFile.Size = new Size(30, 23);
            ButtonGoogleEarthFile.TabIndex = 3;
            ButtonGoogleEarthFile.Text = "...";
            ButtonGoogleEarthFile.UseVisualStyleBackColor = true;
            ButtonGoogleEarthFile.Click += ButtonGoogleEarthFile_Click;
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(695, 109);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(93, 34);
            ButtonStart.TabIndex = 4;
            ButtonStart.Text = "Iniciar...";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // FormImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 155);
            Controls.Add(ButtonStart);
            Controls.Add(ButtonGoogleEarthFile);
            Controls.Add(TextBoxGoogleEarthFile);
            Controls.Add(LabelGoogleEarthFile);
            Controls.Add(RadioButtonGoogleEarthFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Importar datos";
            FormClosed += FormImport_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadioButtonGoogleEarthFile;
        private Label LabelGoogleEarthFile;
        private TextBox TextBoxGoogleEarthFile;
        private Button ButtonGoogleEarthFile;
        private Button ButtonStart;
    }
}
