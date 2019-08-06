using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Sheuchan.Sheuchan.UI.ShellRibbon
{
    public partial class ShellRibbonView : UserControl, IShellRibbonView
    {

        #region Properties and Fields

        public MetroTile Module1Tile { get; set; }
        public MetroTile Module2Tile { get; set; }
        public MetroTile Module3Tile { get; set; }
        public MetroTile Module4Tile { get; set; }
        public IShellRibbonViewPresenter ShellRibbonPresenter { get; set; }
        public ShellForm MainShellForm { get; set; }

        #endregion

        public ShellRibbonView(ShellForm shell)
        {
            InitializeComponent();

            //---- Link UI objects to properties
            Module1Tile = tileModule1;
            Module2Tile = tileModule2;
            Module3Tile = tileModule3;
            Module4Tile = tileModule4;

            ShellRibbonPresenter = new ShellRibbonViewPresenter(this);
            MainShellForm = shell;
        }

        #region Event Handlers
        public void OnModule1Click (object sender, EventArgs e)
        {
            ShellRibbonPresenter.OnModule1Click(sender, e);
        }

        public void OnModule2Click(object sender, EventArgs e)
        {
            ShellRibbonPresenter.OnModule2Click();
        }

        public void OnModule3Click(object sender, EventArgs e)
        {
            ShellRibbonPresenter.OnModule3Click();
        }

        public void OnModule4Click(object sender, EventArgs e)
        {
            ShellRibbonPresenter.OnModule4Click();
        }
        #endregion

        private void tileModule1_Click(object sender, EventArgs e)
        {
            ShellRibbonPresenter.OnModule1Click(sender, e);
        }
    }
}
