using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class ProducerConsumer
    {
        private Queue<int> buffer;
        private object bufferLock;
        private int bufferSize;
        private int itemCount;
        private bool producerFinished;

        public ProducerConsumer(int bufferSize)
        {
            this.buffer = new Queue<int>();
            this.bufferLock = new object();
            this.bufferSize = bufferSize;
            this.itemCount = 0;
            this.producerFinished = false;
        }

        public void Produce()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                lock (bufferLock)
                {
                    while (buffer.Count >= bufferSize)
                    {
                        Monitor.Wait(bufferLock);
                    }

                    int item = random.Next(100);
                    buffer.Enqueue(item);
                    Console.WriteLine($"Producer produced: {i}");

                    itemCount++;
                    if (itemCount == 10)
                    {
                        producerFinished = true;
                    }

                    Monitor.Pulse(bufferLock);
                }

                Thread.Sleep(random.Next(500));
            }
        }

        public void Consume()
        {
            while (true)
            {
                lock (bufferLock)
                {
                    if (buffer.Count == 0 && !producerFinished)
                    {
                        Monitor.Wait(bufferLock);
                    }

                    if (buffer.Count == 0 && producerFinished)
                    {
                        break;
                    }

                    int item = buffer.Dequeue();
                    Console.WriteLine($"Consumer consumed: {item}");

                    Monitor.Pulse(bufferLock);
                }

                Thread.Sleep(500);
            }
        }
    }

}
