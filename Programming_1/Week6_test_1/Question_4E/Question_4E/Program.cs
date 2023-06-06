using System;

namespace Question_4E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ====================      Test #1      ====================
             * 
             * Name: Ujjwal Poudel
             * Student ID: 30124284
             *
             * Question 4e.
             * 9 Marks.
             *
             * Write a program that prompts the user for the since her
             * last vaccination. If the time is less than 6 months, the
             * program calculates the number of day of protection left.
             * protection = (6 - month) * 30 days 
             
             * It the time is 6 months or longer, then it informs the
             * user that she should get a booster shot.
             * 
             * You may assume that there are 30 days in a month.
             * You must declare the value 30 and 6 as named constants
             */

            const int DAYS_IN_MONTH = 30;
            const int MONTHS_CHECKER = 6;
            Console.Write("How many months has passed since your last vaccination: ");
            int monthAfter = Convert.ToInt32(Console.ReadLine());

            if (monthAfter < MONTHS_CHECKER)
            {
                int protection = (MONTHS_CHECKER - monthAfter) * DAYS_IN_MONTH;
                Console.WriteLine($"You probably have {protection} days of protection left.");
            }
            else
            {
                Console.WriteLine("You should get a booster dose.");
            }
        }
    }
}
