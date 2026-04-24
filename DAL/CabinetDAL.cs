using MongoDB.Driver;
using Entities;
using Microsoft.Extensions.Configuration;

using System.Collections.Generic;

namespace DAL
{
    public class CabinetDAL
    {
        private readonly IMongoCollection<Cabinet> _collection;

        public CabinetDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<Cabinet>("Cabinet");
        }

        public List<Cabinet> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        public void Add(Cabinet c)
        {
            _collection.InsertOne(c);
        }

        public void Update(Cabinet c)
        {
            _collection.ReplaceOne(x => x.Id == c.Id, c);
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }
    }
}