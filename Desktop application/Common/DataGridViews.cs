using CardonerSistemas.Framework.Base;

namespace CSMaps.Common
{
    internal static class DataGridViews
    {

        #region Common

        internal static void CommonActionFinalize(Form form, DataGridView dataGridView)
        {
            form.Cursor = Cursors.Default;
            dataGridView.Enabled = true;
        }

        #endregion

        #region View

        internal static bool ViewVerify(Form form, DataGridView dataGridView, string entityNameSingle, bool entityIsFemale)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show(string.Format(entityIsFemale ? Properties.Resources.StringActionNoneFemale : Properties.Resources.StringActionNoneMale, entityNameSingle, Properties.Resources.StringActionView), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            form.Cursor = Cursors.WaitCursor;
            dataGridView.Enabled = false;
            return true;
        }

        #endregion

        #region Add

        internal static bool AddVerify(Form form, DataGridView dataGridView)
        {
            form.Cursor = Cursors.WaitCursor;
            dataGridView.Enabled = false;
            return true;
        }

        #endregion

        #region Edit

        internal static bool EditVerify(Form form, DataGridView dataGridView, string entityNameSingle, bool entityIsFemale)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show(string.Format(entityIsFemale ? Properties.Resources.StringActionNoneFemale : Properties.Resources.StringActionNoneMale, entityNameSingle, Properties.Resources.StringActionEdit), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            form.Cursor = Cursors.WaitCursor;
            dataGridView.Enabled = false;
            return true;
        }

        #endregion

        #region Delete

        internal static bool DeleteVerify(DataGridView dataGridView, string entityNameSingle, bool entityIsFemale)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show(string.Format(entityIsFemale ? Properties.Resources.StringActionNoneFemale : Properties.Resources.StringActionNoneMale, entityNameSingle, Properties.Resources.StringActionDelete), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        internal static bool DeleteConfirm(string entityNameSingle, bool entityIsFemale, string entityData)
        {
            string mensaje = string.Format(entityIsFemale ? Properties.Resources.StringActionDeleteConfirmationFemale : Properties.Resources.StringActionDeleteConfirmationMale, entityNameSingle, entityData);
            return MessageBox.Show(mensaje, Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        #endregion

        #region Sort by column

        internal static bool ColumnHeaderMouseClick(DataGridView dataGridView, DataGridViewCellMouseEventArgs e, ref DataGridViewColumn sortedColumn, ref SortOrder sortOrder, DataGridViewColumn[] sorteableColumns)
        {
            DataGridViewColumn column = dataGridView.Columns[e.ColumnIndex];
            if (!sorteableColumns.Contains(column))
            {
                return false;
            }
            if (column == sortedColumn)
            {
                // Clicked column is the sorted one, so invert sort order
                if (sortOrder == SortOrder.Ascending)
                {
                    sortOrder = SortOrder.Descending;
                }
                else
                {
                    sortOrder = SortOrder.Ascending;
                }
            }
            else
            {
                // Clicked column is different from the previous one
                if (sortedColumn != null)
                {
                    sortedColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
                sortedColumn = column;
                sortOrder = SortOrder.Ascending;
            }
            return true;
        }

        #endregion

        #region Search row by first key letter pressed

        private static void SearchByKeyPressFirstOccurrence(KeyPressEventArgs e, DataGridView dataGridView, DataGridViewColumn dataGridViewColumn)
        {
            DataGridViewRow row = (from DataGridViewRow r in dataGridView.Rows
                                   where r.Cells[dataGridViewColumn.Name].Value.ToString().ReplaceDiacritics().StartsWith(e.KeyChar.ToString(), StringComparison.CurrentCultureIgnoreCase)
                                   select r).FirstOrDefault();
            if (row != null)
            {
                row.Cells[dataGridViewColumn.Name].Selected = true;
                e.Handled = true;
                dataGridView.Focus();
            }
        }

        private static void SearchByKeyPressNextOccurrences(KeyPressEventArgs e, DataGridView dataGridView, DataGridViewColumn dataGridViewColumn)
        {
            if (dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1)
            {
                if (dataGridView.Rows[dataGridView.CurrentCell.RowIndex + 1].Cells[dataGridViewColumn.Name].Value.ToString().ReplaceDiacritics().StartsWith(e.KeyChar.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    dataGridView.Rows[dataGridView.CurrentCell.RowIndex + 1].Cells[dataGridViewColumn.Name].Selected = true;
                    e.Handled = true;
                    dataGridView.Focus();
                }
                else
                {
                    SearchByKeyPressFirstOccurrence(e, dataGridView, dataGridViewColumn);
                }
            }
            else
            {
                SearchByKeyPressFirstOccurrence(e, dataGridView, dataGridViewColumn);
            }
        }

        internal static void SearchByKeyPress(KeyPressEventArgs e, DataGridView dataGridView, DataGridViewColumn dataGridViewColumn)
        {
            if (char.IsLetter(e.KeyChar))
            {
                if (dataGridView.CurrentRow.Cells[dataGridViewColumn.Name].Value.ToString().ReplaceDiacritics().StartsWith(e.KeyChar.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    // It's the same key search, so iterate through items
                    SearchByKeyPressNextOccurrences(e, dataGridView, dataGridViewColumn);
                }
                else
                {
                    // It's a new key search
                    SearchByKeyPressFirstOccurrence(e, dataGridView, dataGridViewColumn);
                }
            }
        }

        #endregion

        #region Items count text

        internal static string GetItemsCountText(string entityName, string entitiesName, int itemsCount)
        {
            const int spaces = 5;

            string itemsCountText = itemsCount switch
            {
                0 => string.Format(Properties.Resources.StringDatabaseItemsCountNone, entityName),
                1 => string.Format(Properties.Resources.StringDatabaseItemsCountOne, entityName),
                _ => string.Format(Properties.Resources.StringDatabaseItemsCountMany, entitiesName, itemsCount.ToString("N0")),
            };

            return new string(' ', spaces) + itemsCountText + new string(' ', spaces);
        }

        #endregion

    }
}
