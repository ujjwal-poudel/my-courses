using System;
/*
 * 6. Write a program for a furniture company. Ask the user to choose Pine, Oak or Mahogany.
Show the price of a table manufactured with the chosen wood Pine tables cost $100, Oak
tables cost $225, and Mahogany tables cost $310. You must use named constants and switch.
Also you must be able to accept any variation on the case. E.g. Pine, pine PINE, pinE, Pine ...
should give $100.
 */

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int OAK = 225; 
            const int MAHOGANY = 310;
            const int PINE = 100;

            Console.Write("Enter the wood for table: ");
            string wood = Console.ReadLine().ToLower();

            switch (wood)
            {
                case "pine":
                    Console.WriteLine($"The table cost is {PINE:C}");
                    break;

                case "mahogany":
                    Console.WriteLine($"The table cost is {MAHOGANY:C}");
                    break;

                case "oak":
                    Console.WriteLine($"The table cost is {OAK:C}");
                    break;

                default:
                    Console.WriteLine("Please enter a valid wood name (oak or mahogany or pine)");
                    break;
            }
        }
    }
}
