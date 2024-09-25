using System;

public class Exercise10
{
    public static void Main()
    {
        int number1, number2, number3;
        Console.Write("Input the 1st number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 2nd number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd number: ");
        number3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The result is: " + test(number1, number2, number3));
    }
    public static int test(int x, int y, int z)
    {
        int result = x + y;
        return result * z;
    }
}