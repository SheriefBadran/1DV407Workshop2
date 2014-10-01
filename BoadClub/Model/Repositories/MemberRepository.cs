using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BoatClub.Model.Repositories
{
    class MemberRepository: Repository
    {
        const string collectionName = "memberRegister";

        public void Add(Member member) 
        {
            _db.GetCollection(collectionName).Insert(new BsonDocument(member.ToJson()));
        }

        public IEnumerable<Member> GetAll()
        {
            List<Member> members = new List<Member>();

            foreach (var memberBson in _db.GetCollection(collectionName).FindAll())
            {
                // Parse JSON to object and then cast object to IDictionary.
                var jsonObject = (JObject)JsonConvert.DeserializeObject(memberBson.ToJson());
                members.Add(new Member(jsonObject));
            }

            return members;
        }
    }
}
