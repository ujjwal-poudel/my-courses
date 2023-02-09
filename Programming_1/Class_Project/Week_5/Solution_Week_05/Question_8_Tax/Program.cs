using Microsoft.SqlServer.Server;
using System;
/*
 * 8. Harmonised tax exitsts in Ontario, New Brunswick, New Foundland,
 * Nova Scotia, British Columbia.Prompt the user for a province and
 * using a suitable switch statement, display a message HST exist or HST
 * does not exist.
 */

namespace Question_8_Tax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first two letter of your province: ");
            String province = Console.ReadLine();

            switch (province.ToUpper()) 
            {
                case "ON":
                    Console.WriteLine("In {0} privince, the HST don't exist", province);
                    break;

                case "NB":
                    Console.WriteLine("In {0} privince, the HST don't exist", province);
                    break;

                case "NF":
                    Console.WriteLine("In {0} privince, the HST don't exist", province);
                    break;

                case "NS":
                    Console.WriteLine("In {0} privince, the HST don't exist", province);
                    break;

                case "BC":
                    Console.WriteLine("In {0} privince, the HST don't exist", province);
                    break;

                default:
                    Console.WriteLine("Wow, the HST exists if {0} is a province", province);
                    break;
            }
        }
    }
}
