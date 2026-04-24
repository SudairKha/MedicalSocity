using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    public class Leadership
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Status { get; set; }
        public string ProfilePicture { get; set; }
        public string Experiences { get; set; }
        public string Message { get; set; }
    }
}