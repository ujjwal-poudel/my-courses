using System;

/*
 * 5. Write a program that prompts the user for a day of the week. The program will display a
message based on the following table:

   Choice              Message
    Sun                 "Home"
    Mon                 "Work"
    Tue                 "Work"
    Wed                 "Home"
    Thu                 "Work"
    Fri                 "Work"
    Sat                 "Work"

 */

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first three letters of the day: ");
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "sun":
                    Console.WriteLine("Home");
                    break;

                case "mon":
                    Console.WriteLine("Work");
                    break;

                case "tue":
                    Console.WriteLine("Work");
                    break;

                case "wed":
                    Console.WriteLine("Home");
                    break;

                case "thu":
                    Console.WriteLine("Work");
                    break;

                case "fri":
                    Console.WriteLine("Work");
                    break;

                case "sat":
                    Console.WriteLine("Work");
                    break;

                default:
                    Console.WriteLine("Your choice is wrong");
                    break;

            }
        }
    }
}
