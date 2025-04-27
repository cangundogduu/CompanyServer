namespace Company.API.DTOs
{
    public class ProductDto
    {
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}
