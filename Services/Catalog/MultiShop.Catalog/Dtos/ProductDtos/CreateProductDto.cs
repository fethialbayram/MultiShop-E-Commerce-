namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string? productName { get; set; }
        public decimal productPrice { get; set; }
        public int productStock { get; set; }
        public string? productImageUrl { get; set; }
        public string? productDescription { get; set; }
        public string? categoryId { get; set; }

    }
}
