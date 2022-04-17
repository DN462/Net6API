namespace Net6API.Models.Geo
{
    public class GeoCoordinatesResultsDataModel
    {
        public GeoAddressComponentsDataModel Address_Components { get; set; }
        public string Formatted_Address { get; set; }
        public GeoGeometryDataModel Geometry { get; set; }
        public string Place_ID { get; set; }
        public string[] Types { get; set; }
    }
}
