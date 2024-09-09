namespace Exercise5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of Person objects
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "Alice", Age = 25, City = "New York" },
                new Person() { Name = "Eve", Age = 45, City = "London"},
                new Person() { Name = "Charlie", Age = 40, City = "Paris" },
                new Person() { Name = "David", Age = 30, City = "Ha Noi" },
                new Person() { Name = "Andy", Age = 14, City = "Ho Chi Minh" },
                new Person() { Name = "Karden", Age = 70, City = "Can Tho" },
                new Person() { Name = "Bob", Age = 35, City = "England" },
                new Person() { Name = "Jack", Age = 50, City = "Jarkarta" },
                new Person() { Name = "Cris", Age = 5, City = "Manila" },
                new Person() { Name = "Taylor", Age = 12, City = "Ha Noi" },
                new Person() { Name = "Tylor", Age = 20, City = "Ho Chi Minh" },
                new Person() { Name = "Vi", Age = 20, City = "Ho Chi Minh" },
                new Person() { Name = "Quan", Age = 50, City = "Ho Chi Minh" },
                new Person() { Name = "Bao", Age = 22, City = "Hai Phong" },
                new Person() { Name = "Anh", Age = 21, City = "Vung Tau" },
                new Person() { Name = "An", Age = 20, City = "Ho Chi Minh" },
                new Person() { Name = "Dat", Age = 23, City = "Ho Chi Minh" },
                new Person() { Name = "Ngoc", Age = 19, City = "Ho Chi Minh" },
            };

            // Use lambda expressions to filter the list and select objects that people older than 30
            List<Person> olderThan30 = people.Where(person => person.Age > 30).ToList();

            // Use a lambda expression to filter the list and select objects whose names start with the letter "A"
            List<Person> nameStartsWithA = people.Where(person => person.Name.StartsWith("A")).ToList();

            // Use a lambda expression to filter the list and select objects whose names start with the letter "A"
            List<Person> nameStartsWithB = people.Where(person => person.Name.StartsWith("B")).ToList();

            // Use lambda expressions to order the list by sorting people by age
            List<Person> sortedByAge = people.OrderBy(person => person.Age).ToList();

            // Use lambda expressions to order the list by name (ascending)
            List<Person> sortedByName = people.OrderBy(person => person.Name).ToList();

            // Use lambda expressions to order the list by city (descending)
            List<Person> sortedByCity = people.OrderByDescending(person => person.City).ToList();

            // Use lambda expressions to create a list of names
            List<string> names = people.Select(person => person.Name).ToList();

            // Use lambda expressions to check if any person in the list matches a specific condition (e.g., anyone aged 50 or older)
            bool anyPersonAged50OrOlder = people.Any(person => person.Age >= 50);

            // Use lambda expressions to calculate the average age of the people in the list
            double averageAge = people.Average(person => person.Age);

            // Print the results
            Console.WriteLine("People older than 30:");
            foreach (Person person in olderThan30)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nPeople whose names start with 'A':");
            foreach (Person person in nameStartsWithA)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nPeople whose names start with 'B':");
            foreach (Person person in nameStartsWithB)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nPeople sorted by age:");
            foreach (Person person in sortedByAge)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nPeople sorted by name (ascending):");
            foreach (Person person in sortedByName)
            {
                Console.WriteLine($"{person.Name} ({person.Age}) - {person.City}");
            }

            Console.WriteLine("\nPeople sorted by city (descending):");
            foreach (Person person in sortedByCity)
            {
                Console.WriteLine($"{person.Name} ({person.Age}) - {person.City}");
            }

            Console.WriteLine("\nList of names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"\nIs there any person aged 50 or older? {anyPersonAged50OrOlder}");

            Console.WriteLine($"\nAverage age: {averageAge}");
        }
    }
}