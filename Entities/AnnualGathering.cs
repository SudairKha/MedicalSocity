using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    public class AnnualGathering
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Status { get; set; }

        public string PresidentName { get; set; }

        public string Venue { get; set; }

        public DateTime? GatheringDate { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}