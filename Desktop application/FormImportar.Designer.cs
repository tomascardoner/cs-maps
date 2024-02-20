namespace CSMaps
{
    partial class FormImportar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RadioButtonArchivoKml = new RadioButton();
            LabelArchivoKml = new Label();
            TextBoxArchivoKml = new TextBox();
            ButtonArchivoKml = new Button();
            ButtonIniciar = new Button();
            SuspendLayout();
            // 
            // RadioButtonArchivoKml
            // 
            RadioButtonArchivoKml.AutoSize = true;
            RadioButtonArchivoKml.Checked = true;
            RadioButtonArchivoKml.Location = new Point(12, 12);
            RadioButtonArchivoKml.Name = "RadioButtonArchivoKml";
            RadioButtonArchivoKml.Size = new Size(259, 19);
            RadioButtonArchivoKml.TabIndex = 0;
            RadioButtonArchivoKml.TabStop = true;
            RadioButtonArchivoKml.Text = "Puntos desde archivo de Google Earth (.kml)";
            RadioButtonArchivoKml.UseVisualStyleBackColor = true;
            // 
            // LabelArchivoKml
            // 
            LabelArchivoKml.AutoSize = true;
            LabelArchivoKml.Location = new Point(38, 44);
            LabelArchivoKml.Name = "LabelArchivoKml";
            LabelArchivoKml.Size = new Size(51, 15);
            LabelArchivoKml.TabIndex = 1;
            LabelArchivoKml.Text = "Archivo:";
            // 
            // TextBoxArchivoKml
            // 
            TextBoxArchivoKml.Location = new Point(95, 41);
            TextBoxArchivoKml.Name = "TextBoxArchivoKml";
            TextBoxArchivoKml.Size = new Size(657, 23);
            TextBoxArchivoKml.TabIndex = 2;
            // 
            // ButtonArchivoKml
            // 
            ButtonArchivoKml.Location = new Point(758, 41);
            ButtonArchivoKml.Name = "ButtonArchivoKml";
            ButtonArchivoKml.Size = new Size(30, 23);
            ButtonArchivoKml.TabIndex = 3;
            ButtonArchivoKml.Text = "...";
            ButtonArchivoKml.UseVisualStyleBackColor = true;
            // 
            // ButtonIniciar
            // 
            ButtonIniciar.Location = new Point(695, 243);
            ButtonIniciar.Name = "ButtonIniciar";
            ButtonIniciar.Size = new Size(93, 34);
            ButtonIniciar.TabIndex = 4;
            ButtonIniciar.Text = "Iniciar...";
            ButtonIniciar.UseVisualStyleBackColor = true;
            ButtonIniciar.Click += ButtonIniciar_Click;
            // 
            // FormImportar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 289);
            Controls.Add(ButtonIniciar);
            Controls.Add(ButtonArchivoKml);
            Controls.Add(TextBoxArchivoKml);
            Controls.Add(LabelArchivoKml);
            Controls.Add(RadioButtonArchivoKml);
            Name = "FormImportar";
            Text = "Importar datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadioButtonArchivoKml;
        private Label LabelArchivoKml;
        private TextBox TextBoxArchivoKml;
        private Button ButtonArchivoKml;
        private Button ButtonIniciar;
    }
}
