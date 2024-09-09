using System.Threading.Tasks.Dataflow;
using System;

namespace Exercise9
{
    internal class Program
    {
        static Queue<int> buffer = new Queue<int>();
        static SemaphoreSlim producerSemaphore = new SemaphoreSlim(1); 
        static SemaphoreSlim consumerSemaphore = new SemaphoreSlim(0);
        public static void Main(string[] args)
        {
            Console.WriteLine("==================== Using Lock ====================");
            ProducerConsumer producerConsumer = new ProducerConsumer(5);

            Thread producerThread = new Thread(producerConsumer.Produce);
            Thread consumerThread = new Thread(producerConsumer.Consume);

            producerThread.Start();
            consumerThread.Start();

            producerThread.Join();
            consumerThread.Join();

            Console.WriteLine("Program Using Lock completed.");

            Console.WriteLine("==================== Using Semaphores ====================");
            producerThread = new Thread(Producer);
            consumerThread = new Thread(Consumer);

            producerThread.Start();
            consumerThread.Start();

            producerThread.Join();
            consumerThread.Join();

            Console.WriteLine("Program Using Semaphores completed.");
        }

        static void Producer()
        {
            for (int i = 0; i < 10; i++)
            {
                producerSemaphore.Wait(); 

                int item = i;
                Console.WriteLine($"Producer produced: {i}");

                buffer.Enqueue(item);

                consumerSemaphore.Release();
                Thread.Sleep(500);
            }
        }

        static void Consumer()
        {
            for (int i = 0; i < 10; i++)
            {
                consumerSemaphore.Wait();

                int item = buffer.Dequeue();
                Console.WriteLine($"Consumer consumed: {item}");

                producerSemaphore.Release();
                Thread.Sleep(500);
            }

        }
    }
}