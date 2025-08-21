using System.Linq;

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
                        if (textBoxsToIgnore != null && activeControl != null && (from TextBox textBox in textBoxsToIgnore
                                                                                  where activeControl == textBox
                                                                                  select textBox).Any())
                        {
                            return;
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

        internal static Users.FormUsersGroups GetUsersGroups()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<Users.FormUsersGroups>(Program.FormMdi.MdiChildren);
        }

        internal static Users.FormUsersGroups GetUsersGroupsOrNew()
        {
            return GetUsersGroups() ?? new();
        }

        internal static Users.FormUsersGroupsPermissions GetUsersGroupsPermissions()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<Users.FormUsersGroupsPermissions>(Program.FormMdi.MdiChildren);
        }

        internal static Users.FormUsersGroupsPermissions GetUsersGroupsPermissionsOrNew()
        {
            return GetUsersGroupsPermissions() ?? new();
        }

        internal static Users.FormUsers GetUsers()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<Users.FormUsers>(Program.FormMdi.MdiChildren);
        }

        internal static Users.FormUsers GetUsersOrNew()
        {
            return GetUsers() ?? new();
        }

        internal static General.FormEntities GetEntities()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormEntities>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormEntities GetEntitiesOrNew()
        {
            return GetEntities() ?? new();
        }

        internal static General.FormSettlements GetSettlements()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormSettlements>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormSettlements GetSettlementsOrNew()
        {
            return GetSettlements() ?? new();
        }

        internal static General.FormPoints GetPoints()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormPoints>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormPoints GetPointsOrNew()
        {
            return GetPoints() ?? new();
        }

        internal static General.FormPointsDataAndEvents GetPointsDataAndEvents()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormPointsDataAndEvents>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormPointsDataAndEvents GetPointsDataAndEventsOrNew()
        {
            return GetPointsDataAndEvents() ?? new();
        }

        internal static General.FormPointEvents GetPointEvents()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormPointEvents>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormImportGoogleEarthFile GetImportGoogleEarthFile()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormImportGoogleEarthFile>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormImportGoogleEarthFile GetImportGoogleEarthFileOrNew()
        {
            return GetImportGoogleEarthFile() ?? new();
        }

        internal static ImportExport.FormImportGpsFile GetImportGpsFile()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<ImportExport.FormImportGpsFile>(Program.FormMdi.MdiChildren);
        }

        internal static ImportExport.FormImportGpsFile GetImportGpsFileOrNew()
        {
            return GetImportGpsFile() ?? new();
        }

        internal static ImportExport.FormExportGpsFile GetExportGpsFile()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<ImportExport.FormExportGpsFile>(Program.FormMdi.MdiChildren);
        }

        internal static ImportExport.FormExportGpsFile GetExportGpsFileOrNew()
        {
            return GetExportGpsFile() ?? new();
        }

        internal static General.FormExportGoogleEarthFile GetExportGoogleEarthFile()
        {
            return CardonerSistemas.Framework.Base.Forms.GetInstance<General.FormExportGoogleEarthFile>(Program.FormMdi.MdiChildren);
        }

        internal static General.FormExportGoogleEarthFile GetExportGoogleEarthFileOrNew()
        {
            return GetExportGoogleEarthFile() ?? new();
        }

        #endregion

    }

}