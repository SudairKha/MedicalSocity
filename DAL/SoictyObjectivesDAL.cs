using MongoDB.Driver;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class SocietyObjectivesDAL
    {
        private readonly IMongoCollection<SocietyObjectives> _collection;

        public SocietyObjectivesDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<SocietyObjectives>("SocietyObjectives");
        }

        // GET ALL
        public List<SocietyObjectives> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        // ADD
        public void Add(SocietyObjectives obj)
        {
            _collection.InsertOne(obj);
        }

        // UPDATE
        public void Update(SocietyObjectives obj)
        {
            _collection.ReplaceOne(x => x.Id == obj.Id, obj);
        }

        // DELETE
        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }

        // GET BY ID
        public SocietyObjectives GetById(string id)
        {
            return _collection.Find(x => x.Id == id).FirstOrDefault();
        }
    }
}