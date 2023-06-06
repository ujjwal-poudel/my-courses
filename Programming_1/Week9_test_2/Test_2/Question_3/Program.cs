using System;
using System.Diagnostics;
/*
* ==================      Test #2       ==================
* 
* Name: Ujjwal Poudel
* Student ID:301284284
*
* Question 3B.
* 10 Marks.
*
* Write a program that prints decrements of 7 on a single
* line. The program prompts the user for the starting 
* value the end value will be 0 or the first negative 
* number. 
* 
* Type of loop-> for
* 
* Sample Executable: Q3B_win.exe Q3B_mac.exe
* Solution folder 
*/

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            int decrement = number;

            for(;decrement > 0; )
            {
                Console.Write($"{decrement} ");
                decrement = decrement - 7;
                counter++;
            }
            Console.WriteLine($"\nIt will take {counter} decreaments will reach {decrement}");
        }
    }
}
