using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;
using CSMaps.Users;

namespace CSMaps.General
{
    public partial class FormPoint : Form
    {

        #region Declarations

        private const string entityNameSingular = "punto";
        private const bool entityIsFemale = false;

        private readonly bool isLoading;
        private readonly bool isNew;
        private bool isEditMode;

        private Models.CSMapsContext context = new();
        private Models.Punto punto;

        #endregion

        #region Form stuff

        public FormPoint(bool editMode, int idPunto)
        {
            InitializeComponent();

            isLoading = true;
            isNew = (idPunto == 0);
            isEditMode = editMode;

            if (isNew)
            {
                punto = new();
                InitializeNewObjectData();
                context.Puntos.Add(punto);
            }
            else
            {
                punto = context.Puntos.Find(idPunto);
            }

            InitializeForm();
            SetDataToUserInterface();
            isLoading = false;

            ChangeEditMode();
        }

        private void InitializeForm()
        {
            SetAppearance();
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

            TextBoxNombre.ReadOnly = !isEditMode;
            DoubleTextBoxLatitud.ReadOnly = !isEditMode;
            DoubleTextBoxLongitud.ReadOnly = !isEditMode;
            DoubleTextBoxAltitud.ReadOnly = !isEditMode;
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
            // General
            Values.ToTextBox(TextBoxNombre, punto.Nombre);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxLatitud, punto.Latitud);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxLongitud, punto.Longitud);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxAltitud, punto.Altitud);

            // Auditoría
            Values.ToTextBox(TextBoxId, punto.IdPunto, true, entityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
            Values.ToTextBoxAsShortDateTime(TextBoxFechaHoraCreacion, punto.FechaHoraCreacion);
            TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(context, punto.IdUsuarioCreacion);
            Values.ToTextBoxAsShortDateTime(TextBoxFechaHoraUltimaModificacion, punto.FechaHoraUltimaModificacion);
            TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(context, punto.IdUsuarioUltimaModificacion);
        }

        private void SetDataToEntityObject()
        {
            punto.Nombre = Values.TextBoxToString(TextBoxNombre);
            punto.Latitud = CardonerSistemas.Framework.Controls.Syncfusion.Values.DoubleTextBoxToDecimal(DoubleTextBoxLatitud).Value;
            punto.Longitud = CardonerSistemas.Framework.Controls.Syncfusion.Values.DoubleTextBoxToDecimal(DoubleTextBoxLongitud).Value;
            punto.Altitud = CardonerSistemas.Framework.Controls.Syncfusion.Values.DoubleTextBoxToDecimal(DoubleTextBoxAltitud).Value;
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
                punto.FechaHoraUltimaModificacion = System.DateTime.Now;
                try
                {
                    context.SaveChanges();
                    Program.FormMdi.FormPoints?.ReadData(punto.IdPunto);
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
            if (Permissions.Verify(Permissions.Actions.PointEdit))
            {
                isEditMode = true;
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
            punto.IdUsuarioCreacion = Program.Usuario.IdUsuario;
            punto.FechaHoraCreacion = System.DateTime.Now;
            punto.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            punto.FechaHoraUltimaModificacion = System.DateTime.Now;
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
                if (newIdContext.Puntos.Any())
                {
                    punto.IdPunto = (short)(newIdContext.Puntos.Max(e => e.IdPunto) + 1);
                }
                else
                {
                    punto.IdPunto = 1;
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
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "nombre");
                TabControlMain.SelectedTab = TabPageGeneral;
                TextBoxNombre.Focus();
                return false;
            }
            if (DoubleTextBoxLatitud.DoubleValue == 0)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, true, "latitud");
                TabControlMain.SelectedTab = TabPageGeneral;
                DoubleTextBoxLatitud.Focus();
                return false;
            }
            if (DoubleTextBoxLongitud.DoubleValue == 0)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, true, "longitud");
                TabControlMain.SelectedTab = TabPageGeneral;
                DoubleTextBoxLongitud.Focus();
                return false;
            }
            return true;
        }

        #endregion

    }
}
