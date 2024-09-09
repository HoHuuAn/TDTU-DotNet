namespace Exercise2
{
    internal class StoreApp
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Pepsi", 7.5m, "Soft drink");
            Product product2 = new Product(2, "RedBull", 5.5m, "Energy drink");
            Product product3 = new Product(3, "M&N", 2.5m, "Candy");
            Product product4 = new Product(4, "Doublemint", 1.5m, "Gum");

            Customer customer1 = new Customer( 1, "Ho Huu An","521H0489@student.tdtu.edu.vn","Binh Tan");
            Customer customer2 = new Customer( 2, "Quoc Bao","bao123@gmail.com","Binh Chanh");
            Customer customer3 = new Customer( 3, "Hai Tien","pear1305@gmail.com","District 6");

            ShoppingCart cart = new ShoppingCart();

            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);

            Console.WriteLine("====================Displaying the shopping cart====================");
            cart.DisplayCart();

            Console.WriteLine("====================Displaying the shopping cart After removing products====================");
            cart.RemoveProduct(product1);
            cart.DisplayCart();

            Order order = new Order(1, customer1, cart.products, DateTime.Now);

            Console.WriteLine("====================Order Details====================");
            Console.WriteLine($"Order ID: {order.OrderID}");
            Console.WriteLine($"Customer: {order.Customer.Name}");
            Console.WriteLine($"Order Date: {order.OrderDate}");
            Console.WriteLine("\n====================Ordered Products====================\n");
            foreach (var product in order.Products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price:C}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}