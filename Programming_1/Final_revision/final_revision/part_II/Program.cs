using System;
using System.Runtime.CompilerServices;

namespace part_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayHorizontalStars(0);
            Console.WriteLine();
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
            DisplayVerticalStars(0);
            DisplayVerticalStars(5);
            DisplayVerticalStars(10);
            CalculateVolumeOfSphere(1);
            CalculateVolumeOfSphere(2);
            CalculateVolumeOfSphere(10);
            CelsiusToDouble(37.0);
            CelsiusToDouble(101.43);
            KilometerToMilesConversion(5.0, 1.0, 15);
            KilometerToMilesConversion(8.343, 2.34, 10);
            KilometerToMilesConversion(12.45, 0.01, 6);
            DisplaySineTable(0, 1, 9);
            CentimetersToMeters(90);
            CentimetersToMeters(120);
            CentimetersToMeters(275);

        }

        #region Question_1
        /*
         * 1. Write a method called
         * DisplayHorizontalStars(int
         * numberOfStars). This method will
         * output the number of stars horizontally
         * specified by its argument. Call the
         * DisplayHorizontalStars()
         * method three times from your program
         * Main() method, supplying 0, 5 and 10
         * respectively for the number of stars.
         */

        static void DisplayHorizontalStars(int numOfStars)
        {
            for (int i = 0;i < numOfStars; i++)
            {
                Console.Write($"* ");
            }
        }
        #endregion

        #region Question_2
        /*
         * 2. Write a method similar to the one above that displays a vertical line of stars.
         * Call this method three times with arguments 0, 5 and 10 respectively.
         */

        static void DisplayVerticalStars(int numOfStars)
        {
            for (int i = 0; i < numOfStars; i++)
            {
                Console.WriteLine($"*");
            }
        }
        #endregion

        #region Question_3
        /*
         * 3. Write a method that accepts an argument of type double. The method will calculate
         * and display the volume of a sphere with radius specified by its argument. [
         * V = 4
         * 3 π r3].
         * Call this method from your main three times, with arguments 1, 2, and 10
         * respectively. The answers are 4.1888, 33.5103 and 4188.7902 respectively.
         * Use Math.PI for the value of π
         */

        static void CalculateVolumeOfSphere(double radius)
        {
            double volume = (Math.PI * radius * radius * radius) * 4.0000/3.0000;
            Console.WriteLine($"The volume of sphere with radius {radius:F4} is {volume:F4}.");
        }
        #endregion

        #region Question_4
        /*
         * 4. Write a method that takes two arguments: a cost price and a two-letter province
         * code. It will calculate and display the selling price. (If province is Ontario a tax of
         * 13% is added to the price, if the province is Quebec a tax of 17% is added to the cost
         * price. There is no tax for the rest of the provinces and territories).
         * In your main, call this method enough times to fully test it
         */

        static void DisplaySellingPrice(double costPrice, string provinceCode)
        {
            double sellingPrice;
            switch (provinceCode.ToUpper()) 
            {
                case "ON":
                    sellingPrice = (0.13 * costPrice) + costPrice;
                    break;

                case "QC":
                    sellingPrice = (0.17 * costPrice) + costPrice;
                    break;

                default:
                    sellingPrice = costPrice;
                    break;
            }

            Console.WriteLine($"The selling price with tax is {sellingPrice:F}.");
        }

        #endregion

        #region Question_5
        /*
         * 5. Write a method that takes a single argument of type double. The will display a
         * Celsius to Fahrenheit conversion table. The starting temperature is indicated by the
         * argument and it will display 10 lines in increments of 1. [Fahrenheit = 9/5
         * Celsius + 32].
         * In your main call this method two times, each time with a different start value.
         */

        static void CelsiusToDouble(double celsius)
        {

            Console.WriteLine("Celsius    Farenheit");
            for (int i = 0; i < 10; i++) 
            {
                double farenheit = (celsius + 32.00) * 9.00/7.00;
                Console.WriteLine($"{celsius,1:F}{farenheit,12:F}");
                celsius += 1.00;
            }
        }
        #endregion

        #region Question_6
        /*
         * 6. Write a method that takes the following arguments: a starting km value of type
         * double, an increment size of type double and the number of lines of type int. The
         * display a kilometer to miles conversion table. [miles = km * 0.621371].
         * In your main call this method three times, each time with different values.
         */

        static void KilometerToMilesConversion(double startingKm, double increamentSize, int numberOfLines)
        {
            Console.WriteLine("Kilometers    Miles");
            for (int i = 0; i < numberOfLines; i++ )
            {
                double miles = startingKm * 0.621371;
                Console.WriteLine($"{startingKm,1:F2}{miles,14:F2}");
                startingKm += increamentSize;
            }
        }
        #endregion

        #region Question_7
        /*
         * 7. Modify the DisplaySineTable() method in the previous section to accept the
         * start value, the step size and number of rows as argument to the method.
         */

        static void DisplaySineTable(double startValue, double stepSize, int rows)
        {
            Console.WriteLine("Sine     Value");
            for (int i = 0; i < rows; i++)
            {
                double value = Math.Sin(startValue);
                Console.WriteLine($"{startValue,1:F}{value,11:F4}");
                startValue += stepSize;
            }
        }
        #endregion

        #region Question_8
        /*
         * 8. Write a method that converts a person’s height from centimeter to meters and
         * centimeters and display the result on the console.
         * In your main method, you should call this method three times with argument 90,
         * 120 and 275.
         * Input Result
         * 90cm 0m 90cm
         * 120cm 1m 20 cm
         * 275cm 2m 75cm
         */

        static void CentimetersToMeters(double centimeters)
        {
            int m = 0;
            //this is the meter in integer
            double meter;
            double remainingCm;

            if (centimeters < 100)
            {
                meter = 0;
                remainingCm = centimeters;
            }

            else
            {
                meter = centimeters / 100;
                m = (int) meter;
                remainingCm = (meter - m) * 100;
            }
            Console.WriteLine($"{centimeters,1:F0}cm{m,9}m{remainingCm,3:F0}cm");
        }
        #endregion
    }
}
