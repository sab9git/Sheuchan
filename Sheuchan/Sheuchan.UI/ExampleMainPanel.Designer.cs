namespace Sheuchan.Sheuchan.UI
{
    partial class ExampleMainPanel
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
            this.tileExample = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileExample
            // 
            this.tileExample.ActiveControl = null;
            this.tileExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileExample.Enabled = false;
            this.tileExample.Location = new System.Drawing.Point(3, 3);
            this.tileExample.Name = "tileExample";
            this.tileExample.Size = new System.Drawing.Size(876, 511);
            this.tileExample.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileExample.TabIndex = 0;
            this.tileExample.UseSelectable = true;
            // 
            // ExampleMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileExample);
            this.Name = "ExampleMainPanel";
            this.Size = new System.Drawing.Size(882, 517);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileExample;
    }
}
