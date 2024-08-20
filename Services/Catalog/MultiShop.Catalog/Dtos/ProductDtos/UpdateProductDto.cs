namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string Id { get; set; }
        public string? productName { get; set; }
        public decimal productPrice { get; set; }
        public int productStock { get; set; }
        public string? productImageUrl { get; set; }
        public string? productDescription { get; set; }
        public string? categoryId { get; set; }

    }
}
