using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class SaucePageController : Controller
    {
        public IActionResult Index()
        {
            SaucePage saucePage = new SaucePage();
            saucePage.LoadData(@"D:\MyPizza\sauces.csv");
            return View(saucePage.Sauces);
        }
        public IActionResult Ingredients(string id)
        {
            SaucePage saucePage = new SaucePage();
            saucePage.LoadData(@"D:\MyPizza\sauces.csv");
            var chosenSauce = saucePage.Sauces.Find(item => item.Id == id);
            if (chosenSauce != null)
            {
                return View(chosenSauce);
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult AddToCart(string id)
        {
            SaucePage saucePage = new SaucePage();
            saucePage.LoadData(@"D:\MyPizza\sauces.csv");
            var chosenSauce = saucePage.Sauces.Find(item => item.Id == id);
            if (chosenSauce != null)
            {
                PizzaPageController.ProductsInCart.Add(chosenSauce);
            }
            return RedirectToAction("ViewMyCart");

        }
        public IActionResult ViewMyCart()
        {
            return View("MyCart", PizzaPageController.ProductsInCart);
        }
    }
}
