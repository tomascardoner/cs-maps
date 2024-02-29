namespace CSMaps.General
{
    partial class FormEntities
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
            ToolStripMain = new ToolStrip();
            ToolStripButtonAdd = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonDelete = new ToolStripButton();
            ToolStripLabelItemsCounter = new ToolStripLabel();
            DataGridViewMain = new DataGridView();
            DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            DataGridViewColumnTelefonoMovil = new DataGridViewTextBoxColumn();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // ToolStripMain
            // 
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonAdd, ToolStripButtonEdit, ToolStripButtonDelete, ToolStripLabelItemsCounter });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(641, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(85, 36);
            ToolStripButtonAdd.Text = "Agregar";
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(73, 36);
            ToolStripButtonEdit.Text = "Editar";
            // 
            // ToolStripButtonDelete
            // 
            ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            ToolStripButtonDelete.Size = new Size(75, 36);
            ToolStripButtonDelete.Text = "Borrar";
            // 
            // ToolStripLabelItemsCounter
            // 
            ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            ToolStripLabelItemsCounter.Size = new Size(0, 36);
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.AllowUserToAddRows = false;
            DataGridViewMain.AllowUserToDeleteRows = false;
            DataGridViewMain.AllowUserToResizeColumns = false;
            DataGridViewMain.AllowUserToResizeRows = false;
            DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnTelefonoMovil });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(0, 39);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(641, 294);
            DataGridViewMain.TabIndex = 1;
            DataGridViewMain.ColumnHeaderMouseClick += DataGridViewMain_ColumnHeaderMouseClick;
            DataGridViewMain.KeyPress += DataGridViewMain_KeyPress;
            // 
            // DataGridViewColumnNombre
            // 
            DataGridViewColumnNombre.DataPropertyName = "Nombre";
            DataGridViewColumnNombre.HeaderText = "Nombre";
            DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            DataGridViewColumnNombre.ReadOnly = true;
            DataGridViewColumnNombre.Width = 76;
            // 
            // DataGridViewColumnTelefonoMovil
            // 
            DataGridViewColumnTelefonoMovil.DataPropertyName = "TelefonoMovil";
            DataGridViewColumnTelefonoMovil.HeaderText = "Teléfono móvil";
            DataGridViewColumnTelefonoMovil.Name = "DataGridViewColumnTelefonoMovil";
            DataGridViewColumnTelefonoMovil.ReadOnly = true;
            DataGridViewColumnTelefonoMovil.Width = 110;
            // 
            // FormEntities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 333);
            Controls.Add(DataGridViewMain);
            Controls.Add(ToolStripMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEntities";
            Text = "Entidades";
            FormClosed += FormEntities_FormClosed;
            Load += FormEntities_Load;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStripMain;
        private ToolStripButton ToolStripButtonAdd;
        private ToolStripButton ToolStripButtonEdit;
        private ToolStripButton ToolStripButtonDelete;
        private ToolStripLabel ToolStripLabelItemsCounter;
        private DataGridView DataGridViewMain;
        private DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private DataGridViewTextBoxColumn DataGridViewColumnTelefonoMovil;
    }
}