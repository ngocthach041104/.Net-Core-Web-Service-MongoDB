using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SampleAPI.Models;
namespace SampleAPI.Models
{
    public class Book
    {
        [BsonId] //primary key
        [BsonRepresentation(BsonType.ObjectId)] //passing paran as string 
        public string? Id { get; set; }
        [BsonElement("Name")]
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
