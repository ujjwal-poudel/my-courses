using System;
/*
 *  Write a console-based program that indicate and acceptance or rejection of a user’s message. A
    message is short enough for a social networking service if it does not comprise of more than 140
    characters. [Hint: if the user’s input is assigned to the variable message then message.Length
    will automatically give you the number of characters (i.e. the length of char that makes up that
    variable) in the variable message]
*/

namespace Q_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int number;

            Console.Write("Enter a short message: ");
            message = Console.ReadLine();

            number = message.Length;

            if (number > 150)
            {
                Console.WriteLine("Your letter count is {0}", number);
                Console.WriteLine("Thank you your message is long enough");
            }
            else
            {
                Console.WriteLine("Your words length is {0}", number);
                Console.WriteLine("Sorry your message is not lengthy. make sure to try again and reach character length of 140");
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}
