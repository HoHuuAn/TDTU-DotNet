using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Product
    {
        public int ProductID;
        public string? Name;
        public decimal? Price;
        public string? Description;

        public Product() {

        }
        
        public Product(int id, string name, decimal price, string description)
        {
            ProductID = id;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
