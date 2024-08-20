using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string? productName { get; set; }
        public decimal productPrice { get; set; }
        public int productStock { get; set; }
        public string? productImageUrl { get; set; }
        public string? productDescription { get; set; }
        public string? categoryId { get; set; }

        // [BsonIgnore] tells MongoDB not to keep this value in the database

        [BsonIgnore] 
        public Category? category { get; set; }
    }
}
