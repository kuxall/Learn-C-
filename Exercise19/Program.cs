using System;
using System.Collections.Generic;
public class Exercise19
{
    public static void Main(string[] args )
    {
        Console.WriteLine(SumTriple(2, 2));
        Console.WriteLine(SumTriple(12, 10));
        Console.WriteLine(SumTriple(-5, 2));
    }
    public static int SumTriple(int a, int b)
    {
        return a == b ? (a + b) * 3 : a + b;
        // if a equals b, return the triplesum of a and b, otherwise return the sum
    }
}