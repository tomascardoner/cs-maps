using System.Reflection;

namespace CSMaps
{
    public partial class FormAboutBox : Form
    {
        private const string ItemDBServer = "DB - Server";
        private const string ItemDBDatabase = "DB - Database";
        private const string ItemReportsPath = "Reports path";

        public FormAboutBox()
        {
            InitializeComponent();
            LayoutControls();
        }

        private void This_Load(object sender, EventArgs e)
        {
            this.Text = $"Acerca de {Program.ApplicationTitle}";

            LabelApplicationTitle.Text = Program.ApplicationTitle;
            LabelVersion.Text = $"Versión {CardonerSistemas.Framework.Base.Application.Info.Version} - ({File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location):yyyyMMdd})";
            LabelCopyright.Text = Program.Copyright;
            LabelLicense.Text = Program.LicensedCompany;

            // Propiedades
            ListViewData.Items.Add(new ListViewItem(new string[] { ItemDBServer, Program.DatabaseConfig.Server }));
            ListViewData.Items.Add(new ListViewItem(new string[] { ItemDBDatabase, Program.DatabaseConfig.Database }));
            ListViewData.Items.Add(new ListViewItem(new string[] { ItemReportsPath, Program.GeneralConfig.ReportsPath }));
        }

        private void This_Resize(object sender, EventArgs e)
        {
            //LayoutControls();
        }

        private void This_DpiChanged(object sender, DpiChangedEventArgs e)
        {
            LayoutControls();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LayoutControls()
        {
            ListViewData.Columns[0].Width = CardonerSistemas.Framework.Base.String.GetExtends(ItemDBDatabase, this.CreateGraphics(), this.Font) + SystemInformation.BorderSize.Width;
            ListViewData.Columns[1].Width = ListViewData.ClientSize.Width - ListViewData.Columns[0].Width - SystemInformation.BorderSize.Width - SystemInformation.VerticalScrollBarWidth;
        }

    }
}