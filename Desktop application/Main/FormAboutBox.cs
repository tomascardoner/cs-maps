using System.Reflection;

namespace CSMaps
{
    public partial class FormAboutBox : Form
    {
        public FormAboutBox()
        {
            InitializeComponent();
        }

        private void This_Load(object sender, EventArgs e)
        {
            this.Text = $"Acerca de {Program.ApplicationTitle}";

            LabelApplicationTitle.Text = Program.ApplicationTitle;
            LabelVersion.Text = $"Versión {CardonerSistemas.Framework.Base.Application.Info.Version} - ({File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location):yyyyMMdd})";
            LabelCopyright.Text = CardonerSistemas.Framework.Base.Application.Info.Copyright;
            //LabelLicensed.Text = Program.licensedCompany;
            LabelLicense.Visible = false;

            // Propiedades
            ListViewItem newItem;

            newItem = new() { Text = "DB - Server" };
            newItem.SubItems.Add(Program.DatabaseConfig.Server);
            ListViewData.Items.Add(newItem);

            newItem = new() { Text = "DB - Database" };
            newItem.SubItems.Add(Program.DatabaseConfig.Database);
            ListViewData.Items.Add(newItem);

            newItem = new() { Text = "Reports path" };
            newItem.SubItems.Add(Program.GeneralConfig.ReportsPath);
            ListViewData.Items.Add(newItem);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
