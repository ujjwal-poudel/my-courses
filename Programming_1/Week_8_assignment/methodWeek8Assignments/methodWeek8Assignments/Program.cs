using System;

namespace methodWeek8Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling Question_1
            DisplayMenu();
            //calling blankspace method
            BlankSpace();

            #region Question_2_3_4_5
            /*
             * Modify your main so that the above method is call repeatedly.
             * The program will terminate when the user enters 0. Any other
             * choice should produce an error message. Because you will not
             * be doing any arithmetic you may accept the user response
             * either as an int, or a char or a string.
             */

            while(true)
            {
                DisplayMenu();
                int menu = Convert.ToInt32(Console.ReadLine());

                //question_2
                if (menu == 0)
                {
                    break;
                }

                //question_3
                else if (menu == 3)
                {
                    int sum = CalculateSum(5);
                    Console.WriteLine($"The total sum is {sum}");
                    Console.WriteLine();
                    continue;
                }

                //question_4
                else if (menu == 4)
                {
                    Console.Write("How many times you want to sum: ");
                    int limit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"The sum is {CalculateSumOfSquares(limit)}");
                    Console.WriteLine();
                    continue;
                }

                //question_5
                else if (menu == 5)
                {
                    Console.Write("How many times you want to sum: ");
                    int limit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"The sum is {CalculateSumOfCubes(limit)}");
                    Console.WriteLine();
                    continue;
                }

                //question_6
                else if (menu == 6)
                {
                    Console.Write("How many times you want to sum: ");
                    int limit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"The Average is {CalculateAverage(limit)}");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Sorry! This is out of service; Try another function");
                Console.WriteLine();
            }
            #endregion


        }

        #region Question_1
        /*
         * Write a method with the following specifications:
         * name         : DisplayMenu
         * arguments    : none
         * return value : none
         * tasks        : display the following menu choice on the screen
         * 
         * Calculation Menu
         * 3) Calculate Sum
         * 4) Calculate Sum of Squares
         * 5) Calculate Sum of Cubes
         * 0) To Exit
         * Enter the number that corresponds to your choice:
         * 
         * You may beautify the output to your own likings. You don’t have to implement the functionalities of the
         * various menu choices at this stage
         * Call this method from your main.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("6) Calculate Average"); //added calculate average option according to question 6
            Console.WriteLine("0) To Exit");
            Console.Write("Enter the number that corresponds to your choice: ");
        }
        #endregion

        #region Question_3
        /*
         * Write a method with the following specifications:
         * name         : CalculateSum
         * arguments    : a single int representing the number of inputs that will constitute the sum
         * return value : int representing the sum of all the user inputs
         * displays     : only the prompt for the user inputs, but does not display the sum
         * tasks        : prompt and accepts inputs (as many as specified by the argument), and sum them, Finally
         *                the method will return the sum of all the inputs (the sum)
         *                
         * In your main you will call this method when the user enters 3 in response to the menu choices. You will
         * invoke this method with argument 5 and then display the resulting value from the method.
         */

        static int CalculateSum(int limit)
        {
            int sum = 0;
            do
            {
                Console.Write("Enter your number for adding: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                limit--;
            }
            while (limit > 0);

            return sum;
        }
        #endregion

        #region Question_4
        /*
         * Write a method with the following specifications:
         * name         : CalculateSumOfSquares
         * arguments    : int representing the number of input that will constitute the sum
         * return value : int representing the sum of the squares of its input
         * displays     : the user prompts but NOT the sum of the squares
         * tasks        : prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as
         *                specified by the argument. Returns the final sum
         *                
         * In your main when the user enters 4 in response to the menu choices, you will prompt the user for the
         * number of inputs that she will be working with. You will invoke this method with this value and display the
         * resulting value.
         */
        static int CalculateSumOfSquares(int limit)
        {
            int sum = 0;
            do
            {
                Console.Write("Enter the number for squaring and summing: ");
                int number = Convert.ToInt32(Console.ReadLine());
                number *= number;
                sum += number;
                limit--;
            }
            while (limit > 0);

            return sum;
        }

        #endregion

        #region Queston_5
        /*
         * Write a method with the following specifications:
         * name         : CalculateSumOfCubes
         * arguments    : none
         * return value : int representing the sum of the cubes of its input
         * displays     : the user prompts but NOT the sum of the cubes
         * 
         * tasks:
         *  prompt the user for the number of inputs that she will be working with
         *  read in the user input
         *  Prompts the user for their input
         *  Accumulates the sum of the cubes input
         *  Repeat the above two steps are many times as required
         *  Returns the final sum
         * 
         * In your main when the user enters 5 in response to the menu choices, you will invoke this method and display
         * the resulting value.
         */

        static int CalculateSumOfCubes(int limit)
        {
            int sum = 0;
            do
            {
                Console.Write("Enter the number for cubing and summing: ");
                int number = Convert.ToInt32(Console.ReadLine());
                number *= number * number;
                sum += number;
                limit--;
            }
            while (limit > 0);

            return sum;
        }
        #endregion

        #region Question_6
        /*
         * Write a method with the following specifications:
         * name         : CalculateAverage
         * arguments    : none
         * return value : double representing the mathematical average of its inputs
         * displays     : the user prompts but NOT the average
         * tasks        : prompt and accept for the number of inputs that she will be working with. Prompts the user
         *                for the required number of inputs. Calculate and return the average of the inputs.
         *                
         * Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes. In your
         * main when the user enters the appropriate choice in response to the menu choices, you will invoke this
         * method and display the resulting value.
         */
        static double CalculateAverage(int limit)
        {
            double sum = 0;
            double entryNum = limit;
            do
            {
                Console.Write("Enter the number calculating average: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                limit--;
            }
            while (limit > 0);

            double average = sum / entryNum;
            return average;
        }
        #endregion

        #region BlankSpace
        //This is used for creating new line space
        static void BlankSpace() 
        {
            Console.WriteLine("\n");
        }
        #endregion
    }
}