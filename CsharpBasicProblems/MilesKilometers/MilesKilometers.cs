using System;

namespace MilesKilometers
{
    class MilesKilometers
    {
        static void Main(string[] args)
        {
            double mile = 1.60934;
            double miles = double.Parse(Console.ReadLine());
            double result = mile * miles;
            Console.WriteLine($"{result:f2}");
        }
    }
}
