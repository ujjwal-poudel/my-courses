using System;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("botton left to right diagonal pattern");
            int row = 9;
            int col = 9;
            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= col; j++)
            //    {
            //        if (j + i == col + 1)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("top left to right diagonal pattern");
            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= col; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine();
            Console.WriteLine("botton left to right diagonal pattern");
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (j + i == col + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("botton left to right diagonal pattern");
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (j + i == col + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("top left to right diagonal pattern");
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //Console.WriteLine();
            //Console.WriteLine("Hollow box pattern");
            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= col; j++)
            //    {
            //        if (i == 1 || j == 1 || i == row || j == col)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Cross star pattern");
            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= col; j++)
            //    {
            //        if (i == j || i + j == row + 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}