namespace Exercise6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventHandling eventHandling = new EventHandling();

            eventHandling.Event += (msg) =>
            {
                Console.WriteLine("Event handler called!");
                Console.WriteLine($"Message: {msg}");
            };

            eventHandling.TriggerEvent("Hi, I am Ho Huu An, student at TDTU :))))");

            Console.ReadKey();
        }
    }
}