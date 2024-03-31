namespace CSMaps.Common
{
    internal static class Forms
    {
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
                    MessageBox.Show(string.Format(Properties.Resources.StringTextFilterMinimumLenght, minimumLenght), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (context.ChangeTracker.HasChanges() && MessageBox.Show(Properties.Resources.StringEntityCancelChanges, Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
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
            MessageBox.Show(string.Format(message, entityName, fieldName), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}