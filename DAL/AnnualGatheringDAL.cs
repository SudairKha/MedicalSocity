using MongoDB.Driver;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class AnnualGatheringDAL
    {
        private readonly IMongoCollection<AnnualGathering> _collection;

        public AnnualGatheringDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<AnnualGathering>("AnnualGathering");
        }

        // GET ALL
        public List<AnnualGathering> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        // ADD
        public void Add(AnnualGathering a)
        {
            // IMPORTANT: let MongoDB generate ObjectId
            a.Id = null;
            _collection.InsertOne(a);
        }

        // UPDATE
        public void Update(AnnualGathering a)
        {
            if (string.IsNullOrEmpty(a.Id))
                return;

            _collection.ReplaceOne(x => x.Id == a.Id, a);
        }

        // DELETE
        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return;

            _collection.DeleteOne(x => x.Id == id);
        }
    }
}