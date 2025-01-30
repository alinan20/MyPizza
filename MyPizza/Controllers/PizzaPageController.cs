using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class PizzaPageController : Controller
    {
        public IActionResult Index()
        {
            PizzaPage pizzaPage = new PizzaPage();
            pizzaPage.LoadData(@"D:\MyPizza\pizzas.csv");
            return View(pizzaPage.Pizzas);
        }
        public IActionResult Ingredients(string id)
        {
            PizzaPage pizzaPage = new PizzaPage();
            pizzaPage.LoadData(@"D:\MyPizza\pizzas.csv");
            var chosenPizza = pizzaPage.Pizzas.Find(item => item.Id == id);
            if (chosenPizza != null)
            {
                return View(chosenPizza);
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult AddToCart(string id)
        {
            PizzaPage pizzaPage = new PizzaPage();
            pizzaPage.LoadData(@"D:\MyPizza\pizzas.csv");
            var chosenPizza = pizzaPage.Pizzas.Find(item => item.Id == id);
            if (chosenPizza != null)
            {
                MyCartPage.ProductsInCart.Add(chosenPizza);
            }
            return RedirectToAction("ViewMyCart");

        }
        public IActionResult ViewMyCart()
        {
            return View("MyCart", MyCartPage.ProductsInCart);
        }
    }
}
