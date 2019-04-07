using System.Collections.Generic;

namespace AutomatedCheckout
{
    //Class to have in-memory object of Products data
    public class Products
    {
        public static Dictionary<int, Product> items = new Dictionary<int, Product>(){
        { 1, new Product() { Name = "Toothpaste", Price = 24.94 } },
        { 2, new Product() { Name = "Cheese", Price = 59.00 } },
        { 3, new Product() { Name = "Bread", Price = 11.95 } },
        { 4, new Product() { Name = "Coffee", Price = 22.49 } },
        { 5, new Product() { Name = "Appels", Price = 32.95 } },
        { 6, new Product() { Name = "Flour", Price = 11.95 } },
        { 7, new Product() { Name = "Ground Beef", Price = 93.00 } },
        { 8, new Product() { Name = "Milk", Price = 9.32 } }

    };
    }
    public class Product
    {
        public string Name { get; set; } // Name of Product
        public double Price { get; set; } // Price of Product
    }
}