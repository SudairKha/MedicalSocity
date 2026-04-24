using MongoDB.Driver;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class SocietyInfoDAL
    {
        private readonly IMongoCollection<SocietyInfo> _collection;

        public SocietyInfoDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<SocietyInfo>("Society_Info");
        }

        // 🔹 GET ALL
        public List<SocietyInfo> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        // 🔹 INSERT
        public void Add(SocietyInfo s)
        {
            _collection.InsertOne(s);
        }

        // 🔹 UPDATE
        public void Update(SocietyInfo s)
        {
            _collection.ReplaceOne(x => x.Id == s.Id, s);
        }

        // 🔹 DELETE
        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }
    }
}