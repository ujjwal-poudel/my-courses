using System;

/*
 * Write a console-based program that prompts a user for an hourly pay rate. If the user enters values
   less than $7.50 or greater than $49.99, prompt the user again. If the user enters an invalid value
   again, display an appropriate error message. If the user enters a valid value on either the first or
   second attempt, display the pay rate as well as the weekly rate, which is calculated as 40 times the
   hourly rate.
*/

namespace Question_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hourly payrate: ");
            float payRate = (float)Convert.ToDouble(Console.ReadLine());
            float weeklyRate = 40 * payRate;

            if (payRate < 7.50 || payRate > 49.99)
            {
                Console.WriteLine("The hourly pay rate should between 7.50 and 49.99");
                Console.Write("Enter your hourly payrate again: ");
                payRate = (float)Convert.ToDouble(Console.ReadLine());

                if (payRate < 7.50 || payRate > 49.99)
                {
                    Console.WriteLine("Please start from first, you are error generator");
                }
                else
                {
                    Console.WriteLine($"your hourly pay rate is {payRate:C}");
                    Console.WriteLine($"your weekly pay rate is {weeklyRate:C}");
                }
            }
            else
            {
                weeklyRate = 40 * payRate;
                Console.WriteLine($"your hourly pay rate is {payRate:C}");
                Console.WriteLine($"your weekly pay rate is {weeklyRate:C}");
            }
        }
    }
}
