namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1. Write a lambda expression that takes two integers and returns their sum.
            Func<int, int, int> sum = (x, y) => x + y;

            int result = sum(3, 5);
            Console.WriteLine("1. " + result);

            //2. Write a lambda expression that takes a string and returns its length.
            Func<string, int> stringLength = str => str.Length;

            int length = stringLength("Hello, I am Ho Huu An, I am 20 years old");
            Console.WriteLine("2. " + length); 

            //3. Write a lambda expression that checks if an integer is even.
            Predicate<int> isEven = num => num % 2 == 0;

            bool even = isEven(4);
            Console.WriteLine("3. " + even);

            bool odd = isEven(7);
            Console.WriteLine("3. " + odd);


            //4. Write a lambda expression that filters a list of integers to select only even numbers.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
            Console.WriteLine("4. ");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}