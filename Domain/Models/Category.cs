namespace Supermarket.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IList<Product> Products { get; set; } = new List<Product>();
    }
}
