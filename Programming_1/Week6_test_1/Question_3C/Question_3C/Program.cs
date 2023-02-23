using System;

namespace Question_3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ====================      Test #1      ====================
             * 
             * Name: Ujjwal Poudel
             * Student ID: 301284284
             *
             * Question 3c.
             * 6 Marks.
             *
             * Write a program that prompts the user for a number. The 
             * program prints the number and the letter equivalent. The 
             * letter equivalent is obtained by casting the double to a 
             * char. You must match the format exactly.
             * 
             * YOU MUST READ IN THE INPUT AS A double and you must do an explicit cast
             * [For testing purposes, use a number in the range 48 to 90]
             */

            Console.Write("Enter the value as double: ");
            double value = Convert.ToDouble(Console.ReadLine());
            char character = (char) value;
            Console.WriteLine($"The number {value} corresponds to letter {character}");
        }
    }
}
