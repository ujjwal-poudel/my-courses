using System;
using Converter;

namespace StatementCheck
{
    public class Question7
    {
        private double radius;

        public void GetRadius()
        {
            Console.Write("Enter the radius: ");
            this.radius = UserInput.ToDouble();
        }

        public void Solution()
        {
            double circumference = 2 * Math.PI * this.radius;

            Console.WriteLine($"Circumference for given radius is: {circumference}");
        }
    }
}