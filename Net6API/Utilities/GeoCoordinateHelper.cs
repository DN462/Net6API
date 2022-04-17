using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Net6API.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using Net6API.Models.Geo;

namespace Net6API.Utilities
{
    /*
     * I architected this to get Geo Coordinates based off of the Google Maps API. It calls out using the CallAPI system
     * that was injected as a Dependency Injection.
     */
    public class GeoCoordinateHelper : IGeoCoordinateHelper
    {
        private readonly IConfiguration _config;
        private readonly ICallApi _api;
        public GeoCoordinateHelper(IConfiguration config, ICallApi api)
        {
            _api = api;
            _config = config;
        }
        private async Task<Dictionary<double, double>> GettingGeocoordinates(string StreetAddress)
        {
            Dictionary<double, double> geoCoordinates = new();
            string Url = $"https://maps.googleapis.com/maps/api/geocode/json?address={StreetAddress}&key={_config.GetValue<string>("MapsApiKey")}";
            RestResponse response = await _api.ApiCall(Url, Method.Get);
            if (response.StatusCode == HttpStatusCode.OK && response.Content != null)
            {
                var geoData = JsonConvert.DeserializeObject<GeoCoordinatesDataModel>(response.Content);
                if (geoData != null)
                {
                    geoCoordinates.Add(geoData.Results.Geometry.Locations.lat, geoData.Results.Geometry.Locations.lng);
                }
            }
            return geoCoordinates;
        }
        public async Task<Dictionary<double, double>> GetGeoCoordinates(string StreetAddress)
        {
            return await GettingGeocoordinates(StreetAddress);
        }
    }
}
