using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    struct Member
    {
        private const string name = "name";
        private const string memberNumber = "memberNumber";
        private const string socialSecurityNumber = "socialSecurityNumber";
        private const string boats = "boats";

        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }
        public long MemberNumber { get; set; }
        public List<Boat> Boats { get; set; }

        public Member(string name, string socialSecurityNumber, long memberNumber)
            : this()
        {
            Name = name;
            SocialSecurityNumber = socialSecurityNumber;
            MemberNumber = memberNumber;
            Boats = new List<Boat>();
        }

        public Member(JObject memberJson)
            : this()
        {
            Boats = memberJson.GetValue(boats).ToList().ConvertAll(JsonBoat => new Boat((JObject) JsonBoat));
            Name = memberJson[name].ToString();
            MemberNumber = (long)memberJson[memberNumber];
            SocialSecurityNumber = memberJson[socialSecurityNumber].ToString();

        }

        public IDictionary ToJson()
        {
            return new Dictionary<string, object> {
                {name, Name},
                {socialSecurityNumber, SocialSecurityNumber},
                {memberNumber, MemberNumber},
                {boats, Boats.ConvertAll(boat => boat.ToJson())}
            };
        }

        public JObject JsonBoat { get; set; }
    }
}
