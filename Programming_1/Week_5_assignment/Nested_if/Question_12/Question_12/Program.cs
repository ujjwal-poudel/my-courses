using System;

/*
 * 12. Write a console-based program for a lawn-mowing service. The lawn-mowing season lasts 20
weeks. The weekly fee for mowing a lot less than 400 square feet is $25. The fee for a lot that is 400
square feet or more, but less than 600 square feet, is $35 per week. The fee for a lot that is 600
square feet or over is $50 per week. Prompt the user for the length and width of a lawn, and then
display the weekly mowing fee, as well as the total fee for the 20-week season.
 */

namespace Question_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of your lawn in feet: ");
            float length = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of your lawn in feet: ");
            float width = (float)Convert.ToDouble(Console.ReadLine());

            float area = length * width;

            if (area < 400)
            {
                Console.WriteLine($"The weekly cost for {area} sq feet area lawn-mowing is {(25 * area):C}");
                Console.WriteLine($"The 20-week season cost for {area} sq feet area lawn-mowing is {(20 * 25 * area):C}");
            }
            else if (area >= 400 && area <600)
            {
                Console.WriteLine($"The weekly cost for {area} feet area lawn-mowing is {(35 * area):C}");
                Console.WriteLine($"The 20-week season cost for {area} sq feet area lawn-mowing is {(20 * 35 * area):C}");
            }
            else if (area >= 600)
            {
                Console.WriteLine($"The weekly cost for {area} sq feet area lawn-mowing is {(50 * area):C}");
                Console.WriteLine($"The 20-week season cost for {area} sq feet area lawn-mowing is {(20 * 50 * area):C}");
            }
            else
            {
                Console.WriteLine("Please enter valid length and width of your lawn");
            }
        }
    }
}
