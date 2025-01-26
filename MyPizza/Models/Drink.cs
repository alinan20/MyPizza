namespace MyPizza.Models
{
    public class Drink : Product
    {
        public string BottleCapacity { get; set; }
        public static Drink CreateObjectFromCsvLine(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Drink drink = new Drink();
            drink.Id = Convert.ToInt32(values[0]);
            drink.Name = values[1];
            drink.Description = values[2];
            drink.Price = Convert.ToDouble(values[3]);
            drink.ImageUrl = values[4];
            drink.BottleCapacity = values[5];
            return drink;
        }
    }
}
