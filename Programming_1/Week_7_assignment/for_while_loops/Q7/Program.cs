using System;
/*Write a program to produce a table of numbers from 10 to 1,
 * with their squares and cubes. Again,
 * your table must look professional!
 */

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            //using while loop
            Console.WriteLine(" number    squares    cubes");
            Console.WriteLine("----------------------------");
            while (i > 0)
            {
                int squares = i * i;
                int cubes = i * i * i;
                Console.WriteLine($"{i,4}{squares,12}{cubes,11}");
                i--;
            }

            ////using for loop
            //Console.WriteLine(" Number    Squares    Cubes");
            //Console.WriteLine("----------------------------");
            //for (; i > 0; i--)
            //{
            //    int squares = i * i;
            //    int cubes = i * i * i;
            //    Console.WriteLine($"{i, 5}{squares, 12}{cubes, 11}");
            //}

            Console.ReadKey();
        }
    }
}
