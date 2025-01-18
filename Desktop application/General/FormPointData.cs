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

            InitializeForm();
            SetDataToUserInterface();
            isLoading = false;

            ChangeEditMode();
        }

        private void InitializeForm()
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
            TextBoxNotas.ReadOnly = !isEditMode;

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
            // General
            Values.ToControl(TextBoxNombre, punto.Nombre);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLatitud, punto.Latitud);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLongitud, punto.Longitud);
            Values.ToControl(ComboBoxEstablecimiento, puntoDato.IdEstablecimiento);
            CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(IntegerTextBoxChapaNumero, puntoDato.ChapaNumero);
            Values.ToControl(TextBoxNotas, puntoDato.Notas);

            // Auditoría
            Values.ToControl(TextBoxId, puntoDato.IdPunto, true, entityIsFemale ? Properties.Resources.StringNewFemale : Properties.Resources.StringNewMale);
            Values.ToControl(TextBoxFechaHoraCreacion, puntoDato.FechaHoraCreacion, Values.DateTimeFormats.ShortDateTime);
            TextBoxUsuarioCreacion.Text = Users.Users.GetDescription(context, puntoDato.IdUsuarioCreacion);
            Values.ToControl(TextBoxFechaHoraUltimaModificacion, puntoDato.FechaHoraUltimaModificacion, Values.DateTimeFormats.ShortDateTime);
            TextBoxUsuarioUltimaModificacion.Text = Users.Users.GetDescription(context, puntoDato.IdUsuarioUltimaModificacion);
        }

        private void SetDataToEntityObject()
        {
            puntoDato.IdPunto = punto.IdPunto;
            puntoDato.IdEstablecimiento = Values.ToShort(ComboBoxEstablecimiento);
            puntoDato.ChapaNumero = CardonerSistemas.Framework.Controls.Syncfusion.Values.ToInt(IntegerTextBoxChapaNumero);
            puntoDato.Notas = Values.ToString(TextBoxNotas);

            if (isNew && CheckBoxEventoAgregar.Checked)
            {
                context.PuntoEventos.Add(
                    new()
                    {
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
                Values.ToControl(TextBoxNombre, punto.Nombre);
                CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLatitud, punto.Latitud);
                CardonerSistemas.Framework.Controls.Syncfusion.Values.ToControl(DoubleTextBoxLongitud, punto.Longitud);
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
                    Common.RefreshLists.PointsData(punto.IdPunto);
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
                TabControlMain.SelectedTab = TabPageGeneral;
                ButtonBuscarPunto.Focus();
                return false;
            }
            if (ComboBoxEstablecimiento.SelectedIndex == -1)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "establecimiento");
                TabControlMain.SelectedTab = TabPageGeneral;
                ComboBoxEstablecimiento.Focus();
                return false;
            }
            if (IntegerTextBoxChapaNumero.IntegerValue < ChapaNumeroMinimo)
            {
                MessageBox.Show($"El nº de chapa debe ser mayor o igual a {ChapaNumeroMinimo}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControlMain.SelectedTab = TabPageGeneral;
                IntegerTextBoxChapaNumero.Focus();
                return false;
            }
            if (isNew && CheckBoxEventoAgregar.Checked && ComboBoxEventoAgregar.SelectedIndex == -1)
            {
                Common.Forms.ShowRequiredFieldMessageBox(entityIsFemale, entityNameSingular, false, "evento");
                TabControlMain.SelectedTab = TabPageGeneral;
                ComboBoxEventoAgregar.Focus();
                return false;
            }
            return true;
        }

        #endregion

    }
}
