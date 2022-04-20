using System;

namespace NumericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            // Calculate the area of this rectangle
            double area = length * width;
            Console.WriteLine($"The area of the rectangle is {area}");
        }
    }
}
