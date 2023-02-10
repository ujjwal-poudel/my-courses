using System;
using System.Runtime.InteropServices;

/*
 * 13. To the Lawn application you created in the above question, add a prompt that asks the user
whether the customer wants to pay (1) once, (2) twice, or(3) 20 times per season. If the user enters
1 for once, the fee for the season is simply the seasonal total. If the customer requests two
payments, each payment is half the seasonal fee plus a $5 service charge. If the user requests 20
separate payments, add a $3 service charge per week. Display the number of payments the
customer must make, each payment amount, and the total for the season.
*/

namespace Question_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of your lawn in feet: ");
            float length = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of your lawn in feet: ");
            float width = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("In how many times you want to pay (1 or 2 or 20): ");
            int pay = Convert.ToInt32(Console.ReadLine());

            float area = length * width;

            if (pay == 1)
            {
                float charge = 20 * 25 * area;
                if (area < 1)
                {
                    Console.WriteLine("Please enter valid length and width of your lawn");
                }
                else if (area < 400)
                {
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge:C}");
                }
                else if (area >= 400 && area < 600)
                {
                    charge = 20 * 35 * area;
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge:C}");
                }
                else
                {
                    charge = 20 * 50 * area;
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge:C}");
                }
            }

            else if (pay == 2)
            {
                float charge = ((20 * 25 * area) / 2) + 5;

                if (area < 1)
                {
                    Console.WriteLine("Please enter valid length and width of your lawn");
                }
                else if (area < 400)
                {
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge * 2:C}");
                }
                else if (area >= 400 && area < 600)
                {
                    charge = ((20 * 35 * area) / 2) + 5;
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge * 2:C}");
                }
                else
                {
                    charge = ((20 * 50 * area) / 2) + 5;
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge * 2:C}");
                }
            }

            else if (pay == 20)
            {
                float charge = ((20 * 25 * area) / 20) + 3;

                if (area < 1)
                {
                    Console.WriteLine("Please enter valid length and width of your lawn");
                }
                else if (area < 400)
                {
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge * 20:C}");
                }
                else if (area >= 400 && area < 600)
                {
                    charge = ((20 * 35 * area) / 20) + 3;
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge * 20:C}");
                }
                else
                {
                    charge = ((20 * 50 * area) / 20) + 3;
                    Console.WriteLine($"The first payment for lawn-mowing this season is {charge:C}");
                    Console.WriteLine($"The total payment amount this season is {charge * 20:C}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid pay term !");
            }
        }
    }
}
