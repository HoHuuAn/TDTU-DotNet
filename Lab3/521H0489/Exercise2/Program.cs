using System;

public delegate int MathOperation(int x, int y);

public class Program
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static void Main(string[] args)
    {
        MathOperation addOperation = Add;
        MathOperation subtractOperation = Subtract;
        MathOperation multiplyOperation = Multiply;

        int num1 = 15;
        int num2 = 10;

        int Addition = addOperation(num1, num2);
        int Subtraction = subtractOperation(num1, num2);
        int Multiplication = multiplyOperation(num1, num2);

        Console.WriteLine($"Addition: {num1} + {num2} = {Addition}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {Subtraction}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {Multiplication}");
    }
}