using System;
/*
    Write an application that asks a user to enter an IQ score. If the score is a number less than 0 or
    greater than 200, issue an error message; otherwise, issue an “above average”, “average”, or
    "below average” message for scores over, at, or under 100, respectively 
 */

namespace Q_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plese enter your IQ score: ");
            double iq = Convert.ToDouble(Console.ReadLine());

            if (iq > 0 && iq < 200)
            {
                if (iq > 100)
                {
                    Console.WriteLine("Wow, you got above average iq");
                }
                else if (iq == 100)
                {
                    Console.WriteLine("Cool you got average iq");
                }
                else
                {
                    Console.WriteLine("Your iq is below average, but never mind");
                }
            }
            else
            {
                Console.WriteLine("Error, You need to enter a valid iq between 0 and 200");
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}
