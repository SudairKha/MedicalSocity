using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Entities
{
    public class SocietyInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string SocietyName { get; set; }
        public string Vision { get; set; }
        public string Aims { get; set; }
        public string Message { get; set; }
    }
}