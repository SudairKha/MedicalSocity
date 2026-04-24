using MongoDB.Driver;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class PastPresidentDAL
    {
        private readonly IMongoCollection<PastPresident> _collection;

        public PastPresidentDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<PastPresident>("PastPresident");
        }

        // GET ALL
        public List<PastPresident> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        // ADD
        public void Add(PastPresident p)
        {
            _collection.InsertOne(p);
        }

        // UPDATE
        public void Update(PastPresident p)
        {
            _collection.ReplaceOne(x => x.Id == p.Id, p);
        }

        // DELETE (SAFE VERSION)
        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return;

            _collection.DeleteOne(x => x.Id == id);
        }
    }
}