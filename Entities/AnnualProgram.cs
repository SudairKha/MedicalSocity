using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    public class AnnualProgram
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ProgramName { get; set; }
        public DateTime? ProgramDate { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}