// See https://aka.ms/new-console-template for more information
using System;

class UserInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);
    }
}

