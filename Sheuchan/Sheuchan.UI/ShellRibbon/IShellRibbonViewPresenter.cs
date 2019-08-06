using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheuchan.Sheuchan.UI.ShellRibbon
{
    public interface IShellRibbonViewPresenter
    {

        #region Properties
        IShellRibbonView View { get; set; }
        #endregion

        #region Methods 
        void OnModule1Click(object sender, EventArgs e);
        void OnModule2Click();
        void OnModule3Click();
        void OnModule4Click();
        #endregion

    }
}
