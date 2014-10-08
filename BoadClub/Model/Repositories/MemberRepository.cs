using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MongoDB.Driver;

namespace BoatClub.Model.Repositories
{
    class MemberRepository: Repository
    {
        const string collectionName = "memberRegister";

        public void Save(Member member, Member updatedMember) 
        {
            var option = new MongoUpdateOptions().Flags = UpdateFlags.Upsert; 
            _db.GetCollection(collectionName).Update(new QueryDocument(member.ToJson()), new UpdateDocument(updatedMember.ToJson()), option);
        }

        public IEnumerable<Member> GetAll()
        {
            List<Member> members = new List<Member>();

            foreach (var memberBson in _db.GetCollection(collectionName).FindAll())
            {
                // Parse JSON to object and then cast object to IDictionary.
                var jsonObject = (JObject)JsonConvert.DeserializeObject(memberBson.ToJson(jsonSettings));
                members.Add(new Member(jsonObject));
            }

            return members;
        }
    }
}
