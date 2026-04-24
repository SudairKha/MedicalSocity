using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    public class Cabinet
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
    }
}