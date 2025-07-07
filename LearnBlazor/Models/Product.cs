using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Models
{
    public class Product
    {
        public Product()
        {
            AvailableAfter = DateOnly.FromDateTime(DateTime.Now);
        }
        public int productId { get; set; }
        [Required]
        public string productName { get; set; }
        
        public bool IsActive { get; set; }

        [Range(1, 1000)]
        public double price { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }
        public Category Category { get; set; }
        public DateOnly AvailableAfter { get; set; }
    }

    public enum Category
    {
        Entree,
        Appetizer,
        Dessert
    }
}
