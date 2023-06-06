using System;

/*
* A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years. Write
* and run a C# program that computes and displays a depreciation table for seven years. The
* table should have the form:
* END-OF-YEAR ACCUMULATED
* YEAR  DEPRECIATION VALUE DEPRECIATION
* ---- ------------ ------------ ------------
* 1 4000 24000 4000
* 2 4000 20000 8000
* 3 4000 16000 12000
* 4 4000 12000 16000
* 5 4000 8000 20000
* 6 4000 4000 24000
* 7 4000 0 28000
*/

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int purchased = 28000;
            int depreciationRate = 4000;
            int years = 1;
            int accDepreciation = 0;

            Console.WriteLine("                        END-OF-YEAR      ACCUMULATED");
            Console.WriteLine("YEAR    DEPRECIATION       VALUE        DEPRECIATION");
            Console.WriteLine("----    ------------    ------------    ------------");

            do
            {
                accDepreciation += depreciationRate;
                int eoyValue = purchased - accDepreciation;
                Console.WriteLine($"{years, 4} {depreciationRate, 11} {eoyValue, 15} {accDepreciation, 15}");
                years ++;
            }
            while (years <= 7);
            Console.ReadKey();
        }
    }
}
