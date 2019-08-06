using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheuchan.Sheuchan.Constants
{
    internal static class ShConstants
    {
        #region UI Visual Styles and Appearances constants

        //--------- Colour Styles for Tiles and Controls for each of the Modules
        internal static MetroFramework.MetroColorStyle _modColour1 = MetroFramework.MetroColorStyle.Green;
        internal static MetroFramework.MetroColorStyle _modColour2 = MetroFramework.MetroColorStyle.Blue;
        internal static MetroFramework.MetroColorStyle _modColour3 = MetroFramework.MetroColorStyle.Lime;
        internal static MetroFramework.MetroColorStyle _modColour4 = MetroFramework.MetroColorStyle.Orange;

        #endregion

        #region String constants for captions and labelling 

        //--------- Application specific labels
        internal static string _applicationName = "Sheuchan";

        //--------- String Labels for each of the Modules
        internal static string _module1Name = "Arable";
        internal static string _module2Name = "Livestock";
        internal static string _module3Name = "Estate";
        internal static string _module4Name = "Contacts";

        //--------- UserControl Names
        internal static string WorkspaceArable = "ArableWorkspace";

        //--------- Workspace Panel Names

        internal static string WksPanelArableMain = "pnlArableMain";
        internal static string WksPanelArableMap = "pnlArableMap";

        #endregion

    }
}
