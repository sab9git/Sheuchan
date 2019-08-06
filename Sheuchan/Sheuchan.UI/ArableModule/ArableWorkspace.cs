using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Sheuchan.Sheuchan.HelperClasses;
using Sheuchan.Sheuchan.UI.ArableModule.ArableMapView;
using Sheuchan.Sheuchan.UI.ArableModule.ArableRibbonView;
using Sheuchan.Sheuchan.UI.ArableModule.ArableDefineFieldView;

namespace Sheuchan.Sheuchan.UI.ArableModule
{
    public partial class ArableWorkspace : UserControl
    {
        #region Panels

        public MetroPanel ArableRibbonZone { get; set; }
        public MetroPanel ArableMainZone { get; set; }
        public MetroPanel ArableMapZone { get; set; }

        public IArableMapView CurrentMapView { get; set; }
        public IArableRibbonView CurrentArableRibbon { get; set; }

        //--- Main Views
        public ArableDefineFieldView.ArableDefineFieldView CurrentDefineView { get; set; }


        public UserControl CurrentMainView { get; set; }

        #endregion

        public ArableWorkspace()
        {
            InitializeComponent();
            ArableRibbonZone = pnlArableRibbon;
            ArableMainZone = pnlArableMain;
            ArableMapZone = pnlArableMap;

            //--- Instantiate the Ribbon
            CurrentArableRibbon = new ArableRibbonView.ArableRibbonView(this);
            ControlInjector.InjectIntoZone((UserControl)CurrentArableRibbon, ArableRibbonZone);

            //--- Instantiate the Map View
            CurrentMapView = new ArableMapView.ArableMapView(this);
            ControlInjector.InjectIntoZone((UserControl)CurrentMapView, ArableMapZone);
        }
    }
}
