using System;

namespace part_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The fees is {CalculateTuitionFee(6, 449.99):C}");
            Console.WriteLine($"The fees is {CalculateTuitionFee(7, 330.66):C}");
            Console.WriteLine($"The fees is {CalculateTuitionFee(3, 880.34):C}");

            Console.WriteLine($"\nThe commission is {CalculateCommission(900):C}");
            Console.WriteLine($"\nThe commission is {CalculateCommission(1000):C}");
            Console.WriteLine($"\nThe commission is {CalculateCommission(1001):C}");
            Console.WriteLine($"\nThe commission is {CalculateCommission(2000):C}");

            Console.WriteLine($"The burger cost is {CalculateBurgerCosts():C}");
            Console.WriteLine($"\nThe burger cost is {CalculateBurgerCosts():C}");

            Console.WriteLine($"\nThe force of attraction is {CalculateGravitationalAttraction(5.972 * Math.Pow(10, 24), 7.348 * Math.Pow(10, 22), 3.844 * Math.Pow(10, 7)):e}N");

            Console.WriteLine($"\nThe burger cost is {CalculateHeronAreaOfTraingle(5.83, 4.24, 8.00):F}");

            Console.WriteLine($"\nThe temperature in farenheit is {ConvertCelciusToFahrenheit(0):F}");
            Console.WriteLine($"\nThe temperature in farenheit is {ConvertCelciusToFahrenheit(51):F}");
            Console.WriteLine($"\nThe temperature in farenheit is {ConvertCelciusToFahrenheit(100):F}");

            Console.WriteLine($"\nThe temperature in celcius is {ConvertFahrenheitToCelcius(0):F}");
            Console.WriteLine($"\nThe temperature in celcius is {ConvertFahrenheitToCelcius(123.8):F}");
            Console.WriteLine($"\nThe temperature in celcius is {ConvertFahrenheitToCelcius(212):F}");

            Console.WriteLine($"\nThe temperature in kelvin is {ConvertFahrenheitToKelvin(0):F}");
            Console.WriteLine($"\nThe temperature in kelvin is {ConvertFahrenheitToKelvin(123.8):F}");
            Console.WriteLine($"\nThe temperature in kelvin is {ConvertFahrenheitToKelvin(212):F}");
        }

        #region Question_3
        /* 3. Write a method called CaculateTuitionFee(int numberOfCourses,
         * double costPerCourse = 449.99). This method will calculate and return
         * the required fees amount. [Fees = number of courses * cost per course + 15.25].
         * Call the CaculateTuitionFee() method four times from your program Main()
         * method supplying different arguments each time.
         * 
         */

        static double CalculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;
            return fees;
        }
        #endregion

        #region Question_4
        /* 4. Write a method called CalculateCommission(double saleAmount). This
         * method will calculate and return a sales representation’s commission. [over $1000
         * the commission will be 1%].
         * Call the CalculateCommission() method three times from your program
         * Main() method, supplying arguments 900, 1000, 1001 and 2000.
         * 
         */

        static double CalculateCommission(double saleAmount)
        {
            int commissionLimit = 1000;
            double commission;

            if (saleAmount > commissionLimit)
            {
                commission = 0.01 * saleAmount;
                return commission;
            }
            
            else
            {
                commission = 0;
                return commission;
            }
            
        }
        #endregion

        #region Question_5
        /* 5. Write a method that does not take any argument. The method will prompt the user
         * for the number of burgers that he wants to buy. The method will calculate and 
         * return the amount of money that will be required. [One burger cost $1.39].
         * From your program Main() method, call the above method two times
         * 
         */

        static double CalculateBurgerCosts()
        {
            double burgerCosts = 1.39;
            Console.Write("Enter the number of burgers you want to have: ");
            int burgerNum = Convert.ToInt32(Console.ReadLine());
            double requiredAmount = burgerCosts * burgerNum;
            return requiredAmount;
        }
        #endregion

        #region Question_6
        /* 6. “Newton's law of universal gravitation states
         * that every point mass in the universe attracts
         * every other point mass with a force that is
         * directly proportional to the product of their
         * masses and inversely proportional to the
         * square of the distance between them.” Write a method called
         * CalculateGravitationalAttraction() that takes three double
         * arguments (masses of the two bodies and the distance between them). The method
         * will calculate and return the force of attraction between them. [ F=G m1 m2
         * d2 ,
         * where G = 6.673x10-11].
         * In your main call this method with the masses of the earth, moon and the distance
         * between them and display the resulting force. Mass of Earth = 5.972 × 1024, moon =
         * 7.348 × 1022, Distance = 384,400000m. [Answer 1.982 x 1020N].
         */

        static double CalculateGravitationalAttraction(double massOne, double massTwo, double distance) 
        {
            double forceOfAttraction = (6.673 * massOne * massTwo) / Math.Pow(distance, 2);
            return forceOfAttraction;
        }
        #endregion

        #region Question_7
        /* 7. Heron’s formula allows you to calculate the area of any triangle given the length of
         * the three sides. Write a method that takes the length of the three sides and return
         * the area of the specified triangle. A= √s ( s−a ) ( s−b ) ( s−c ) where s= a+ b+c /
         * 2. In your main call this method with arguments 5.83, 4.24 and 8.00, and display the
         * area. [Answer = 11.99].
         */

        static double CalculateHeronAreaOfTraingle(double sideA, double sideB, double sideC)
        {
            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            return area;
        }
        #endregion

        #region Question_8
        /* 8. Write a method called ConvertCelsiusToFahrenheit that takes a double
         * argument. The method will calculate and return the Fahrenheit equivalent of the
         * argument. [F = C * 9 / 5 + 32].
         * In your main call this method three times with arguments 0, 51 and 100 respectively
         * and display the results.
         */

        static double ConvertCelciusToFahrenheit(double celcius)
        {
            double farenheit = ((celcius * 9) / 5) + 32;
            return farenheit;
        }
        #endregion

        #region Question_9
        /* 9. Write a method called ConvertFahrenheitToCelsius that takes a double
         * argument. The method will calculate and return the Celsius equivalent of the
         * argument. [C = (F – 32) * 5 / 9].
         * In your main call this method three times with arguments 0, 123.8 and 212
         * respectively and display the results.
         * 
         */

        static double ConvertFahrenheitToCelcius(double farenheit)
        {
            double celcius = (farenheit - 32) * (5.0 / 9.00);
            return celcius;
        }
        #endregion

        #region Question_10
        /* 10. Write a method called ConvertCelsiusToKelvin that takes a double
         * argument. The method will calculate and return the Kelvin equivalent of the
         * argument. [K = C + 273.15].
         * In your main call this method three times with arguments -196, 0 and 100
         * respectively and display the results.
         */

        static double CelciusToKelvin(double celcius)
        {
            double kelvin = celcius + 273.15;
            return kelvin;
        }
        #endregion

        #region Question_11
        /* 11. Write a method call
         * ConvertFahrenheitToKelvin that takes a
         * double argument. The method will calculate and
         * return the Kelvin equivalent of the argument.
         * [DO NOT RE-CODE THIS METHOD. Use the two
         * previous methods to assist in your computation].
         * In your main call this method three times and display the results.
         * 
         */

        static double ConvertFahrenheitToKelvin(double farenheit)
        {
            double celcius = ConvertCelciusToFahrenheit(farenheit);
            double kelvin = CelciusToKelvin(celcius);
            return kelvin;
        }
        #endregion
    }
}
