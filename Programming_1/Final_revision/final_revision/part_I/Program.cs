using System;

namespace part_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

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

        static void CalculateTution()
        {
            const double TutionFee = 569.99;
            Console.Write("Enter your number of courses: ");
            double courseNum = Convert.ToDouble(Console.ReadLine());

            double cost = TutionFee * courseNum;
            Console.WriteLine($"Your Tution fee is {cost:F}\n");
        }

        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area:F}\n");
        }

        static void CalculateAreaOfTringle()
        {
            Console.Write("Enter the base of the traingle: ");
            double baseOfTraingle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the traingle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (baseOfTraingle * height) / 2;
            Console.WriteLine($"The area of the traingle is {area:F}\n");
        }

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
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DisplayPersonalInfo();
                        continue;
                    case 2:
                        CalculateTution();
                        continue;

                    case 3:
                        CalculateAreaOfCircle();
                        continue;

                    case 4:
                        CalculateAreaOfTringle();
                        continue;

                    case 5:
                        CalculateSaleCommision();
                        continue;

                    case 6:
                        DisplaySineTable();
                        continue;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Please Enter a valid value!");
                        continue;
                }
            }
        }
    }
}
