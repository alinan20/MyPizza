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
    }
}
