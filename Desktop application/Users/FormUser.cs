using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.Users;

public partial class FormUser : Form
{

    #region Declarations

    private const string entityNameSingular = "usuario";
    private const bool entityIsFemale = false;

    private readonly bool isLoading;
    private readonly bool isNew;
    private bool isEditMode;

    private Models.CSMapsContext context = new();
    private Models.Usuario usuario;

    #endregion

    #region Form stuff

    public FormUser(bool editMode, short idUsuario)
    {
        InitializeComponent();

        isLoading = true;
        isNew = (idUsuario == 0);
        isEditMode = editMode;

        if (isNew)
        {
            usuario = new();
            InitializeNewObjectData();
            context.Usuarios.Add(usuario);
        }
        else
        {
            usuario = context.Usuarios.Find(idUsuario);
        }

        InitializeFormAndControls();
        SetDataToUserInterface();
        isLoading = false;

        ChangeEditMode();
    }

    private void InitializeFormAndControls()
    {
        SetAppearance();

        Common.Lists.GetGenders(ComboBoxGenero, false);
        Common.Lists.GetUsersGroups(ComboBoxUsuarioGrupo, context, false, false);
    }

    private void SetAppearance()
    {
        this.Text = entityNameSingular.FirstCharToUpperCase();
        Forms.SetFont(this, Program.AppearanceConfig.Font);
    }

    private void ChangeEditMode()
    {
        if (isLoading)
        {
            return;
        }

        ToolStripButtonSave.Visible = isEditMode;
        ToolStripButtonCancel.Visible = isEditMode;
        ToolStripButtonEdit.Visible = !isEditMode;
        ToolStripButtonClose.Visible = !isEditMode;

        // General
        TextBoxNombre.ReadOnly = !isEditMode;
        TextBoxDescripcion.ReadOnly = !isEditMode;
        TextBoxPassword.ReadOnly = !isEditMode;
        ComboBoxGenero.Enabled = isEditMode;
        ComboBoxUsuarioGrupo.Enabled = isEditMode;

        // Notas y Auditoría
        TextBoxNotas.ReadOnly = !isEditMode;
        CheckBoxEsActivo.Enabled = isEditMode;
    }

    private void This_FormClosed(object sender, FormClosedEventArgs e)
    {
        context.Dispose();
        context = null;
        usuario = null;
        this.Dispose();
    }

    #endregion

    #region User interface data

    private void SetDataToUserInterface()
    {
        // General
        Values.ToControl(TextBoxNombre, usuario.Nombre);
        Values.ToControl(TextBoxDescripcion, usuario.Descripcion);
        if (string.IsNullOrWhiteSpace(usuario.Password))
        {
            TextBoxPassword.Text = string.Empty;
        }
        else
        {
            if (CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(usuario.Password, Main.Constants.PublicEncryptionPassword, out var decryptedPassword))
            {
                TextBoxPassword.Text = decryptedPassword;
            }
            else
            {
                TextBoxPassword.Text = string.Empty;
            }
        }

        Values.ToControl(ComboBoxGenero, usuario.Genero, ComboBoxExtension.SelectedItemOptions.Value, Main.Constants.GenderUnknown);
        Values.ToControl(ComboBoxUsuarioGrupo, usuario.IdUsuarioGrupo);

        // Notas y Auditoría
        Values.ToControl(TextBoxNotas, usuario.Notas);
        Values.ToControl(CheckBoxEsActivo, usuario.EsActivo);
        Values.ToControl(TextBoxId, usuario.IdUsuario, true, entityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, usuario.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.GetDescription(context, usuario.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, usuario.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.GetDescription(context, usuario.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        // General
        usuario.Nombre = Values.ToString(TextBoxNombre);
        usuario.Descripcion = Values.ToString(TextBoxDescripcion);
        if (CardonerSistemas.Framework.Cryptography.StringCipher.Encrypt(TextBoxPassword.Text.Trim(), Main.Constants.PublicEncryptionPassword, out var encryptedPassword))
        {
            usuario.Password = encryptedPassword;
        }
        else
        {
            usuario.Password = null;
        }

        usuario.Genero = Values.ToString(ComboBoxGenero, Main.Constants.GenderUnknown);
        usuario.IdUsuarioGrupo = Values.ToByte(ComboBoxUsuarioGrupo).Value;

        // Notas y Auditoría
        usuario.Notas = Values.ToString(TextBoxNotas);
        usuario.EsActivo = Values.ToBoolean(CheckBoxEsActivo);
    }

    #endregion

    #region Controls events

    private void This_KeyPress(object sender, KeyPressEventArgs e)
    {
        Common.Forms.This_KeyPress(e, isEditMode, this.ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, [TextBoxNotas]);
    }

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
    }

    private void TextboxNombre_Leave(object sender, EventArgs e)
    {
        TextBoxNombre.Text = TextBoxNombre.Text.RemoveSpaces();
    }

    #endregion

    #region Main toolbar

    private void ToolStripButtonSave_Click(object sender, EventArgs e)
    {
        if (!VerifyData())
        {
            return;
        }

        if (!CompleteNewObjectData())
        {
            return;
        }

        SetDataToEntityObject();

        if (context.ChangeTracker.HasChanges())
        {
            this.Cursor = Cursors.WaitCursor;
            usuario.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            usuario.FechaHoraUltimaModificacion = DateTime.Now;
            try
            {
                context.SaveChanges();
                Common.RefreshLists.Users(usuario.IdUsuario);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                this.Cursor = Cursors.Default;
                Common.DBErrors.DbUpdateException(dbUEx, entityNameSingular, entityIsFemale, isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                return;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Common.DBErrors.OtherUpdateException(ex, entityNameSingular, entityIsFemale, isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                return;
            }
        }

        this.Close();
    }

    private void ToolStripButtonCancel_Click(object sender, EventArgs e)
    {
        if (Common.Forms.ButtonCancel_Click(context))
        {
            this.Close();
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Permissions.Verify(Permissions.Actions.UserEdit))
        {
            isEditMode = true;
            ChangeEditMode();
        }
    }

    private void ToolStripButtonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #endregion

    #region New object initialization

    private void InitializeNewObjectData()
    {
        usuario.EsActivo = true;
        usuario.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        usuario.FechaHoraCreacion = DateTime.Now;
        usuario.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        usuario.FechaHoraUltimaModificacion = usuario.FechaHoraCreacion;
    }

    private bool CompleteNewObjectData()
    {
        if (!isNew)
        {
            return true;
        }

        try
        {
            using Models.CSMapsContext newIdContext = new();
            if (newIdContext.Usuarios.Any())
            {
                usuario.IdUsuario = (short)(newIdContext.Usuarios.Max(u => u.IdUsuario) + 1);
            }
            else
            {
                usuario.IdUsuario = 1;
            }

            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, string.Format(entityIsFemale ? Properties.Resources.StringEntityNewValuesErrorFemale : Properties.Resources.StringEntityNewValuesErrorMale, entityNameSingular));
            return false;
        }
    }

    #endregion

    #region Extra stuff

    private bool VerifyData()
    {
        TextBoxNombre.Text = TextBoxNombre.Text.Trim().RemoveSpaces();
        if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "nombre");
            TextBoxNombre.Focus();
            return false;
        }

        var usuarioNombreLongitudMinima = Parameters.GetIntegerAsByte(Parameters.ParametersId.UsuarioNombreLongitudMinima, 5).Value;
        if (TextBoxNombre.Text.Length < usuarioNombreLongitudMinima)
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            MessageBox.Show($"El nombre debe tener al menos {usuarioNombreLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextBoxNombre.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(TextBoxDescripcion.Text))
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, true, "descripción");
            TextBoxDescripcion.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(TextBoxPassword.Text))
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, true, "contraseña");
            TextBoxPassword.Focus();
            return false;
        }

        var usuarioPasswordLongitudMinima = Parameters.GetIntegerAsByte(Parameters.ParametersId.UsuarioPasswordLongitudMinima, 8).Value;
        if (TextBoxPassword.Text.Trim().Length < usuarioPasswordLongitudMinima)
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            MessageBox.Show($"La contraseña debe tener al menos {usuarioPasswordLongitudMinima} caracteres.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextBoxPassword.Focus();
            return false;
        }

        if (ComboBoxGenero.SelectedIndex < 0)
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "género");
            ComboBoxGenero.Focus();
            return false;
        }

        if (ComboBoxUsuarioGrupo.SelectedIndex < 0)
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "grupo");
            ComboBoxUsuarioGrupo.Focus();
            return false;
        }

        return true;
    }

    #endregion

}
