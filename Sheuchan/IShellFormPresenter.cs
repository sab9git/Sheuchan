using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace Sheuchan
{
    public interface IShellFormPresenter
    {

        #region Properties
        IShellForm ShellView { get; set; }
        MetroPanel ZoneRibbon { get; set; }
        MetroPanel ZoneMain { get; set; }
        #endregion

        #region Methods

        #endregion

    }
}
