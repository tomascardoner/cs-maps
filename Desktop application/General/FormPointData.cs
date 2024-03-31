using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General
{
    public partial class FormPointData : Form
    {

        #region Declarations

        private const string entityNameSingular = "dato del punto";
        private const bool entityIsFemale = false;

        private readonly bool isLoading;
        private readonly bool isNew;
        private bool isEditMode;

        private Models.CSMapsContext context = new();
        private Models.Punto punto;
        private readonly Models.PuntoDato puntoDato;

        #endregion

        #region Form stuff

        public FormPointData(bool editMode, int idPunto)
        {
            InitializeComponent();

            isLoading = true;
            isNew = (idPunto == 0);
            isEditMode = editMode;

            if (isNew)
            {
                punto = new();
                puntoDato = new() { IdPunto = idPunto };
                InitializeNewObjectData();
                context.PuntoDatos.Add(puntoDato);
            }
            else
            {
                punto = context.Puntos.Find(idPunto);
                puntoDato = context.PuntoDatos.Find(idPunto);
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
            Common.Lists.GetEventosTipos(ComboBoxEventoAgregar, context, false, false, false);
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

            ButtonBuscarPunto.Visible = isNew;

            ComboBoxEstablecimiento.Enabled = isEditMode;
            IntegerTextBoxChapaNumero.ReadOnly = !isEditMode;
            ButtonChapaNumeroObtenerDesdeNombre.Visible = isEditMode;

            GroupBoxAgregarEvento.Visible = isNew;
            ComboBoxEventoAgregar.Visible = isNew && CheckBoxEventoAgregar.Checked;
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

            Values.ToComboBox(ComboBoxEstablecimiento, puntoDato.IdEstablecimiento);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToIntegerTextBox(IntegerTextBoxChapaNumero, puntoDato.ChapaNumero);
            Values.ToTextBoxAsShortDateTime(TextBoxUltimaModificacion, puntoDato.FechaHoraUltimaModificacion);
        }

        private void SetDataToEntityObject()
        {
            puntoDato.IdPunto = punto.IdPunto;
            puntoDato.IdEstablecimiento = Values.ComboBoxToShort(ComboBoxEstablecimiento);
            puntoDato.ChapaNumero = CardonerSistemas.Framework.Controls.Syncfusion.Values.IntegerTextBoxToInt(IntegerTextBoxChapaNumero);

            if (isNew && CheckBoxEventoAgregar.Checked)
            {
                context.PuntoEventos.Add(
                    new() {
                        IdPunto = punto.IdPunto,
                        IdEvento = 1,
                        IdEventoTipo = (byte)ComboBoxEventoAgregar.SelectedValue,
                        FechaHora = System.DateTime.Now,
                        IdUsuarioCreacion = Program.Usuario.IdUsuario,
                        FechaHoraCreacion = System.DateTime.Now,
                        IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario,
                        FechaHoraUltimaModificacion = System.DateTime.Now
                    });
            }
        }

        #endregion

        #region Controls events

        private void This_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Forms.This_KeyPress(e, isEditMode, ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, null);
        }

        private void ButtonBuscarPunto_Click(object sender, EventArgs e)
        {
            FormPointFind formPointFind = new();
            if (formPointFind.ShowDialog(this) == DialogResult.OK)
            {
                punto = (Models.Punto)formPointFind.DataGridViewMain.CurrentRow.DataBoundItem;
                Values.ToTextBox(TextBoxIdPunto, punto.IdPunto);
                Values.ToTextBox(TextBoxNombre, punto.Nombre);
                CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxLatitud, punto.Latitud);
                CardonerSistemas.Framework.Controls.Syncfusion.Values.ToDoubleTextBox(DoubleTextBoxLongitud, punto.Longitud);
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
            if (punto.IdPunto != 0 && punto.Nombre.IsDigitsOnly() && int.TryParse(punto.Nombre, out int result))
            {
                IntegerTextBoxChapaNumero.IntegerValue = result;
            }
            IntegerTextBoxChapaNumero.Focus();
        }

        private void CheckBoxEventoAgregar_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxEventoAgregar.Visible = CheckBoxEventoAgregar.Checked;
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
                puntoDato.FechaHoraUltimaModificacion = System.DateTime.Now;
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
            puntoDato.IdUsuarioCreacion = Program.Usuario.IdUsuario;
            puntoDato.FechaHoraCreacion = System.DateTime.Now;
            puntoDato.IdUsuarioUltimaModificacion = Program.Usuario.IdUsuario;
            puntoDato.FechaHoraUltimaModificacion = System.DateTime.Now;
        }

        #endregion

        #region Extra stuff

        private bool VerifyData()
        {
            const int ChapaNumeroMinimo = 30001;

            if (isNew && punto.IdPunto == 0)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "punto");
                ButtonBuscarPunto.Focus();
                return false;
            }
            if (ComboBoxEstablecimiento.SelectedIndex == -1)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "establecimiento");
                ComboBoxEstablecimiento.Focus();
                return false;
            }
            if (IntegerTextBoxChapaNumero.IntegerValue < ChapaNumeroMinimo)
            {
                MessageBox.Show($"El nº de chapa debe ser mayor o igual a {ChapaNumeroMinimo}", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                IntegerTextBoxChapaNumero.Focus();
                return false;
            }
            if (isNew && CheckBoxEventoAgregar.Checked && ComboBoxEventoAgregar.SelectedIndex == -1)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "evento");
                ComboBoxEventoAgregar.Focus();
                return false;
            }
            return true;
        }

        #endregion

    }
}
