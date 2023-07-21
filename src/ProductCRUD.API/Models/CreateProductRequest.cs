namespace ProductCRUD.API.Models
{
    public class CreateProductRequest
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        // public record CreateProductRequest(string Name, string Description, decimal Price);
    }
}
