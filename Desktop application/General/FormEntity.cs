using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Users;

namespace CSMaps.General;

public partial class FormEntity : Form
{

    #region Declarations

    private const string EntityNameSingular = "entidad";
    private const bool EntityIsFemale = true;

    private readonly bool _isLoading;
    private readonly bool _isNew;
    private bool _isEditMode;

#pragma warning disable CA2213 // Disposable fields should be disposed
    private readonly Models.CSMapsContext _dbContext = new();
#pragma warning restore CA2213 // Disposable fields should be disposed
    private readonly Models.Entidad _entidad;

    #endregion Declarations

    #region Form stuff

    public FormEntity(bool editMode, short idEntidad)
    {
        InitializeComponent();

        _isLoading = true;
        _isNew = (idEntidad == 0);
        _isEditMode = editMode;

        if (_isNew)
        {
            _entidad = new();
            InitializeNewObjectData();
            _dbContext.Entidades.Add(_entidad);
        }
        else
        {
            _entidad = _dbContext.Entidades.Find(idEntidad);
        }

        InitializeForm();
        SetDataToUserInterface();
        _isLoading = false;

        ChangeEditMode();
    }

    private void InitializeForm()
    {
        SetAppearance();
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

        TextBoxNombre.ReadOnly = !_isEditMode;
        TextBoxTelefonoMovil.ReadOnly = !_isEditMode;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _dbContext?.Dispose();
    }

    #endregion Form stuff

    #region User interface data

    private void SetDataToUserInterface()
    {
        // General
        Values.ToControl(TextBoxNombre, _entidad.Nombre);
        Values.ToControl(TextBoxTelefonoMovil, _entidad.TelefonoMovil);

        // Auditoría
        Values.ToControl(TextBoxId, _entidad.IdEntidad, true, EntityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _entidad.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(_dbContext, _entidad.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, _entidad.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(_dbContext, _entidad.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        _entidad.Nombre = Values.ToString(TextBoxNombre);
        _entidad.TelefonoMovil = Values.ToString(TextBoxTelefonoMovil);
    }

    #endregion User interface data

    #region Controls events

    private void This_KeyPress(object sender, KeyPressEventArgs e)
    {
        Common.Forms.This_KeyPress(e, _isEditMode, ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, null);
    }

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
    }

    #endregion Controls events

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

        if (_dbContext.ChangeTracker.HasChanges())
        {
            this.Cursor = Cursors.WaitCursor;
            _entidad.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            _entidad.FechaHoraUltimaModificacion = DateTime.UtcNow;
            try
            {
                _dbContext.SaveChanges();
                Common.RefreshLists.Entities(_entidad.IdEntidad);
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
        if (Common.Forms.ButtonCancel_Click(_dbContext))
        {
            this.Close();
        }
    }

    private void ToolStripButtonEdit_Click(object sender, EventArgs e)
    {
        if (Permissions.Verify(Permissions.Actions.EntityEdit))
        {
            _isEditMode = true;
            ChangeEditMode();
        }
    }

    private void ToolStripButtonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #endregion Main toolbar

    #region New object initialization

    private void InitializeNewObjectData()
    {
        _entidad.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _entidad.FechaHoraCreacion = DateTime.UtcNow;
        _entidad.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _entidad.FechaHoraUltimaModificacion = DateTime.UtcNow;
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
            _entidad.IdEntidad = newIdContext.Entidades.Any() ? (short)(newIdContext.Entidades.Max(e => e.IdEntidad) + 1) : (short)1;

            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, string.Format(CultureInfo.CurrentCulture, EntityIsFemale ? Properties.Resources.StringEntityNewValuesErrorFemale : Properties.Resources.StringEntityNewValuesErrorMale, EntityNameSingular));
            return false;
        }
    }

    #endregion New object initialization

    #region Extra stuff

    private bool VerifyData()
    {
        if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "nombre");
            TabControlMain.SelectedTab = TabPageGeneral;
            TextBoxNombre.Focus();
            return false;
        }

        return true;
    }

    #endregion Extra stuff

}
