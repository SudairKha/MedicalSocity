using MongoDB.Driver;
using Entities;

using System.Collections.Generic;

namespace DAL
{
    public class LeadershipDAL
    {
        private readonly IMongoCollection<Leadership> _collection;

        public LeadershipDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<Leadership>("Leadership");
        }

        public List<Leadership> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        public void Add(Leadership obj)
        {
            _collection.InsertOne(obj);
        }

        public void Update(Leadership obj)
        {
            _collection.ReplaceOne(x => x.Id == obj.Id, obj);
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }
    }
}