// Example project using MyHelsinki Open API
// https://open-api.myhelsinki.fi/

using System;
using System.Threading.Tasks;
using MyHelsinkiActivities;

namespace MyHelsinki
{
    class Program
    {
        static async Task Main(string[] args)
        {


            // Show first 5 activities

            ActivityList activityLIst = await EventApi.GetActivies(5);

            Console.WriteLine("\n First 5 activies: \n");
            foreach (Activity row in activityLIst.rows)
            {
                Console.WriteLine("  " + row.descriptions.en.name + " - Järjestäjä: " + row.company.name);
            }


            // Show finnish names of first 5 events with tag "Children and families"

            EventList eventList = await EventApi.GetEvents(5, "Children and families");

            Console.WriteLine("\n\n First 5 events for children and families: \n");
            foreach (Event e in eventList.data)
            {
                Console.WriteLine("  " + e.name.fi + " " + e.event_dates.starting_day);
            }


            // Show finnish name of specific event

            Event singleEvent = await EventApi.GetSingleEvent("helmet:234663");

            Console.WriteLine("\n\n Single event: \n");
            Console.WriteLine("  " + singleEvent.name.fi);


            Console.WriteLine("\n\n\n press [q] to exit");
            Console.ReadKey(true);
        }
    }
}
