namespace CSMaps;

public partial class FormAboutBox : Form
{
    public FormAboutBox()
    {
        InitializeComponent();
        LayoutControls();
    }

    private void This_Load(object sender, EventArgs e)
    {
        this.Text = string.Format(Properties.Resources.StringAbout, Program.Info.Title);

        LabelApplicationTitle.Text = Program.Info.Title;
        LabelVersion.Text = string.Format(Properties.Resources.StringApplicationVersionWithDate, Program.Info.Version, Program.Info.FileDateTime.ToString("yyyyMMdd"));
        LabelCopyright.Text = Program.Info.Copyright;
        LabelLicense.Text = Program.LicensedCompany;

        // Propiedades
        ListViewData.Items.Add(new ListViewItem(new string[] { Properties.Resources.StringAboutItemDBServer, Program.DatabaseConfig.Server }));
        ListViewData.Items.Add(new ListViewItem(new string[] { Properties.Resources.StringAboutItemDBDatabase, Program.DatabaseConfig.Database }));
        ListViewData.Items.Add(new ListViewItem(new string[] { Properties.Resources.StringAboutItemReportsPath, Program.GeneralConfig.ReportsPath }));
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
        using var graphics = this.CreateGraphics();
        var itemMaxExtends = CardonerSistemas.Framework.Base.String.GetMaxExtends([Properties.Resources.StringAboutItemDBServer, Properties.Resources.StringAboutItemDBDatabase, Properties.Resources.StringAboutItemReportsPath], graphics, this.Font);
        ListViewData.Columns[0].Width = itemMaxExtends + SystemInformation.BorderSize.Width;
        ListViewData.Columns[1].Width = ListViewData.ClientSize.Width - ListViewData.Columns[0].Width - SystemInformation.BorderSize.Width - SystemInformation.VerticalScrollBarWidth;
    }

}