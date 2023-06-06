using System;

namespace Question_6D
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
             * Question 6D.
             * 14 Marks.
             *
             * Write a program that prompts the user for the kind of camera
             * that she would like to buy. Based on the user's input the 
             * program will display the following:
             * 
             * Input: nikon
             * Message: A nikon camera cost $240.99
             * 
             * Input: CANON
             * Message: A CANON camera cost $225.99
             * 
             * Input: Panasonic
             * Message: A Panasonic camera cost $199.99
             * 
             * any other input (e.g. fujitsu)
             * Message: I am sorry we don't carry fujitsu cameras
             * 
             * You may use either the ToUpper() or ToLower() methods 
             * 
             * You MUST USE ONLY NESTED if-statement to solve this problem
             * [For full marks you need to accept all permutations of 
             * Nikon, Cannon and Panasonic]
             */

            Console.Write("What kind of camera would you like to buy: ");
            string cameraType = Console.ReadLine().ToLower();

            if (cameraType == "nikon")
            {
                Console.WriteLine("A nikon camera cost $240.99");
            }

            else if (cameraType == "panasonic")
            {
                Console.WriteLine("A Panasonic camera cost $199.99");
            }

            else if (cameraType == "canon")
            {
                Console.WriteLine("A CANON camera cost $225.99");
            }

            else
            {
                Console.WriteLine($"I am sorry we don't carry {cameraType} cameras");
            }
        }
    }
}
