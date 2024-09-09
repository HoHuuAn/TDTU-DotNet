using System;
using System.Threading;
namespace Exercise3
{
    class Program
    {
        static int numThreads = 16;
        static int N = 50000000;

        public static void Main()
        {
            Console.Write("Enter number n: ");

            int number = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.Write("Value is not numeric. Please enter again: ");
                }
            }

            Console.Write("Enter number of threads: ");

            int numThreads = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numThreads))
                {
                    break;
                }
                else
                {
                    Console.Write("Value is not numeric. Please enter again: ");
                }
            }


            // Single thread
            var startTimeSingle = DateTime.Now;
            long totalSumSingle = CalculateSumSingleThread(number);
            var endTimeSingle = DateTime.Now;
            var executionTimeSingle = endTimeSingle - startTimeSingle;

            Console.WriteLine("Single thread - Total sum: " + totalSumSingle);
            Console.WriteLine("Single thread - Execution time: " + executionTimeSingle.TotalMilliseconds + " milliseconds");

            // Multiple threads
            var startTimeMulti = DateTime.Now;
            long totalSumMulti = CalculateSumMultiThread(number, numThreads);
            var endTimeMulti = DateTime.Now;
            var executionTimeMulti = endTimeMulti - startTimeMulti;

            Console.WriteLine("Multiple threads - Total sum: " + totalSumMulti);
            Console.WriteLine("Multiple threads - Execution time: " + executionTimeMulti.TotalMilliseconds + " milliseconds");

            Console.ReadLine();
        }

        public static long CalculateSumSingleThread(int N)
        {
            long totalSum = 0;
            for (int i = 1; i <= N; i++)
            {
                totalSum += i;
            }
            return totalSum;
        }

        public static long CalculateSumMultiThread(int N, int numThreads)
        {
            long[] partialSums = new long[numThreads];
            Thread[] threads = new Thread[numThreads];

            int work = N / numThreads;
            int partSize = work + ( N- work * numThreads);

            for (int i = 0; i < numThreads; i++)
            {
                int start = i * partSize + 1;
                int end = (i == (numThreads - 1)) ? N : (start + partSize - 1);


                int currentIndex = i;

                threads[i] = new Thread(() => partialSums[currentIndex] = CalculatePartialSum(start, end));
                threads[i].Start();
            }

            for (int i = 0; i < numThreads; i++)
            {
                threads[i].Join();
            }

            long totalSum = 0;
            for (int i = 0; i < numThreads; i++)
            {
                totalSum += partialSums[i];
            }

            return totalSum;
        }

        public static long CalculatePartialSum(int start, int end)
        {
            long sum = 0;
            for (long i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}