using CardonerSistemas.Framework.Base;

namespace CSMaps.General;

public partial class FormPointFind : Form
{
    private readonly List<Models.Punto> puntos;

    public FormPointFind()
    {
        InitializeComponent();
        SetAppearance();

        ComboBoxTipoBusqueda.Items.AddRange([Properties.Resources.StringTextFilterTypeBegin, Properties.Resources.StringTextFilterTypeContains]);
        ComboBoxTipoBusqueda.SelectedIndex = 1;

        this.Cursor = Cursors.WaitCursor;
        using Models.CSMapsContext context = new();
        puntos = [.. context.Puntos.OrderBy(p => p.Nombre)];
        this.Cursor = Cursors.Default;
    }

    private void SetAppearance()
    {
        Forms.SetFont(this, Program.AppearanceConfig.Font);
        Common.Appearance.SetControlsDataGridViews(this.Controls, false);
    }

    private void TextBoxNombre_Enter(object sender, EventArgs e)
    {
        TextBoxNombre.SelectAll();
    }

    private void ButtonBuscarPunto_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
        {
            MessageBox.Show("Debe ingresar el nombre a buscar.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (TextBoxNombre.Text.Trim().Length < 3)
        {
            MessageBox.Show("El nombre a buscar debe tener al menos 3 caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        List<Models.Punto> puntosFiltrados;

        if (ComboBoxTipoBusqueda.SelectedIndex == 0)
        {
            puntosFiltrados = [.. puntos.Where(p => p.Nombre.ReplaceDiacritics().StartsWith(TextBoxNombre.Text.Trim().ReplaceDiacritics()))];
        }
        else
        {
            puntosFiltrados = [.. puntos.Where(p => p.Nombre.ReplaceDiacritics().Contains(TextBoxNombre.Text.Trim().ReplaceDiacritics()))];
        }

        if (puntosFiltrados.Count == 0)
        {
            MessageBox.Show("No se encontraron puntos que coincidan con la búsqueda.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DataGridViewMain.AutoGenerateColumns = false;
        DataGridViewMain.DataSource = puntosFiltrados;
    }

    private void ToolStripButtonSelect_Click(object sender, EventArgs e)
    {
        if (DataGridViewMain.CurrentRow == null)
        {
            MessageBox.Show(string.Format(Properties.Resources.StringActionNoneMale, "punto", Properties.Resources.StringActionSelect), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        this.DialogResult = DialogResult.OK;
        this.Hide();
    }

    private void ToolStripButtonCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Hide();
    }

    private void DataGridViewMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        ToolStripButtonSelect.PerformClick();
    }
}
