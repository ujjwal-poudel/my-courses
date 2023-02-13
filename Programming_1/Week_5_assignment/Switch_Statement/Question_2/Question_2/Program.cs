using System;

/*
2. Write a program that prompts the user for a menu choice. The program will display a
message based on the following table:

Choice                       Message
1                            "Calculate area"
2                            "Calculate volume"
3                            "Calculate surface area"
0                            "Exit the program"
<< any other input>>         "ERROR: Invalid choice "

If the user responds with a 1 after the program prompt, the program will display "Calculate area".
Etc.
 */

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Exit the program");
                    break;

                case 1:
                    Console.WriteLine("Calculate area");
                    break;
                case 2:
                    Console.WriteLine("Calculate volume");
                    break;

                case 3:
                    Console.WriteLine("Calculate surface area");
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid choice");
                    break;
            }
        }
    }
}
