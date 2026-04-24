using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    public class SocietyObjectives
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ObjectiveName { get; set; }
        public string Description { get; set; }
    }
}