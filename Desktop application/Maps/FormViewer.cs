using CSMaps.Main;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace CSMaps.Maps;

public partial class FormViewer : Form
{
    private const double ZoomInitial = 17;

    public FormViewer(decimal latitude, decimal longitude)
    {
        const string ServerAddress = "google.com";

        InitializeComponent();

        // set cache mode only if no internet available
        if (!CardonerSistemas.Framework.Base.Network.Ping(ServerAddress))
        {
            GMapControlMain.Manager.Mode = AccessMode.CacheOnly;
            MessageBox.Show("No hay conexión a internet. Se utilizará en modo sólo caché.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //----------------------------------------
        // Config Map at Startup
        //----------------------------------------
        GMapControlMain.MinZoom = 0;
        GMapControlMain.MaxZoom = 24;
        GMapControlMain.Zoom = ZoomInitial;
        GMapControlMain.MapProvider = GMapProviders.GoogleSatelliteMap;
        GoogleMapProvider.Instance.ApiKey = Constants.GoogleMapsApiKey;
        PointLatLng pointLatLng = new((double)latitude, (double)longitude);
        GMapControlMain.Position = pointLatLng;
        AddMarker(pointLatLng);
    }

    private void AddMarker(PointLatLng pointLatLng)
    {
        GMarkerGoogle gMarkerGoogle = new(pointLatLng, GMarkerGoogleType.green);
        GMapOverlay gMapOverlay = new("markers");
        gMapOverlay.Markers.Add(gMarkerGoogle);
        GMapControlMain.Overlays.Add(gMapOverlay);
    }

    private void ButtonZoomIn_Click(object sender, EventArgs e)
    {
        GMapControlMain.Zoom += 1;
    }

    private void ButtonZoomOut_Click(object sender, EventArgs e)
    {
        GMapControlMain.Zoom -= 1;
    }

    private void ButtonZoomRestore_Click(object sender, EventArgs e)
    {
        GMapControlMain.ZoomAndCenterMarkers("markers");
        GMapControlMain.Zoom = ZoomInitial;
    }

    private void FormViewer_FormClosed(object sender, FormClosedEventArgs e)
    {
        GMapControlMain.Dispose();
        GMapControlMain = null;
        this.Dispose();
    }
}