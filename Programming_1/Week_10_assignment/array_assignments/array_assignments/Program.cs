using System;


namespace array_assignments
{
    internal class Program
    {

        static Random rand = new Random();
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            #region Question_4
            /*
             * 4. In your main method use the method in question 1 to display the letters array, then use
                  the Array.Reverse() method to reverse the letters array and then again call the
                  appropriate method to print it
             */

            //PrintCharArray(letters);
            //Console.WriteLine();
            //Array.Reverse(letters);
            //PrintCharArray(letters);
            //Console.WriteLine();

            #endregion

            #region Question_5
            /*
             * 5. In your main method use the method in question 3 to display the poem array, then use the
               Array.Sort() method to sort the poem array and then again call the appropriate
               method to print it
             */
            //PrintStringArray(poem);
            //Console.WriteLine();
            //Array.Sort(poem);
            //PrintStringArray(poem);
            //Console.WriteLine();
            #endregion

            #region Question_6
            /*
             * 6. In your main method use the method in question 2 to display the numbers array, then use
                  the Array.Binarysearch() method to try to find the position of 3 in the numbers
                  array. What is your answer?
                  Now repeat the same steps after you have sorted the array and printed the sorted array
             */
            Array.Sort(numbers);
            Console.WriteLine(Array.BinarySearch(numbers, 3));
            #endregion

            //int[] newArray = MemoryAllocater(5);
            //foreach (int c in newArray)
            //{
            //    Console.Write($"{c} ");
            //}
            //Console.WriteLine();

            //int[] newArray2= Integers(5);
            //foreach (int i in newArray2)
            //{
            //    Console.Write($"{i} ");
            //}
        }

        #region Question_7
        /*
         * 7. Write a method that creates and return an array of ints. The method
         * takes a single int argument that represents the how many items will be in
         * the resulting array and does the following:
         *  Declare an array of the required type.
         *  Allocate memory for the intended number of items.
         *  Using any looping structure, prompt the user for a number and then assign to each element.
         *  Return the array after the loop.
         * In your main method do the following:
         * (a) call this method (you will need to supply an argument), assign the resulting value to at suitable variable
         * and then
         * (b) display this variable.
         */

        static int[] MemoryAllocater(int value)
        {
            int[] ints;
            ints = new int[value];
            int counter = 0;
            do
            {
                Console.Write("Enter the items for array: ");
                int item = Convert.ToInt32(Console.ReadLine());
                ints[counter] = item;
                counter++;
            }
            while (counter < value);

            return ints;

        }
        #endregion

        static void PrintStringArray(string[] strings)
        {
            foreach (string s in strings)
            {
                Console.Write($"{s} ");
            }
        }

        static void PrintCharArray(char[] chars)
        {
            foreach (char a in chars)
            {
                Console.Write($"{a}" );
            }
        }

        #region Question_8
        /*
         * 8. Write another method that creates and return an array of ints. The method takes a single argument that
         *    represents the number of items in the resulting array and does the following:
         *     Declare an array of the required type.
         *     Allocate memory for the intended number of items.
         *     Using any looping structure, assign to each element a random integer in the range 100 to 200.
         *     Return the array.
         *    You will need the following statement in global scope.
         *    static Random rand = new Random();
         *    The following statement will give you a random letter
         *    rand.Next(100, 200);
         *    Exercise this method in a similar fashion as you did for question 7
         */

        static int[] Integers(int value)
        {
            int[] integers;
            integers = new int[value];
            int counter = 0;
            do
            {
                integers[counter] = rand.Next(100, 200); ;
                counter++;
            }
            while (counter < value);

            return integers;
        }
        #endregion
    }
}
