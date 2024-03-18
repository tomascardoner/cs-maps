﻿using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General
{
    public partial class FormEntity : Form
    {

        #region Declarations

        private const string entityNameSingular = "entidad";
        private const bool entityIsFemale = true;

        private readonly bool isLoading;
        private readonly bool isNew;
        private bool isEditMode;

        private Models.CSMapsContext context = new();
        private Models.Entidad entidad;

        #endregion

        #region Form stuff

        public FormEntity(bool editMode, short idEntidad)
        {
            InitializeComponent();

            isLoading = true;
            isNew = (idEntidad == 0);
            isEditMode = editMode;

            if (isNew)
            {
                entidad = new();
                InitializeNewObjectData();
                context.Entidads.Add(entidad);
            }
            else
            {
                entidad = context.Entidads.Find(idEntidad);
            }

            InitializeFormAndControls();
            SetDataToUserInterface();
            isLoading = false;

            ChangeEditMode();
        }

        private void InitializeFormAndControls()
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
            TextBoxTelefonoMovil.ReadOnly = !isEditMode;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidad = null;
            this.Dispose();
        }

        #endregion

        #region User interface data

        private void SetDataToUserInterface()
        {
            Values.ToTextBox(TextBoxIdEntidad, entidad.IdEntidad);
            Values.ToTextBox(TextBoxNombre, entidad.Nombre);
            Values.ToTextBox(TextBoxTelefonoMovil, entidad.TelefonoMovil);
            Values.ToTextBoxAsShortDateTime(TextBoxUltimaActualizacion, entidad.UltimaActualizacion);
        }

        private void SetDataToEntityObject()
        {
            entidad.Nombre = Values.TextBoxToString(TextBoxNombre);
            entidad.TelefonoMovil = Values.TextBoxToString(TextBoxTelefonoMovil);
        }

        #endregion

        #region Controls events

        private void FormEntity_KeyPress(object sender, KeyPressEventArgs e)
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
                entidad.UltimaActualizacion = System.DateTime.Now;
                try
                {
                    context.SaveChanges();
                    Program.formMdi.formEntities?.ReadData(entidad.IdEntidad);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbUEx)
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
            entidad.UltimaActualizacion = System.DateTime.Now;
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
                if (context.Entidads.Any())
                {
                    entidad.IdEntidad = (short)(newIdContext.Entidads.Max(e => e.IdEntidad) + 1);
                }
                else
                {
                    entidad.IdEntidad = 1;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, string.Format(Properties.Resources.StringEntityNewValuesErrorFemale, entityNameSingular));
                return false;
            }
        }

        #endregion

        #region Extra stuff

        private bool VerifyData()
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
            {
                MessageBox.Show(string.Format(entityIsFemale ? Properties.Resources.StringEntityDataVerificationMaleFieldRequiredFemale : Properties.Resources.StringEntityDataVerificationMaleFieldRequiredMale, entityNameSingular, "nombre"), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion

    }
}
