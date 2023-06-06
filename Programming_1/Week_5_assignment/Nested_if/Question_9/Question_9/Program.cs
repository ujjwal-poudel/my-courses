using System;

/*
 * 9. Write a console-based application that asks a user to enter an IQ score. If the score is a number less
      than 0 or greater than 200, issue an error message; otherwise, issue an “above average”, “average”,
      or “below average” message for scores over, at, or under 100, respectively.
 */

namespace Question_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your IQ score: ");
            int iq = Convert.ToInt32(Console.ReadLine());

            if (iq < 0 || iq > 200) 
            {
                Console.WriteLine("Please enter your IQ between 0 to 200");
            }
            else
            {
                if (iq == 100)
                {
                    Console.WriteLine("Your got average IQ");
                }
                else if (iq < 100)
                {
                    Console.WriteLine("Your got low IQ");
                }
                else if (iq > 100)
                {
                    Console.WriteLine("Your got high IQ");
                }
                else
                {
                    Console.WriteLine("Please enter your IQ between 0 to 200");
                }
            }
        }
    }
}
