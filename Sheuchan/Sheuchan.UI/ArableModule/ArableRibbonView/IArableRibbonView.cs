using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableRibbonView
{
    public interface IArableRibbonView
    {

        #region Properties
        ArableRibbonViewPresenter Presenter { get; set; }
        MetroTile TileDefineField { get; set; }
        MetroTile TileFieldManager { get; set; }
        MetroTile TileCropRotation { get; set; }

        MetroFramework.MetroColorStyle ModuleColour { get; set; }
        ArableWorkspace CurrentWorkspace { get; set; }
        #endregion

        #region Methods 

        #endregion

    }
}
