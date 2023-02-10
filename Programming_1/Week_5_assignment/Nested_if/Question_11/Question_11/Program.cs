using System;
/*
 * 11. Write a console-based program for a college’s admissions office. The user enters a numeric high
school grade point average (for example, 3.2) and an admission test score. Display the message
“Accept” if the student meets either of the following requirements:
A grade point average of 3.0 or higher and an admission test score of at least 60
A grade point average of less than 3.0 and an admission test score of at least 80
If the student does not meet either of the qualification criteria, display “Reject”.
 */

namespace Question_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your high school GPA: ");
            float gpa = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your admission testscore: ");
            float testScore = (float)Convert.ToDouble(Console.ReadLine());

            if ((gpa >= 3 && testScore >= 60) || (gpa < 3 && testScore >= 80))
            {
                Console.WriteLine("You are accepted");
            }
            else
            {
                Console.WriteLine("You are rejected");
            }
        }
    }
}
