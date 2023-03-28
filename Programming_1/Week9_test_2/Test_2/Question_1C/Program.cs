using System;
/*
 * ==================      Test #2       ==================
 * 
 * Name: Ujjwal Poudel
 * Student ID: 301284284
 *
 * Question 1C.
 * 10 Marks.
 *
 * Write a program that adds the user input to reach a 
 * target. When the sum reaches or just exceeds the target, 
 * the program prints the final sum and the number of user 
 * inputs required.
 * 
 * Type of loop-> do-while
 * 
 * Sample Executable: Q1C_win.exe Q1C_mac.exe
 * Solution folder 
 */

namespace Question_1C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target value: ");
            int targetValue = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            do
            {
                Console.Write($"Enter #{counter+1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                counter++;
            }
            while (sum < targetValue);

            Console.WriteLine($"It took {counter} inputs to take the sum to {targetValue}");
        }
    }
}
