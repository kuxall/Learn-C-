using System;

public class Exercise13
{
    public static void Main()
    {
        int x;
        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x + " + " + x + x + " + " + x + x + x);
        Console.WriteLine("= " + (x + Convert.ToInt32(string.Format("{0}{0}", x)) + Convert.ToInt32(string.Format("{0}{0}{0}", x))));
    }
}