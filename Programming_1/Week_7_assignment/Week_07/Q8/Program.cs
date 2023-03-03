using System;
/*
Same as the previous question but additionally displays the average of the numbers when the
loop terminates. You will need a counter but not as a loop terminator.
*/

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double counter = 1;
            double sum = 0;

            do
            {
                Console.Write("Enter an Integer: ");
                double number = Convert.ToDouble(Console.ReadLine());
                double average = (number + sum) / counter;
                Console.WriteLine($"The total average is {average}");
                sum = number + sum;
                counter++;
            }
            while (sum < 100);
        }
    }
}