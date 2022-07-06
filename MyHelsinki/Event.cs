
using System;

namespace MyHelsinki
{


    public class EventList
    {
        public Meta meta { get; set; }
        public Event[] data { get; set; }
        public Tags tags { get; set; }
    }

    public class Meta
    {
        public string count { get; set; }
    }

    public class Tags
    {
        public string linkedeventshelmet1 { get; set; }
        public string linkedeventshelmet10592 { get; set; }
        public string linkedeventshelmet10593 { get; set; }
        public string linkedeventshelmet10594 { get; set; }
        public string linkedeventshelmet10595 { get; set; }
        public string linkedeventshelmet10654 { get; set; }
        public string linkedeventshelmet10655 { get; set; }
        public string linkedeventshelmet10659 { get; set; }
        public string linkedeventshelmet10670 { get; set; }
        public string linkedeventshelmet10672 { get; set; }
        public string linkedeventshelmet10673 { get; set; }
        public string linkedeventshelmet10674 { get; set; }
        public string linkedeventshelmet10675 { get; set; }
        public string linkedeventshelmet10676 { get; set; }
        public string linkedeventshelmet10677 { get; set; }
        public string linkedeventshelmet10689 { get; set; }
        public string linkedeventshelmet10690 { get; set; }
        public string linkedeventshelmet10691 { get; set; }
        public string linkedeventshelmet10737 { get; set; }
        public string linkedeventshelmet10795 { get; set; }
        public string linkedeventshelmet10801 { get; set; }
        public string linkedeventshelmet10823 { get; set; }
        public string linkedeventshelmet10840 { get; set; }
        public string linkedeventshelmet10851 { get; set; }
        public string linkedeventshelmet11193 { get; set; }
        public string linkedeventshelmet11274 { get; set; }
        public string linkedeventshelmet11347 { get; set; }
        public string linkedeventshelmet11351 { get; set; }
        public string linkedeventshelmet11686 { get; set; }
        public string linkedeventshelmet11687 { get; set; }
        public string linkedeventshelmet11689 { get; set; }
        public string linkedeventshelmet11699 { get; set; }
        public string linkedeventshelmet11767 { get; set; }
        public string linkedeventshelmet11777 { get; set; }
        public string linkedeventshelmet11893 { get; set; }
        public string linkedeventshelmet11916 { get; set; }
        public string linkedeventshelmet11932 { get; set; }
        public string linkedeventshelmet11996 { get; set; }
        public string linkedeventshelmet12005 { get; set; }
        public string linkedeventshelmet12006 { get; set; }
        public string linkedeventsysop11617 { get; set; }
        public string linkedeventsysop1178 { get; set; }
        public string linkedeventsysop13050 { get; set; }
        public string linkedeventsysop14710 { get; set; }
        public string linkedeventsysop16485 { get; set; }
        public string linkedeventsysop16486 { get; set; }
        public string linkedeventsysop1808 { get; set; }
        public string linkedeventsysop2149 { get; set; }
        public string linkedeventsysop2433 { get; set; }
        public string linkedeventsysop26626 { get; set; }
        public string linkedeventsysop2787 { get; set; }
        public string linkedeventsysop4354 { get; set; }
        public string linkedeventsysop556 { get; set; }
        public string linkedeventsysop6062 { get; set; }
        public string linkedeventsysop6165 { get; set; }
        public string linkedeventsysop7642 { get; set; }
        public string linkedeventsysop8113 { get; set; }
        public string linkedeventsysop916 { get; set; }
        public string linkedeventsysop9270 { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public Name name { get; set; }
        public Source_Type source_type { get; set; }
        public string info_url { get; set; }
        public DateTime modified_at { get; set; }
        public Location location { get; set; }
        public Description description { get; set; }
        public Tag[] tags { get; set; }
        public Event_Dates event_dates { get; set; }
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
        public string intro { get; set; }
        public string body { get; set; }
        public Image[] images { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public string copyright_holder { get; set; }
        public License_Type license_type { get; set; }
        public object media_id { get; set; }
    }

    public class License_Type
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Event_Dates
    {
        public DateTime starting_day { get; set; }
        public DateTime ending_day { get; set; }
        public object additional_description { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string name { get; set; }
    }


}