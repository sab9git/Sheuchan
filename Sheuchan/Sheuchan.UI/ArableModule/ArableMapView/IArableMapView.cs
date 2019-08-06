using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Windows.Forms;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableMapView
{
    public interface IArableMapView
    {

        #region Properties and Fields
        GMapControl MapControl { get; set; }
        ArableMapViewPresenter Presenter { get; set; }
        ArableWorkspace CurrentWorkspace { get; set; }

        bool IsCreateMode { get; set; }
        bool CreateIsNewField { get; set; }
        #endregion

        #region Methods
        void InitialiseMap();
        #endregion

    }
}
