using MongoDB.Driver;

namespace DAL
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _db;

        public MongoDBContext()
        {
            var client = new MongoClient("mongodb+srv://sudairalam611_db_user:sudair123@cluster0.hac0dqq.mongodb.net");
            _db = client.GetDatabase("MedicalSocietyDB");
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _db.GetCollection<T>(name);
        }
    }
}