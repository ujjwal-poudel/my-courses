using System;
using Converter;

namespace week4
{
    public class StatementCheck
    {
        public bool Ques6()
        {
            /*
             Write a program to ask the user about the validity of
             response then display the statement as well as the
             a simple statement. The program should accept the
             response. The response should be true or false. For
             this question, you must use a variable of type bool.
             It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc.
            */

            Console.Write("The statement earth revolves around the sun is True or False? ");

            //This line takes string value as user input and assign to variable check of data type bool
            bool check = UserInput.ToBoolean();

            //This line returns the bool value assigned in check
            return check;
        }

        public double Ques7()
        {
            //This program calculates the radius of circle
            Console.Write("Enter the radius of the circle: ");

            //This line takes string value as user input and assign to variable radius of data type double
            double radius = UserInput.ToDouble();

            //This line return the double value in radius value
            return radius;
        }

        public double numDouble; //assigning variable of double data type
        public int numInt; //assigning variable of int data type
        public char valChar; //assigning variable of char data type

        public void Ques8()
        {
           Console.Write("Enter the number in double: ");
           this.numDouble = UserInput.ToDouble(); //takes user input and assign in variable numDouble

           Console.Write("Enter the number in integer: ");
           this.numInt = UserInput.ToInt32(); //takes user input and assign in variable numInt

           Console.Write("Enter any character: ");
           this.valChar = UserInput.ToChar(); //takes user input and assign in variable valChar
        }

        public int numAdult; //assigning variable of int data type
        public int numChild; //assigning variable of int data type

        public double priceAdult = 3.75; //assigning variable of double data type

        public double priceChild = 2.25; //assigning variable of double data type
        public double totalAdult; //assigning variable of double data type
        public double totalChild; //assigning variable of double data type
        public double grandTotal; //assigning variable of double data type
        
        public void Ques9()
        {
            //prints the below statement
            Console.WriteLine("Hi, this program so your total amount of tickets you purchased with the price");
            Console.WriteLine("The ticket price of Adult is $3.75/adult");
            Console.WriteLine("The ticket price of Child is $2.25/child");
            Console.WriteLine("");

            Console.Write("Enter the number of number of adults you have: ");
            this.numAdult = Convert.ToInt32(Console.ReadLine()); //takes user input and assign in variable numAdult

            Console.Write("Enter the number of children you have: "); //takes user input and assign in variable numChild
            this.numChild = Convert.ToInt32(Console.ReadLine());

            Console.Write(""); //printing an empty line

            this.totalAdult = this.priceAdult * this.numAdult; //arthematic operation on different variables
            this.totalChild = this.priceChild * this.numChild;
            this.grandTotal = this.totalAdult + this.totalChild;

            //printing the below line
            Console.WriteLine("The total cost of the tickets are detailed below");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------");
            //using format specifier as currency while printing
            Console.WriteLine($"The ticket price of {this.numAdult} Adults is: {this.totalAdult, 10:C}");
            Console.WriteLine($"The ticket price of {this.numChild} Adults is: {this.totalChild, 10:C}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"The total ticket price is:       {this.grandTotal, 10:C}");
            Console.WriteLine("---------------------------------------------------");
        }

        public double Ques10()
        {
            Console.Write("Enter the Current Flowing: ");
            double current = Convert.ToDouble(Console.ReadLine()); //takes user input and assign in variable current

            Console.Write("Enter the resistance of wire: ");
            double resistance = Convert.ToDouble(Console.ReadLine()); //takes user input and assign in variable resistance

            //using arthematic operation
            double potentialDiff = current * resistance;

            return potentialDiff; //returning the value of potential difference
        }
    }
}