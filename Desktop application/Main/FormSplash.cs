namespace CSMaps
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.IconApplication;
            this.Text = Program.ApplicationTitle;
            labelAppTitle.Text = Program.ApplicationTitle;
            labelLicensedTo.Text = string.Empty;
            labelStatus.Text = "Iniciando...";
            labelCopyright.Text = CardonerSistemas.Framework.Base.Application.Info.Copyright;
        }
    }
}
