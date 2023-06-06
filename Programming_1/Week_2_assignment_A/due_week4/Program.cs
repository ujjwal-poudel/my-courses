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

            bool truth = obj.Ques6(); //creating a variable named truth from the instance
            Console.WriteLine(truth);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("");

            double radius = obj.Ques7(); //creating a variable named radius from the instance
            double area = 3.14 * radius * radius; //arthematic operation
            Console.WriteLine($"The Area of circle with radius {radius} is {area:F}");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("");

            obj.Ques8(); //calling the function named Ques8
            Console.WriteLine("The double value is {0}", obj.numDouble);
            Console.WriteLine("The integer value is {0}", obj.numInt);
            Console.WriteLine("The character is {0}", obj.valChar);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("");

            obj.Ques9();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("");//calling the function named Ques9

            double pd = obj.Ques10(); //assigning a variable named pd from the instance
            Console.WriteLine("The potential difference is {0}", pd);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("");
        }
    }
}