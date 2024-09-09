namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n========== Simple calculator ==========\n");
            Console.Write("Enter the first number: ");

            int a = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine($"The first number: {a}\n");
                    break;
                }
                else
                {
                    Console.Write("Value is not numeric. Please enter again: ");
                }
            }

            Console.Write("Enter the second number: ");
            int b = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine($"The first number: {b}\n");
                    break;
                }
                else
                {
                    Console.Write("Value is not numeric. Please enter again: ");
                }
            }


            Console.Write("Choose arithmetic operations:\n" +
                                "1. Addition\n" +
                                "2. Subtraction\n" +
                                "3. Multiplication\n" +
                                "4. Division\n" +
                                "Choose 1 to 4 respectively: ");

            int operation = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out operation))
                {
                    if (operation < 1 || operation > 4)
                    {
                        Console.Write("Value must from 1 to 4. Please enter again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("Value is not numeric. Please enter again: ");
                }
            }

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Answer: {a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Answer: {a} - {b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Answer: {a} * {b} = {a * b}");
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("The second input number is zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Answer: {a} / {b} = {a / b}");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}