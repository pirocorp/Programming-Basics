using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            //Data input
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            //Calculation
            var area = a * h / 2;

            //Output + data formating
            Console.WriteLine(Math.Round(area, 2));   
        }
    }
}
