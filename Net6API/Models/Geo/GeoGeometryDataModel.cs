namespace Net6API.Models.Geo
{
    public class GeoGeometryDataModel
    {
        public GeoBoundsViewportDataModel Bounds { get; set; }
        public GeoLatLngDataModel Locations { get; set; }
        public string Location_Type { get; set; }
        public GeoBoundsViewportDataModel Viewport { get; set; }
    }
}
