using System;

public class Exercise8
{
    public static void Main()
    {
        int x;
        int result;
        Console.WriteLine("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        result = x * 1;
        Console.WriteLine("The table of the given number is: ", x);
        Console.WriteLine("{0} * 1 = {1}", x, result);
        Console.WriteLine("{0} * 2 = {1}", x, result * 2);
        Console.WriteLine("{0} * 3 = {1}", x, result * 3);
        Console.WriteLine("{0} * 4 = {1}", x, result * 4);
        Console.WriteLine("{0} * 5 = {1}", x, result * 5);
        Console.WriteLine("{0} * 6 = {1}", x, result * 6);
        Console.WriteLine("{0} * 7 = {1}", x, result * 7);
        Console.WriteLine("{0} * 8 = {1}", x, result * 8);
        Console.WriteLine("{0} * 9 = {1}", x, result * 9);
        Console.WriteLine("{0} * 10 = {1}", x, result * 10);

    }
}