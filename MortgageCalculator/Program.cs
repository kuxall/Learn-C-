using System;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mortgage Calculator");
            Console.WriteLine("-------------------");

            double loanAmount = 0;
            double annualInterestRate = 0;
            int loanTermYears = 0;
            double downPayment = 0;

            // Get Loan Amount
            while (true)
            {
                Console.Write("Enter the loan amount (between $100,000 and $10,000,000): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out loanAmount))
                {
                    if (loanAmount >= 100000 && loanAmount <= 10000000)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Loan amount must be between $100,000 and $10,000,000. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for loan amount. Please enter a numeric value.");
                }
            }

            // Get Annual Interest Rate
            while (true)
            {
                Console.Write("Enter the annual interest rate (in %, between 0.25% and 25%): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out annualInterestRate))
                {
                    if (annualInterestRate >= 0.25 && annualInterestRate <= 25)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Interest rate must be between 0.25% and 25%. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for interest rate. Please enter a numeric value.");
                }
            }

            // Get Loan Term in Years
            while (true)
            {
                Console.Write("Enter the loan term (in years, between 15 and 35): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out loanTermYears))
                {
                    if (loanTermYears >= 15 && loanTermYears <= 35)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Loan term must be between 15 and 35 years. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for loan term. Please enter an integer value.");
                }
            }

            // Get Down Payment
            while (true)
            {
                Console.Write("Enter the down payment amount: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out downPayment))
                {
                    if (downPayment >= 0 && downPayment <= loanAmount)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Down payment cannot be negative or greater than the loan amount. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for down payment. Please enter a numeric value.");
                }
            }

            // Calculate Mortgage Payment using the formula M = P * ( r(1+r)^n ) / ( (1+r)^n - 1)
            double principal = loanAmount - downPayment;
            double monthlyInterestRate = (annualInterestRate / 100) / 12;
            int totalPayments = loanTermYears * 12;

            double monthlyPayment = 0;

            if (monthlyInterestRate == 0)
            {
                monthlyPayment = principal / totalPayments;
            }
            else
            {
                monthlyPayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalPayments)) /
                                 (Math.Pow(1 + monthlyInterestRate, totalPayments) - 1);
            }

            Console.WriteLine();
            Console.WriteLine($"Monthly Mortgage Payment: ${monthlyPayment:F2}");
            Console.ReadKey();
        }
    }
}
