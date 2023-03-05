using System;
/*
* Write a C program that continuously requests a grade.
* If the grade is less than 0 or greater than 100, your program should
* print an appropriate message informing the user that an invalid
* grade has been entered,
* else the grade should be added to a total.
* 
* If the grade is 999, the program should exit the loop and display the sum, number of valid grades
* and the average of the valid grades entered. (You must NOT display an invalid message)
* P.S. The value 999 is use to terminate the cycle and should not be used in any of the calculation.
* You must not display an “Invalid grade”
*/

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            double total = grade;
            double counter = 1;

            ////while loop 
            //while (true)
            //{
            //    Console.Write("Enter your grade: ");
            //    grade = Convert.ToDouble(Console.ReadLine());

            //    if (grade > 0 && grade < 100)
            //    {
            //        counter++;
            //        total += grade;
            //    }

            //    else if (grade == 999)
            //    {
            //        double average = total / counter;
            //        Console.WriteLine($"Your total grade is {total:F2}");
            //        Console.WriteLine($"Your valid grade count is {counter}");
            //        Console.WriteLine($"Your average is {average:F2}");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Sorry, the grade should between 0 to 100. Press 999 to exit");
            //    }
            //}

            //for loop
            for (;;)
            {
                Console.Write("Enter your grade: ");
                grade = Convert.ToDouble(Console.ReadLine());

                if (grade > 0 && grade < 100)
                {
                    counter++;
                    total += grade;
                }

                else if (grade == 999)
                {
                    double average = total / counter;
                    Console.WriteLine($"Your total grade is {total:F2}");
                    Console.WriteLine($"Your valid grade count is {counter}");
                    Console.WriteLine($"Your average is {average:F2}");
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, the grade should between 0 to 100. Press 999 to exit");
                }
            }
        }
    }
}