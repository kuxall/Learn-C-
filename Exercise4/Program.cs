using System;
public class Exercise4
{
    public static void Main()
    {
        int check_year;
        Console.WriteLine("\n \n Check whether a given year is leap year or not:\n");
        Console.WriteLine("----------------------------------------------------\n");
        Console.WriteLine("Input an Year: ");

        check_year = Convert.ToInt32(Console.ReadLine());
        if ((check_year % 400) == 0)
            Console.WriteLine("{0} is a Leap Year.\n", check_year);
        else if ((check_year % 100) == 0)
            Console.WriteLine("{0} is not a Leap Year.\n", check_year);
        else if ((check_year % 4) == 0)
            Console.WriteLine("{0} is a Leap Year.\n", check_year);
        else
            Console.WriteLine("{0} is not a Leap Year.\n", check_year);
    }
}
