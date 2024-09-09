namespace Exercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MarketingContext mc = new MarketingContext();

            //Manufacture apple = new Manufacture() { ID = "M01", Name = "Apple", Location = "USA", Employee = 10000 };
            //Manufacture samsung = new Manufacture() { ID = "M02", Name = "Samsung", Location = "Korea", Employee = 10000 };
            //Manufacture microsoft = new Manufacture{ ID = "M03",Name = "Microsoft",Location = "USA",Employee = 15000 };
            //Manufacture toyota = new Manufacture{ID = "M04",Name = "Toyota",Location = "Japan",Employee = 5000 };
            //Manufacture nike = new Manufacture {ID = "M05",Name = "Nike",Location = "USA", Employee = 8000};

            //Phone phone1 = new Phone() { ID = "P01", Name = "iPhone X", Price = 1299, Color = "Gray", Country = "USA", Quantity = 1000 };
            //Phone phone2 = new Phone() { ID = "P02", Name = "iPhone XS", Price = 1399, Color = "Pacific Blue", Country = "USA", Quantity = 1000 };
            //Phone phone3 = new Phone() { ID = "P03", Name = "Samsung Galaxy S21", Price = 999, Color = "Phantom Black", Country = "South Korea", Quantity = 800 };
            //Phone phone4 = new Phone() { ID = "P04", Name = "Google Pixel 6", Price = 899, Color = "Sorta Sage", Country = "USA", Quantity = 1200 };
            //Phone phone5 = new Phone() { ID = "P05", Name = "OnePlus 9 Pro", Price = 1099, Color = "Morning Mist", Country = "China", Quantity = 900 };
            //Phone phone6 = new Phone() { ID = "P06", Name = "Samsung Galaxy Note 20 Ultra", Price = 1299, Color = "Mystic Bronze", Country = "South Korea", Quantity = 750 };
            //Phone phone7 = new Phone() { ID = "P07", Name = "Google Pixel 6 Pro", Price = 1199, Color = "Stormy Black", Country = "USA", Quantity = 900 };
            //Phone phone8 = new Phone() { ID = "P08", Name = "iPhone 13", Price = 1299, Color = "Product(RED)", Country = "USA", Quantity = 1000 };
            //Phone phone9 = new Phone() { ID = "P09", Name = "OnePlus 9", Price = 899, Color = "Arctic Sky", Country = "China", Quantity = 1100 };
            //Phone phone10 = new Phone() { ID = "P10", Name = "Xiaomi Mi 11", Price = 999, Color = "Midnight Gray", Country = "China", Quantity = 950 };
            //Phone phone11 = new Phone() { ID = "P11", Name = "Samsung Galaxy S21 Ultra", Price = 1399, Color = "Phantom Silver", Country = "South Korea", Quantity = 800 };
            //Phone phone12 = new Phone() { ID = "P12", Name = "Google Pixel 5a", Price = 699, Color = "Mostly Black", Country = "USA", Quantity = 1500 };
            //Phone phone13 = new Phone() { ID = "P13", Name = "iPhone SE", Price = 399, Color = "White", Country = "USA", Quantity = 2000 };
            //Phone phone14 = new Phone() { ID = "P14", Name = "OnePlus Nord 2", Price = 699, Color = "Blue Haze", Country = "China", Quantity = 1200 };
            //Phone phone15 = new Phone() { ID = "P15", Name = "Xiaomi Redmi Note 10 Pro", Price = 299, Color = "Glacier Blue", Country = "China", Quantity = 1800 };

            //mc.Manufactures.Add(apple);
            //mc.Manufactures.Add(samsung);
            //mc.Manufactures.Add(microsoft);
            //mc.Manufactures.Add(toyota);
            //mc.Manufactures.Add(nike);
            //mc.SaveChanges();


            //phone1.Manufacture = apple;
            //phone2.Manufacture = apple;
            //phone3.Manufacture = samsung;
            //phone4.Manufacture = samsung;
            //phone5.Manufacture = samsung;
            //phone6.Manufacture = samsung;
            //phone7.Manufacture = samsung;
            //phone8.Manufacture = apple;
            //phone9.Manufacture = samsung;
            //phone10.Manufacture = samsung;
            //phone11.Manufacture = samsung;
            //phone12.Manufacture = samsung;
            //phone13.Manufacture = apple;
            //phone14.Manufacture = samsung;
            //phone15.Manufacture = samsung;

            //mc.Phones.Add(phone1);
            //mc.Phones.Add(phone2);
            //mc.Phones.Add(phone3);
            //mc.Phones.Add(phone4);
            //mc.Phones.Add(phone5);
            //mc.Phones.Add(phone6);
            //mc.Phones.Add(phone7);
            //mc.Phones.Add(phone8);
            //mc.Phones.Add(phone9);
            //mc.Phones.Add(phone10);
            //mc.Phones.Add(phone11);
            //mc.Phones.Add(phone12);
            //mc.Phones.Add(phone13);
            //mc.Phones.Add(phone14);
            //mc.Phones.Add(phone15);
            //mc.SaveChanges();


            //foreach (var item in mc.Phones.ToList())
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in mc.Phones)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in mc.Manufactures)
            //{
            //    Console.WriteLine(item);
            //}

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
        }
    }
}