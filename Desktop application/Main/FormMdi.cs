using CardonerSistemas.Framework.Base;
using CSMaps.General;

namespace CSMaps.Main
{
    public partial class FormMdi : Form
    {

        #region Declarations

        internal FormEntities formEntities;
        internal FormSettlements formSettlements;
        internal FormImport formImport;

        #endregion

        #region Form stuff

        public FormMdi()
        {
            InitializeComponent();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.IconApplication.ToBitmap());
            this.Text = Program.ApplicationTitle;
        }

        private void FormMdi_Load(object sender, EventArgs e)
        {
            SetAppearance();
        }

        #endregion

        #region Toolbar commands

        private void ToolStripButtonEntities_Click(object sender, EventArgs e)
        {
            formEntities ??= new();
            ShowMdiForm(formEntities);
        }

        private void ToolStripButtonSettlements_Click(object sender, EventArgs e)
        {
            formSettlements ??= new();
            ShowMdiForm(formSettlements);
        }

        private void ToolStripButtonImport_Click(object sender, EventArgs e)
        {
            formImport ??= new() { MdiParent = this };
            formImport.Show();
        }

        #endregion

        #region Extra stuff

        private void ShowMdiForm(Form form)
        {
            Application.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            Forms.MdiChildPositionAndSizeToFit(this, form);
            form.Show();
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            form.Focus();

            this.Cursor = Cursors.Default;
            Application.UseWaitCursor = false;
            Application.DoEvents();
        }

        #endregion

    }
}
