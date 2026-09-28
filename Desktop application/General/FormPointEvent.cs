using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Main;

namespace CSMaps.General;

public partial class FormPointEvent : Form
{

    #region Declarations

    private const string EntityNameSingular = "evento del punto";
    private const bool EntityIsFemale = false;

    private readonly bool _isLoading;
    private readonly bool _isNew;
    private bool _isEditMode;

    private readonly Models.CSMapsContext _context = new();
    private readonly int _idPunto;
    private readonly Models.PuntoEvento _puntoEvento;

    #endregion

    #region Form stuff

    public FormPointEvent(bool editMode, int idPuntoOrigen, short idEvento)
    {
        InitializeComponent();

        _isLoading = true;
        _isNew = (idEvento == 0);
        _isEditMode = editMode;

        _idPunto = idPuntoOrigen;
        _puntoEvento = _context.PuntoEvento.Find(_idPunto, idEvento);
        if (_isNew)
        {
            _puntoEvento = new() { IdPunto = _idPunto };
            InitializeNewObjectData();
            _context.PuntoEvento.Add(_puntoEvento);
        }
        else
        {
            _puntoEvento = _context.PuntoEvento.Find(_idPunto, idEvento);
        }

        InitializeForm();
        SetDataToUserInterface();
        _isLoading = false;

        ChangeEditMode();
    }

    private void InitializeForm()
    {
        SetAppearance();
        Common.Lists.GetEventosTipos(ComboBoxEventoTipo, _context, false, false, false);
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

        ComboBoxEventoTipo.Enabled = _isEditMode;
        DateTimePickerFecha.Enabled = _isEditMode;
        DateTimePickerHora.Enabled = _isEditMode;
        TextBoxNotas.ReadOnly = !_isEditMode;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
            _context?.Dispose();
        }

        base.Dispose(disposing);
    }

    #endregion

    #region User interface data

    private void SetDataToUserInterface()
    {
        // General
        Values.ToControl(ComboBoxEventoTipo, _puntoEvento.IdEventoTipo);
        Values.ToControl(DateTimePickerFecha, _puntoEvento.FechaHora);
        Values.ToControl(DateTimePickerHora, _puntoEvento.FechaHora);
        Values.ToControl(TextBoxNotas, _puntoEvento.Notas);

        // Auditoría
        Values.ToControl(TextBoxId, _puntoEvento.IdEvento, true, EntityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _puntoEvento.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(_context, _puntoEvento.IdUsuarioCreacion);
        Values.ToControl(TextBoxFechaHoraUltimaModificacion, _puntoEvento.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(_context, _puntoEvento.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        _puntoEvento.IdEventoTipo = Values.ToByte(ComboBoxEventoTipo).Value;
        _puntoEvento.FechaHora = Values.ToDateTime(DateTimePickerFecha, DateTimePickerHora).Value;
        _puntoEvento.Notas = Values.ToString(TextBoxNotas);
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

#pragma warning disable MA0155 // Do not use async void methods (event handler)
    private async void ToolStripButtonSave_Click(object sender, EventArgs e)
#pragma warning restore MA0155
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
            _puntoEvento.FechaHoraUltimaModificacion = DateTime.UtcNow.ToLocalTime();
            try
            {
                await _context.SaveChangesAsync();
                await Common.RefreshLists.PointsEventsAsync(_idPunto, _puntoEvento.IdEvento);
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
        _isEditMode = true;
        ChangeEditMode();
    }

    private void ToolStripButtonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #endregion

    #region New object initialization

    private void InitializeNewObjectData()
    {
        _puntoEvento.FechaHora = DateTime.UtcNow.ToLocalTime();
        _puntoEvento.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _puntoEvento.FechaHoraCreacion = DateTime.UtcNow.ToLocalTime();
        _puntoEvento.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _puntoEvento.FechaHoraUltimaModificacion = DateTime.UtcNow.ToLocalTime();
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
            _puntoEvento.IdEvento = newIdContext.PuntoEvento.Where(pe => pe.IdPunto == _idPunto).Any()
                ? (short)(newIdContext.PuntoEvento.Where(pe => pe.IdPunto == _idPunto).Max(pe => pe.IdEvento) + 1)
                : (short)1;

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
        if (ComboBoxEventoTipo.SelectedIndex == -1)
        {
            Common.Forms.ShowRequiredFieldMessageBox(EntityIsFemale, EntityNameSingular, false, "tipo de evento");
            TabControlMain.SelectedTab = TabPageGeneral;
            ComboBoxEventoTipo.Focus();
            return false;
        }

        return true;
    }

    #endregion

}
