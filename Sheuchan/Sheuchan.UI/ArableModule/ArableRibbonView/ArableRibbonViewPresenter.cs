using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sheuchan.Sheuchan.UI.ArableModule.ArableDefineFieldView;
using Sheuchan.Sheuchan.HelperClasses;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableRibbonView
{
    public class ArableRibbonViewPresenter
    {
        #region Properties and Fields
        public IArableRibbonView View { get; set; }

        #endregion

        #region Constructor

        public ArableRibbonViewPresenter(IArableRibbonView view)
        {
            View = view;
        }

        #endregion


        #region Events

        public void OnDefineFieldClick(object sender, EventArgs e)
        {
            if (View.CurrentWorkspace.CurrentDefineView == null)
            {
                var newDefineView = new ArableDefineFieldView.ArableDefineFieldView();
                View.CurrentWorkspace.CurrentDefineView = newDefineView;
            }
            ControlInjector.InjectIntoZone(View.CurrentWorkspace.CurrentDefineView, View.CurrentWorkspace.ArableMainZone);

            View.CurrentWorkspace.CurrentMapView.IsCreateMode = true;
            View.CurrentWorkspace.CurrentMapView.CreateIsNewField = true;
        }

        public void OnFieldManagerClick(object sender, EventArgs e)
        {
            //if (View.CurrentWorkspace.CurrentDefineView == null)
            //{
            //    var newDefineView = new ArableDefineFieldView.ArableDefineFieldView();
            //    View.CurrentWorkspace.CurrentDefineView = newDefineView;
            //}
            //ControlInjector.InjectIntoZone(View.CurrentWorkspace.CurrentDefineView, View.CurrentWorkspace.ArableMainZone);
            var ctrl = new System.Windows.Forms.UserControl();
            ControlInjector.InjectIntoZone(ctrl, View.CurrentWorkspace.ArableMainZone);
        }

        public void OnCropRotationClick(object sender, EventArgs e)
        {
            //if (View.CurrentWorkspace.CurrentDefineView == null)
            //{
            //    var newDefineView = new ArableDefineFieldView.ArableDefineFieldView();
            //    View.CurrentWorkspace.CurrentDefineView = newDefineView;
            //}
            //ControlInjector.InjectIntoZone(View.CurrentWorkspace.CurrentDefineView, View.CurrentWorkspace.ArableMainZone);
            var ctrl = new System.Windows.Forms.UserControl();
            ControlInjector.InjectIntoZone(ctrl, View.CurrentWorkspace.ArableMainZone);
        }

        #endregion
    }
}
