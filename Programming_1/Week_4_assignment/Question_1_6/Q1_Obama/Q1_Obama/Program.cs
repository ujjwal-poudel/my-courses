using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create a program that prompts the user for her first name, middle initial and last name. The
 *  program will display the user name three times using the following three formats:
 *  first name and last name
 *  first name middle initial and last name
 *  last name, first name and middle initial
 *  Example for inputs Barack H Obama
 *  Barack Obama
 *  Barack H Obama
 *  Obama, Barack H
 */

namespace Q1_Obama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your middle name: ");
            string mName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("{0} {1}", fName, lName);
            Console.WriteLine("{0} {1} {2}", fName, mName, lName);
            Console.WriteLine("{0} {1} {2}", fName, lName, mName);
        }
    }
}
