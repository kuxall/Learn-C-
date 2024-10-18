using System;

namespace OnlinePrintingCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            // Ask user to choose a format
            Console.Write("Enter 'c' for 10x15cm, anything else for 8x11in: ");
            string format = Console.ReadLine();
            double pricePerCopy = format == "c" ? 0.20 : 0.25;

            // Ask if this is the first time for the customer
            Console.Write("Is this your first time here? Type 'y' for 'yes': ");
            string firstTime = Console.ReadLine();
            bool isFirstTime = firstTime == "y" || firstTime == "Y";

            // Get number of copies
            Console.Write("Enter a number of copies: ");
            int numberOfCopies;
            while (!int.TryParse(Console.ReadLine(), out numberOfCopies) || numberOfCopies <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for copies.");
            }

            // Calculate total cost
            double totalCost = numberOfCopies * pricePerCopy;

            // Apply discounts
            if (isFirstTime && totalCost > 5)
            {
                Console.WriteLine("We cherish our new customers, so we are giving you a $3 discount!");
                totalCost -= 3;
            }

            if (numberOfCopies > 50)
            {
                Console.WriteLine("You had a 10% discount!");
                totalCost *= 0.9;
            }

            // Display total cost
            Console.WriteLine($"Your total is ${totalCost:F2}.");
        }
    }
}
