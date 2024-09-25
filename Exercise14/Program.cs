using System;

public class Exercise14
{
    public static void Main()
    {
        Console.Write("Enter the amount of Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}
