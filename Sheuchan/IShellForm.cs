using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace Sheuchan
{
    public interface IShellForm
    {
        #region Properties 

        IShellFormPresenter Presenter { get; set; }
        MetroPanel RibbonZone { get; set; }
        MetroPanel MainZone { get; set; }

        #endregion

        #region Methods
        void OnStartup();
        #endregion


    }
}
