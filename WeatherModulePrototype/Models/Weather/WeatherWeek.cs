using System;
using System.Collections.Generic;

namespace WeatherModulePrototype.Models.Weather
{
    class WeatherWeek
    {
        public List<WeatherWeekDay> WeatherDays { get; }
        public Location WeatherLocation { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateTime TimeRead { get; }

        public WeatherWeek()
        {
            WeatherDays = new List<WeatherWeekDay>(5);
            TimeRead = DateTime.Now;
        }

        public WeatherWeek(DateTime dateRead)
        {
            WeatherDays = new List<WeatherWeekDay>(5);
            TimeRead = dateRead;
        }

        //TODO setup constructor with parameters once we know what we need in the service class
        //public WeatherWeek()

        public WeatherWeekDay GetDay(int day)
        {
            if (day >= 5 || day < 0)
            {
                //TODO this should throw something like InvalidArgumentException
                throw new Exception("Day value out of range; " + day + " Value must be 0->4.");
            }
            WeatherWeekDay weatherDay;
            try
            {
                weatherDay = WeatherDays[day];
            }
            catch (Exception e)
            {
                //TODO log the exception occured here before we rethrow exception
                throw e;
            }
            return weatherDay;
        }

        public void InsertDay(int day, int high, int low, string weatherType, string iconID)
        {
            WeatherWeekDay dayOfWeek = new WeatherWeekDay()
            {
                HighTemperature = high,
                LowTemperature = low,
                WeatherType = weatherType,
                IconId = iconID
            };
            WeatherDays[day] = dayOfWeek;
        }

        public void InsertDay(int day, WeatherWeekDay dayOfWeek)
        {
            WeatherDays[day] = dayOfWeek;
        }

        public void AddDay(WeatherWeekDay day)
        {
            WeatherDays.Add(day);
        }
    }

    class WeatherWeekDay
    {
        public double HighTemperature { get; set; }
        public double LowTemperature { get; set; }
        public string IconId { get; set; }
        public string WeatherType { get; set; }
    }
}
