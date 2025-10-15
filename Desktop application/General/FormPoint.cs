using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Users;

namespace CSMaps.General;

public partial class FormPoint : Form
{

    #region Declarations

    private const string EntityNameSingular = "punto";
    private const bool EntityIsFemale = false;

    private readonly bool _isLoading;
    private readonly bool _isNew;
    private bool _isEditMode;

    private readonly Models.CSMapsContext _dbContext = new();
    private readonly Models.Punto _punto;

    #endregion Declarations

    #region Form stuff

    public FormPoint(bool editMode, int idPunto)
    {
        InitializeComponent();

        _isLoading = true;
        _isNew = (idPunto == 0);
        _isEditMode = editMode;

        if (_isNew)
        {
            _punto = new();
            InitializeNewObjectData();
            _dbContext.Puntos.Add(_punto);
        }
        else
        {
            _punto = _dbContext.Puntos.Find(idPunto);
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
        DoubleTextBoxLatitud.ReadOnly = !_isEditMode;
        DoubleTextBoxLongitud.ReadOnly = !_isEditMode;
        DoubleTextBoxAltitud.ReadOnly = !_isEditMode;
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
        Values.ToControl(TextBoxNombre, _punto.Nombre);
        CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLatitud, _punto.Latitud);
        CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLongitud, _punto.Longitud);
        CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxAltitud, _punto.Altitud);

        // Auditoría
        Values.ToControl(TextBoxId, _punto.IdPunto, true, EntityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _punto.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(_dbContext, _punto.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, _punto.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(_dbContext, _punto.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        _punto.Nombre = Values.ToString(TextBoxNombre);
        _punto.Latitud = CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDecimal(DoubleTextBoxLatitud).Value;
        _punto.Longitud = CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDecimal(DoubleTextBoxLongitud).Value;
        _punto.Altitud = CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDecimal(DoubleTextBoxAltitud).Value;
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
            _punto.FechaHoraUltimaModificacion = DateTime.UtcNow;
            try
            {
                _dbContext.SaveChanges();
                Common.RefreshLists.Points(_punto.IdPunto);
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
        if (Permissions.Verify(Permissions.Actions.PointEdit))
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
        _punto.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _punto.FechaHoraCreacion = DateTime.UtcNow;
        _punto.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _punto.FechaHoraUltimaModificacion = DateTime.UtcNow;
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
            _punto.IdPunto = newIdContext.Puntos.Any() ? (short)(newIdContext.Puntos.Max(e => e.IdPunto) + 1) : 1;

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
#pragma warning disable S1244 // Floating point numbers should not be tested for equality
        if (DoubleTextBoxLatitud.DoubleValue == 0)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, true, "latitud");
            TabControlMain.SelectedTab = TabPageGeneral;
            DoubleTextBoxLatitud.Focus();
            return false;
        }

        if (DoubleTextBoxLongitud.DoubleValue == 0)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, true, "longitud");
            TabControlMain.SelectedTab = TabPageGeneral;
            DoubleTextBoxLongitud.Focus();
            return false;
        }
#pragma warning restore S1244 // Floating point numbers should not be tested for equality
        return true;
    }

    #endregion Extra stuff

}
