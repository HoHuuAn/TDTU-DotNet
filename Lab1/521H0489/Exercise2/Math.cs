namespace Number
{
    public class Math
    {
        public static long factorial(int number)
        {
            long result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}