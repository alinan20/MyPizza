namespace MyPizza.Models
{
    public class SaucePage
    {
        public List<Sauce> Sauces { get; set; }
        public void LoadData(string filePath)
        {
            Sauces = File.ReadAllLines(filePath)
                .Skip(1)
                .Select(line => Sauce.CreateObjectFromCsvLine(line))
                .ToList();

        }
    }
}
