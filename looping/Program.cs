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

        Console.WriteLine("\nForeach Loop: \n");
        string[] fruits = { "Apple", "Banana", "Mango", "Orange" };
        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nNested Loop: \n");
        for (int l = 1; l <= 3; l++)
        {
            for (int m = 1; m <= 3; m++)
            {
                Console.WriteLine("l = " + l + " m = " + m);
            }
        }

        Console.WriteLine("\nBreak Statement: \n");
        for (int n = 1; n <= 5; n++)
        {
            if (n == 3)
            {
                break;
            }
            Console.WriteLine(n);
        }

        Console.WriteLine("\nContinue Statement: \n");
        for (int o = 1; o <= 5; o++)
        {
            if (o == 3)
            {
                continue;
            }
            Console.WriteLine(o);
        }

        Console.WriteLine("\nLooping with Goto: \n");
        int p = 1;
        start:
        Console.WriteLine(p);
        p++;
        if ( p < 10)
            goto start;
    }
}
