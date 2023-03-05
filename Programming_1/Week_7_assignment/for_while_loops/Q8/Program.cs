using System;
/*
 * Write a program that displays a conversion table from Fahrenheit to Celsius. The program must
 * request the starting Fahrenheit value, the ending Fahrenheit value, and the increment. Thus,
 * instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit
 * value. Your table must look professional!
 */

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting Fahrenheit value: ");
            double start = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter ending Fahrenheit value: ");
            double end = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the increament: ");
            double increament = Convert.ToDouble(Console.ReadLine());

            double celcius;

            ////while loop
            //Console.WriteLine(" Farenheit         Celcius");
            //Console.WriteLine("---------------------------");
            //while(start < end)
            //{
            //    celcius = (start - 32) * 10 / 18;
            //    Console.WriteLine($"{start, 6}{celcius, 14}");
            //    start += increament;
            //}

            //for loop
            Console.WriteLine(" Farenheit         Celcius");
            Console.WriteLine("---------------------------");
            for (;start < end; start = start + increament)
            {
                celcius = (start - 32) * 10 / 18;
                Console.WriteLine($"{start,8:F2}{celcius,17:F2}");
            }
            Console.ReadLine();
        }
    }
}
