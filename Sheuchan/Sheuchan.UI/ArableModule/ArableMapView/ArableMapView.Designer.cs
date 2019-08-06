namespace Sheuchan.Sheuchan.UI.ArableModule.ArableMapView
{
    partial class ArableMapView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmapControl = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gmapControl
            // 
            this.gmapControl.Bearing = 0F;
            this.gmapControl.CanDragMap = true;
            this.gmapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapControl.GrayScaleMode = false;
            this.gmapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapControl.LevelsKeepInMemmory = 5;
            this.gmapControl.Location = new System.Drawing.Point(0, 0);
            this.gmapControl.MarkersEnabled = true;
            this.gmapControl.MaxZoom = 16;
            this.gmapControl.MinZoom = 2;
            this.gmapControl.MouseWheelZoomEnabled = true;
            this.gmapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapControl.Name = "gmapControl";
            this.gmapControl.NegativeMode = false;
            this.gmapControl.PolygonsEnabled = true;
            this.gmapControl.RetryLoadTile = 0;
            this.gmapControl.RoutesEnabled = true;
            this.gmapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapControl.ShowTileGridLines = false;
            this.gmapControl.Size = new System.Drawing.Size(439, 496);
            this.gmapControl.TabIndex = 0;
            this.gmapControl.Zoom = 13D;
            this.gmapControl.Click += new System.EventHandler(this.gmapControl_Click);
            // 
            // ArableMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gmapControl);
            this.Name = "ArableMapView";
            this.Size = new System.Drawing.Size(439, 496);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmapControl;
    }
}
