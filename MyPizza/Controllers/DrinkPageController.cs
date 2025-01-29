using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class DrinkPageController : Controller
    {
        public IActionResult Index()
        {
            DrinkPage drinkPage = new DrinkPage();
            drinkPage.LoadData(@"D:\MyPizza\drinks.csv");
            return View(drinkPage.Drinks);
        }
        public IActionResult AddToCart(string id)
        {
            DrinkPage drinkPage = new DrinkPage();
            drinkPage.LoadData(@"D:\MyPizza\drinks.csv");
            var chosenDrink = drinkPage.Drinks.Find(item => item.Id == id);
            if (chosenDrink != null)
            {
                PizzaPageController.ProductsInCart.Add(chosenDrink);
            }
            return RedirectToAction("ViewMyCart");

        }
        public IActionResult ViewMyCart()
        {
            return View("MyCart", PizzaPageController.ProductsInCart);
        }
    }
}
