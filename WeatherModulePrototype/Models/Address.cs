using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherModulePrototype.Models.Weather;

namespace WeatherModulePrototype.Models
{
    class Address : Location
    {
        public string StreetAddress1 { get; }
        public string StreetAddress2 { get; }

        public Address(string add1, string add2, string city, string state, string country, string zip) : base(city, state, country, zip)
        {
            StreetAddress1 = add1;
            StreetAddress2 = add2;
        }
    }
}
