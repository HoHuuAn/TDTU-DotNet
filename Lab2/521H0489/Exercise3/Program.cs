namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal dolphin = new Mammal() { Name = "dolphin", Species = "omnivores", Age = 20, NumberOfLegs = 0};
            Mammal lion = new Mammal() { Name = "Leo", Species = "Carnivores", Age = 5, NumberOfLegs = 4 };
            Bird eagle = new Bird() { Name = "Soar", Species = "Carnivores", Age = 3, Wingspan = 2 };
            Bird sparrow = new Bird() { Name = "Sparrow", Species = "insectivores", Age = 1, Wingspan = 0.3 };
            Reptile snake = new Reptile() { Name = "Slither", Species = "Carnivores", Age = 2, IsVenomous = true };
            Reptile cricket = new Reptile() { Name = "Cricket", Species = "insectivores", Age =1, IsVenomous = false };

            Console.WriteLine("==================== Animal Details ====================");
            Console.WriteLine($"Name: {dolphin.Name}, Age: {dolphin.Age}, Species: {dolphin.Species}, Number of Legs: {dolphin.NumberOfLegs}");
            dolphin.MakeSound();
            dolphin.GiveBirth();
            Console.WriteLine();

            Console.WriteLine($"Name: {lion.Name}, Age: {lion.Age}, Species: {lion.Species}, Number of Legs: {lion.NumberOfLegs}");
            lion.MakeSound();
            lion.GiveBirth();
            Console.WriteLine();

            Console.WriteLine($"Name: {eagle.Name}, Age: {eagle.Age}, Species: {eagle.Species}, Wingspan: {eagle.Wingspan}");
            eagle.MakeSound();
            eagle.Fly();
            Console.WriteLine();

            Console.WriteLine($"Name: {sparrow.Name}, Age: {sparrow.Age}, Species: {sparrow.Species}, Wingspan: {sparrow.Wingspan}");
            sparrow.MakeSound();
            sparrow.Fly();
            Console.WriteLine();

            Console.WriteLine($"Name: {snake.Name}, Age: {snake.Age}, Species: {snake.Species}, Is Venomous: {snake.IsVenomous}");
            snake.MakeSound();
            Console.WriteLine();

            Console.WriteLine($"Name: {cricket.Name}, Age: {cricket.Age}, Species: {cricket.Species}, Is Venomous: {cricket.IsVenomous}");
            cricket.MakeSound();
            Console.WriteLine();

            ZooKeeper zooKeeper = new ZooKeeper();
            zooKeeper.AddAnimal(dolphin);
            zooKeeper.AddAnimal(lion);
            zooKeeper.AddAnimal(eagle);
            zooKeeper.AddAnimal(sparrow);
            zooKeeper.AddAnimal(snake);
            zooKeeper.AddAnimal(cricket);

            Console.WriteLine("==================== All Animals ====================");
            List<Animal> allAnimals = zooKeeper.FilterAnimals(animal => true);
            foreach (var animal in allAnimals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Species: {animal.Species}");
            }
            Console.WriteLine();

            Console.WriteLine("==================== Filtered Animals (Mammals) ====================");
            List<Animal> mammals = zooKeeper.FilterAnimals(animal => animal is Mammal);
            foreach (var mammal in mammals)
            {
                Console.WriteLine($"Name: {mammal.Name}, Age: {mammal.Age}, Species: {mammal.Species}");
            }
            Console.WriteLine();

            Console.WriteLine("==================== Filtered Animals (Flying) ====================");
            List<Animal> flyingAnimals = zooKeeper.FilterAnimals(animal => animal is IFlyable);
            foreach (var flyingAnimal in flyingAnimals)
            {
                Console.WriteLine($"Name: {flyingAnimal.Name}, Age: {flyingAnimal.Age}, Species: {flyingAnimal.Species}");
            }
            Console.WriteLine();

            Console.WriteLine("==================== Filtered Animals (Reptile) ====================");
            List<Animal> reptiles = zooKeeper.FilterAnimals(animal => animal is Reptile);
            foreach (var reptile in reptiles)
            {
                Console.WriteLine($"Name: {reptile.Name}, Age: {reptile.Age}, Species: {reptile.Species}");
            }
            Console.WriteLine();

            zooKeeper.RemoveAnimal("Lion");

            Console.WriteLine("==================== All Animals after removing Lion ====================");
            allAnimals = zooKeeper.FilterAnimals(animal => true);
            foreach (var animal in allAnimals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Species: {animal.Species}");
            }

            Console.ReadKey();
        }
    }
}