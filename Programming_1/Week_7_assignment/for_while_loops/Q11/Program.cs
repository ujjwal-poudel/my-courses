using System;
/*
 * Print the decimal, octal, and hexadecimal values of all characters between the start and stop
 * characters entered by a user. For example, if the user enters an a and a z, the program should
 * print all the characters between a and z and their respective numerical values. Make sure that the
 * second character entered by the user occurs later in the alphabet than the first character. If it does
 * not, write a loop that repeatedly asks the user for a valid second character until one is entered.
 * Your output should be formatted as shown below
 * Letter Decimal  Octal  Hex
 *   a      97      141   61
 *   b      98      142   62
 *   c      99      143   63
 *   d      100     144   64
 *   e      101     145   65
 * to obtain an int from a char use an explicit cast
 * to obtain an octal from an int use Convert.ToString(«number_value», 8)
 * to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)
 */

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start, end;
            //while loop
            while (true)
            {
                Console.Write("Enter starting character from a to z: ");
                start = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter ending character from a to z: ");
                end = Convert.ToChar(Console.ReadLine());

                if (end > start)
                {
                    break;
                }
            }

            Console.WriteLine("Letter Decimal Octal Hex");
            while (start<= end)
            {
                int decimalValue = (int)start;
                string octalValue = Convert.ToString(decimalValue, 8);
                string hexValue = Convert.ToString(decimalValue, 16);
                Console.WriteLine($"{start,3}{decimalValue,9}{octalValue,7}{hexValue,4}");
                start++;
            }

            ////for loop
            //for (;;)
            //{
            //    Console.Write("Enter the first letter in alphabet: ");
            //    start = Convert.ToChar(Console.ReadLine());

            //    Console.Write("Enter the second letter in alphabet: ");
            //    end = Convert.ToChar(Console.ReadLine());

            //    if (end > start)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("Letter Decimal Octal Hex");
            //for (;start <= end;)
            //{
            //    int decimalValue = (int)start;
            //    string octalValue = Convert.ToString(decimalValue, 8);
            //    string hexValue = Convert.ToString(decimalValue, 16);
            //    Console.WriteLine($"{start, 3}{decimalValue, 9}{octalValue, 7}{hexValue, 4}");
            //    start++;
            //}
        }
    }
}
