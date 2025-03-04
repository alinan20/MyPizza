﻿using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class SaucePageController : Controller
    {
        public PizzeriaBusiness Pizzeria = new PizzeriaBusiness();
        public IActionResult Index()
        {
            return View(Pizzeria.SaucePage.Sauces);
        }
        public IActionResult Ingredients(int id)
        {
            var chosenSauce = Pizzeria.GetSauceById(id);
            if (chosenSauce != null)
            {
                return View(chosenSauce);
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult AddToCart(int id)
        {
            var chosenSauce = Pizzeria.GetSauceById(id);
            if (chosenSauce != null)
            {
                MyCartPage.ProductsInCart.Add(chosenSauce);
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
