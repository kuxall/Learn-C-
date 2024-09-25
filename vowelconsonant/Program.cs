using System;

public class Exercise16
{
    static void Main(string[] args)
    {
        char ch;
        Console.Write("\n\n");
        Console.Write("Accept a character from user and check whether it is a vowel or consonant:\n");
        Console.Write("------------------------------------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an alphabet (A-Z or a-z) : ");
        ch = Convert.ToChar(Console.ReadLine().ToLower());
        if (ch >= 48 && ch <= 57)
        {
            Console.WriteLine("You entered a number, Please enter an alphabet.");
        }
        else
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The entered alphabet is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("The entered alphabet is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("The entered alphabet is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("The entered alphabet is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("The entered alphabet is a vowel");
                    break;
                default:
                    Console.WriteLine("The entered alphabet is a consonant");
                    break;
            }
        }
        Console.ReadKey();
    }
}
 
