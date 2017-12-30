using System;

namespace PointSegment
{
    class PointSegment
    {
        static void Main()
        {
            var x1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            var distance = Math.Min(Math.Abs(x - x1), Math.Abs(x - x2));
            
            if (x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2))
            {
                Console.WriteLine("in");
                Console.WriteLine(distance);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(distance);
            }
        }
    }
}
