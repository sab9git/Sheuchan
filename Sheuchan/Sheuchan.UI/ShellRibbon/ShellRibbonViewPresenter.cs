using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sheuchan.Sheuchan.Constants;
using Sheuchan.Sheuchan.UI.ArableModule;
using Sheuchan.Sheuchan.HelperClasses;
using System.Windows.Forms;

namespace Sheuchan.Sheuchan.UI.ShellRibbon
{
    class ShellRibbonViewPresenter : IShellRibbonViewPresenter
    {
        #region Properties

        public IShellRibbonView View { get; set; }
        #endregion


        public ShellRibbonViewPresenter(IShellRibbonView view)
        {
            View = view;
        }

        #region Events

        //==== Instantiates and Injects the Arable Module into the Main workspace
        public void OnModule1Click(object sender, EventArgs e)
        {
           if (!View.MainShellForm.InitialisedWorkspaces.Contains(ShConstants.WorkspaceArable))
            {

                var newArableWorkspace = new ArableWorkspace();
                ControlInjector.InjectIntoZone(newArableWorkspace, View.MainShellForm.MainZone);
                View.MainShellForm.InitialisedWorkspaces.Add(ShConstants.WorkspaceArable);
                View.MainShellForm.Modules.Add(newArableWorkspace);
            }
        }

        public void OnModule2Click()
        {
        }
        public void OnModule3Click()
        {
        }
        public void OnModule4Click()
        {

        }

        #endregion

    }
}
