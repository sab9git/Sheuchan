namespace Sheuchan.Sheuchan.UI.ArableModule
{
    partial class ArableWorkspace
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
            this.pnlArableMain = new MetroFramework.Controls.MetroPanel();
            this.pnlArableMap = new MetroFramework.Controls.MetroPanel();
            this.pnlArableRibbon = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // pnlArableMain
            // 
            this.pnlArableMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlArableMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlArableMain.HorizontalScrollbarBarColor = true;
            this.pnlArableMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlArableMain.HorizontalScrollbarSize = 10;
            this.pnlArableMain.Location = new System.Drawing.Point(0, 43);
            this.pnlArableMain.Name = "pnlArableMain";
            this.pnlArableMain.Size = new System.Drawing.Size(566, 430);
            this.pnlArableMain.TabIndex = 0;
            this.pnlArableMain.VerticalScrollbarBarColor = true;
            this.pnlArableMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlArableMain.VerticalScrollbarSize = 10;
            // 
            // pnlArableMap
            // 
            this.pnlArableMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArableMap.BackColor = System.Drawing.Color.Transparent;
            this.pnlArableMap.HorizontalScrollbarBarColor = true;
            this.pnlArableMap.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlArableMap.HorizontalScrollbarSize = 10;
            this.pnlArableMap.Location = new System.Drawing.Point(562, 43);
            this.pnlArableMap.Name = "pnlArableMap";
            this.pnlArableMap.Size = new System.Drawing.Size(263, 433);
            this.pnlArableMap.Style = MetroFramework.MetroColorStyle.Orange;
            this.pnlArableMap.TabIndex = 1;
            this.pnlArableMap.UseCustomBackColor = true;
            this.pnlArableMap.VerticalScrollbarBarColor = true;
            this.pnlArableMap.VerticalScrollbarHighlightOnWheel = false;
            this.pnlArableMap.VerticalScrollbarSize = 10;
            // 
            // pnlArableRibbon
            // 
            this.pnlArableRibbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArableRibbon.HorizontalScrollbarBarColor = true;
            this.pnlArableRibbon.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlArableRibbon.HorizontalScrollbarSize = 10;
            this.pnlArableRibbon.Location = new System.Drawing.Point(0, 0);
            this.pnlArableRibbon.Name = "pnlArableRibbon";
            this.pnlArableRibbon.Size = new System.Drawing.Size(825, 45);
            this.pnlArableRibbon.TabIndex = 2;
            this.pnlArableRibbon.VerticalScrollbarBarColor = true;
            this.pnlArableRibbon.VerticalScrollbarHighlightOnWheel = false;
            this.pnlArableRibbon.VerticalScrollbarSize = 10;
            // 
            // ArableWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlArableRibbon);
            this.Controls.Add(this.pnlArableMap);
            this.Controls.Add(this.pnlArableMain);
            this.Name = "ArableWorkspace";
            this.Size = new System.Drawing.Size(825, 476);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlArableMain;
        private MetroFramework.Controls.MetroPanel pnlArableMap;
        private MetroFramework.Controls.MetroPanel pnlArableRibbon;
    }
}
