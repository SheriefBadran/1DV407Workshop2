using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.IO;

namespace BoatClub.Model.Repositories
{
    public abstract class Repository
    {
        // Private field
        private static string _connectionString = "mongodb://ooad:ooad@ds063929.mongolab.com:63929/ooadw2";
        protected MongoDatabase _db;
        protected JsonWriterSettings jsonSettings;

        // Methods
        protected Repository()
        {
            var client = new MongoClient(_connectionString);
            _db = client.GetServer().GetDatabase("ooadw2");
            jsonSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict };
        }
    }
}
