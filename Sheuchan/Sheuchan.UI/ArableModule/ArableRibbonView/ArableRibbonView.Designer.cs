namespace Sheuchan.Sheuchan.UI.ArableModule.ArableRibbonView
{
    partial class ArableRibbonView
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
            this.tileDefineField = new MetroFramework.Controls.MetroTile();
            this.tileFieldManager = new MetroFramework.Controls.MetroTile();
            this.tileCropRotation = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileDefineField
            // 
            this.tileDefineField.ActiveControl = null;
            this.tileDefineField.Location = new System.Drawing.Point(4, 4);
            this.tileDefineField.Name = "tileDefineField";
            this.tileDefineField.Size = new System.Drawing.Size(134, 38);
            this.tileDefineField.TabIndex = 0;
            this.tileDefineField.Text = "Define Field";
            this.tileDefineField.UseSelectable = true;
            this.tileDefineField.Click += new System.EventHandler(this.tileDefineField_Click);
            // 
            // tileFieldManager
            // 
            this.tileFieldManager.ActiveControl = null;
            this.tileFieldManager.Location = new System.Drawing.Point(144, 4);
            this.tileFieldManager.Name = "tileFieldManager";
            this.tileFieldManager.Size = new System.Drawing.Size(134, 38);
            this.tileFieldManager.TabIndex = 0;
            this.tileFieldManager.Text = "Field Manager";
            this.tileFieldManager.UseSelectable = true;
            this.tileFieldManager.Click += new System.EventHandler(this.tileFieldManager_Click);
            // 
            // tileCropRotation
            // 
            this.tileCropRotation.ActiveControl = null;
            this.tileCropRotation.Location = new System.Drawing.Point(284, 4);
            this.tileCropRotation.Name = "tileCropRotation";
            this.tileCropRotation.Size = new System.Drawing.Size(134, 38);
            this.tileCropRotation.TabIndex = 0;
            this.tileCropRotation.Text = "Crop Rotation";
            this.tileCropRotation.UseSelectable = true;
            this.tileCropRotation.Click += new System.EventHandler(this.tileCropRotation_Click);
            // 
            // ArableRibbonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tileCropRotation);
            this.Controls.Add(this.tileFieldManager);
            this.Controls.Add(this.tileDefineField);
            this.Name = "ArableRibbonView";
            this.Size = new System.Drawing.Size(729, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileDefineField;
        private MetroFramework.Controls.MetroTile tileFieldManager;
        private MetroFramework.Controls.MetroTile tileCropRotation;
    }
}
