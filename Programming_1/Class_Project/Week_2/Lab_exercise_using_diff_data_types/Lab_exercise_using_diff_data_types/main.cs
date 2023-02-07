using System;

namespace DiffDatatypes 
{
    public class main //creating a class named as main
    {
        public static void Main(string[] args) //creating an entry point for the program
        {
            // Program obj= new(); //creating an object to call methods from different class
            // int total = obj.Total(); //assigning the returned value of method Total to total with int data types
            // int dozens = total / 12; //calculating the dozen
            // int eggs = total - (12 * dozens); //calculating the remaining eggs
            // Console.WriteLine(""); //prints an empty line
            // Console.WriteLine("{0} dozen {1} eggs produced by 4 hens in a month", dozens, eggs); //prints dozens and eggs

            Program2 pay = new(); //creating an object to call methods from different class
            pay.TotalPay();
            Console.WriteLine("");
            Console.WriteLine("Payroll summary of {0}", pay.name);
            Console.WriteLine("SIN: {0}", pay.sin);
            Console.WriteLine("{0} Worked {1} hours at the rate of {2} per hour", pay.name, pay.hour, pay.rate);
            Console.WriteLine("");
            Console.WriteLine($"Gross Pay:   {pay.total,19:C}");
            Console.WriteLine($"Federal Tax: {pay.fedTax,19:C}");
            Console.WriteLine($"Federal Tax: {pay.povTax,19:C}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Net Pay:     {pay.pay,19:C}");
        }
    }
}
