
using System;

namespace MyHelsinki
{


    public class Event
    {
        public Meta meta { get; set; }
        public Datum[] data { get; set; }
        public Tags tags { get; set; }
    }

    public class Meta
    {
        public string count { get; set; }
        public string next { get; set; }
    }

    public class Tags
    {
        public string matko11 { get; set; }
        public string matko12 { get; set; }
        public string matko1226 { get; set; }
        public string matko19 { get; set; }
        public string matko2104 { get; set; }
        public string matko212 { get; set; }
        public string matko2282 { get; set; }
        public string matko272 { get; set; }
        public string matko2aAliPay { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public Name name { get; set; }
        public Source_Type source_type { get; set; }
        public string info_url { get; set; }
        public DateTime modified_at { get; set; }
        public Location location { get; set; }
        public Description description { get; set; }
        public Tag[] tags { get; set; }
        public Opening_Hours opening_hours { get; set; }
        public object extra_searchwords { get; set; }
    }

    public class Name
    {
        public string fi { get; set; }
        public string en { get; set; }
        public string sv { get; set; }
        public object zh { get; set; }
    }

    public class Source_Type
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Location
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public Address address { get; set; }
    }

    public class Address
    {
        public string street_address { get; set; }
        public string postal_code { get; set; }
        public string locality { get; set; }
        public object neighbourhood { get; set; }
    }

    public class Description
    {
        public object intro { get; set; }
        public string body { get; set; }
        public Image[] images { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public string copyright_holder { get; set; }
        public License_Type license_type { get; set; }
        public string media_id { get; set; }
    }

    public class License_Type
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Opening_Hours
    {
        public Hour[] hours { get; set; }
        public string openinghours_exception { get; set; }
    }

    public class Hour
    {
        public int weekday_id { get; set; }
        public string opens { get; set; }
        public string closes { get; set; }
        public bool open24h { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string name { get; set; }
    }



}