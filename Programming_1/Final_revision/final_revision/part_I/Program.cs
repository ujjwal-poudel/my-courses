using System;

namespace part_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        #region Question_1
        /*
         * 1. Write a method called
         * DisplayPersonalInfo(). This method will
         * display your name, school, program and your
         * favorite course. Call the
         * DisplayPersonalInfo() method from your program Main() method
         */
        static void DisplayPersonalInfo()
        {
            string fullName = "Ujjwal Poudel";
            string schoolName = "Centennial College";
            string program = "Software Engineering Technology-Artificial Intelligence";
            string favouriteCourse = "Comp100";

            Console.WriteLine($"My full name is {fullName}.");
            Console.WriteLine($"I study in {schoolName}.");
            Console.WriteLine($"I am enrolled in {program} in {schoolName}.");
            Console.WriteLine($"I am intrested in learning {favouriteCourse}.\n");
        }
        #endregion

        #region Question_2
        /*
         * 2. Write a method called CalculateTuition(). This method will prompt the user
         * for the number of courses that she is currently taking and then calculate and display
         * the tuition cost. (cost = number of course * 569.99). Call the
         * CalculateTuition() method two times from the same Main() method as in
         * question 1.
         */
        static void CalculateTution()
        {
            const double TutionFee = 569.99;
            Console.Write("Enter your number of courses: ");
            double courseNum = Convert.ToDouble(Console.ReadLine());

            double cost = TutionFee * courseNum;
            Console.WriteLine($"Your Tution fee is {cost:F}\n");
        }
        #endregion

        #region Question_3
        /*
         * 3. Write a method call CalculateAreaOfCircle(). This method will prompt the
         * user for the radius of a circle and then calculate and display the area.[A = πr2].
         * Call the CalculateAreaOfCircle() method twice from the same Main()
         * method as in question 1. Use Math.Pi for the value of π
         */
        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area:F}\n");
        }
        #endregion

        #region Question_4
        /*
         * 4. Write a method call CalculateAreaOfTriangle(), that prompts the user
         * for the base and height of a triangle and then calculate and display the area.[
         * A=bt
         * 2 ]
         * Call the CalculateAreaOfTriangle() method twice from the same Main()
         * method as in question 1.
         */
        static void CalculateAreaOfTringle()
        {
            Console.Write("Enter the base of the traingle: ");
            double baseOfTraingle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the traingle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (baseOfTraingle * height) / 2;
            Console.WriteLine($"The area of the traingle is {area:F}\n");
        }
        #endregion

        #region Question_5
        /*
         * 5. Write a method call CalculateSaleCommission(), that prompts the user
         *  for his sales figure, and then calculate and display his commission. (commission
         *  = 25% of sales in excess of 1000. If sales is equal to or
         *  below $1000.00 there is no commission)
         *  Call the CalculateSaleCommission() method three times from the same
         *  Main() method as in question 1.
         */
        static void CalculateSaleCommision()
        {
            Console.Write("Enter your sales figure: ");
            double saleAmount = Convert.ToDouble(Console.ReadLine());

            if (saleAmount > 1000)
            {
                double commissionAmount = 0.25 * saleAmount;
                Console.WriteLine($"Your commission amount is {commissionAmount:C}\n");
            }

            else
            {
                Console.WriteLine("You don't get any commission. Since, your sale amount is not more than $1000\n");
            }
        }
        #endregion

        #region Question_6
        /*
         * 6. Write a method call DisplaySineTable(), that prompts the user for a starting
         *  sine values based on the user input. Use the built-in method Math.Sin() to
         *  obtain the sine of an angle. e.g. if the starting value is 0.5 and the step size is 0.03
         *  the method will display the following table:
         *  0.50 0.4794
         *  0.53 0.5055
         *  value and an step size. The method will calculate and display a table (10 rows) of
         *  0.56 0.5311
         *  0.77 0.6961
         *  The numbers in both columns MUST be right aligned. Call the
         *  DisplaySineTable() method from the same Main() method as in question
         *  1.
         */
        static void DisplaySineTable()
        {
            Console.Write("Enter the starting value for sin: ");
            double start = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the stepping value: ");
            double step = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sine     Value");

            for (int i = 0; i < 10; i++)
            {
                double value = Math.Sin(start);
                Console.WriteLine($"{start,1:F}{value,11:F4}");
                start += step;
            }
        }
        #endregion

        #region Question_7
        /*
         * 7. In a write a method called DisplayMenu() to display the following text on
         * screen:
         * ===========Narendra’s Computer
         * Systems================
         * | 1. Display My Personal Information
         * |
         * | 2. Calculate Tuition
         * |
         * | 3. Calculate Area Of A Circle
         * |
         * | 4. Calculate the Area Of A Triangle
         * |
         * | 5. Calculate Sales Commission
         * |
         * | 6. Display Sine Table
         * |
         * | 0. End program
         * |
         * |
         * |
         *         Programming I Control Structures – Method
         * ===================================================
         * ===
         * Enter the number of your choice ->
         * You may replace the instructor’s name with your name.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("\n===========Ujjwal's Computer");
            Console.WriteLine("Systems================");
            Console.WriteLine("|       1. Display My Personal Information");
            Console.WriteLine("|       2. Calculate Tution");
            Console.WriteLine("|       3. Calculate Area Of Circle");
            Console.WriteLine("|       4. Calculate Area Of Traingle");
            Console.WriteLine("|       5. Calculate Sales Commission");
            Console.WriteLine("|       6. Display Sine Table");
            Console.WriteLine("|       0. End Program");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("====================================================");
            Console.WriteLine("===");
            Console.WriteLine("         Enter the number of your choice ->");
        }

        static void ShowMenu()
        {
            while (true)
            {
                DisplayMenu();
                string choice = Convert.ToString(Console.ReadLine());
                if (choice == "0")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        DisplayPersonalInfo();
                        break;
                    case "2":
                        CalculateTution();
                        break;

                    case "3":
                        CalculateAreaOfCircle();
                        break;

                    case "4":
                        CalculateAreaOfTringle();
                        break;

                    case "5":
                        CalculateSaleCommision();
                        break;

                    case "6":
                        DisplaySineTable();
                        break;

                    default:
                        Console.WriteLine("Please Enter a valid value!");
                        break;
                }
            }
        }
        #endregion
    }
}
