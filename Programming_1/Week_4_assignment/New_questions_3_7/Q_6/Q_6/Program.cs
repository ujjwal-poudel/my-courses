using System;
/*
 * Write a console-based program that prompts the user for an hourly pay rate and hours worked.
Compute and display gross pay (hours times pay rate), withholding tax, and net pay (gross pay
minus withholding tax). Withholding tax is computed as a percentage of gross pay based on the
following:
    Gross Pay Withholding                       Percentage

    Up to and including 300.00                  10%
    More than300.00                             12%
 */

namespace Q_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pay, hour, grossPay;
            Console.Write("Enter your hourly pay rate: ");
            pay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of hours you worked: ");
            hour = Convert.ToDouble(Console.ReadLine());

            grossPay = pay * hour;

            /*
            Using if conditional statement to check whether the user's 
            gross pay is higher than 300 or not
            */

            if (grossPay <= 300)
            {
                Console.WriteLine($"Your gross pay is {grossPay:C} without including tax");
                double withholdingTax = 0.1 * grossPay;
                double finalPay = grossPay - withholdingTax;
                Console.WriteLine("");
                Console.WriteLine($"Your withholding tax is {withholdingTax:C}");
                Console.WriteLine($"Your pay after reducing tax is {finalPay:C} as 10% tax defined");
            }
            else 
            {
                Console.WriteLine($"Your gross pay is {grossPay:C} without including tax");
                double withholdingTax = 0.12 * grossPay;
                double finalPay = grossPay - withholdingTax;
                Console.WriteLine("");
                Console.WriteLine($"Your withholding tax is {withholdingTax:C} as 12% tax rate defined");
                Console.WriteLine($"Your pay after reducing tax is {finalPay:C}");
            }
             Console.WriteLine("sorry, Please enter a valid input either float or integer");
            Console.WriteLine(new string('-', 75));
        }
    }
}
