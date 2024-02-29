using CardonerSistemas.Framework.Base;

namespace CSMaps.Common
{
    internal static class DataGridViews
    {

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
            return itemsCount switch
            {
                0 => string.Format(Properties.Resources.StringDatabaseItemsCountNone, entityName),
                1 => string.Format(Properties.Resources.StringDatabaseItemsCountOne, entityName),
                _ => string.Format(Properties.Resources.StringDatabaseItemsCountMany, entitiesName, itemsCount.ToString("N0")),
            };
        }

        #endregion

    }
}
