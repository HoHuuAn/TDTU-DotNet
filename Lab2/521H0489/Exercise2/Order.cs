using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Order
    {
        public int OrderID;
        public Customer Customer;
        public List<Product> Products;
        public DateTime OrderDate;

        public Order() { }

        public Order(int id, Customer customer, List<Product> products, DateTime OrderData)
        {
            OrderID = id;
            Customer = customer;
            Products = products;
            OrderDate = OrderData;
        }
    }
}
