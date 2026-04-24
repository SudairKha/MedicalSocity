using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    public class PastPresident
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string PresidentName { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Services { get; set; }
    }
}