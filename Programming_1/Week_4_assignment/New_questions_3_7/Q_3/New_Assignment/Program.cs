using System;
/*
 * If money is left in a particular bank for more than 5 years, the interest rate given by the bank is 7.5%, else the
    interest rate is 5.4%. Write a program that prompt the user for the number of years that the money was left
    in the bank and display the appropriate interest rate depending on the value input. How many runs should
    you make to very that it works correctly?
 */

namespace New_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance, year, interest;

            Console.WriteLine("This program gives interest and amount information of a particular bank");

            //prompts the user information about bank balance and stores in variable
            Console.Write("Enter your bank balance: ");
            balance = Convert.ToDouble(Console.ReadLine());

            //prompts the user information about years and stores in variable
            Console.Write("Enter the number of years you had the balance: ");
            year = Convert.ToDouble(Console.ReadLine());

            /*
            If statement check whether the year prompted by user is greater than 5 or not.
            IF yes then the following print codes will be executed

            Else if statement checks wether the year prompted by user is equal to five or not.
            IF yes then the following print codes will be executed

            The else statement is executed if none above if statement gets exexuted
            */

            if (year > 5)
            {
                interest = 0.075 * balance * year;
                Console.WriteLine("The bank provides 7.5% of interest rate for 5 years or more deposit");
                Console.WriteLine("");
                Console.WriteLine($"Your previous balance is {balance:C}");
                Console.WriteLine($"Your total balance after interest is {interest + balance:C}");
                Console.WriteLine("");
            }
            else if (year == 5)
            {
                interest = 0.05 * balance * year;
                Console.WriteLine("The bank provides only 7.5% of interest rate if depsited for more than 5 years");
                Console.WriteLine("");
                Console.WriteLine($"Your previous balance is {balance:C}");
                Console.WriteLine($"Your total balance after interest in {year} years at the rate of 5% is {interest + balance:C}.");
                Console.WriteLine("");

                Console.WriteLine($"you need 1 more day to get interest rate of 7.5%.");
                Console.WriteLine("");
            }
            else
            {
                interest = 0.05 * balance * year;
                Console.WriteLine("The bank provides only 7.5% of interest rate if depsited for more than less 5 years");
                Console.WriteLine("");
                Console.WriteLine($"Your previous balance is {balance:C}");
                Console.WriteLine($"Your total balance after interest in {year} at the rate  years is {interest + balance:C}.");
                Console.WriteLine("");

                Console.WriteLine($"you need {5 - year} more year to get interest rate of 7.5%.");
                Console.WriteLine("");
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}
