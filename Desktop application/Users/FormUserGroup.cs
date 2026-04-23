using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Main;

namespace CSMaps.Users;

public partial class FormUserGroup : Form
{

    #region Declaraciones

    private readonly Models.CSMapsContext _context = new();
    private Models.UsuarioGrupo _usuarioGrupo;

    private readonly string _entidadNombreSingular = "grupo de usuarios";
    private const bool EntidadFemenina = false;

    private bool _isLoading;
    private bool _isNew;
    private bool _isEditMode;

    #endregion

    #region Cosas del form

    public FormUserGroup()
    {
        InitializeComponent();
    }

    internal void LoadAndShow(bool editMode, Form parentForm, byte idUsuarioGrupo)
    {
        _isLoading = true;
        _isNew = (idUsuarioGrupo == 0);
        _isEditMode = editMode;

        if (_isNew)
        {
            _usuarioGrupo = new Models.UsuarioGrupo();
            InicializarDatosObjetoNuevo();
            _context.UsuarioGrupo.Add(_usuarioGrupo);
        }
        else
        {
            _usuarioGrupo = _context.UsuarioGrupo.Find(idUsuarioGrupo);
        }

        InitializeFormAndControls();
        SetDataToUserInterface();

        _isLoading = false;

        ChangeEditMode();

        this.ShowDialog(parentForm);
    }

    private void ChangeEditMode()
    {
        if (_isLoading)
        {
            return;
        }

        ButtonGuardar.Visible = _isEditMode;
        ButtonCancelar.Visible = _isEditMode;
        ButtonEditar.Visible = !_isEditMode;
        ButtonCerrar.Visible = !_isEditMode;

        // General
        TextBoxNombre.ReadOnly = !_isEditMode;

        // Notas y Auditoría
        TextBoxNotas.ReadOnly = !_isEditMode;
        CheckBoxEsActivo.Enabled = _isEditMode;
    }

    private void InitializeFormAndControls()
    {
        SetAppearance();
    }

    private void SetAppearance()
    {
        this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIcon(Properties.Resources.ImageTablas32);
        this.Text = _entidadNombreSingular.FirstCharToUpperCase();
        Forms.SetFont(this, Program.AppearanceConfig.Font);
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        Common.Forms.This_KeyPress(e, _isEditMode, this.ActiveControl, ButtonCerrar, ButtonGuardar, ButtonCancelar, [TextBoxNotas]);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _context?.Dispose();
        this.Dispose();
    }

    #endregion

    #region Mostrar y leer datos

    private void SetDataToUserInterface()
    {
        // General
        Values.ToControl(TextBoxNombre, _usuarioGrupo.Nombre);

        // Notas y Auditoría
        Values.ToControl(TextBoxNotas, _usuarioGrupo.Notas);
        Values.ToControl(CheckBoxEsActivo, _usuarioGrupo.EsActivo);
        Values.ToControl(TextBoxId, _usuarioGrupo.IdUsuarioGrupo, true, EntidadFemenina ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
        Values.ToControl(TextBoxFechaHoraCreacion, _usuarioGrupo.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioCreacion.Text = Users.GetDescription(_context, _usuarioGrupo.IdUsuarioCreacion);
        Values.ToControl(TextBoxUsuarioUltimaModificacion, _usuarioGrupo.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
        TextBoxUsuarioUltimaModificacion.Text = Users.GetDescription(_context, _usuarioGrupo.IdUsuarioUltimaModificacion);
    }

    private void SetDataToEntityObject()
    {
        // General
        _usuarioGrupo.Nombre = Values.ToString(TextBoxNombre);

        // Notas y Auditoría
        _usuarioGrupo.Notas = Values.ToString(TextBoxNotas);
        _usuarioGrupo.EsActivo = Values.ToBoolean(CheckBoxEsActivo);
    }

    #endregion

    #region Eventos de los controles

    private void TextBoxs_Enter(object sender, EventArgs e)
    {
        ((TextBox)sender).SelectAll();
    }

    #endregion

    #region Toolbar principal

    private void Editar_Click(object sender, EventArgs e)
    {
        if (Permissions.Verify(Permissions.Actions.UserEdit))
        {
            _isEditMode = true;
            ChangeEditMode();
        }
    }

    private void Cerrar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Guardar_Click(object sender, EventArgs e)
    {
        if (!VerificarDatos())
        {
            return;
        }

        if (!CompletarDatosObjetoNuevo())
        {
            return;
        }

        SetDataToEntityObject();

        if (_context.ChangeTracker.HasChanges())
        {
            this.Cursor = Cursors.WaitCursor;

            _usuarioGrupo.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            _usuarioGrupo.FechaHoraUltimaModificacion = DateTime.UtcNow.ToLocalTime();

            try
            {
                _context.SaveChanges();
                Common.RefreshLists.UsersGroups(_usuarioGrupo.IdUsuarioGrupo);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                this.Cursor = Cursors.Default;
                Common.DBErrors.DbUpdateException(dbUEx, _entidadNombreSingular, EntidadFemenina, _isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                return;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Common.DBErrors.OtherUpdateException(ex, _entidadNombreSingular, EntidadFemenina, _isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                return;
            }
        }

        this.Close();
    }

    private void Cancelar_Click(object sender, EventArgs e)
    {
        if (Common.Forms.ButtonCancel_Click(_context))
        {
            this.Close();
        }
    }

    #endregion

    #region Inicializar instancia de objeto

    private void InicializarDatosObjetoNuevo()
    {
        _usuarioGrupo.EsActivo = true;
        _usuarioGrupo.IdUsuarioCreacion = Program.Usuario.IdUsuario;
        _usuarioGrupo.FechaHoraCreacion = DateTime.UtcNow.ToLocalTime();
        _usuarioGrupo.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
        _usuarioGrupo.FechaHoraUltimaModificacion = _usuarioGrupo.FechaHoraCreacion;
    }

    private bool CompletarDatosObjetoNuevo()
    {
        if (!_isNew)
        {
            return true;
        }

        try
        {
            // Obtengo el id
            using Models.CSMapsContext newIdContext = new();
            _usuarioGrupo.IdUsuarioGrupo = newIdContext.UsuarioGrupo.Any() ? (byte)(newIdContext.UsuarioGrupo.Max(u => u.IdUsuarioGrupo) + 1) : (byte)1;

            return true;
        }
        catch (Exception ex)
        {
            Error.ProcessException(ex, string.Format(CultureInfo.CurrentCulture, EntidadFemenina ? Properties.Resources.StringEntityNewValuesErrorFemale : Properties.Resources.StringEntityNewValuesErrorMale, _entidadNombreSingular));
            return false;
        }
    }

    #endregion

    #region Cosas extra

    private bool VerificarDatos()
    {
        // General
        if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
        {
            TabControlMain.SelectedTab = TabPageGeneral;
            MessageBox.Show("Debe ingresar el Nombre del grupo de usuarios.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextBoxNombre.Focus();
            return false;
        }

        return true;
    }

    #endregion

}
