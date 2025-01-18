using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General
{
    public partial class FormPointEvent : Form
    {

        #region Declarations

        private const string entityNameSingular = "evento del punto";
        private const bool entityIsFemale = false;

        private readonly bool isLoading;
        private readonly bool isNew;
        private bool isEditMode;

        private Models.CSMapsContext context = new();
        private readonly int idPunto;
        private readonly Models.PuntoEvento puntoEvento;

        #endregion

        #region Form stuff

        public FormPointEvent(bool editMode, int idPuntoOrigen, short idEvento)
        {
            InitializeComponent();

            isLoading = true;
            isNew = (idEvento == 0);
            isEditMode = editMode;

            idPunto = idPuntoOrigen;
            puntoEvento = context.PuntoEventos.Find(idPunto, idEvento);
            if (isNew)
            {
                puntoEvento = new() { IdPunto = idPunto };
                InitializeNewObjectData();
                context.PuntoEventos.Add(puntoEvento);
            }
            else
            {
                puntoEvento = context.PuntoEventos.Find(idPunto, idEvento);
            }

            InitializeForm();
            SetDataToUserInterface();
            isLoading = false;

            ChangeEditMode();
        }

        private void InitializeForm()
        {
            SetAppearance();
            Common.Lists.GetEventosTipos(ComboBoxEventoTipo, context, false, false, false);
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

            ComboBoxEventoTipo.Enabled = isEditMode;
            DateTimePickerFecha.Enabled = isEditMode;
            DateTimePickerHora.Enabled = isEditMode;
            TextBoxNotas.ReadOnly = !isEditMode;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            this.Dispose();
        }

        #endregion

        #region User interface data

        private void SetDataToUserInterface()
        {
            // General
            Values.ToControl(ComboBoxEventoTipo, puntoEvento.IdEventoTipo);
            Values.ToControl(DateTimePickerFecha, puntoEvento.FechaHora);
            Values.ToControl(DateTimePickerHora, puntoEvento.FechaHora);
            Values.ToControl(TextBoxNotas, puntoEvento.Notas);

            // Auditoría
            Values.ToControl(TextBoxId, puntoEvento.IdEvento, true, entityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
            Values.ToControl(TextBoxFechaHoraCreacion, puntoEvento.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
            TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(context, puntoEvento.IdUsuarioCreacion);
            Values.ToControl(TextBoxFechaHoraUltimaModificacion, puntoEvento.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
            TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(context, puntoEvento.IdUsuarioUltimaModificacion);
        }

        private void SetDataToEntityObject()
        {
            puntoEvento.IdEventoTipo = Values.ToByte(ComboBoxEventoTipo).Value;
            puntoEvento.FechaHora = Values.ToDateTime(DateTimePickerFecha, DateTimePickerHora).Value;
            puntoEvento.Notas = Values.ToString(TextBoxNotas);
        }

        #endregion

        #region Controls events

        private void This_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Forms.This_KeyPress(e, isEditMode, ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, null);
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

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;
                puntoEvento.FechaHoraUltimaModificacion = System.DateTime.Now;
                try
                {
                    context.SaveChanges();
                    Common.RefreshLists.PointsEvents(idPunto, puntoEvento.IdEvento);
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
            isEditMode = true;
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
            puntoEvento.FechaHora = System.DateTime.Now;
            puntoEvento.IdUsuarioCreacion = Program.Usuario.IdUsuario;
            puntoEvento.FechaHoraCreacion = System.DateTime.Now;
            puntoEvento.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            puntoEvento.FechaHoraUltimaModificacion = System.DateTime.Now;
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
                if (newIdContext.PuntoEventos.Where(pe => pe.IdPunto == idPunto).Any())
                {
                    puntoEvento.IdEvento = (short)(newIdContext.PuntoEventos.Where(pe => pe.IdPunto == idPunto).Max(pe => pe.IdEvento) + 1);
                }
                else
                {
                    puntoEvento.IdEvento = 1;
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
            if (ComboBoxEventoTipo.SelectedIndex == -1)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "tipo de evento");
                TabControlMain.SelectedTab = TabPageGeneral;
                ComboBoxEventoTipo.Focus();
                return false;
            }
            return true;
        }

        #endregion

    }
}
