using System.Globalization;
using CardonerSistemas.Framework.Base;

namespace CSMaps.Common;

internal static class DataGridViews
{

    #region Common

    internal static void CommonActionFinalize(Form form, DataGridView dataGridView)
    {
        form.Cursor = Cursors.Default;
        dataGridView.Enabled = true;
    }

    #endregion Common

    #region View

    internal static bool ViewVerify(Form form, DataGridView dataGridView, string entityNameSingle, bool entityIsFemale)
    {
        if (dataGridView.CurrentRow == null)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringActionNoneFemale : Properties.Resources.StringActionNoneMale, entityNameSingle, Properties.Resources.StringActionView), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        form.Cursor = Cursors.WaitCursor;
        dataGridView.Enabled = false;
        return true;
    }

    #endregion View

    #region Add

    internal static bool AddVerify(Form form, DataGridView dataGridView, Users.Permissions.Actions? permiso)
    {
        if (permiso.HasValue && !Users.Permissions.Verify(permiso.Value))
        {
            return false;
        }

        form.Cursor = Cursors.WaitCursor;
        dataGridView.Enabled = false;
        return true;
    }

    #endregion Add

    #region Edit

    internal static bool EditVerify(Form form, DataGridView dataGridView, Users.Permissions.Actions? permiso, string entityNameSingle, bool entityIsFemale)
    {
        if (dataGridView.CurrentRow == null)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringActionNoneFemale : Properties.Resources.StringActionNoneMale, entityNameSingle, Properties.Resources.StringActionEdit), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (permiso.HasValue && !Users.Permissions.Verify(permiso.Value))
        {
            return false;
        }

        form.Cursor = Cursors.WaitCursor;
        dataGridView.Enabled = false;
        return true;
    }

    #endregion Edit

    #region Delete

    internal static bool DeleteVerify(DataGridView dataGridView, Users.Permissions.Actions? permiso, string entityNameSingle, bool entityIsFemale)
    {
        if (dataGridView.CurrentRow == null)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringActionNoneFemale : Properties.Resources.StringActionNoneMale, entityNameSingle, Properties.Resources.StringActionDelete), Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return !permiso.HasValue || Users.Permissions.Verify(permiso.Value);
    }

    internal static bool DeleteConfirm(string entityNameSingle, bool entityIsFemale, string entityData)
    {
        var mensaje = string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringActionDeleteConfirmationFemale : Properties.Resources.StringActionDeleteConfirmationMale, entityNameSingle, entityData);
        return MessageBox.Show(mensaje, Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
    }

    #endregion Delete

    #region Sort by column

    internal static bool ColumnHeaderMouseClick(DataGridView dataGridView, DataGridViewCellMouseEventArgs e, ref DataGridViewColumn sortedColumn, ref SortOrder sortOrder, DataGridViewColumn[] sorteableColumns)
    {
        var column = dataGridView.Columns[e.ColumnIndex];
        if (!sorteableColumns.Contains(column))
        {
            return false;
        }

        if (column == sortedColumn)
        {
            // Clicked column is the sorted one, so invert sort order
            sortOrder = sortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
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

    #endregion Sort by column

    #region Search row by first key letter pressed

    private static void SearchByKeyPressFirstOccurrence(KeyPressEventArgs e, DataGridView dataGridView, DataGridViewColumn dataGridViewColumn)
    {
        var row = (from DataGridViewRow r in dataGridView.Rows
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

    #endregion Search row by first key letter pressed

    #region Items count text

    internal static string GetItemsCountText(string entityName, string entitiesName, int itemsCount)
    {
        const int spaces = 5;

        var itemsCountText = itemsCount switch
        {
            0 => string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringDatabaseItemsCountNone, entitiesName),
            1 => string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringDatabaseItemsCountOne, entityName),
            _ => string.Format(CultureInfo.CurrentCulture, Properties.Resources.StringDatabaseItemsCountMany, entitiesName, itemsCount.ToString("N0", CultureInfo.CurrentCulture)),
        };

        return new string(' ', spaces) + itemsCountText + new string(' ', spaces);
    }

    #endregion Items count text

}