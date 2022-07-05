using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APIHelpers;
using MyHelsinkiActivities;

namespace MyHelsinki
{
    public static class EventApi
    {
        const string url = "http://open-api.myhelsinki.fi/v1/places/";

        public static async Task<Event> GetEvents()
        {
            string urlParams = "?limit=5";

            var response = await ApiHelper.RunAsync<Event> (url, urlParams);
            return response;
        }

        public static async Task<Activities> GetActivies()
        {
            string urlParams = "";

            var response = await ApiHelper.RunAsync<Activities>(url, urlParams);
            return response;
        }
    }

    public static class TrainApi
    {
        const string url = "https://rata.digitraffic.fi/api/v1/metadata/stations";

        public static async Task<StationList> GetStations()
        {
            string urlParams = "";

            var response = await ApiHelper.RunAsync<StationList>(url, urlParams);
            return response;
        }
    }
}
