using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    struct Boat
    {
        private const string length = "length";
        private const string type = "type";

        public double Length { get; set; }
        public BoatType Type { get; set; }

        public Boat(double length, BoatType boatType) 
            : this()
        {
            Length = length;
            Type = boatType;
        }

        public Boat(JObject boatJson)
            : this()
        {
            Length = (double)boatJson.GetValue(length);
            Type = (BoatType)(int)boatJson.GetValue(type);
        }

        public IDictionary ToJson()
        {
            var document = new Dictionary<string, object> {
                {length, Length},
                {type, Type}
            };

            return document;
        }
    }
}
