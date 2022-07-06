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
        const string baseUrl = "https://open-api.myhelsinki.fi";


        public static async Task<EventList> GetEvents(int limit, string tag)
        {
            string url = baseUrl + "/v1/events/";

            string urlParams = "";

            if (limit > 0)
            {
                urlParams = "?limit=" + limit + "&tags_search=" + tag;
            }

            var response = await ApiHelper.RunAsync<EventList>(url, urlParams);
            return response;
        }

        public static async Task<Event> GetSingleEvent(string eventId)
        {
            string url = baseUrl + "/v1/event/" + eventId;
            var response = await ApiHelper.RunAsync<Event>(url, "");
            return response;
        }

        public static async Task<ActivityList> GetActivies(int limit)
        {
            string url = baseUrl + "/v2/activities";
            string urlParams = "?limit=" + limit;

            var response = await ApiHelper.RunAsync<ActivityList>(url, urlParams);
            return response;
        }
    }

}
