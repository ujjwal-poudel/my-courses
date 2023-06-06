using System;
/*
 * ==================      Test #2       ==================
 * 
 * Name: Ujjwal Poudel
 * Student ID: 301284284
 *
 * Question 4b.
 * 12 Marks.
 *
 * Write a program that displays the table show in the 
 * sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = 2x^2 + x - 6
 *    
 * Type of loop-> your favorite (your MUST use a loop)
 * Hints:
 *  1) Generate the first column of all the rows using a
 *     Console.WriteLine() statement and a single expression 
 *     (use increment = 0.25, there will be rounding inthe output)
 *  2) Generate successive columns one at a time by adding 
 *     another expression
 *  3) Format using a column specifier (do not use tabs)
 * 
 * Sample Executable: Q4B_win.exe Q4B_mac.exe
 * Solution folder 
 */

namespace Question_4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  x     2x^2    x    -6      y");
            Console.WriteLine(" ----   ----   ----  ----   ----");
            Console.WriteLine("-2.50  12.50  -2.50 -6.00   4.00");

            double increament = 0.25;
            double x = -2.50;
            while(x != 2.00)
            {
                x += increament;
                double b = 2.00 * x * x;
                double d = -6.00;
                double y = (2 * x * 2) + x - 6.00;
                Console.WriteLine($"{x, 1:F2}{b, 7:F2}{x, 7:F2}{d, 7:F2}{y, 9:F2}");
            }
        }
    }
}
