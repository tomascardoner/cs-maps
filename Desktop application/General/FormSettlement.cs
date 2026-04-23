using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Main;

namespace CSMaps.General;

public partial class FormSettlement : Form
{

    #region Declarations

    private const string EntityNameSingular = "establecimiento";
    private const bool EntityIsFemale = false;

    private readonly bool _isLoading;
    private readonly bool _isNew;
    private bool _isEditMode;

#pragma warning disable CA2213 // Disposable fields should be disposed
    private readonly Models.CSMapsContext _dbContext = new();
#pragma warning restore CA2213 // Disposable fields should be disposed
    private readonly Models.Establecimiento _establecimiento;

    #endregion Declarations

    #region Form stuff

    public FormSettlement(bool editMode, short idEstablecimiento)
    {
        InitializeComponent();

        _isLoading = true;
        _isNew = (idEstablecimiento == 0);
        _isEditMode = editMode;

        if (_isNew)
        {
            _establecimiento = new();
            InitializeNewObjectData();
            _dbContext.Establecimiento.Add(_establecimiento);
        }
        else
        {
            _establecimiento = _dbContext.Establecimiento.Find(idEstablecimiento);
        }

        InitializeForm();
        SetDataToUserInterface();
        _isLoading = false;

        ChangeEditMode();
    }

    private void InitializeForm()
    {
        SetAppearance();
        Common.Lists.GetEntidades(ComboBoxEntidad, _dbContext, false, true);
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
        ComboBoxEntidad.Enabled = _isEditMode;
        TextBoxTelefonoMovil.ReadOnly = !_isEditMode;
    }

    private void This_FormClosed(object sender, FormClosedEventArgs e)
    {
        _dbContext?.Dispose();
    }

    #endregion Form stuff

    #region User interface data

    private void SetDataToUserInterface()
    {
        // General
        Values.ToControl(TextBoxNombre, _establecimiento.Nombre);
        Values.ToControl(ComboBoxEntidad, _establecimiento.IdEntidad);
        Values.ToControl(TextBoxTelefonoMovil, _establecimiento.TelefonoMovil);

        // Auditoría
        Values.ToControl(TextBoxId, _establecimiento.IdEstablecimiento, true, EntityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _establecimiento.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(_dbContext, _establecimiento.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, _establecimiento.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(_dbContext, _establecimiento.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        _establecimiento.Nombre = Values.ToString(TextBoxNombre);
        _establecimiento.IdEntidad = Values.ToShort(ComboBoxEntidad);
        _establecimiento.TelefonoMovil = Values.ToString(TextBoxTelefonoMovil);
    }

    #endregion

    #region Controls events

    private void This_KeyPress(object sender, KeyPressEventArgs e)
    {
        Common.Forms.This_KeyPress(e, _isEditMode, ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, null);
    }

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
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

        if (_dbContext.ChangeTracker.HasChanges())
        {
            this.Cursor = Cursors.WaitCursor;
            _establecimiento.FechaHoraUltimaModificacion = DateTime.UtcNow;
            try
            {
                _dbContext.SaveChanges();
                Common.RefreshLists.Settlements(_establecimiento.IdEstablecimiento);
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
        _isEditMode = true;
        ChangeEditMode();
    }

    private void ToolStripButtonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #endregion Main toolbar

    #region New object initialization

    private void InitializeNewObjectData()
    {
        _establecimiento.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _establecimiento.FechaHoraCreacion = DateTime.UtcNow;
        _establecimiento.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _establecimiento.FechaHoraUltimaModificacion = DateTime.UtcNow;
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
            _establecimiento.IdEstablecimiento = newIdContext.Establecimiento.Any() ? (short)(newIdContext.Establecimiento.Max(e => e.IdEstablecimiento) + 1) : (short)1;

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

        if (ComboBoxEntidad.SelectedIndex == -1)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, true, "entidad");
            TabControlMain.SelectedTab = TabPageGeneral;
            ComboBoxEntidad.Focus();
            return false;
        }

        return true;
    }

    #endregion

}
