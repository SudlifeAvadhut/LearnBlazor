namespace LearnBlazor.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public bool IsActive { get; set; }
        public double price { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
