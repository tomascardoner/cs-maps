namespace CSMaps.General
{
    partial class FormExportGoogleEarthFile
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
            ButtonStart = new Button();
            ButtonFile = new Button();
            TextBoxFile = new TextBox();
            LabelFile = new Label();
            CheckedListBoxGrupos = new CheckedListBox();
            LabelGrupos = new Label();
            ButtonGruposSeleccionarTodos = new Button();
            ButtonGruposSeleccionarNinguno = new Button();
            ButtonGruposInvertirSeleccion = new Button();
            SuspendLayout();
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(554, 336);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(93, 34);
            ButtonStart.TabIndex = 8;
            ButtonStart.Text = "Iniciar...";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonFile
            // 
            ButtonFile.Location = new Point(617, 296);
            ButtonFile.Name = "ButtonFile";
            ButtonFile.Size = new Size(30, 23);
            ButtonFile.TabIndex = 7;
            ButtonFile.Text = "...";
            ButtonFile.UseVisualStyleBackColor = true;
            ButtonFile.Click += ButtonFile_Click;
            // 
            // TextBoxFile
            // 
            TextBoxFile.Location = new Point(12, 297);
            TextBoxFile.Name = "TextBoxFile";
            TextBoxFile.Size = new Size(599, 23);
            TextBoxFile.TabIndex = 6;
            TextBoxFile.Enter += TextBoxFile_Enter;
            // 
            // LabelFile
            // 
            LabelFile.AutoSize = true;
            LabelFile.Location = new Point(12, 279);
            LabelFile.Name = "LabelFile";
            LabelFile.Size = new Size(109, 15);
            LabelFile.TabIndex = 5;
            LabelFile.Text = "Archivo de destino:";
            // 
            // CheckedListBoxGrupos
            // 
            CheckedListBoxGrupos.CheckOnClick = true;
            CheckedListBoxGrupos.FormattingEnabled = true;
            CheckedListBoxGrupos.Location = new Point(12, 27);
            CheckedListBoxGrupos.Name = "CheckedListBoxGrupos";
            CheckedListBoxGrupos.Size = new Size(333, 220);
            CheckedListBoxGrupos.TabIndex = 1;
            // 
            // LabelGrupos
            // 
            LabelGrupos.AutoSize = true;
            LabelGrupos.Location = new Point(12, 9);
            LabelGrupos.Name = "LabelGrupos";
            LabelGrupos.Size = new Size(104, 15);
            LabelGrupos.TabIndex = 0;
            LabelGrupos.Text = "Grupos a exportar:";
            // 
            // ButtonGruposSeleccionarTodos
            // 
            ButtonGruposSeleccionarTodos.Location = new Point(351, 27);
            ButtonGruposSeleccionarTodos.Name = "ButtonGruposSeleccionarTodos";
            ButtonGruposSeleccionarTodos.Size = new Size(132, 29);
            ButtonGruposSeleccionarTodos.TabIndex = 2;
            ButtonGruposSeleccionarTodos.Text = "Seleccionar todos";
            ButtonGruposSeleccionarTodos.UseVisualStyleBackColor = true;
            ButtonGruposSeleccionarTodos.Click += ButtonGruposSeleccionarTodos_Click;
            // 
            // ButtonGruposSeleccionarNinguno
            // 
            ButtonGruposSeleccionarNinguno.Location = new Point(351, 62);
            ButtonGruposSeleccionarNinguno.Name = "ButtonGruposSeleccionarNinguno";
            ButtonGruposSeleccionarNinguno.Size = new Size(132, 29);
            ButtonGruposSeleccionarNinguno.TabIndex = 3;
            ButtonGruposSeleccionarNinguno.Text = "Deseleccionar todos";
            ButtonGruposSeleccionarNinguno.UseVisualStyleBackColor = true;
            ButtonGruposSeleccionarNinguno.Click += ButtonGruposSeleccionarNinguno_Click;
            // 
            // ButtonGruposInvertirSeleccion
            // 
            ButtonGruposInvertirSeleccion.Location = new Point(351, 97);
            ButtonGruposInvertirSeleccion.Name = "ButtonGruposInvertirSeleccion";
            ButtonGruposInvertirSeleccion.Size = new Size(132, 29);
            ButtonGruposInvertirSeleccion.TabIndex = 4;
            ButtonGruposInvertirSeleccion.Text = "Invertir selección";
            ButtonGruposInvertirSeleccion.UseVisualStyleBackColor = true;
            ButtonGruposInvertirSeleccion.Click += ButtonGruposInvertirSeleccion_Click;
            // 
            // FormExportGoogleEarthFile
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(659, 383);
            Controls.Add(ButtonGruposInvertirSeleccion);
            Controls.Add(ButtonGruposSeleccionarNinguno);
            Controls.Add(ButtonGruposSeleccionarTodos);
            Controls.Add(LabelGrupos);
            Controls.Add(CheckedListBoxGrupos);
            Controls.Add(ButtonStart);
            Controls.Add(ButtonFile);
            Controls.Add(TextBoxFile);
            Controls.Add(LabelFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormExportGoogleEarthFile";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exportar datos a archivo de Google Earth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonStart;
        private Button ButtonFile;
        private TextBox TextBoxFile;
        private Label LabelFile;
        private CheckedListBox CheckedListBoxGrupos;
        private Label LabelGrupos;
        private Button ButtonGruposSeleccionarTodos;
        private Button ButtonGruposSeleccionarNinguno;
        private Button ButtonGruposInvertirSeleccion;
    }
}