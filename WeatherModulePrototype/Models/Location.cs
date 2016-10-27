using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherModulePrototype.Models
{
    class Location
    {
        public string City { get; }
        public string State { get; }
        public string Country { get; }
        public string ZipCode { get; }

        public Location(string city, string state, string country, string zip)
        {
            City = city;
            State = state;
            Country = country;
            ZipCode = zip;
        }
    }
}
