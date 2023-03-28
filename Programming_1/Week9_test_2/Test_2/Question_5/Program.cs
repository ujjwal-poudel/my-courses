using System;
/*
 * ==================      Test #2       ==================
 * 
 * Name: Ujjwal Poudel
 * Student ID: 301284284
 *
 * Question 5b.
 * 14 Marks.
 *
 * Write a program that displays the pattern show in the 
 * sample executable.
 * 
 * Type of loop-> your favorite (you must use a pair of 
 * nested loops)
 * Hints:
 *  1) Use variables that increments
 *  2) When running the sample, use values between 61 and 
 *     76 for the number of columns, values between 16 and 
 *     21 the number of rows
 *  3) Start with a vertical line of "+" then repeat it as 
 *     necessary (use the % operator)
 *  4) Again start with a horizontal line of "+" then 
 *     repeat it as necessary. (use the % operator)
 *  5) Now combine the two above conditions
 * 
 * Sample Executable: Q5B_win.exe Q5B_mac.exe
 * Solution folder 
 */

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (i == 1 || j == 1 || i == 6 || j == 6)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
