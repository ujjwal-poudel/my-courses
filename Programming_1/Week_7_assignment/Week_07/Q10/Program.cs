  using System;
/*
 * A conversion table of Celsius to Fahrenheit temperature. The table must start with 100
 * Celsius and end at 0 Celsius with decrements of 10. (Fahrenheit = 9/5 * Celsius +
 * 32). Your table must have a suitable header and the values in the table must be right-align
 * like the output of question 11.
 */

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = 100;
            Console.WriteLine("Celcius    Fahrenheit");;
            do
            {
                Console.Write($"{celcius, 5}");
                double fahrenheit = 9 / 5 * (celcius + 32);
                Console.WriteLine($"{fahrenheit, 13}");
                celcius -= 10;
            }
            while (celcius > 0);
        }
    }
}
