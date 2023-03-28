using System;
/*
 * ==================      Test #2       ==================
 * 
 * Name: Ujjwal Poudel
 * Student ID: 301284284
 *
 * Question 2A.
 * 8 Marks.
 *
 * Write a program that prints multiples of 9 in descending 
 * order on a single line.
 * The program prompts the user for the start value. 
 * 
 * Type of loop-> while
 * 
 * Sample Executable: Q2A_win.exe Q2A_mac.exe
 * Solution folder 
 */

namespace Question_2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            while (value >= 9)
            {
                if(value % 9 == 0)
                {
                    Console.Write($"{value} ");
                }
                value--;
            }
        }
    }
}
