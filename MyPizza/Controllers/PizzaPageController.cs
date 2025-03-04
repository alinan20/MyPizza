﻿using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class PizzaPageController : Controller
    {
        public PizzeriaBusiness Pizzeria = new PizzeriaBusiness();
        
        public IActionResult Index()
        {
            return View(Pizzeria.PizzaPage.Pizzas);
        }
        public IActionResult Ingredients(int id)
        {
            var chosenPizza = Pizzeria.GetPizzaById(id);
            if (chosenPizza != null)
            {
                return View(chosenPizza);
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult AddToCart(int id)
        {
            var chosenPizza = Pizzeria.GetPizzaById(id);
            if (chosenPizza != null)
            {
                MyCartPage.ProductsInCart.Add(chosenPizza);
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
