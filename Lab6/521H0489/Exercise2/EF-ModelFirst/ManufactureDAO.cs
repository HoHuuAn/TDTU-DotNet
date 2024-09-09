using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    public class ManufactureDAO
    {
        private EF_ModelFirstContainer context;

        public ManufactureDAO()
        {
            context = new EF_ModelFirstContainer();
        }

        public void AddManufacture(Manufacture manufacture)
        {
            context.Manufactures.Add(manufacture);
            context.SaveChanges();
        }

        public Manufacture GetManufactureById(String id)
        {
            return context.Manufactures.First(m => m.ID.Equals(id));
        }

        public List<Manufacture> GetAllManufactures()
        {
            return context.Manufactures.ToList();
        }

        public void UpdateManufacture(Manufacture manufacture)
        {
            context.Manufactures.AddOrUpdate(manufacture);
            context.SaveChanges();
        }

        public void DeleteManufacture(Manufacture manufacture)
        {
            context.Manufactures.Remove(manufacture);
            context.SaveChanges();
        }

        public bool AreAllManufacturersOver100Employees()
        {
            return context.Manufactures.All(m => m.Employee > 100);
        }

        public int GetTotalNumberOfEmployees()
        {
            return context.Manufactures.Sum(m => m.Employee);
        }

        public Manufacture GetLastManufacturerWithHeadquartersInUSA()
        {
            var manufacturer = context.Manufactures.OrderByDescending(m => m.ID).FirstOrDefault(m => m.Location.Equals("USA"));
            if (manufacturer == null)
            {
                throw new InvalidOperationException("No manufacturer with headquarters in the USA found.");
            }
            return manufacturer;
        }
    }
}
