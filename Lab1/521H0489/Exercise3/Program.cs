namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n========== Welcome to the Number Guessing Game! ==========\n");

                Random random = new Random();
                int targetNumber = random.Next(1, 101);
                int userGuess = 0;
                int totalGuesses = 0;


                do
                {
                    Console.Write("Enter your guess (1-100): ");

                    if (!int.TryParse(Console.ReadLine(), out userGuess))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    totalGuesses++;

                    if (userGuess < targetNumber)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else if (userGuess > targetNumber)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("\n========== Congratulations! You guessed the correct number!==========");
                        break;
                    }
                } while (true);

                Console.WriteLine($"Number of guesses: {totalGuesses}");
            } while (true);
        }
    }
}