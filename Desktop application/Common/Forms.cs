namespace CSMaps.Common
{
    internal static class Forms
    {

        #region Events

        internal static void This_KeyPress(KeyPressEventArgs e, bool isEditMode, Control activeControl, ToolStripButton toolStripButtonClose, ToolStripButton toolStripButtonSave, ToolStripButton toolStripButtonCancel, TextBox[] textBoxsToIgnore)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    if (isEditMode)
                    {
                        if (textBoxsToIgnore != null)
                        {
                            foreach (TextBox textBox in textBoxsToIgnore)
                            {
                                if (activeControl == textBox)
                                {
                                    return;
                                }
                            }
                        }
                        toolStripButtonSave.PerformClick();
                    }
                    else
                    {
                        toolStripButtonClose?.PerformClick();
                    }
                    break;
                case (char)Keys.Escape:
                    if (isEditMode)
                    {
                        toolStripButtonCancel.PerformClick();
                    }
                    else
                    {
                        toolStripButtonClose?.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        internal static void This_KeyPress(KeyPressEventArgs e, Control activeControl, ToolStripButton toolStripButtonSelect, ToolStripButton toolStripButtonCancel, TextBox[] textBoxsToIgnore)
        {
            This_KeyPress(e, true, activeControl, null, toolStripButtonSelect, toolStripButtonCancel, textBoxsToIgnore);
        }

        internal static bool Filter_KeyPress(KeyPressEventArgs e, TextBox textBox, int minimumLenght = 3)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textBox.Text.Trim().Length < minimumLenght)
                {
                    MessageBox.Show(string.Format(Properties.Resources.StringTextFilterMinimumLenght, minimumLenght), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox.Focus();
                }
                else
                {
                    return true;
                }
                e.Handled = true;
            }
            return false;
        }

        internal static bool ButtonCancel_Click(Models.CSMapsContext context)
        {
            if (context.ChangeTracker.HasChanges() && MessageBox.Show(Properties.Resources.StringEntityCancelChanges, Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static void ShowRequiredFieldMessageBox(bool entityIsFemale, string entityName, bool fieldIsFemale, string fieldName)
        {
            string message;

            if (entityIsFemale)
            {
                if (!fieldIsFemale)
                {
                    message = Properties.Resources.StringEntityDataVerificationFemaleFieldRequiredFemale;
                }
                else
                {
                    message = Properties.Resources.StringEntityDataVerificationMaleFieldRequiredFemale;
                }
            }
            else
            {
                if (!fieldIsFemale)
                {
                    message = Properties.Resources.StringEntityDataVerificationFemaleFieldRequiredMale;
                }
                else
                {
                    message = Properties.Resources.StringEntityDataVerificationMaleFieldRequiredMale;
                }
            }
            MessageBox.Show(string.Format(message, entityName, fieldName), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Instances

        private const string FormNameUsersGroups = "FormUsersGroups";
        private const string FormNameUsersGroupsPermissions = "FormUsersGroupsPermissions";
        private const string FormNameUsers = "FormUsers";
        private const string FormNameEntities = "FormEntities";
        private const string FormNameSettlements = "FormSettlements";
        private const string FormNamePoints = "FormPoints";
        private const string FormNamePointsDataAndEvents = "FormPointsDataAndEvents";
        private const string FormNamePointEvents = "FormPointEvents";
        private const string FormNameImportGoogleEarthFile = "FormImportGoogleEarthFile";
        private const string FormNameExportGpsFile = "FormExportGpsFile";
        private const string FormNameExportGoogleEarthFile = "FormExportGoogleEarthFile";

        internal static Users.FormUsersGroups GetUsersGroups()
        {
            return (Users.FormUsersGroups)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameUsersGroups);
        }

        internal static Users.FormUsersGroups GetUsersGroupsOrNew()
        {
            return GetUsersGroups() ?? new();
        }

        internal static Users.FormUsersGroupsPermissions GetUsersGroupsPermissions()
        {
            return (Users.FormUsersGroupsPermissions)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameUsersGroupsPermissions);
        }

        internal static Users.FormUsersGroupsPermissions GetUsersGroupsPermissionsOrNew()
        {
            return GetUsersGroupsPermissions() ?? new();
        }

        internal static Users.FormUsers GetUsers()
        {
            return (Users.FormUsers)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameUsers);
        }

        internal static Users.FormUsers GetUsersOrNew()
        {
            return GetUsers() ?? new();
        }

        internal static General.FormEntities GetEntities()
        {
            return (General.FormEntities)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameEntities);
        }

        internal static General.FormEntities GetEntitiesOrNew()
        {
            return GetEntities() ?? new();
        }

        internal static General.FormSettlements GetSettlements()
        {
            return (General.FormSettlements)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameSettlements);
        }

        internal static General.FormSettlements GetSettlementsOrNew()
        {
            return GetSettlements() ?? new();
        }

        internal static General.FormPoints GetPoints()
        {
            return (General.FormPoints)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNamePoints);
        }

        internal static General.FormPoints GetPointsOrNew()
        {
            return GetPoints() ?? new();
        }

        internal static General.FormPointsDataAndEvents GetPointsDataAndEvents()
        {
            return (General.FormPointsDataAndEvents)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNamePointsDataAndEvents);
        }

        internal static General.FormPointsDataAndEvents GetPointsDataAndEventsOrNew()
        {
            return GetPointsDataAndEvents() ?? new();
        }

        internal static General.FormPointEvents GetPointEvents()
        {
            return (General.FormPointEvents)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNamePointEvents);
        }

        internal static General.FormImportGoogleEarthFile GetImportGoogleEarthFile()
        {
            return (General.FormImportGoogleEarthFile)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameImportGoogleEarthFile);
        }

        internal static General.FormImportGoogleEarthFile GetImportGoogleEarthFileOrNew()
        {
            return GetImportGoogleEarthFile() ?? new();
        }

        internal static General.FormExportGpsFile GetExportGpsFile()
        {
            return (General.FormExportGpsFile)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameExportGpsFile);
        }

        internal static General.FormExportGpsFile GetExportGpsFileOrNew()
        {
            return GetExportGpsFile() ?? new();
        }

        internal static General.FormExportGoogleEarthFile GetExportGoogleEarthFile()
        {
            return (General.FormExportGoogleEarthFile)CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNameExportGoogleEarthFile);
        }

        internal static General.FormExportGoogleEarthFile GetExportGoogleEarthFileOrNew()
        {
            return GetExportGoogleEarthFile() ?? new();
        }

        #endregion

    }

}