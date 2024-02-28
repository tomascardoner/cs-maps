namespace CSMaps.Common
{
    internal static class Appearance
    {
        internal static void SetControlsDataGridViews(Control.ControlCollection controlCollection, bool recursive)
        {
            foreach (Control control in controlCollection)
            {
                if (control is DataGridView dataGridView)
                {
                    SetDataGrid(dataGridView);
                }
                if (recursive && control.Controls.Count > 0)
                {
                    SetControlsDataGridViews(control.Controls, recursive);
                }
            }
        }

        internal static void SetControlsTreeViews(Control.ControlCollection controlCollection, bool recursive)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TreeView treeView)
                {
                    SetTreeView(treeView);
                }
                if (recursive && control.Controls.Count > 0)
                {
                    SetControlsTreeViews(control.Controls, recursive);
                }
            }
        }

        internal static void SetControls(Control.ControlCollection controlCollection, bool recursive)
        {
            foreach (Control control in controlCollection)
            {
                if (control is DataGridView dataGridView)
                {
                    SetDataGrid(dataGridView);
                }
                if (control is TreeView treeView)
                {
                    SetTreeView(treeView);
                }
                if (recursive && control.Controls.Count > 0)
                {
                    SetControls(control.Controls, recursive);
                }
            }
        }

        internal static void SetDataGrid(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.BackColor = Program.AppearanceConfig.GridRowBackColor;
            dataGridView.DefaultCellStyle.ForeColor = Program.AppearanceConfig.GridRowForeColor;
            dataGridView.DefaultCellStyle.SelectionBackColor = Program.AppearanceConfig.GridRowSelectionBackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = Program.AppearanceConfig.GridRowSelectionForeColor;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Program.AppearanceConfig.GridAlternateRowBackColor;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Program.AppearanceConfig.GridAlternateRowForeColor;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Program.AppearanceConfig.GridAlternateRowSelectionBackColor;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Program.AppearanceConfig.GridAlternateRowSelectionForeColor;
        }

        internal static void SetTreeView(TreeView treeView)
        {
            treeView.Indent = (int)(Program.AppearanceConfig.Font.Size / 10 * 25);
        }

    }
}