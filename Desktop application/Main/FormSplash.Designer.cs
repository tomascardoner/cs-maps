namespace CSMaps
{
    partial class FormSplash
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
            labelStatus = new Label();
            labelLicensedTo = new Label();
            labelCopyright = new Label();
            labelAppTitle = new Label();
            PictureBoxCompanyLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.ForeColor = Color.Black;
            labelStatus.Location = new Point(13, 253);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(507, 18);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLicensedTo
            // 
            labelLicensedTo.BackColor = Color.Transparent;
            labelLicensedTo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLicensedTo.ForeColor = Color.Blue;
            labelLicensedTo.Location = new Point(13, 214);
            labelLicensedTo.Margin = new Padding(4, 0, 4, 0);
            labelLicensedTo.Name = "labelLicensedTo";
            labelLicensedTo.Size = new Size(507, 30);
            labelLicensedTo.TabIndex = 9;
            labelLicensedTo.Text = "LicensedTo";
            labelLicensedTo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCopyright
            // 
            labelCopyright.BackColor = Color.Transparent;
            labelCopyright.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCopyright.ForeColor = Color.MediumTurquoise;
            labelCopyright.Location = new Point(13, 273);
            labelCopyright.Margin = new Padding(4, 0, 4, 0);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(507, 18);
            labelCopyright.TabIndex = 8;
            labelCopyright.Text = "Copyright";
            labelCopyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAppTitle
            // 
            labelAppTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAppTitle.BackColor = Color.Transparent;
            labelAppTitle.Font = new Font("Tahoma", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAppTitle.ForeColor = Color.DarkRed;
            labelAppTitle.Location = new Point(13, 103);
            labelAppTitle.Margin = new Padding(4, 0, 4, 0);
            labelAppTitle.Name = "labelAppTitle";
            labelAppTitle.Size = new Size(507, 72);
            labelAppTitle.TabIndex = 6;
            labelAppTitle.Text = "Title";
            // 
            // PictureBoxCompanyLogo
            // 
            PictureBoxCompanyLogo.BackColor = Color.White;
            PictureBoxCompanyLogo.Image = Properties.Resources.ImageCardonerSistemas;
            PictureBoxCompanyLogo.Location = new Point(332, 12);
            PictureBoxCompanyLogo.Margin = new Padding(4, 3, 4, 3);
            PictureBoxCompanyLogo.Name = "PictureBoxCompanyLogo";
            PictureBoxCompanyLogo.Size = new Size(188, 58);
            PictureBoxCompanyLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxCompanyLogo.TabIndex = 17;
            PictureBoxCompanyLogo.TabStop = false;
            // 
            // FormSplash
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(192, 192, 0);
            BackgroundImage = Properties.Resources.ImageSplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(533, 300);
            ControlBox = false;
            Controls.Add(PictureBoxCompanyLogo);
            Controls.Add(labelAppTitle);
            Controls.Add(labelLicensedTo);
            Controls.Add(labelStatus);
            Controls.Add(labelCopyright);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App.Title";
            ((System.ComponentModel.ISupportInitialize)PictureBoxCompanyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.Label labelStatus;
        internal System.Windows.Forms.Label labelLicensedTo;
        internal System.Windows.Forms.Label labelCopyright;
        internal System.Windows.Forms.Label labelAppTitle;
        internal PictureBox PictureBoxCompanyLogo;
    }
}