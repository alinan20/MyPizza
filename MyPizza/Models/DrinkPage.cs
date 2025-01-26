namespace MyPizza.Models
{
    public class DrinkPage
    {
        public List<Drink> Drinks { get; set; }
        public void LoadData(string filePath)
        {
            Drinks = File.ReadAllLines(filePath)
                .Skip(1)
                .Select(line => Drink.CreateObjectFromCsvLine(line))
                .ToList();

        }
    }
}
