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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            RadioButtonGoogleEarthFile = new RadioButton();
            LabelGoogleEarthFile = new Label();
            TextBoxGoogleEarthFile = new TextBox();
            ButtonGoogleEarthFile = new Button();
            ButtonStart = new Button();
            SuspendLayout();
            // 
            // RadioButtonGoogleEarthFile
            // 
            resources.ApplyResources(RadioButtonGoogleEarthFile, "RadioButtonGoogleEarthFile");
            RadioButtonGoogleEarthFile.Checked = true;
            RadioButtonGoogleEarthFile.Name = "RadioButtonGoogleEarthFile";
            RadioButtonGoogleEarthFile.TabStop = true;
            RadioButtonGoogleEarthFile.UseVisualStyleBackColor = true;
            // 
            // LabelGoogleEarthFile
            // 
            resources.ApplyResources(LabelGoogleEarthFile, "LabelGoogleEarthFile");
            LabelGoogleEarthFile.Name = "LabelGoogleEarthFile";
            // 
            // TextBoxGoogleEarthFile
            // 
            resources.ApplyResources(TextBoxGoogleEarthFile, "TextBoxGoogleEarthFile");
            TextBoxGoogleEarthFile.Name = "TextBoxGoogleEarthFile";
            // 
            // ButtonGoogleEarthFile
            // 
            resources.ApplyResources(ButtonGoogleEarthFile, "ButtonGoogleEarthFile");
            ButtonGoogleEarthFile.Name = "ButtonGoogleEarthFile";
            ButtonGoogleEarthFile.UseVisualStyleBackColor = true;
            ButtonGoogleEarthFile.Click += ButtonGoogleEarthFile_Click;
            // 
            // ButtonStart
            // 
            resources.ApplyResources(ButtonStart, "ButtonStart");
            ButtonStart.Name = "ButtonStart";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // FormImport
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonStart);
            Controls.Add(ButtonGoogleEarthFile);
            Controls.Add(TextBoxGoogleEarthFile);
            Controls.Add(LabelGoogleEarthFile);
            Controls.Add(RadioButtonGoogleEarthFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImport";
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
