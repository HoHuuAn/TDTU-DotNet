using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Customer
    {
        public int CustomerID;
        public string? Name;
        public string? Email;
        public string? Address;
        
        public Customer() { }

        public Customer(int id, string name, string email, string address)
        {
            CustomerID = id;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
