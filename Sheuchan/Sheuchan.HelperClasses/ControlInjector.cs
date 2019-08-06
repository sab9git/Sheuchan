using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace Sheuchan.Sheuchan.HelperClasses
{
    public static class ControlInjector
    {
        // This class defines an Injector used to inject UserControls into Panels.
        // Loosely based on the CAB / SCSF approach of injecting SmartParts into 
        // Workspaces, I have not taken that full approach in favour of having something
        // a bit easier to understand

        public static void InjectIntoZone(UserControl ctrl, MetroPanel zone)
        {
            // Hide any controls currently sitting in the "zone" (panel)
            //foreach (var cont in zone.Controls)
            //{
            //    zone.Controls.Remove((Control)cont);
            //}

            zone.Controls.Clear();
            zone.Controls.Add(ctrl);
            ctrl.Show();
            ctrl.Dock = DockStyle.Fill;
        }


    }
}
