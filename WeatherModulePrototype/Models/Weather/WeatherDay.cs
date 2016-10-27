using System;
using System.Collections.Generic;

namespace WeatherModulePrototype.Models.Weather
{
    class WeatherDay
    {
        public List<BasicWeather> WeatherDays { get; }
        public Location WeatherLocation { get; set; }
        public string Date { get; set; }
        public DateTime TimeRead { get; }

        public WeatherDay(DateTime dateRead)
        {
            WeatherDays = new List<BasicWeather>();
            TimeRead = dateRead;
        }
    }

    //A Basic Weather object to represent hour increments of a day    
    class BasicWeather
    {
        public double HighTemperature { get; set; }
        public double LowTemperature { get; set; }
        public string IconId { get; set; }
        public string WeatherType { get; set; }
        public string Time { get; set; }

        public BasicWeather()
        {
        }

        public BasicWeather(double high, double low, string weather, string icon)
        {
            HighTemperature = high;
            LowTemperature = low;
            WeatherType = weather;
            IconId = icon;
        }
    }
}
