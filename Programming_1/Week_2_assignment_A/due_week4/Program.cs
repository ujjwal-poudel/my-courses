using System;
using StatementCheck;

namespace week4
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Question7 question7 = new Question7();
            question7.GetRadius();
            question7.Solution();
        }

        public void OptionalMain()
        {
            StatementCheck obj = new(); //creating an object from class as obj
            // bool truth = obj.Ques6(); //creating a variable named truth from the instance

            try
            {
                // if (truth) //comparision method using if and else statement
                // {
                //     Console.WriteLine("Hurray, You got it right");
                // }
                // else
                // {
                //     Console.WriteLine("Opps, you said false, the statement is fact, if you can change my mind");
                // }

                Console.Write("Enter a divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a diviend: ");
                int diviend = Convert.ToInt32(Console.ReadLine());
                int result = diviend / divisor;
                Console.WriteLine("The result is: {0}", result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("");

            double radius = obj.Ques7(); //creating a variable named radius from the instance
            double area = 3.14 * radius * radius; //arthematic operation
            Console.WriteLine($"The Area of circle with radius {radius} is {area:F}");

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("");

            obj.Ques8(); //calling the function named Ques8
            Console.WriteLine("The double value is {0}", obj.numDouble);
            Console.WriteLine("The integer value is {0}", obj.numInt);
            Console.WriteLine("The character is {0}", obj.valChar);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("");

            obj.Ques9(); //calling the function named Ques9

            double pd = obj.Ques10(); //assigning a variable named pd from the instance
            Console.WriteLine("The potential difference is {0}", pd);
        }
    }
}