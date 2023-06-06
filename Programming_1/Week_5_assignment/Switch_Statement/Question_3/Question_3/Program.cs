using System;

/*
 * 3. Write a program that allows the user to enter two integers and a character If the character is
A, add the two integers If it is S, subtract the second integer from the first else multiply the
integers Display the results of the arithmetic 
 */

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter any character: ");
            char character = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (character)
            {
                case 'A':
                    int sum = num1 + num2;
                    Console.WriteLine("The sum is {0}", sum);
                    break;

                case 'B':
                    int subtract = num1 - num2;
                    Console.WriteLine("The subtraction is {0}", subtract);
                    break;

                default:
                    int product = num1 * num2;
                    Console.WriteLine("The product is {0}", product);
                    break;
            }
        }
    }
}
