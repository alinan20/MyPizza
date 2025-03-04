﻿using Microsoft.AspNetCore.Mvc;
using MyPizza.Models;

namespace MyPizza.Controllers
{
    public class MyCartController : Controller
    {
        public PizzeriaBusiness Pizzeria = new PizzeriaBusiness();
        public IActionResult DeleteFromCart(int id)
        {
            var chosenProduct = Pizzeria.GetProductById(id);
            if (chosenProduct != null)
            {
                MyCartPage.ProductsInCart.Remove(chosenProduct);
                return View("MyCart", MyCartPage.ProductsInCart);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CalculateSubtotal(int id, int quantity)
        {
            var chosenProduct = Pizzeria.GetProductById(id);
            if (chosenProduct != null)
            {
                chosenProduct.Subtotal = quantity * chosenProduct.Price;
                return View("MyCart", MyCartPage.ProductsInCart);
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult Checkout()
        {
            return View("CustomerData");
            
        }
        public IActionResult Finish()
        {
            MyCartPage.ProductsInCart.Clear();
            return View("SuccessfulOrder");
        }
    }
}
