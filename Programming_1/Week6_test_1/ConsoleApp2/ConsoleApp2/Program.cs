using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ====================      Test #1      ====================
             * Name: Ujjwal Poudel
             * Student ID: 301284284
             *
             * Question 2e.
             * 12 Marks.
             *
             * Write a program that prompts the user for the name and 
             * price of an item. The program displays the item and he cost. You must match the 
             * format exactly.
             * 
             * Hint: cost = 1.13 * price
             */

            Console.Write("Enter the Item Name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter the Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            double cost = 1.13 * price;
            Console.WriteLine($"You will have to pay {cost:C} for the {itemName}");
        }
    }
}
