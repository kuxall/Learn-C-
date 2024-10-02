// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Array
{
    public static void Main(string[] args)
    {
        // Create an array of four elements, and add values later
        string[] cars = new string[4];
        Console.WriteLine("Cars Array Uninitialized");

        // Create an array of four elements and add values right away 
        string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine("Cars 2 Array ");
        Console.WriteLine(string.Join(",", cars2));

        // Create an array of four elements without specifying the size 
        string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine("Cars 3 Array ");

        Console.WriteLine(string.Join(",", cars3));

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" }; 
        Console.WriteLine("Cars 4 Array ");
        Console.WriteLine(string.Join(",", cars4));

    }

}