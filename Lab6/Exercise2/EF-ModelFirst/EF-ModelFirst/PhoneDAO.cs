using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    internal class PhoneDAO
    {
        private EF_ModelFirstContainer context;

        public PhoneDAO()
        {
            context = new EF_ModelFirstContainer();
        }

        public void AddPhone(Phone phone)
        {
            context.Phones.Add(phone);
            context.SaveChanges();
        }

        public Phone GetPhoneById(String id)
        {
            return context.Phones.First(p => p.ID.Equals(id));
        }

        public List<Phone> GetAllPhones()
        {
            return context.Phones.ToList();
        }

        public void UpdatePhone(Phone phone)
        {
            context.Phones.AddOrUpdate(phone);
            context.SaveChanges();
        }

        public void DeletePhone(Phone phone)
        {
            context.Phones.Remove(phone);
            context.SaveChanges();
        }

        public Phone GetPhoneWithHighestPrice()
        {
            return context.Phones.OrderByDescending(p => p.Price).First();
        }

        public List<Phone> GetPhonesSortedByCountryAndPrice()
        {
            return context.Phones.OrderBy(p => p.Country)
                                  .ThenByDescending(p => p.Price)
                                  .ToList();
        }

        public bool HasPhoneWithPriceAbove50Million()
        {
            return context.Phones.Any(p => p.Price > 50000000);
        }

        public Phone GetFirstPinkPhoneWithPriceAbove15Million()
        {
            return context.Phones.FirstOrDefault(p => (p.Color.Equals("Pink") && p.Price > 15000000));
        }
    }
}
