using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.Users
{
    public partial class FormUserGroup : Form
    {

        #region Declaraciones

        private Models.CSMapsContext context = new();
        private Models.UsuarioGrupo usuarioGrupo;

        private readonly string entidadNombreSingular = "grupo de usuarios";
        private readonly bool entidadFemenina = false;

        private bool isLoading;
        private bool isNew;
        private bool isEditMode;

        #endregion

        #region Cosas del form

        public FormUserGroup()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, byte idUsuarioGrupo)
        {
            isLoading = true;
            isNew = (idUsuarioGrupo == 0);
            isEditMode = editMode;

            if (isNew)
            {
                usuarioGrupo = new Models.UsuarioGrupo();
                InicializarDatosObjetoNuevo();
                context.UsuarioGrupos.Add(usuarioGrupo);
            }
            else
            {
                usuarioGrupo = context.UsuarioGrupos.Find(idUsuarioGrupo);
            }

            InitializeFormAndControls();
            SetDataToUserInterface();

            isLoading = false;

            ChangeEditMode();

            this.ShowDialog(parentForm);
        }

        private void ChangeEditMode()
        {
            if (isLoading)
            {
                return;
            }

            ButtonGuardar.Visible = isEditMode;
            ButtonCancelar.Visible = isEditMode;
            ButtonEditar.Visible = !isEditMode;
            ButtonCerrar.Visible = !isEditMode;

            // General
            TextBoxNombre.ReadOnly = !isEditMode;

            // Notas y Auditoría
            TextBoxNotas.ReadOnly = !isEditMode;
            CheckBoxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Framework.Base.Graphics.GetIconFromBitmap(Properties.Resources.ImageTablas32);
            this.Text = entidadNombreSingular.FirstCharToUpperCase();
            Forms.SetFont(this, Program.AppearanceConfig.Font);
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            usuarioGrupo = null;
            this.Dispose();
        }

        #endregion

        #region Mostrar y leer datos

        private void SetDataToUserInterface()
        {
            // General
            Values.ToTextBox(TextBoxNombre, usuarioGrupo.Nombre);

            // Notas y Auditoría
            Values.ToTextBox(TextBoxNotas, usuarioGrupo.Notas);
            Values.ToCheckBox(CheckBoxEsActivo, usuarioGrupo.EsActivo);
            Values.ToTextBox(TextBoxId, usuarioGrupo.IdUsuarioGrupo, true, entidadFemenina ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
            Values.ToTextBoxAsShortDateTime(TextBoxFechaHoraCreacion, usuarioGrupo.FechaHoraCreacion);
            TextBoxUsuarioCreacion.Text = Users.GetDescription(context, usuarioGrupo.IdUsuarioCreacion);
            Values.ToTextBoxAsShortDateTime(TextBoxFechaHoraModificacion, usuarioGrupo.FechaHoraUltimaModificacion);
            TextBoxUsuarioModificacion.Text = Users.GetDescription(context, usuarioGrupo.IdUsuarioUltimaModificacion);
        }

        private void SetDataToEntityObject()
        {
            // General
            usuarioGrupo.Nombre = Values.TextBoxToString(TextBoxNombre);

            // Notas y Auditoría
            usuarioGrupo.Notas = Values.TextBoxToString(TextBoxNotas);
            usuarioGrupo.EsActivo = Values.CheckBoxToBoolean(CheckBoxEsActivo).Value;
        }

        #endregion

        #region Eventos de los controles

        private void This_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Forms.This_KeyPress(e, isEditMode, this.ActiveControl, ButtonCerrar, ButtonGuardar, ButtonCancelar, [TextBoxNotas]);
        }

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
                isEditMode = true;
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

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                usuarioGrupo.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
                usuarioGrupo.FechaHoraUltimaModificacion = System.DateTime.Now;

                try
                {
                    context.SaveChanges();
                    Common.RefreshLists.UsersGroups(usuarioGrupo.IdUsuarioGrupo);
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
                {
                    this.Cursor = Cursors.Default;
                    Common.DBErrors.DbUpdateException(dbUEx, entidadNombreSingular, entidadFemenina, isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                    return;
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    Common.DBErrors.OtherUpdateException(ex, entidadNombreSingular, entidadFemenina, isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                    return;
                }
            }

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (Common.Forms.ButtonCancel_Click(context))
            {
                this.Close();
            }
        }

        #endregion

        #region Inicializar instancia de objeto

        private void InicializarDatosObjetoNuevo()
        {
            usuarioGrupo.EsActivo = true;
            usuarioGrupo.IdUsuarioCreacion = Program.Usuario.IdUsuario;
            usuarioGrupo.FechaHoraCreacion = System.DateTime.Now;
            usuarioGrupo.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            usuarioGrupo.FechaHoraUltimaModificacion = usuarioGrupo.FechaHoraCreacion;
        }

        private bool CompletarDatosObjetoNuevo()
        {
            if (!isNew)
            {
                return true;
            }
            try
            {
                // Obtengo el id
                using Models.CSMapsContext newIdContext = new();
                if (newIdContext.UsuarioGrupos.Any())
                {
                    usuarioGrupo.IdUsuarioGrupo = (byte)(newIdContext.UsuarioGrupos.Max(u => u.IdUsuarioGrupo) + 1);
                }
                else
                {
                    usuarioGrupo.IdUsuarioGrupo = 1;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, string.Format(entidadFemenina ? Properties.Resources.StringEntityNewValuesErrorFemale : Properties.Resources.StringEntityNewValuesErrorMale, entidadNombreSingular));
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
}
