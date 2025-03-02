namespace MyPizza.Models
{
    public class MyCartPage
    {
        public static List<Product> ProductsInCart = new List<Product>();
        public static double Total => CalculateTotal();
        public static double CalculateTotal()
        {
            double total = 0;
            for (int i = 0; i < ProductsInCart.Count; i++)
            {
                total += ProductsInCart[i].Subtotal;
            }
            return total;
        }
        public static void GetNewIds()
        {
            for (int i = 0; i < ProductsInCart.Count; i++)
            {
                ProductsInCart[i].CartId = i+1;
            }
        }
    }
}
