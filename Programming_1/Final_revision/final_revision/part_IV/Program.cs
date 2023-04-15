using System;

namespace part_IV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question 1*/
            int varA = 2; int varB = 3;
            Console.WriteLine($"The first variable is {varA}");
            Console.WriteLine($"The second variable is {varB}");
            CubeIt(varA, ref varB);
            Console.WriteLine($"The cube is {varB}");

            /*Question 2*/
            int varCubeA = 5;
            int varCubeB = 7;
            Console.WriteLine($" Before calling method varcubeB is {varCubeB}");
            CubeIt(varCubeA, ref varCubeB);
            Console.WriteLine($"After calling method varcubeB is {varCubeB}");

            int varCubeC = 2;
            int varCubeD = 3;
            Console.WriteLine($" Before calling method varcubeD is {varCubeD}");
            CubeIt(varCubeC, ref varCubeD);
            Console.WriteLine($"After calling method varcubeD is {varCubeD}");

            /*Question 3*/
            double varC = 2, varD = 3, varE = 4, varF = 5;
            Console.WriteLine($"The variable C {varC}");
            Console.WriteLine($"The variable D {varD}");
            Console.WriteLine($"The variable E {varE}");
            Console.WriteLine($"The variable F {varF}");

            CalculateTuitionFee(2, 330, ref varC);
            Console.WriteLine(varC);

            CalculateTuitionFee(3, 340, ref varD);
            Console.WriteLine(varD);

            CalculateTuitionFee(4, 350, ref varE);
            Console.WriteLine(varE);

            CalculateTuitionFee(5, 360, ref varF);
            Console.WriteLine(varF);

            /*Question 4*/
            int varG = 2, varH = 3, varI = 4, varJ = 5, varK = 6, varL = 7;
            Console.WriteLine($"The variable G {varG}");
            Console.WriteLine($"The variable H {varH}");
            SumAndDifference(1, 1, ref varG, ref varH);
            Console.WriteLine($"new varG is {varG} and varH {varH}");


            Console.WriteLine($"The variable I {varI}");
            Console.WriteLine($"The variable J {varJ}");
            SumAndDifference(3, 2, ref varI, ref varJ);
            Console.WriteLine($"new varI is {varI} and varJ {varJ}");

            Console.WriteLine($"The variable K {varK}");
            Console.WriteLine($"The variable L {varL}");
            SumAndDifference(5, 3, ref varK, ref varL);
            Console.WriteLine($"new varK is {varK} and varL {varL}");

            /*Question_5*/
            double degrees = 0;
            double sine;
            double cosine;
            double tangent;

            Console.WriteLine("degrees    sine    cosine    tangent");
            do
            {
                CalculateTrigValues(degrees, out sine, out cosine, out tangent);
                degrees += 5;
            }
            while (degrees < 100);

            /*Question_6*/
            double radian = 0.50;
            double sin;
            double cos;

            Console.WriteLine($"radian    sine    cosine");
            do
            {
                CalculateSineAndCosine(radian, out sin, out cos);
                radian += 0.01;
            }
            while (radian < 1);
        }

        #region Question_2
        /*
         * 2. Write a method call CubeIt(int x, ref
         * int cube) that takes two arguments and does not return a value. The method
         * will cube the first argument and assign it to the second argument.
         * In your main create two variables and print them, call this method and print the
         * value of both of the parameters after the method call. Change the first parameter
         * and repeat.
         */

        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
        #endregion 

        #region Question_3
        /*
         * 3. Write a method with the following header: static void
         * CalculateTuitionFee(int numberOfCourses, double
         * costPerCourse, ref double fees). This method will calculate and assign
         * the required fees amount to the third argument. [Fees = number of courses * cost
         * per course + 15.25]. [Use variable when invoking the method and when printing.]
         * From your program Main() method, call the CalculateTuitionFee ()
         * method four times supplying different arguments each time and display the value of
         * the third argument after each method call.
         */

        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = (costPerCourse * costPerCourse) + 15.25;
        }
        #endregion

        #region Question_4
        /*
         * 4. Write a method that takes four parameter of type int. The method will assign the
         * sum of the first two arguments to the third and the difference of the first two to the
         * fourth. This method should be coded so that the calling method will use the value of
         * the third and fourth parameters. [Do not use the Math.Abs() method.]
         * Call this method about three times and print out the value of the four parameters
         * after each method call.
         */

        static void SumAndDifference(int numA, int numB, ref int sum, ref int difference) 
        {
            sum = numA + numB;
            difference = numA- numB;
        }
        #endregion

        #region Question_5
        /*
         * 5. Write a method with header static void
         * CalculateTrigValues(double
         * degrees, out double sine, out double cosine, out double tangent).
         * The method will use the first argument to compute the values of the
         * other three arguments. Used the method Math.Sin, Math.Cos and Math.Tan
         * to compute the second to fourth arguments respectively. [radians = degrees
         * * Math.Pi /180].
         *
         * In the Main() method, invoke this method 20 times with the first argument taking
         * the values 0, 5, 10, ... 95 and display the four arguments in a professional tabular
         * format
         */

        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            sine = Math.Sin(degrees * Math.PI / 180);
            cosine = Math.Cos(degrees * Math.PI / 180);
            tangent = Math.Tan(degrees * Math.PI / 180);
            Console.WriteLine($"{degrees, 4:F}{sine, 10:F}{cosine, 10:F}{tangent, 10:F}");
        }

        #endregion

        #region Question_6
        /*
         * 6. Write a method that takes three parameters of
         * type double: the first represents an angle, the
         * other two represents the sine and cosine of the angle respectively. The method
         * must be able to change the actual value of the second and third argument. In your
         * Main() method, call this method ten times with values 0.50, 0.51, 0.52 ... 0.59 and
         * printout the values for angle, sine and cosine in a tabular format.
         */

        static void CalculateSineAndCosine(double angle, out double sine, out double cosine)
        {
            sine= Math.Sin(angle);
            cosine= Math.Cos(angle);
            Console.WriteLine($"{angle,1:F}{sine,10:F}{cosine,9:F}");
        }
        #endregion
    }
}
