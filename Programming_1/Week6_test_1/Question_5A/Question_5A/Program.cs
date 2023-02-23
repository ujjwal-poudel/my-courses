using System;

namespace Question_5A
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
             * Question 5A.
             * 12 Marks.
             *
             * TTC has asked you to Write a program that prompts the user 
             * for the category of rider. Based on the user's  input the 
             * program will display the following:
             * 
             * Input: student
             * Message: student pays $1.75
             * 
             * Input: ADULT
             * Message: ADULT pays $3.75
             * 
             * Input: Senior
             * Message: Senior pays $2.00
             * 
             * any other input
             * Message: I am sorry I don't know of that class of riders
             * 
             * You may use either the ToUpper() or ToLower() methods 
             * 
             * YOU MUST USE ONLY A SWITCH statement to solve this problem
             * [For full marks you need to accept all combinations of 
             * student, adult and senior]
             */

            Console.Write("What is your rider category: ");
            string category = Console.ReadLine().ToLower();

            switch (category)
            {
                case "student":
                    Console.WriteLine("Student Pays $1.75");
                    break;

                case "adult":
                    Console.WriteLine("ADULT Pays $2.00");
                    break;

                case "senior":
                    Console.WriteLine("Senior pays $2.00");
                    break;

                default:
                    Console.WriteLine("I am sorry I don't know of that class of riders");
                    break;
            }
        }
    }
}
