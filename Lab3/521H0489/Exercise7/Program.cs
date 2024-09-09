namespace Exercise7
{
    public delegate string StringOperation(string input);
    public class Program
    {
        public static string ToUpper(string input)
        {
            return input.ToUpper();
        }

        public static string ToLower(string input)
        {
            return input.ToLower();
        }

        public static void Main(string[] args)
        {
            StringOperation stringOperation = ToUpper;

            string result = stringOperation("Ho Huu An, major is computer science");
            Console.WriteLine(result);

            stringOperation += ToLower;

            result = stringOperation("Ho Huu An, major is computer science");
            Console.WriteLine(result);
        }

    }
}