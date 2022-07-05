using System;
using System.Collections.Generic;
using System.Text;

namespace MyHelsinki
{


    public class StationList
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public bool passengerTraffic { get; set; }
        public string type { get; set; }
        public string stationName { get; set; }
        public string stationShortCode { get; set; }
        public int stationUICCode { get; set; }
        public string countryCode { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
    }


}
