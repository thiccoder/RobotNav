
using GMap.NET.WindowsForms;

namespace RobotNav
{
    partial class MainForm
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
            this.SMSButton = new System.Windows.Forms.Button();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.SerialButton = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LatTextBox = new System.Windows.Forms.TextBox();
            this.LngTextBox = new System.Windows.Forms.TextBox();
            this.RepositionMarkerButton = new System.Windows.Forms.Button();
            this.AddMarkerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SMSButton
            // 
            this.SMSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SMSButton.Location = new System.Drawing.Point(210, 266);
            this.SMSButton.Name = "SMSButton";
            this.SMSButton.Size = new System.Drawing.Size(100, 25);
            this.SMSButton.TabIndex = 7;
            this.SMSButton.Text = "Send Via SMS";
            this.SMSButton.UseVisualStyleBackColor = true;
            this.SMSButton.Click += new System.EventHandler(this.SendSMS);
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 100000;
            this.Map.MinZoom = 0;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(314, 291);
            this.Map.TabIndex = 0;
            this.Map.Zoom = 0D;
            this.Map.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.OnMarkerDoubleClick);
            this.Map.Load += new System.EventHandler(this.Map_Load);
            this.Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map_Mouse);
            this.Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_Mouse);
            // 
            // SerialButton
            // 
            this.SerialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SerialButton.Location = new System.Drawing.Point(0, 266);
            this.SerialButton.Name = "SerialButton";
            this.SerialButton.Size = new System.Drawing.Size(100, 25);
            this.SerialButton.TabIndex = 5;
            this.SerialButton.Text = "Send Via Serial";
            this.SerialButton.UseVisualStyleBackColor = true;
            this.SerialButton.Click += new System.EventHandler(this.SendSerial);
            // 
            // Export
            // 
            this.Export.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Export.Location = new System.Drawing.Point(105, 266);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(100, 25);
            this.Export.TabIndex = 6;
            this.Export.Text = "Export as CSV";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.ExportCSV);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // LatTextBox
            // 
            this.LatTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LatTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LatTextBox.Location = new System.Drawing.Point(205, 92);
            this.LatTextBox.Name = "LatTextBox";
            this.LatTextBox.PlaceholderText = "Latitude";
            this.LatTextBox.Size = new System.Drawing.Size(100, 23);
            this.LatTextBox.TabIndex = 1;
            // 
            // LngTextBox
            // 
            this.LngTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LngTextBox.Location = new System.Drawing.Point(205, 122);
            this.LngTextBox.Name = "LngTextBox";
            this.LngTextBox.PlaceholderText = "Longitude";
            this.LngTextBox.Size = new System.Drawing.Size(100, 23);
            this.LngTextBox.TabIndex = 2;
            // 
            // RepositionMarkerButton
            // 
            this.RepositionMarkerButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RepositionMarkerButton.Location = new System.Drawing.Point(205, 182);
            this.RepositionMarkerButton.Name = "RepositionMarkerButton";
            this.RepositionMarkerButton.Size = new System.Drawing.Size(100, 23);
            this.RepositionMarkerButton.TabIndex = 4;
            this.RepositionMarkerButton.Text = "Move selected";
            this.RepositionMarkerButton.UseVisualStyleBackColor = true;
            this.RepositionMarkerButton.Click += new System.EventHandler(this.Reposition_Click);
            // 
            // AddMarkerButton
            // 
            this.AddMarkerButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddMarkerButton.Location = new System.Drawing.Point(205, 152);
            this.AddMarkerButton.Name = "AddMarkerButton";
            this.AddMarkerButton.Size = new System.Drawing.Size(100, 23);
            this.AddMarkerButton.TabIndex = 3;
            this.AddMarkerButton.Text = "Add new";
            this.AddMarkerButton.UseVisualStyleBackColor = true;
            this.AddMarkerButton.Click += new System.EventHandler(this.AddMarker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.AddMarkerButton);
            this.Controls.Add(this.RepositionMarkerButton);
            this.Controls.Add(this.LngTextBox);
            this.Controls.Add(this.LatTextBox);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.SerialButton);
            this.Controls.Add(this.SMSButton);
            this.Controls.Add(this.Map);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMapControl Map;
        private System.Windows.Forms.Button SerialButton;
        private System.Windows.Forms.Button SMSButton;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TextBox LatTextBox;
        private System.Windows.Forms.TextBox LngTextBox;
        private System.Windows.Forms.Button RepositionMarkerButton;
        private System.Windows.Forms.Button AddMarkerButton;
    }
}

