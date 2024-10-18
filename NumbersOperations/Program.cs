using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int evenCount = 0;
            int oddCount = 0;
            int multiplesOf4Count = 0;

            // Accept 20 integers from the user
            Console.WriteLine("Enter 20 integer numbers:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Number {i }: ");
                numbers[i] = int.Parse(Console.ReadLine());

                // Determine if the number is even or odd
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                // Determine if the number is a multiple of 4
                if (numbers[i] % 4 == 0)
                {
                    multiplesOf4Count++;
                }
            }

            // Display the results
            Console.WriteLine($"\nNumber of even numbers: {evenCount}");
            Console.WriteLine($"Number of odd numbers: {oddCount}");
            Console.WriteLine($"Number of multiples of 4: {multiplesOf4Count}");
        }
    }
}
