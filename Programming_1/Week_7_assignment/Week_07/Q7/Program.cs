using System;
/*
 * To repeatedly prompt for a number and sum it. When the sum just exceeds 100, stop the
prompting and display the sum at the end. You must not display the sum while the user in
typing in numbers. (You do not need a counter but you will need some way of terminating the
loop)
 */

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adder = 0;
            int sum;

            do 
            {
                Console.Write("Enter an Integer: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum = number + adder;
                Console.WriteLine($"The total sum is {sum}");
                adder = sum;
            } 
            while (sum < 100);
        }
    }
}
