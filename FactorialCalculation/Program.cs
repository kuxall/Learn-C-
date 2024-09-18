using System.Numerics;

public class FactorialCalculation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to calculate the Factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        BigInteger factorial = CalculateFactorial(number);
        Console.WriteLine("Factorial of {0} is {1}", number, factorial);
    }

    public static BigInteger CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new Exception("Factorial of negative number is not possible");
        }

        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}