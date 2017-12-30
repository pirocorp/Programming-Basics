using System;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            //Input Data
            var rad = double.Parse(Console.ReadLine());

            //Calculation
            var deg = rad * 180 / Math.PI;

            //Output Data + Formating Data
            Console.WriteLine(Math.Round(deg));
        }
    }
}
