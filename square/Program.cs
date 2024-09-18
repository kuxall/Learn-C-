using System;

public class Square
{
    public static void Main()
    {
        long sum = 0;
        int count = 1;

        Console.WriteLine("Enter the number of squares you want to add: ");

        int high = int.Parse(Console.ReadLine());
        while (count <= high)
        {
            sum += (long)count * count;
            count++;
        }
        Console.WriteLine("The sum of the first {0} squares is {1}", high, sum);
    }
}

// Using int for sum and count will cause an overflow for high values of high.
// Using long for sum will prevent overflow.