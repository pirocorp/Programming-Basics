using System;

namespace PointFigure
{
    class PointFigure
    {
        static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var InRectA = (x >= 2) && (x <= 12) && (y >= -3) && (y <= 1);
            var InRectB = (x >= 4) && (x <= 10) && (y >= -5) && (y <= 3);

            if (InRectA || InRectB)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
