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
    class Member : ICloneable
    {
        private string _name;
        private string _socialSecurityNumber;

        private const string name = "name";
        private const string memberNumber = "memberNumber";
        private const string socialSecurityNumber = "socialSecurityNumber";
        private const string boats = "boats";

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Member name can not be empty."); 
                }

                _name = value;
            }
        }

        public string SocialSecurityNumber 
        {
            get
            {
                return _socialSecurityNumber;
            }

            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Social security number can not be empty.");
                }

                _socialSecurityNumber = value;
            } 
        }

        public long MemberNumber { get; set; }
        public List<Boat> Boats { get; set; }

        public Member()
        {
            MemberNumber = DateTime.UtcNow.ToFileTime();
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

        public object Clone()
        {

            return this.MemberwiseClone();
        }
    }
}
