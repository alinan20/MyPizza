namespace MyPizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double Subtotal { get; set; }
        
    }
}
