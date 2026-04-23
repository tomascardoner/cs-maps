using CardonerSistemas.Framework.Base;
using CSMaps.Main;

namespace CSMaps.Users;

public partial class FormUserChangePassword : Form
{

    #region Declarations

    private readonly Models.CSMapsContext _context = new();

    private int _intentos;

    #endregion

    #region Form stuff

    public FormUserChangePassword()
    {
        InitializeComponent();

        SetApperance();
    }

    private void SetApperance()
    {
        Forms.SetFont(this, Program.AppearanceConfig.Font);
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        Common.Forms.This_KeyPress(e, this.ActiveControl, ButtonAceptar, ButtonCancelar, null);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _context?.Dispose();
        this.Dispose();
    }

    #endregion

    #region Controls behavior

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
    }

    private void TextBoxs_Leave(object sender, EventArgs e)
    {
        var textBox = (TextBox)sender;
        textBox.Text = textBox.Text.Trim();
    }

    #endregion

    #region Main toolbar

    private void Aceptar_Click(object sender, EventArgs e)
    {
        // Verifico la contraseña anterior
        if (string.IsNullOrWhiteSpace(TextBoxPasswordAnterior.Text))
        {
            MessageBox.Show("Debe ingresar la contraseña anterior.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordAnterior.Focus();
            return;
        }

        var usuarioPasswordLongitudMinima = Main.Parameters.GetIntegerAsByte(Main.Parameters.ParametersId.UsuarioPasswordLongitudMinima, 8).Value;
        if (TextBoxPasswordAnterior.Text.Trim().Length < usuarioPasswordLongitudMinima)
        {
            MessageBox.Show($"La contraseña anterior debe contener al menos {usuarioPasswordLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordAnterior.Focus();
            return;
        }

        // Verifico la contraseña nueva
        if (string.IsNullOrWhiteSpace(TextBoxPasswordNueva.Text))
        {
            MessageBox.Show("Debe ingresar la contraseña nueva.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordNueva.Focus();
            return;
        }

        if (TextBoxPasswordNueva.Text.Trim().Length < usuarioPasswordLongitudMinima)
        {
            MessageBox.Show($"La contraseña nueva debe contener al menos {usuarioPasswordLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordNueva.Focus();
            return;
        }

        // Verifico la confirmación de la contraseña nueva
        if (string.IsNullOrWhiteSpace(TextBoxPasswordConfirma.Text))
        {
            MessageBox.Show("Debe ingresar la confirmación de la nueva contraseña.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordConfirma.Focus();
            return;
        }

        if (TextBoxPasswordConfirma.Text.Trim().Length < usuarioPasswordLongitudMinima)
        {
            MessageBox.Show($"La confirmación de la nueva contraseña debe contener al menos {usuarioPasswordLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordConfirma.Focus();
            return;
        }

        if (!string.Equals(TextBoxPasswordNueva.Text, TextBoxPasswordConfirma.Text, StringComparison.Ordinal))
        {
            MessageBox.Show("La contraseña nueva es diferente a la confirmación.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordConfirma.Focus();
            return;
        }

        // Verifico que la nueva contraseña sea diferente a la anterior
        if (string.Equals(TextBoxPasswordAnterior.Text, TextBoxPasswordNueva.Text, StringComparison.Ordinal))
        {
            MessageBox.Show("La contraseña nueva debe ser diferente a la anterior.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordNueva.Focus();
            return;
        }

        // Comparo la contraseña anterior ingresada con la del usuario
        if (!CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(Program.Usuario.Password, Main.Constants.PublicEncryptionPassword, out var decryptedPassword))
        {
            this.Cursor = Cursors.Default;
            return;
        }

        if (!string.Equals(TextBoxPasswordAnterior.Text, decryptedPassword, StringComparison.Ordinal))
        {
            MessageBox.Show("La contraseña anterior ingresada es incorrecta.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPasswordAnterior.SelectAll();
            TextBoxPasswordAnterior.Focus();
            this.Cursor = Cursors.Default;
            _intentos++;
            if (_intentos > 3)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            return;
        }

        // Están todos los datos bien así que los guardo
        try
        {
            if (CardonerSistemas.Framework.Cryptography.StringCipher.Encrypt(TextBoxPasswordNueva.Text, Main.Constants.PublicEncryptionPassword, out var encryptedPassword))
            {
                _context.Usuario.Attach(Program.Usuario);
                Program.Usuario.Password = encryptedPassword;
                _context.SaveChanges();
                MessageBox.Show("Se ha cambiado la contraseña del usuario.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, "Error al modificar la contraseña del usuario.");
            this.Cursor = Cursors.Default;
            return;
        }

        this.Cursor = Cursors.Default;
        this.DialogResult = DialogResult.OK;
    }

    private void Cancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    #endregion Main toolbar

}
