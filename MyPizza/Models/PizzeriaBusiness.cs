namespace MyPizza.Models
{
    public class PizzeriaBusiness
    {
        public PizzaPage PizzaPage { get; set; }
        public DrinkPage DrinkPage { get; set; }
        public SaucePage SaucePage { get; set; }
        public PizzeriaBusiness() 
        { 
            PizzaPage = new PizzaPage();
            DrinkPage = new DrinkPage();
            SaucePage = new SaucePage();
            PizzaPage.LoadData(@"D:\MyPizza\pizzas.csv");
            DrinkPage.LoadData(@"D:\MyPizza\drinks.csv");
            SaucePage.LoadData(@"D:\MyPizza\sauces.csv");
        }
        public Pizza GetPizzaById(int id)
        {
            return PizzaPage.Pizzas.Find(item => item.Id == id);
        }
        public Drink GetDrinkById(int id)
        {
            return DrinkPage.Drinks.Find(item => item.Id == id);

        }
        public Sauce GetSauceById(int id)
        {
            return SaucePage.Sauces.Find(item => item.Id == id);
        }
        public Product GetProductById(int id)
        {
            return MyCartPage.ProductsInCart.Find(item => item.CartId == id);
        }

    }
}
