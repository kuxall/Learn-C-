using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 10;  // Handle 10 students
            double[] aggregates = new double[numberOfStudents];
            int above80Count = 0;
            int below30Count = 0;

            // Accept marks from the user for 10 students
            Console.WriteLine("Enter marks for 10 students in Physics, Chemistry, and Maths (out of 100 each):");

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");

                // Accept Physics Marks
                double physicsMarks = GetMarksFromUser("Physics");

                // Accept Chemistry Marks
                double chemistryMarks = GetMarksFromUser("Chemistry");

                // Accept Maths Marks
                double mathsMarks = GetMarksFromUser("Maths");

                // Calculate aggregate percentage
                aggregates[i] = (physicsMarks + chemistryMarks + mathsMarks) / 3;

                // Determine if the student has 80% and above or 30% and below
                if (aggregates[i] >= 80)
                {
                    above80Count++;
                }
                else if (aggregates[i] <= 30)
                {
                    below30Count++;
                }
            }

            // Display the results
            Console.WriteLine($"\nNumber of students securing 80% and above in aggregate: {above80Count}");
            Console.WriteLine($"Number of students securing 30% and below in aggregate: {below30Count}");
        }

        // Method to get valid marks from the user for a subject
        static double GetMarksFromUser(string subject)
        {
            double marks;
            while (true)
            {
                Console.Write($"{subject}: ");
                if (double.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                {
                    break;  // Exit loop if input is valid
                }
                Console.WriteLine("Invalid input. Please enter a value between 0 and 100.");
            }
            return marks;
        }
    }
}
