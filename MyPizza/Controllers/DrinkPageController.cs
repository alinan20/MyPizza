using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class DrinkPageController : Controller
    {
        public PizzeriaBusiness Pizzeria = new PizzeriaBusiness();
        public IActionResult Index()
        {
            return View(Pizzeria.DrinkPage.Drinks);
        }
        public IActionResult AddToCart(int id)
        {
            var chosenDrink = Pizzeria.GetDrinkById(id);
            if (chosenDrink != null)
            {
                MyCartPage.ProductsInCart.Add(chosenDrink);
            }
            MyCartPage.GetNewIds();
            return RedirectToAction("ViewMyCart");

        }
        public IActionResult ViewMyCart()
        {
            return View("MyCart", MyCartPage.ProductsInCart);
        }
    }
}
