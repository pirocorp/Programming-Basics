using System;

namespace PointRectangleBorder
{
    class PointRectangleBorder
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var onLeftSide =  (x == x1) && (y >= y1) && (y <= y2);
            var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            var onTopSide =   (y == y1) && (x >= x1) && (x <= x2);
            var onDownSide =  (y == y2) && (x >= x1) && (x <= x2);
            //if ((x == x1 || x == x2) && (y >= y1 && y <= y2) ||
            //    (y == y1 || y == y2) && (x >= x1 && x <= x2))
            if (onLeftSide || onRightSide || onTopSide || onDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
