namespace Exercise8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();

            void CreatMail()
            {
                Console.WriteLine("Creating Mail");
            }

            void WriteMail()
            {
                Console.WriteLine("Writing Mail");
            }

            void SendMail()
            {
                Console.WriteLine("Sending Mail");
            }

            eventManager.AddHandler(CreatMail);
            eventManager.AddHandler(WriteMail);
            eventManager.AddHandler(SendMail);
            eventManager.RaiseEvent();

            Console.WriteLine("\nAfter removing writing mail");
            eventManager.RemoveHandler(WriteMail);
            eventManager.RaiseEvent();

            Console.ReadKey();

        }
    }
}