using Number;
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ========== Calculate the factorial of a number ==========\n");
            int number;
            do
            {
                Console.Write("Enter an integer (-1 to exit): ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Please enter a valid integer:");
                    continue;
                }

                if (number == -1)
                {
                    break;
                }

                if (number < 0)
                {
                    Console.Write("Invalid input. Please enter a valid integer equal or more than 0:");
                    continue;
                }

                long result = Number.Math.factorial(number);
                Console.WriteLine($"Factorial of {number} is {result}");

            } while (true);
        }
    }
}