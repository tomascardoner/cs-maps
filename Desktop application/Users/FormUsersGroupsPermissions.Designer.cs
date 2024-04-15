
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
            SuspendLayout();
            // 
            // TreeViewPermisos
            // 
            TreeViewPermisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TreeViewPermisos.CheckBoxes = true;
            TreeViewPermisos.Location = new Point(14, 45);
            TreeViewPermisos.Margin = new Padding(4, 3, 4, 3);
            TreeViewPermisos.Name = "TreeViewPermisos";
            TreeViewPermisos.Size = new Size(902, 460);
            TreeViewPermisos.TabIndex = 2;
            TreeViewPermisos.BeforeCheck += TreeviewPermisos_BeforeCheck;
            TreeViewPermisos.AfterCheck += TreeviewPermisos_AfterCheck;
            // 
            // ComboBoxUsuarioGrupo
            // 
            ComboBoxUsuarioGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxUsuarioGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUsuarioGrupo.FormattingEnabled = true;
            ComboBoxUsuarioGrupo.Location = new Point(156, 14);
            ComboBoxUsuarioGrupo.Margin = new Padding(4, 3, 4, 3);
            ComboBoxUsuarioGrupo.Name = "ComboBoxUsuarioGrupo";
            ComboBoxUsuarioGrupo.Size = new Size(760, 23);
            ComboBoxUsuarioGrupo.TabIndex = 1;
            ComboBoxUsuarioGrupo.SelectedIndexChanged += ComboboxUsuarioGrupo_SelectedIndexChanged;
            // 
            // LabelUsuarioGrupo
            // 
            LabelUsuarioGrupo.AutoSize = true;
            LabelUsuarioGrupo.Location = new Point(14, 17);
            LabelUsuarioGrupo.Margin = new Padding(4, 0, 4, 0);
            LabelUsuarioGrupo.Name = "LabelUsuarioGrupo";
            LabelUsuarioGrupo.Size = new Size(107, 15);
            LabelUsuarioGrupo.TabIndex = 0;
            LabelUsuarioGrupo.Text = "Grupo de Usuarios:";
            // 
            // FormUsersGroupsPermissions
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(931, 519);
            Controls.Add(TreeViewPermisos);
            Controls.Add(ComboBoxUsuarioGrupo);
            Controls.Add(LabelUsuarioGrupo);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsersGroupsPermissions";
            StartPosition = FormStartPosition.Manual;
            Text = "Permisos por grupo de usuarios";
            FormClosed += This_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.TreeView TreeViewPermisos;
        internal System.Windows.Forms.ComboBox ComboBoxUsuarioGrupo;
        internal System.Windows.Forms.Label LabelUsuarioGrupo;
    }
}