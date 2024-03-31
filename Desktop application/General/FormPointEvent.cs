using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General
{
    public partial class FormPointEvent : Form
    {

        #region Declarations

        private const string entityNameSingular = "punto";
        private const bool entityIsFemale = false;

        private readonly bool isLoading;
        private readonly bool isNew;
        private bool isEditMode;

        private Models.CSMapsContext context = new();
        private Models.Punto punto;
        private readonly Models.PuntoEvento puntoEvento;

        #endregion

        #region Form stuff

        public FormPointEvent(bool editMode, int idPunto, short idEvento)
        {
            InitializeComponent();

            isLoading = true;
            isNew = (idEvento == 0);
            isEditMode = editMode;

            punto = context.Puntos.Find(idPunto);
            puntoEvento = context.PuntoEventos.Find(idPunto, idEvento);
            if (isNew)
            {
                puntoEvento = new() { IdPunto = idPunto };
                InitializeNewObjectData();
                context.PuntoEventos.Add(puntoEvento);
            }
            else
            {
            }

            InitializeFormAndControls();
            SetDataToUserInterface();
            isLoading = false;

            ChangeEditMode();
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();
            Common.Lists.GetEstablecimientos(ComboBoxEstablecimiento, context, true);
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

            ComboBoxEstablecimiento.Enabled = isEditMode;
            IntegerTextBoxChapaNumero.ReadOnly = !isEditMode;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            punto = null;
            this.Dispose();
        }

        #endregion

        #region User interface data

        private void SetDataToUserInterface()
        {
            Values.ToTextBox(TextBoxIdPunto, punto.IdPunto, true, entityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
            Values.ToTextBox(TextBoxNombre, punto.Nombre);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxLatitud, punto.Latitud);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxLongitud, punto.Longitud);

            Values.ToTextBoxAsShortDateTime(TextBoxUltimaActualizacion, puntoEvento.FechaHoraUltimaModificacion);
        }

        private void SetDataToEntityObject()
        {
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

            SetDataToEntityObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;
                puntoEvento.FechaHoraUltimaModificacion = System.DateTime.Now;
                try
                {
                    context.SaveChanges();
                    Program.FormMdi.FormPointsDataAndEvents?.ReadData(punto.IdPunto);
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
            puntoEvento.IdUsuarioCreacion = Program.Usuario.IdUsuario;
            puntoEvento.FechaHoraCreacion = System.DateTime.Now;
            puntoEvento.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            puntoEvento.FechaHoraUltimaModificacion = System.DateTime.Now;
        }

        #endregion

        #region Extra stuff

        private bool VerifyData()
        {
            return true;
        }

        #endregion

    }
}
