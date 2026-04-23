using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Main;

namespace CSMaps.Users;

public partial class FormUser : Form
{

    #region Declarations

    private const string EntityNameSingular = "usuario";
    private const bool EntityIsFemale = false;

    private readonly bool _isLoading;
    private readonly bool _isNew;
    private bool _isEditMode;

    private readonly Models.CSMapsContext _context = new();
    private readonly Models.Usuario _usuario;

    #endregion

    #region Form stuff

    public FormUser(bool editMode, short idUsuario)
    {
        InitializeComponent();

        _isLoading = true;
        _isNew = (idUsuario == 0);
        _isEditMode = editMode;

        if (_isNew)
        {
            _usuario = new();
            InitializeNewObjectData();
            _context.Usuario.Add(_usuario);
        }
        else
        {
            _usuario = _context.Usuario.Find(idUsuario);
        }

        InitializeFormAndControls();
        SetDataToUserInterface();
        _isLoading = false;

        ChangeEditMode();
    }

    private void InitializeFormAndControls()
    {
        SetAppearance();

        Common.Lists.GetGenders(ComboBoxGenero, false);
        Common.Lists.GetUsersGroups(ComboBoxUsuarioGrupo, _context, false, false);
    }

    private void SetAppearance()
    {
        this.Text = EntityNameSingular.FirstCharToUpperCase();
        Forms.SetFont(this, Program.AppearanceConfig.Font);
    }

    private void ChangeEditMode()
    {
        if (_isLoading)
        {
            return;
        }

        ToolStripButtonSave.Visible = _isEditMode;
        ToolStripButtonCancel.Visible = _isEditMode;
        ToolStripButtonEdit.Visible = !_isEditMode;
        ToolStripButtonClose.Visible = !_isEditMode;

        // General
        TextBoxNombre.ReadOnly = !_isEditMode;
        TextBoxDescripcion.ReadOnly = !_isEditMode;
        TextBoxPassword.ReadOnly = !_isEditMode;
        ComboBoxGenero.Enabled = _isEditMode;
        ComboBoxUsuarioGrupo.Enabled = _isEditMode;

        // Notas y Auditoría
        TextBoxNotas.ReadOnly = !_isEditMode;
        CheckBoxEsActivo.Enabled = _isEditMode;
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        Common.Forms.This_KeyPress(e, _isEditMode, this.ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, [TextBoxNotas]);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _context?.Dispose();
        this.Dispose();
    }

    #endregion

    #region User interface data

    private void SetDataToUserInterface()
    {
        // General
        Values.ToControl(TextBoxNombre, _usuario.Nombre);
        Values.ToControl(TextBoxDescripcion, _usuario.Descripcion);
        TextBoxPassword.Text = string.IsNullOrWhiteSpace(_usuario.Password)
            ? string.Empty
            : CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(_usuario.Password, Main.Constants.PublicEncryptionPassword, out var decryptedPassword)
                ? decryptedPassword
                : string.Empty;

        Values.ToControl(ComboBoxGenero, _usuario.Genero, ComboBoxExtension.SelectedItemOptions.Value, Main.Constants.GenderUnknown);
        Values.ToControl(ComboBoxUsuarioGrupo, _usuario.IdUsuarioGrupo);

        // Notas y Auditoría
        Values.ToControl(TextBoxNotas, _usuario.Notas);
        Values.ToControl(CheckBoxEsActivo, _usuario.EsActivo);
        Values.ToControl(TextBoxId, _usuario.IdUsuario, true, EntityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _usuario.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.GetDescription(_context, _usuario.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, _usuario.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.GetDescription(_context, _usuario.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        // General
        _usuario.Nombre = Values.ToString(TextBoxNombre);
        _usuario.Descripcion = Values.ToString(TextBoxDescripcion);
        _usuario.Password = CardonerSistemas.Framework.Cryptography.StringCipher.Encrypt(TextBoxPassword.Text.Trim(), Main.Constants.PublicEncryptionPassword, out var encryptedPassword)
            ? encryptedPassword
            : null;

        _usuario.Genero = Values.ToString(ComboBoxGenero, Main.Constants.GenderUnknown);
        _usuario.IdUsuarioGrupo = Values.ToByte(ComboBoxUsuarioGrupo).Value;

        // Notas y Auditoría
        _usuario.Notas = Values.ToString(TextBoxNotas);
        _usuario.EsActivo = Values.ToBoolean(CheckBoxEsActivo);
    }

    #endregion

    #region Controls events

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

        if (_context.ChangeTracker.HasChanges())
        {
            this.Cursor = Cursors.WaitCursor;
            _usuario.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            _usuario.FechaHoraUltimaModificacion = DateTime.UtcNow.ToLocalTime();
            try
            {
                _context.SaveChanges();
                Common.RefreshLists.Users(_usuario.IdUsuario);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                this.Cursor = Cursors.Default;
                Common.DBErrors.DbUpdateException(dbUEx, EntityNameSingular, EntityIsFemale, _isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                return;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Common.DBErrors.OtherUpdateException(ex, EntityNameSingular, EntityIsFemale, _isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                return;
            }
        }

        this.Close();
    }

    private void ToolStripButtonCancel_Click(object sender, EventArgs e)
    {
        if (Common.Forms.ButtonCancel_Click(_context))
        {
            this.Close();
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Permissions.Verify(Permissions.Actions.UserEdit))
        {
            _isEditMode = true;
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
        _usuario.EsActivo = true;
        _usuario.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _usuario.FechaHoraCreacion = DateTime.UtcNow.ToLocalTime();
        _usuario.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _usuario.FechaHoraUltimaModificacion = _usuario.FechaHoraCreacion;
    }

    private bool CompleteNewObjectData()
    {
        if (!_isNew)
        {
            return true;
        }

        try
        {
            using Models.CSMapsContext newIdContext = new();
            _usuario.IdUsuario = newIdContext.Usuario.Any() ? (short)(newIdContext.Usuario.Max(u => u.IdUsuario) + 1) : (short)1;

            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, string.Format(CultureInfo.CurrentCulture, EntityIsFemale ? Properties.Resources.StringEntityNewValuesErrorFemale : Properties.Resources.StringEntityNewValuesErrorMale, EntityNameSingular));
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
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "nombre");
            TextBoxNombre.Focus();
            return false;
        }

        var usuarioNombreLongitudMinima = Main.Parameters.GetIntegerAsByte(Main.Parameters.ParametersId.UsuarioNombreLongitudMinima, 5).Value;
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
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, true, "descripción");
            TextBoxDescripcion.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(TextBoxPassword.Text))
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, true, "contraseña");
            TextBoxPassword.Focus();
            return false;
        }

        var usuarioPasswordLongitudMinima = Main.Parameters.GetIntegerAsByte(Main.Parameters.ParametersId.UsuarioPasswordLongitudMinima, 8).Value;
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
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "género");
            ComboBoxGenero.Focus();
            return false;
        }

        if (ComboBoxUsuarioGrupo.SelectedIndex < 0)
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "grupo");
            ComboBoxUsuarioGrupo.Focus();
            return false;
        }

        return true;
    }

    #endregion

}
