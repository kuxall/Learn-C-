// See https://aka.ms/new-console-template for more 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nFor Loop: \n");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nWhile Loop: \n");
        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine("\nDo While Loop: \n");
        int k = 2;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k <= 10);
    }
}
