namespace CSMaps.General
{
    partial class FormImportGoogleEarthFile
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
            LabelFile = new Label();
            TextBoxFile = new TextBox();
            ButtonFile = new Button();
            ButtonStart = new Button();
            SuspendLayout();
            // 
            // LabelFile
            // 
            LabelFile.AutoSize = true;
            LabelFile.Location = new Point(12, 16);
            LabelFile.Name = "LabelFile";
            LabelFile.Size = new Size(51, 15);
            LabelFile.TabIndex = 1;
            LabelFile.Text = "Archivo:";
            // 
            // TextBoxFile
            // 
            TextBoxFile.Location = new Point(69, 12);
            TextBoxFile.Name = "TextBoxFile";
            TextBoxFile.Size = new Size(657, 23);
            TextBoxFile.TabIndex = 2;
            TextBoxFile.Enter += TextBoxFile_Enter;
            // 
            // ButtonFile
            // 
            ButtonFile.Location = new Point(732, 11);
            ButtonFile.Name = "ButtonFile";
            ButtonFile.Size = new Size(30, 23);
            ButtonFile.TabIndex = 3;
            ButtonFile.Text = "...";
            ButtonFile.UseVisualStyleBackColor = true;
            ButtonFile.Click += ButtonFile_Click;
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(669, 68);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(93, 34);
            ButtonStart.TabIndex = 4;
            ButtonStart.Text = "Iniciar...";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // FormImportGoogleEarthFile
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(774, 114);
            Controls.Add(ButtonStart);
            Controls.Add(ButtonFile);
            Controls.Add(TextBoxFile);
            Controls.Add(LabelFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImportGoogleEarthFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Importar datos desde archivo de Google Earth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelFile;
        private TextBox TextBoxFile;
        private Button ButtonFile;
        private Button ButtonStart;
    }
}
