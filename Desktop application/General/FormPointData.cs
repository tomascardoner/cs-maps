using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General;

public partial class FormPointData : Form
{

    #region Declarations

    private const string EntityNameSingular = "dato del punto";
    private const bool EntityIsFemale = false;

    private readonly bool _isLoading;
    private readonly bool _isNew;
    private bool _isEditMode;

#pragma warning disable CA2213 // Disposable fields should be disposed
    private readonly Models.CSMapsContext _dbContext = new();
#pragma warning restore CA2213 // Disposable fields should be disposed
    private Models.Punto _punto;
    private readonly Models.PuntoDato _puntoDato;

    #endregion Declarations

    #region Form stuff

    public FormPointData(bool editMode, int idPunto)
    {
        InitializeComponent();

        _isLoading = true;
        _isNew = (idPunto == 0);
        _isEditMode = editMode;

        if (_isNew)
        {
            _punto = new();
            _puntoDato = new() { IdPunto = idPunto };
            InitializeNewObjectData();
            _dbContext.PuntoDatos.Add(_puntoDato);
        }
        else
        {
            _punto = _dbContext.Puntos.Find(idPunto);
            _puntoDato = _dbContext.PuntoDatos.Find(idPunto);
        }

        InitializeForm();
        SetDataToUserInterface();
        _isLoading = false;

        ChangeEditMode();
    }

    private void InitializeForm()
    {
        SetAppearance();
        Common.Lists.GetEstablecimientos(ComboBoxEstablecimiento, _dbContext, true);
        Common.Lists.GetEventosTipos(ComboBoxEventoAgregar, _dbContext, false, false, false);
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

        ButtonBuscarPunto.Visible = _isNew;

        ComboBoxEstablecimiento.Enabled = _isEditMode;
        IntegerTextBoxChapaNumero.ReadOnly = !_isEditMode;
        ButtonChapaNumeroObtenerDesdeNombre.Visible = _isEditMode;
        TextBoxNotas.ReadOnly = !_isEditMode;

        GroupBoxAgregarEvento.Visible = _isNew;
        ComboBoxEventoAgregar.Visible = _isNew && CheckBoxEventoAgregar.Checked;
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
        Values.ToControl(ComboBoxEstablecimiento, _puntoDato.IdEstablecimiento);
        CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(IntegerTextBoxChapaNumero, _puntoDato.ChapaNumero);
        Values.ToControl(TextBoxNotas, _puntoDato.Notas);

        // Auditoría
        Values.ToControl(TextBoxId, _puntoDato.IdPunto, true, EntityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _puntoDato.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(_dbContext, _puntoDato.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, _puntoDato.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(_dbContext, _puntoDato.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        _puntoDato.IdPunto = _punto.IdPunto;
        _puntoDato.IdEstablecimiento = Values.ToShort(ComboBoxEstablecimiento);
        _puntoDato.ChapaNumero = CardonerSistemas.Framework.Controls.Syncfusion.Values.ToInt(IntegerTextBoxChapaNumero);
        _puntoDato.Notas = Values.ToString(TextBoxNotas);

        if (_isNew && CheckBoxEventoAgregar.Checked)
        {
            _dbContext.PuntoEventos.Add(
                new()
                {
                    IdPunto = _punto.IdPunto,
                    IdEvento = 1,
                    IdEventoTipo = (byte)ComboBoxEventoAgregar.SelectedValue,
                    FechaHora = DateTime.UtcNow,
                    IdUsuarioCreacion = Program.Usuario.IdUsuario,
                    FechaHoraCreacion = DateTime.UtcNow,
                    IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario,
                    FechaHoraUltimaModificacion = DateTime.UtcNow
                });
        }
    }

    #endregion User interface data

    #region Controls events

    private void This_KeyPress(object sender, KeyPressEventArgs e)
    {
        Common.Forms.This_KeyPress(e, _isEditMode, ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, null);
    }

    private void ButtonBuscarPunto_Click(object sender, EventArgs e)
    {
        FormPointFind formPointFind = new();
        if (formPointFind.ShowDialog(this) == DialogResult.OK)
        {
            _punto = (Models.Punto)formPointFind.DataGridViewMain.CurrentRow.DataBoundItem;
            Values.ToControl(TextBoxNombre, _punto.Nombre);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLatitud, _punto.Latitud);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLongitud, _punto.Longitud);
            ButtonChapaNumeroObtenerDesdeNombre.PerformClick();
            ComboBoxEstablecimiento.Focus();
        }

        formPointFind.Dispose();
    }

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
    }

    private void ButtonChapaNumeroObtenerDesdeNombre_Click(object sender, EventArgs e)
    {
        if (_punto.IdPunto != 0 && _punto.Nombre.IsDigitsOnly() && int.TryParse(_punto.Nombre, out var result))
        {
            IntegerTextBoxChapaNumero.IntegerValue = result;
        }

        IntegerTextBoxChapaNumero.Focus();
    }

    private void CheckBoxEventoAgregar_CheckedChanged(object sender, EventArgs e)
    {
        ComboBoxEventoAgregar.Visible = CheckBoxEventoAgregar.Checked;
    }

    #endregion Controls events

    #region Main toolbar

    private void ToolStripButtonSave_Click(object sender, EventArgs e)
    {
        if (!VerifyData())
        {
            return;
        }

        SetDataToEntityObject();

        if (_dbContext.ChangeTracker.HasChanges())
        {
            this.Cursor = Cursors.WaitCursor;
            _puntoDato.FechaHoraUltimaModificacion = DateTime.UtcNow;
            try
            {
                _dbContext.SaveChanges();
                Common.RefreshLists.PointsData(_punto.IdPunto);
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
        _puntoDato.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _puntoDato.FechaHoraCreacion = DateTime.UtcNow;
        _puntoDato.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _puntoDato.FechaHoraUltimaModificacion = DateTime.UtcNow;
    }

    #endregion New object initialization

    #region Extra stuff

    private bool VerifyData()
    {
        const int chapaNumeroMinimo = 30001;

        if (_isNew && _punto.IdPunto == 0)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "punto");
            TabControlMain.SelectedTab = TabPageGeneral;
            ButtonBuscarPunto.Focus();
            return false;
        }

        if (ComboBoxEstablecimiento.SelectedIndex == -1)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "establecimiento");
            TabControlMain.SelectedTab = TabPageGeneral;
            ComboBoxEstablecimiento.Focus();
            return false;
        }

        if (IntegerTextBoxChapaNumero.IntegerValue < chapaNumeroMinimo)
        {
            MessageBox.Show($"El nº de chapa debe ser mayor o igual a {chapaNumeroMinimo}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TabControlMain.SelectedTab = TabPageGeneral;
            IntegerTextBoxChapaNumero.Focus();
            return false;
        }

        if (_isNew && CheckBoxEventoAgregar.Checked && ComboBoxEventoAgregar.SelectedIndex == -1)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "evento");
            TabControlMain.SelectedTab = TabPageGeneral;
            ComboBoxEventoAgregar.Focus();
            return false;
        }

        return true;
    }

    #endregion Extra stuff

}
