namespace CSMaps
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.IconApplication;
            this.Text = Program.Info.Title;
            labelAppTitle.Text = Program.Info.Title;
            labelLicensedTo.Text = string.Empty;
            labelStatus.Text = "Iniciando...";
            labelCopyright.Text = Program.Info.Copyright;
        }
    }
}
