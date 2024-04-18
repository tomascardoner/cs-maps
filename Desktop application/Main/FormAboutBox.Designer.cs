namespace CSMaps
{
    partial class FormAboutBox
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
            PictureBoxCompanyLogo = new PictureBox();
            LabelLicense = new Label();
            PictureBoxIcon = new PictureBox();
            LabelApplicationTitle = new Label();
            LabelVersion = new Label();
            LabelCopyright = new Label();
            ListViewData = new ListView();
            ColumnName = new ColumnHeader();
            ColumnValue = new ColumnHeader();
            ButtonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCompanyLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxCompanyLogo
            // 
            PictureBoxCompanyLogo.Image = Properties.Resources.ImageCardonerSistemas;
            PictureBoxCompanyLogo.Location = new Point(352, 73);
            PictureBoxCompanyLogo.Margin = new Padding(4, 3, 4, 3);
            PictureBoxCompanyLogo.Name = "PictureBoxCompanyLogo";
            PictureBoxCompanyLogo.Size = new Size(149, 44);
            PictureBoxCompanyLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxCompanyLogo.TabIndex = 16;
            PictureBoxCompanyLogo.TabStop = false;
            // 
            // LabelLicense
            // 
            LabelLicense.BackColor = Color.Transparent;
            LabelLicense.BorderStyle = BorderStyle.Fixed3D;
            LabelLicense.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLicense.ForeColor = SystemColors.ControlText;
            LabelLicense.Location = new Point(14, 128);
            LabelLicense.Margin = new Padding(4, 0, 4, 0);
            LabelLicense.Name = "LabelLicense";
            LabelLicense.Size = new Size(488, 36);
            LabelLicense.TabIndex = 15;
            LabelLicense.Text = "LicensedTo";
            LabelLicense.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBoxIcon
            // 
            PictureBoxIcon.Image = Properties.Resources.ImagePunto32;
            PictureBoxIcon.Location = new Point(14, 14);
            PictureBoxIcon.Margin = new Padding(4, 3, 4, 3);
            PictureBoxIcon.Name = "PictureBoxIcon";
            PictureBoxIcon.Size = new Size(105, 111);
            PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxIcon.TabIndex = 9;
            PictureBoxIcon.TabStop = false;
            // 
            // LabelApplicationTitle
            // 
            LabelApplicationTitle.Anchor = AnchorStyles.None;
            LabelApplicationTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelApplicationTitle.Location = new Point(130, 14);
            LabelApplicationTitle.Margin = new Padding(7, 0, 4, 0);
            LabelApplicationTitle.Name = "LabelApplicationTitle";
            LabelApplicationTitle.Size = new Size(372, 33);
            LabelApplicationTitle.TabIndex = 10;
            LabelApplicationTitle.Text = "Application Title";
            LabelApplicationTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelVersion
            // 
            LabelVersion.Location = new Point(130, 47);
            LabelVersion.Margin = new Padding(7, 0, 4, 0);
            LabelVersion.Name = "LabelVersion";
            LabelVersion.Size = new Size(372, 21);
            LabelVersion.TabIndex = 11;
            LabelVersion.Text = "Version";
            LabelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelCopyright
            // 
            LabelCopyright.Location = new Point(130, 81);
            LabelCopyright.Margin = new Padding(7, 0, 4, 0);
            LabelCopyright.Name = "LabelCopyright";
            LabelCopyright.Size = new Size(216, 44);
            LabelCopyright.TabIndex = 12;
            LabelCopyright.Text = "Copyright";
            // 
            // ListViewData
            // 
            ListViewData.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnValue });
            ListViewData.FullRowSelect = true;
            ListViewData.GridLines = true;
            ListViewData.HeaderStyle = ColumnHeaderStyle.None;
            ListViewData.Location = new Point(14, 167);
            ListViewData.Margin = new Padding(4, 3, 4, 3);
            ListViewData.MultiSelect = false;
            ListViewData.Name = "ListViewData";
            ListViewData.ShowGroups = false;
            ListViewData.ShowItemToolTips = true;
            ListViewData.Size = new Size(487, 133);
            ListViewData.TabIndex = 14;
            ListViewData.UseCompatibleStateImageBehavior = false;
            ListViewData.View = View.Details;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Propiedad";
            ColumnName.Width = 100;
            // 
            // ColumnValue
            // 
            ColumnValue.Text = "Valor";
            ColumnValue.Width = 100;
            // 
            // ButtonOk
            // 
            ButtonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonOk.DialogResult = DialogResult.Cancel;
            ButtonOk.Location = new Point(414, 308);
            ButtonOk.Margin = new Padding(4, 3, 4, 3);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(88, 27);
            ButtonOk.TabIndex = 13;
            ButtonOk.Text = "&OK";
            ButtonOk.Click += ButtonOk_Click;
            // 
            // FormAboutBox
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(516, 348);
            Controls.Add(PictureBoxCompanyLogo);
            Controls.Add(LabelLicense);
            Controls.Add(PictureBoxIcon);
            Controls.Add(LabelApplicationTitle);
            Controls.Add(LabelVersion);
            Controls.Add(LabelCopyright);
            Controls.Add(ListViewData);
            Controls.Add(ButtonOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAboutBox";
            Padding = new Padding(10);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAboutBox";
            Load += This_Load;
            DpiChanged += This_DpiChanged;
            ((System.ComponentModel.ISupportInitialize)PictureBoxCompanyLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal PictureBox PictureBoxCompanyLogo;
        internal Label LabelLicense;
        internal PictureBox PictureBoxIcon;
        internal Label LabelApplicationTitle;
        internal Label LabelVersion;
        internal Label LabelCopyright;
        internal Button ButtonOk;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnValue;
        private ListView ListViewData;
    }
}