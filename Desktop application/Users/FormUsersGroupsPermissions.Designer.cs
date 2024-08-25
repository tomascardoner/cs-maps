
namespace CSMaps.Users
{
    partial class FormUsersGroupsPermissions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeViewPermisos = new TreeView();
            ComboBoxUsuarioGrupo = new ComboBox();
            LabelUsuarioGrupo = new Label();
            TableLayoutPanelMain = new TableLayoutPanel();
            TableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // TreeViewPermisos
            // 
            TreeViewPermisos.CheckBoxes = true;
            TableLayoutPanelMain.SetColumnSpan(TreeViewPermisos, 2);
            TreeViewPermisos.Dock = DockStyle.Fill;
            TreeViewPermisos.Location = new Point(4, 37);
            TreeViewPermisos.Margin = new Padding(4, 3, 4, 3);
            TreeViewPermisos.Name = "TreeViewPermisos";
            TreeViewPermisos.Size = new Size(821, 644);
            TreeViewPermisos.TabIndex = 2;
            TreeViewPermisos.BeforeCheck += TreeviewPermisos_BeforeCheck;
            TreeViewPermisos.AfterCheck += TreeviewPermisos_AfterCheck;
            // 
            // ComboBoxUsuarioGrupo
            // 
            ComboBoxUsuarioGrupo.Dock = DockStyle.Fill;
            ComboBoxUsuarioGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUsuarioGrupo.FormattingEnabled = true;
            ComboBoxUsuarioGrupo.Location = new Point(146, 3);
            ComboBoxUsuarioGrupo.Margin = new Padding(4, 3, 4, 3);
            ComboBoxUsuarioGrupo.Name = "ComboBoxUsuarioGrupo";
            ComboBoxUsuarioGrupo.Size = new Size(679, 28);
            ComboBoxUsuarioGrupo.TabIndex = 1;
            ComboBoxUsuarioGrupo.SelectedIndexChanged += ComboboxUsuarioGrupo_SelectedIndexChanged;
            // 
            // LabelUsuarioGrupo
            // 
            LabelUsuarioGrupo.AutoSize = true;
            LabelUsuarioGrupo.Dock = DockStyle.Fill;
            LabelUsuarioGrupo.Location = new Point(4, 0);
            LabelUsuarioGrupo.Margin = new Padding(4, 0, 4, 0);
            LabelUsuarioGrupo.Name = "LabelUsuarioGrupo";
            LabelUsuarioGrupo.Size = new Size(134, 34);
            LabelUsuarioGrupo.TabIndex = 0;
            LabelUsuarioGrupo.Text = "Grupo de Usuarios:";
            LabelUsuarioGrupo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.AutoSize = true;
            TableLayoutPanelMain.ColumnCount = 2;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(LabelUsuarioGrupo, 0, 0);
            TableLayoutPanelMain.Controls.Add(ComboBoxUsuarioGrupo, 1, 0);
            TableLayoutPanelMain.Controls.Add(TreeViewPermisos, 0, 1);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelMain.Location = new Point(0, 0);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 2;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Size = new Size(829, 684);
            TableLayoutPanelMain.TabIndex = 3;
            // 
            // FormUsersGroupsPermissions
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(829, 684);
            Controls.Add(TableLayoutPanelMain);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsersGroupsPermissions";
            StartPosition = FormStartPosition.Manual;
            Text = "Permisos por grupo de usuarios";
            FormClosed += This_FormClosed;
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.TreeView TreeViewPermisos;
        internal System.Windows.Forms.ComboBox ComboBoxUsuarioGrupo;
        internal System.Windows.Forms.Label LabelUsuarioGrupo;
        private TableLayoutPanel TableLayoutPanelMain;
    }
}