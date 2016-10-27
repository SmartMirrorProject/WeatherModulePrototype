using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace WeatherModulePrototype.Models
{
    class LocationService
    {
        //TODO I don't want this class static, inject it as a singleton or something

        //TODO find a way to pull all the location information from a city, some API or something
        //for now we will just always use Orlando Florida
        public static Location GetLocationFromCity(string city)
        {
            Location location = new Location("Orlando", "Florida", "United States", "32817");
            return location;
        }

        //TODO implement this as a member field on the singleton class that can be accessed
        //and potentially mutated.
        public static Location GetDefaultLocation()
        {
            Location location = new Location("Orlando", "Florida", "United States", "32817");
            return location;
        }
    }
}
