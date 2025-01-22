namespace MyPizza.Models
{
    public class PizzaPage
    {
        public List<Pizza> Pizzas { get; set; }
        public void LoadData( string filePath)
        {
            Pizzas = File.ReadAllLines(filePath)
                .Skip(1)
                .Select(line => Pizza.CreateObjectFromCsvLine(line))
                .ToList();
           
        }
    }
}
