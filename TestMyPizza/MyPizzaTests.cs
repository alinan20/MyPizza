using MyPizza.Controllers;
using MyPizza.Models;

namespace TestMyPizza
{
    [TestClass]
    public class MyPizzaTests
    {
        [TestMethod]
        public void GetPizzaInfo()
        {
            PizzeriaBusiness pizzeriaBusiness = new PizzeriaBusiness();
            var pizza = pizzeriaBusiness.GetPizzaById(4);
            Assert.AreEqual(45, pizza.Price);
        }
        [TestMethod]
        public void TestSubtotal() 
        {
            PizzeriaBusiness pizzeriaBusiness = new PizzeriaBusiness();
            MyCartController cartController = new MyCartController();
            var drink = pizzeriaBusiness.GetDrinkById(4);
            MyCartPage.ProductsInCart.Add(drink);
            MyCartPage.GetNewIds();
            cartController.CalculateSubtotal(1,6);
            Assert.AreEqual(30, drink.Subtotal);
            MyCartPage.ProductsInCart.Clear();
        }
        [TestMethod]
        public void TestTotal()
        {
            PizzeriaBusiness pizzeriaBusiness = new PizzeriaBusiness();
            MyCartController cartController = new MyCartController();
            var pizza = pizzeriaBusiness.GetPizzaById(6);
            var sauce = pizzeriaBusiness.GetSauceById(1);
            MyCartPage.ProductsInCart.Add(pizza);
            MyCartPage.ProductsInCart.Add(sauce);
            MyCartPage.GetNewIds();
            cartController.CalculateSubtotal(1, 2);
            cartController.CalculateSubtotal(2, 3);
            Assert.AreEqual(107, MyCartPage.Total);
            MyCartPage.ProductsInCart.Clear();
        }
        [TestMethod]
        public void TestRemove()
        {
            PizzeriaBusiness pizzeriaBusiness = new PizzeriaBusiness();
            MyCartController cartController = new MyCartController();
            var pizza = pizzeriaBusiness.GetPizzaById(5);
            var drink = pizzeriaBusiness.GetDrinkById(5);
            MyCartPage.ProductsInCart.Add(pizza);
            MyCartPage.ProductsInCart.Add(drink);
            MyCartPage.ProductsInCart.Remove(drink);
            Assert.IsTrue(MyCartPage.ProductsInCart.Count == 1);
            MyCartPage.ProductsInCart.Clear();
        }
    }
}
