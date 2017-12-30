using System;

namespace Grandpa
{
    class Grandpa
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double liters = 0;
            double degrees = 0;
            for (int i = 0; i < n; i++)
            {
                double l = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                liters = liters + l;
                degrees = degrees + l * d;
            }
            double rez = degrees / liters;
            Console.WriteLine("Liter: {0:f2}", liters);
            Console.WriteLine("Degrees: {0:f2}", rez);
            if (rez < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            if (rez < 42 && rez >= 38)
            {
                Console.WriteLine("Super!");
            }
            if (rez >= 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
