namespace Sheuchan.Sheuchan.UI.ShellRibbon
{
    partial class ShellRibbonView
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
            this.tileModule1 = new MetroFramework.Controls.MetroTile();
            this.tileModule2 = new MetroFramework.Controls.MetroTile();
            this.tileModule3 = new MetroFramework.Controls.MetroTile();
            this.tileModule4 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileModule1
            // 
            this.tileModule1.ActiveControl = null;
            this.tileModule1.Location = new System.Drawing.Point(4, 4);
            this.tileModule1.Name = "tileModule1";
            this.tileModule1.Size = new System.Drawing.Size(141, 57);
            this.tileModule1.TabIndex = 0;
            this.tileModule1.Text = "metroTile1";
            this.tileModule1.UseSelectable = true;
            this.tileModule1.Click += new System.EventHandler(this.tileModule1_Click);
            // 
            // tileModule2
            // 
            this.tileModule2.ActiveControl = null;
            this.tileModule2.Location = new System.Drawing.Point(153, 4);
            this.tileModule2.Name = "tileModule2";
            this.tileModule2.Size = new System.Drawing.Size(141, 57);
            this.tileModule2.TabIndex = 1;
            this.tileModule2.Text = "metroTile1";
            this.tileModule2.UseSelectable = true;
            // 
            // tileModule3
            // 
            this.tileModule3.ActiveControl = null;
            this.tileModule3.Location = new System.Drawing.Point(300, 4);
            this.tileModule3.Name = "tileModule3";
            this.tileModule3.Size = new System.Drawing.Size(141, 57);
            this.tileModule3.TabIndex = 2;
            this.tileModule3.Text = "metroTile1";
            this.tileModule3.UseSelectable = true;
            // 
            // tileModule4
            // 
            this.tileModule4.ActiveControl = null;
            this.tileModule4.Location = new System.Drawing.Point(447, 4);
            this.tileModule4.Name = "tileModule4";
            this.tileModule4.Size = new System.Drawing.Size(141, 57);
            this.tileModule4.TabIndex = 3;
            this.tileModule4.Text = "metroTile1";
            this.tileModule4.UseSelectable = true;
            // 
            // ShellRibbonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tileModule4);
            this.Controls.Add(this.tileModule3);
            this.Controls.Add(this.tileModule2);
            this.Controls.Add(this.tileModule1);
            this.Name = "ShellRibbonView";
            this.Size = new System.Drawing.Size(681, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileModule1;
        private MetroFramework.Controls.MetroTile tileModule2;
        private MetroFramework.Controls.MetroTile tileModule3;
        private MetroFramework.Controls.MetroTile tileModule4;
    }
}
