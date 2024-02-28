using CardonerSistemas.Framework.Base;
using CSMaps.General;

namespace CSMaps.Main
{
    public partial class FormMdi : Form
    {

        #region Declarations

        internal FormEntities formEntities;
        internal FormImport formImport;

        #endregion

        #region Form stuff

        public FormMdi()
        {
            InitializeComponent();
        }

        private void SetAppearance()
        {
            this.Text = Program.ApplicationTitle;
        }

        private void FormMdi_Load(object sender, EventArgs e)
        {
            SetAppearance();
        }

        #endregion

        #region Toolbar commands

        private void ToolStripButtonEntidades_Click(object sender, EventArgs e)
        {
            formEntities ??= new();
            MostrarForm(formEntities);
        }
        private void ToolStripButtonImport_Click(object sender, EventArgs e)
        {
            formImport ??= new();
            formImport.MdiParent = this;
            formImport.Show();
        }

        #endregion

        #region Extra stuff

        private void MostrarForm(Form form)
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
