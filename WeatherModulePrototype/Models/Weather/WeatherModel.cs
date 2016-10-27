﻿using System.Diagnostics;

namespace WeatherModulePrototype.Models.Weather
{
    class WeatherModel
    {
        public WeatherCurrent CurrentWeather { get; set; }
        public WeatherDay TodaysWeather { get; set; }
        public WeatherDay TomorrowsWeather { get; set; }
        public WeatherWeek WeeksWeather { get; set; }

        public void InitWeather()
        {
            //When we initialize the weather, we will always start with the default location
            Location defaultLocation = LocationService.GetDefaultLocation();
            //Perform an initial Update on all the weather types using the default Location
            UpdateCurrentWeather(defaultLocation);
            UpdateTodaysWeather(defaultLocation);
            UpdateTomorrowsWeather(defaultLocation);
            UpdateWeeksWeather(defaultLocation);            
        }

        public void HandleVoiceCommand(string command, string timeFrame, string city)
        {
            Location location;
            if (city.Length != 0)
            {
                location = LocationService.GetLocationFromCity(city);
            }
            else
            {
                location = LocationService.GetDefaultLocation();
            }
            if (WeatherCommands.CMD_SHOW.Equals(command))
            {
                Debug.Write("Show ");
                switch (timeFrame)
                {
                    case WeatherCommands.TIME_TODAY:
                        WeatherCurrent weather = WeatherService.FetchCurrentWeather(location);                    
                        break;
                    case WeatherCommands.TIME_TOMORROW:
                        Debug.WriteLine("TIME_TOMORROW: " + timeFrame);
                        break;
                    case WeatherCommands.TIME_WEEK:
                        Debug.WriteLine("TIME_WEEK: " + timeFrame);
                        break;
                }
            }
            else if (WeatherCommands.CMD_HIDE.Equals(command))
            {
                Debug.Write("Hide ");
                switch (timeFrame)
                {
                    case WeatherCommands.TIME_TODAY:
                        Debug.WriteLine("TIME_TODAY: " + timeFrame);
                        break;
                    case WeatherCommands.TIME_TOMORROW:
                        Debug.WriteLine("TIME_TOMORROW: " + timeFrame);
                        break;
                    case WeatherCommands.TIME_WEEK:
                        Debug.WriteLine("TIME_WEEK: " + timeFrame);
                        break;
                }
            }
        }

        private void UpdateCurrentWeather(Location location)
        {
            CurrentWeather = WeatherService.FetchCurrentWeather(location);
        }

        private void UpdateTodaysWeather(Location location)
        {
            TodaysWeather = WeatherService.FetchTodaysWether(location);
        }

        private void UpdateTomorrowsWeather(Location location)
        {
            TomorrowsWeather = WeatherService.FetchTomorrowsWeather(location);
        }

        private void UpdateWeeksWeather(Location location)
        {
            WeeksWeather = WeatherService.FetchWeeksWeather(location);
        }

        private void InitCurrentWeather()
        {

        }

        private void InitTodaysWeather()
        {

        }

        private void InitTomorrowsWeather()
        {

        }

        private void InitWeeksWeather()
        {

        }

    }



}
