using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableMapView
{
    public class ArableMapViewPresenter
    {
        #region Properties and Fields
        public IArableMapView View { get; set; }
        public List<PointLatLng> CurrentFieldPoints { get; set; }

        //--- UI Map Markers
        public GMapOverlay Polygons { get; set; }
        public GMapOverlay PushPins { get; set; }
        #endregion

        #region Constructor 

        public ArableMapViewPresenter(IArableMapView view)
        {
            View = view;
            PushPins = new GMap.NET.WindowsForms.GMapOverlay("markers");
            Polygons = new GMap.NET.WindowsForms.GMapOverlay("polygons");
            View.MapControl.Overlays.Add(PushPins);
            View.MapControl.Overlays.Add(Polygons);
        }

        #endregion

        #region Methods
        public void MapFieldBoundaries( double lat, double lng)
        {
            //--- Check if this is the First point of a new Area
            if (View.CreateIsNewField)
            {
                CurrentFieldPoints = new List<PointLatLng>();
                View.CreateIsNewField = false;
                
            }
            CurrentFieldPoints.Add(new PointLatLng(lat, lng));

            var closedList = CurrentFieldPoints;
            closedList.Add(new PointLatLng(CurrentFieldPoints[0].Lat, CurrentFieldPoints[0].Lng));

            var polygon = new GMapPolygon(closedList, "New Field");
            Polygons.Polygons.Add(polygon);
            closedList.RemoveAt(closedList.Count-1);

            var pnt = new GMap.NET.PointLatLng(lat, lng);
            var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(pnt,GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_dot);
            PushPins.Markers.Add(marker);

            var grid = View.CurrentWorkspace.CurrentDefineView.GridLatLongPoints;
            grid.Rows.Add(grid.RowCount + 1, lat, lng);
            //polygons.Polygons.Add(polygon);
            //gmap.Overlays.Add(polygons);
        }
        #endregion

        #region Events
        public void OnMapClick(object sender, EventArgs e, double lat, double lng)
        {
            if (View.IsCreateMode)
            {
                MapFieldBoundaries(lat, lng);
            }
            else
            {

            }
        }
        #endregion


    }
}
