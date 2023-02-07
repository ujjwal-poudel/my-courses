using System;

namespace Converter
{
    public class UserInput
    {

        public static bool ToBoolean()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }

        public static double ToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static int ToInt32()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static char ToChar()
        {
            return Convert.ToChar(Console.ReadLine());
        }
    }
}