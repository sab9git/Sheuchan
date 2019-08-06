using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace Sheuchan.Sheuchan.UI.ShellRibbon
{
    public interface IShellRibbonView
    {
        #region Properties

        MetroTile Module1Tile { get; set; }
        MetroTile Module2Tile { get; set; }
        MetroTile Module3Tile { get; set; }
        MetroTile Module4Tile { get; set; }

        IShellRibbonViewPresenter ShellRibbonPresenter { get; set; }
        ShellForm MainShellForm { get; set; }

        #endregion

        #region Events

        void OnModule1Click(object sender, EventArgs e);
        void OnModule2Click(object sender, EventArgs e);
        void OnModule3Click(object sender, EventArgs e);
        void OnModule4Click(object sender, EventArgs e);

        #endregion

    }
}
