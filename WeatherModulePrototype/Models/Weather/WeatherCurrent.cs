using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherModulePrototype.Models.Weather
{
    class WeatherCurrent
    {
        public double Temperature { get; set; }
        public double HighTemperature { get; set; }
        public double LowTemperature { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string WeatherType { get; set; }
        public string IconId { get; set; }
        public DateTime Date { get; set; } 
        public DateTime ReadTime { get; set; }

        public WeatherCurrent(DateTime readTime)
        {
            ReadTime = readTime;
        }

        public WeatherCurrent(int temp, int high, int low, string city, string state, 
            string country, string weather, string icon, DateTime date, DateTime readTime)
        {
            Temperature = temp;
            HighTemperature = high;
            LowTemperature = low;
            City = city;
            State = state;
            Country = country;
            WeatherType = weather;
            IconId = icon;
            Date = date;
            ReadTime = readTime;
        }
    }
}
