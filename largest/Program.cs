using System;
using System.ComponentModel.Design;

public class Exercise8
{
    public static void Main()
    {
        int num1, num2, num3;
        Console.Write("\n Enter the First number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n Enter the Second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n Enter the Third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three. \n");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three. \n");
            }

        }
        else if (num2 > num3)
        {
            Console.WriteLine("The 2nd Number is the greatest among three. \n");
        }
        else if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("\n All numbers are equal. \n");
        }
        else
        {
            Console.WriteLine("\n The 3rd Number is the greatest among three. \n");
        }
    }
}