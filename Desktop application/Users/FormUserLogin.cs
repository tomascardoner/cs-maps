using CardonerSistemas.Framework.Base;
using System.Data;

namespace CSMaps.Users;

public partial class FormUserLogin : Form
{

    #region Declarations

    private Models.CSMapsContext context = new();

    int intentos;

    #endregion

    #region Form stuff

    public FormUserLogin()
    {
        InitializeComponent();
        InitializeFormAndControls();
    }

    private void InitializeFormAndControls()
    {
        if (Program.AppearanceConfig.ShowLastLoggedInUser && !string.IsNullOrWhiteSpace(Properties.Settings.Default.LastLoggedInUser))
        {
            TextBoxNombre.Text = Properties.Settings.Default.LastLoggedInUser;
            LabelPassword.TabIndex = 0;
            TextBoxPassword.TabIndex = 1;
            LabelNombre.TabIndex = 6;
            TextBoxNombre.TabIndex = 7;
        }
    }

    private void This_FormClosed(object sender, FormClosedEventArgs e)
    {
        context.Dispose();
        context = null;
        this.Dispose();
    }

    #endregion

    #region Controls behavior

    private void This_KeyPress(object sender, KeyPressEventArgs e)
    {
        switch (e.KeyChar)
        {
            case (char)Keys.Return:
                ButtonAceptar.PerformClick();
                break;
            case (char)Keys.Escape:
                ButtonCancelar.PerformClick();
                break;
            default:
                break;
        }
    }

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
    }

    private void TextBoxs_Leave(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        textBox.Text = textBox.Text.Trim();
    }

    #endregion

    #region Main toolbar

    private void Aceptar_Click(object sender, EventArgs e)
    {
        // Verifico el nombre de usuario ingresado
        TextBoxNombre.Text = TextBoxNombre.Text.Trim().RemoveSpaces();
        if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
        {
            MessageBox.Show("Debe ingresar el nombre de usuario.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxNombre.Focus();
            return;
        }
        byte usuarioNombreLongitudMinima = Parameters.GetIntegerAsByte(Parameters.ParametersId.UsuarioNombreLongitudMinima, 5).Value;
        if (TextBoxNombre.Text.Length < usuarioNombreLongitudMinima)
        {
            MessageBox.Show($"El nombre de usuario debe contener al menos {usuarioNombreLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxNombre.Focus();
            return;
        }

        // Verifico la contraseña ingresada
        if (string.IsNullOrWhiteSpace(TextBoxPassword.Text))
        {
            MessageBox.Show("Debe ingresar la contraseña.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPassword.Focus();
            return;
        }
        byte usuarioPasswordLongitudMinima = Parameters.GetIntegerAsByte(Parameters.ParametersId.UsuarioPasswordLongitudMinima, 8).Value;
        if (TextBoxPassword.Text.Trim().Length < usuarioPasswordLongitudMinima)
        {
            MessageBox.Show($"La contraseña debe contener al menos {usuarioPasswordLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPassword.Focus();
            return;
        }

        // Busco el usuario en la base de datos
        this.Cursor = Cursors.WaitCursor;
        Models.Usuario usuario;
        try
        {
            usuario = context.Usuarios.Where(u => u.Nombre == TextBoxNombre.Text).FirstOrDefault();
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, "Error al obtener los datos del usuario ingresado.");
            usuario = null;
            this.Cursor = Cursors.Default;
            return;
        }

        // Verifico que el usuario exista
        if (usuario == null)
        {
            MessageBox.Show("No se encontró un usuario con ese nombre.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxNombre.SelectAll();
            TextBoxNombre.Focus();
            usuario = null;
            this.Cursor = Cursors.Default;
            intentos++;
            if (intentos > 3)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            return;
        }

        // Comparo la contraseña ingresada con la del usuario
        if (!CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(usuario.Password, Main.Constants.PublicEncryptionPassword, out string decryptedPassword, out string decryptionResultMessage))
        {
            usuario = null;
            this.Cursor = Cursors.Default;
            MessageBox.Show($"No se ha podido desencriptar la contraseña del usuario en la base de datos.\n\n{decryptionResultMessage}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (string.Compare(TextBoxPassword.Text, decryptedPassword, false) != 0)
        {
            MessageBox.Show("La contraseña ingresada es incorrecta.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TextBoxPassword.SelectAll();
            TextBoxPassword.Focus();
            usuario = null;
            this.Cursor = Cursors.Default;
            intentos++;
            if (intentos > 3)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            return;
        }

        // Están todos los datos bien así que los guardo
#pragma warning disable S2696 // Make the enclosing instance method 'static' or remove this set on the 'static' field.
        Program.Usuario = usuario;
#pragma warning restore S2696 // Make the enclosing instance method 'static' or remove this set on the 'static' field.
        Properties.Settings.Default.LastLoggedInUser = usuario.Nombre;
        Properties.Settings.Default.Save();
        usuario = null;

        Users.LogIn();

        this.Cursor = Cursors.Default;
        this.DialogResult = DialogResult.OK;
    }

    private void Cancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    #endregion

}
