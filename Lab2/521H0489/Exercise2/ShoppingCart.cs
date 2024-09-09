using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class ShoppingCart
    {
        public List<Product> products;
        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public void DisplayCart()
        {
            Console.WriteLine("My Shopping Cart:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price:C}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine();
            }
        }
    }
}
