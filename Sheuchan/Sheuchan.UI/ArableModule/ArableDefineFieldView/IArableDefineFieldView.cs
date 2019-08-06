using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using MetroFramework.Controls;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableDefineFieldView
{
    public interface IArableDefineFieldView
    {

        #region Properties
        ArableDefineFieldViewPresenter Presenter { get; set; }
        UserControl CurrentWorkspace { get; set; }
        GMapControl CurrentMapControl { get; set; }

        //---- Field Information Controls

        #endregion

        #region Methods

        #endregion

    }
}
