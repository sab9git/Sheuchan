using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace Sheuchan
{
    public class ShellFormPresenter : IShellFormPresenter
    {
        #region Properties and Fields
        public IShellForm ShellView { get; set; }
        public MetroPanel ZoneRibbon { get; set; }
        public MetroPanel ZoneMain { get; set; }
        #endregion

        #region Constructor
        public ShellFormPresenter(IShellForm view)
        {
            ShellView = view;
            ZoneMain = view.MainZone;
            ZoneRibbon = view.RibbonZone;
        }

        #endregion

    }
}
