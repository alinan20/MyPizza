
namespace MyPizza.Models
{
    public class Pizza : Product
    {
        public string Ingredients { get; set; }
        public static Pizza CreateObjectFromCsvLine(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Pizza pizza = new Pizza();
            pizza.Id = Convert.ToInt32(values[0]);
            pizza.Name = values[1];
            pizza.Description = values[2];
            pizza.Price = Convert.ToDouble(values[3]);
            pizza.ImageUrl = values[4];
            pizza.Ingredients = values[5];
            pizza.Subtotal = pizza.Price;
            return pizza;
        }

    }
}
