namespace CSMaps.Maps
{
    partial class FormViewer
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
            GMapControlMain = new GMap.NET.WindowsForms.GMapControl();
            TableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonZoomIn = new Button();
            ButtonZoomOut = new Button();
            ButtonZoomRestore = new Button();
            TableLayoutPanelMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GMapControlMain
            // 
            GMapControlMain.Bearing = 0F;
            GMapControlMain.CanDragMap = true;
            GMapControlMain.Dock = DockStyle.Fill;
            GMapControlMain.EmptyTileColor = Color.Navy;
            GMapControlMain.GrayScaleMode = false;
            GMapControlMain.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            GMapControlMain.LevelsKeepInMemory = 5;
            GMapControlMain.Location = new Point(3, 45);
            GMapControlMain.MarkersEnabled = true;
            GMapControlMain.MaxZoom = 2;
            GMapControlMain.MinZoom = 2;
            GMapControlMain.MouseWheelZoomEnabled = true;
            GMapControlMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            GMapControlMain.Name = "GMapControlMain";
            GMapControlMain.NegativeMode = false;
            GMapControlMain.PolygonsEnabled = true;
            GMapControlMain.RetryLoadTile = 0;
            GMapControlMain.RoutesEnabled = true;
            GMapControlMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            GMapControlMain.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            GMapControlMain.ShowTileGridLines = false;
            GMapControlMain.Size = new Size(797, 596);
            GMapControlMain.TabIndex = 0;
            GMapControlMain.Zoom = 0D;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelMain.Controls.Add(GMapControlMain, 0, 1);
            TableLayoutPanelMain.Controls.Add(tableLayoutPanel1, 0, 0);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelMain.Location = new Point(0, 0);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 2;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Size = new Size(797, 644);
            TableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(ButtonZoomIn, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonZoomOut, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonZoomRestore, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(797, 36);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonZoomIn
            // 
            ButtonZoomIn.AutoSize = true;
            ButtonZoomIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonZoomIn.Location = new Point(3, 3);
            ButtonZoomIn.Name = "ButtonZoomIn";
            ButtonZoomIn.Size = new Size(73, 30);
            ButtonZoomIn.TabIndex = 0;
            ButtonZoomIn.Text = "Zoom +";
            ButtonZoomIn.UseVisualStyleBackColor = true;
            ButtonZoomIn.Click += ButtonZoomIn_Click;
            // 
            // ButtonZoomOut
            // 
            ButtonZoomOut.AutoSize = true;
            ButtonZoomOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonZoomOut.Location = new Point(82, 3);
            ButtonZoomOut.Name = "ButtonZoomOut";
            ButtonZoomOut.Size = new Size(69, 30);
            ButtonZoomOut.TabIndex = 1;
            ButtonZoomOut.Text = "Zoom -";
            ButtonZoomOut.UseVisualStyleBackColor = true;
            ButtonZoomOut.Click += ButtonZoomOut_Click;
            // 
            // ButtonZoomRestore
            // 
            ButtonZoomRestore.AutoSize = true;
            ButtonZoomRestore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonZoomRestore.Location = new Point(157, 3);
            ButtonZoomRestore.Name = "ButtonZoomRestore";
            ButtonZoomRestore.Size = new Size(81, 30);
            ButtonZoomRestore.TabIndex = 2;
            ButtonZoomRestore.Text = "Restaurar";
            ButtonZoomRestore.UseVisualStyleBackColor = true;
            ButtonZoomRestore.Click += ButtonZoomRestore_Click;
            // 
            // FormViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 644);
            Controls.Add(TableLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormViewer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visor de mapas";
            FormClosed += FormViewer_FormClosed;
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMapControlMain;
        private TableLayoutPanel TableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonZoomIn;
        private Button ButtonZoomOut;
        private Button ButtonZoomRestore;
    }
}