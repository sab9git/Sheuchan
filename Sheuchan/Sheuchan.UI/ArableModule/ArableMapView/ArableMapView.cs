using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableMapView
{
    public partial class ArableMapView : UserControl, IArableMapView
    {

        #region Properties and Fields

        public GMapControl MapControl { get; set; }
        public ArableMapViewPresenter Presenter { get; set; }
        public ArableWorkspace CurrentWorkspace { get; set; }

        //---- Field Mapping Properties
        public bool IsCreateMode { get; set; }
        public bool CreateIsNewField { get; set; }
        #endregion


        #region Constructor
        public ArableMapView(ArableWorkspace _workspace)
        {
            InitializeComponent();
            IsCreateMode = false; 
            CurrentWorkspace = _workspace;
            MapControl = gmapControl;
            InitialiseMap();
            Presenter = new ArableMapViewPresenter(this);
        }
        #endregion

        #region Events and Methods 

        public void InitialiseMap()
        {
            MapControl.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
            MapControl.Position = new PointLatLng(54.911939, -4.948637);
            MapControl.ShowCenter = false;
            MapControl.Zoom = 15;
            MapControl.DragButton = MouseButtons.Left;
        }
        #endregion

        private void gmapControl_Click(object sender, EventArgs e)
        {
            var ne = (MouseEventArgs)e;
            var lat = MapControl.FromLocalToLatLng(ne.X, ne.Y).Lat;
            var lng = MapControl.FromLocalToLatLng(ne.X, ne.Y).Lng;
            Presenter.OnMapClick(sender, e, lat, lng);
        }
    }
}
