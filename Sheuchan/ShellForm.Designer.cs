namespace Sheuchan
{
    partial class ShellForm
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
            this.mpnlRibbonZone = new MetroFramework.Controls.MetroPanel();
            this.mpnlMainZone = new MetroFramework.Controls.MetroPanel();
            this.mlblStephenBrown = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mpnlRibbonZone
            // 
            this.mpnlRibbonZone.HorizontalScrollbarBarColor = true;
            this.mpnlRibbonZone.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlRibbonZone.HorizontalScrollbarSize = 10;
            this.mpnlRibbonZone.Location = new System.Drawing.Point(-1, -2);
            this.mpnlRibbonZone.Name = "mpnlRibbonZone";
            this.mpnlRibbonZone.Size = new System.Drawing.Size(802, 65);
            this.mpnlRibbonZone.TabIndex = 0;
            this.mpnlRibbonZone.VerticalScrollbarBarColor = true;
            this.mpnlRibbonZone.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlRibbonZone.VerticalScrollbarSize = 10;
            // 
            // mpnlMainZone
            // 
            this.mpnlMainZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpnlMainZone.HorizontalScrollbarBarColor = true;
            this.mpnlMainZone.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlMainZone.HorizontalScrollbarSize = 10;
            this.mpnlMainZone.Location = new System.Drawing.Point(-1, 58);
            this.mpnlMainZone.Name = "mpnlMainZone";
            this.mpnlMainZone.Size = new System.Drawing.Size(802, 371);
            this.mpnlMainZone.TabIndex = 1;
            this.mpnlMainZone.VerticalScrollbarBarColor = true;
            this.mpnlMainZone.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlMainZone.VerticalScrollbarSize = 10;
            // 
            // mlblStephenBrown
            // 
            this.mlblStephenBrown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlblStephenBrown.AutoSize = true;
            this.mlblStephenBrown.Location = new System.Drawing.Point(2, 430);
            this.mlblStephenBrown.Name = "mlblStephenBrown";
            this.mlblStephenBrown.Size = new System.Drawing.Size(81, 19);
            this.mlblStephenBrown.TabIndex = 2;
            this.mlblStephenBrown.Text = "metroLabel1";
            // 
            // ShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mlblStephenBrown);
            this.Controls.Add(this.mpnlMainZone);
            this.Controls.Add(this.mpnlRibbonZone);
            this.MinimumSize = new System.Drawing.Size(560, 390);
            this.Name = "ShellForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnlRibbonZone;
        private MetroFramework.Controls.MetroPanel mpnlMainZone;
        private MetroFramework.Controls.MetroLabel mlblStephenBrown;
    }
}

