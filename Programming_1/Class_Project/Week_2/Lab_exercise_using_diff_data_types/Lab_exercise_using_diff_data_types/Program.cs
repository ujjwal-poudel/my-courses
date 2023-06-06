using System;

namespace DiffDatatypes
{
    public class Program //creating a class named Program
    {
       public int Total()  //creating a method called Total
       {
          Console.Write("Enter the eggs produced by Hen A: ");
          int henA = Convert.ToInt32(Console.ReadLine()); //takes user input as string and convert to integer of 32 bit and store in variable

          Console.Write("Enter the eggs produced by Hen B: ");
          int henB = Convert.ToInt32(Console.ReadLine()); //takes user input as string and convert to integer of 32 bit and store in variable

          Console.Write("Enter the eggs produced by Hen C: ");
          int henC = Convert.ToInt32(Console.ReadLine()); //takes user input as string and convert to integer of 32 bit and store in variable

          Console.Write("Enter the eggs produced by Hen D: ");
          int henD = Convert.ToInt32(Console.ReadLine()); //takes user input as string and convert to integer of 32 bit and store in variable

          int total = (henA + henB + henC + henD); //Sums all the input stores in variable

          return total; //this returns the value of total to the user
       }
    }
    public class Program2
    {
        public string name= "";
        public string sin= "";
        public double rate;
        public double hour;
        public double total;
        public double fedTax;
        public double povTax;
        public double pay;

        public void TotalPay()
        {
            Console.Write("Enter the employer name: ");
            this.name= Console.ReadLine()!;

            Console.Write("Social Insurance Number: ");
            this.sin= Console.ReadLine()!;

            Console.Write("Hourly Payrate: ");
            this.rate= Convert.ToDouble(Console.ReadLine());

            Console.Write("Hours Worked: ");
            this.hour= Convert.ToDouble(Console.ReadLine());

            this.total = hour * rate;
            this.fedTax = (0.15) * this.total;
            this.povTax = 0.10 * total;
            this.pay = this.total - this.fedTax - this.povTax;

        }
    }
}