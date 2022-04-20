using System;

namespace MoreOnNumericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive on the trip?");
            float miles = float.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas did your car use?");
            float gasUsed = float.Parse(Console.ReadLine());
            // Calculate the MPG for this trip
            float mpg = miles / gasUsed;
            Console.WriteLine($"Your car got {mpg} MPG this trip.");
        }
    }
}
