using System;

/*
 * 4. Write a program that prompts the user for the number of courses and residency status
(domestic or international) and calculates tuition cost. Cost is calculated based on the table
below.

        Domestic                                $325 per course
        International                           $1375 per course

You decide how you want the user to enter her/his residency status and prompt accordingly,
also you should use named constants for the cost per course
 */

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DOM_COURSE_FEE = 325;
            const int IN_COURSE_FEE = 1375;

            Console.Write("Enter the number of courses you want to take: ");
            int courseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your residency status (D or I): ");
            char residency = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (residency) 
            {
                case 'D':
                    int courseFee = DOM_COURSE_FEE * courseNum;
                    Console.WriteLine($"Your course fee is {courseFee}");
                    break;

                case 'I':
                    courseFee = IN_COURSE_FEE * courseNum;
                    Console.WriteLine($"Your course fee is {courseFee}");
                    break;
            }
        }
    }
}
