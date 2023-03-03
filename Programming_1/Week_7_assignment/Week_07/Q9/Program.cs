using System;
/*
* To display the sum of all the multiples of 3 between 1000000 and 2000000.
(Answer = 499, 999, 500, 000). If you suspect that a value might be larger than 2
billion (as is the case here), then the type of sum should be a long and not an int.
[Hint: like the C (currency) and the F (decimal) format specifiers, there is also a N specifier]
*/

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1000000;
            int end = 2000000;
            long sum = 0;
            do 
            {
                if (start % 3 == 0)
                {
                    sum = start + sum;
                } 
                start++;
            }
            while (start < end);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
