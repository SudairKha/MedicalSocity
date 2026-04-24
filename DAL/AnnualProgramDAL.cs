using MongoDB.Driver;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class AnnualProgramDAL
    {
        private readonly IMongoCollection<AnnualProgram> _collection;

        public AnnualProgramDAL()
        {
            var db = new MongoDBContext();
            _collection = db.GetCollection<AnnualProgram>("AnnualProgram");
        }

        // GET ALL
        public List<AnnualProgram> GetAll()
        {
            return _collection.Find(_ => true).ToList();
        }

        // ADD
        public void Add(AnnualProgram p)
        {
            _collection.InsertOne(p);
        }

        // UPDATE
        public void Update(AnnualProgram p)
        {
            _collection.ReplaceOne(x => x.Id == p.Id, p);
        }

        // DELETE
        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }
    }
}