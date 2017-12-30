using System;

namespace DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            //Data input
            var l = double.Parse(Console.ReadLine()) * 100;
            var w = double.Parse(Console.ReadLine()) * 100;
            var a = double.Parse(Console.ReadLine()) * 100;

            //Calculations
            var area = l * w;
            area = area - a * a - area / 10;
            var nbr = area / 7040;
            nbr = Math.Floor(nbr);

            //Data Output
            Console.WriteLine(nbr);

        }
    }
}
