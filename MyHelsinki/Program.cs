using MyHelsinkiActivities;
using System;
using System.Threading.Tasks;

namespace MyHelsinki
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Event eventList = await EventApi.GetEvents();

            //foreach( Datum d in eventList.data)
            //{
            //    Console.WriteLine(d.name.fi);
            //}


            //Activities activityLIst = await EventApi.GetActivies();

            //foreach (Row row in activityLIst.rows)
            //{
            //    Console.WriteLine(row.descriptions.en.description);
            //}


            StationList stationList = await TrainApi.GetStations();

            //foreach (Station station in stationList)
            //{
            //    Console.WriteLine(station.stationName);
            //}


            Console.WriteLine("\n press any key to exit");
            Console.ReadKey(true);
        }
    }
}
