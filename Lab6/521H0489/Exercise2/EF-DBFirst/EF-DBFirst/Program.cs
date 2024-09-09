using System;

namespace EF_DBFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //=================================== PhoneDAO ===================================
            PhoneDAO phoneDAO = new PhoneDAO();

            Phone phone16 = new Phone()
            {
                ID = "P16",
                Name = "Samsung Galaxy S21",
                Price = 55000000,
                Color = "Pink",
                Country = "South Korea",
                Quantity = 500
            };

            //add
            phoneDAO.AddPhone(phone16);


            Console.WriteLine("====================After adding phone16====================");

            //getAllPhones
            foreach (var item in phoneDAO.GetAllPhones())
            {
                Console.WriteLine(item);
            }

            //update
            phone16.Quantity = 1000;
            phoneDAO.UpdatePhone(phone16);

            //getPhoneByID
            Console.WriteLine("====================Getting phone16 with quantity = 1000 ====================");
            Console.WriteLine(phoneDAO.GetPhoneById(phone16.ID));

            //GetPhoneWithHighestPrice
            Console.Write("Phone With Highest Price ");
            Console.WriteLine(phoneDAO.GetPhoneWithHighestPrice());

            //GetPhonesSortedByCountryAndPrice
            Console.WriteLine("Phones Sorted By Country And Price ");
            foreach (var item in phoneDAO.GetPhonesSortedByCountryAndPrice())
            {
                Console.WriteLine(item);
            }

            //HasPhoneWithPriceAbove50Million
            Console.Write("Phone With Price Above 50 Million ");
            Console.WriteLine(phoneDAO.HasPhoneWithPriceAbove50Million());

            //GetFirstPinkPhoneWithPriceAbove15Million
            Console.WriteLine("First Pink Phone With Price Above 15 Million");
            Console.WriteLine(phoneDAO.GetFirstPinkPhoneWithPriceAbove15Million());

            //deletePhone
            phoneDAO.DeletePhone(phone16);

            Console.WriteLine("====================After deleting phone16====================");
            foreach (var item in phoneDAO.GetAllPhones())
            {
                Console.WriteLine(item);
            }

            //=================================== ManufactureDAO ===================================
            ManufactureDAO manufactureDAO = new ManufactureDAO();

            Manufacture vivo = new Manufacture() { ID = "M06", Name = "Vivo", Location = "Seoul, Korean", Employee = 10000 };
            
            //add
            manufactureDAO.AddManufacture(vivo);

            Console.WriteLine("==================== After adding vivo ====================");
            //getAllManufactures
            foreach (var item in manufactureDAO.GetAllManufactures())
            {
                Console.WriteLine(item);
            }

            //update
            vivo.Employee = 20000;
            manufactureDAO.UpdateManufacture(vivo);

            //getPhoneByID
            Console.WriteLine("====================Getting vivo with Employee = 20000 ====================");
            Console.WriteLine(manufactureDAO.GetManufactureById(vivo.ID));

            //delete
            manufactureDAO.DeleteManufacture(vivo);
            Console.WriteLine("====================After deleting vivo====================");
            foreach (var item in manufactureDAO.GetAllManufactures())
            {
                Console.WriteLine(item);
            }

            //AreAllManufacturersOver100Employees
            Console.WriteLine("Are All Manufacturers Over 100 Employees ? ");
            Console.WriteLine(manufactureDAO.AreAllManufacturersOver100Employees());

            //GetTotalNumberOfEmployees
            Console.WriteLine("Total Number Of Employees ");
            Console.WriteLine(manufactureDAO.GetTotalNumberOfEmployees());


            //GetLastManufacturerWithHeadquartersInUSA
            Console.WriteLine("Last Manufacturer With Headquarters In USA ");
            Console.WriteLine(manufactureDAO.GetLastManufacturerWithHeadquartersInUSA());

            Console.ReadLine();
        }
    }
}