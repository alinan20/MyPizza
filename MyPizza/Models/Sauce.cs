namespace MyPizza.Models
{
    public class Sauce : Product
    {
        public string Ingredients { get; set; }
        public string Weight { get; set; }
        public static Sauce CreateObjectFromCsvLine(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Sauce sauce = new Sauce();
            sauce.Id = values[0];
            sauce.Name = values[1];
            sauce.Description = values[2];
            sauce.Price = Convert.ToDouble(values[3]);
            sauce.ImageUrl = values[4];
            sauce.Ingredients = values[5];
            sauce.Weight = values[6];
            sauce.Subtotal = sauce.Price;
            return sauce;
        }
    }
}