using System;

namespace PointFigure
{
    class PointFigure
    {
        static void Main(string[] args)
        {
            //Cordinates of rectangles 
            //(0, 0) (3h, h) - first rectangle
            //(h, h) (2h, 4h) - second rectangle
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inRectangle1 = ((x > 0 && x < 3 * h) && (y > 0 && y < h)); // <=> ((x > 0 && y > 0) && (x < 3h && y < h))
            bool inRectangle2 = ((x > h && x < 2 * h) && (y > h && y < 4 * h)); // <=> ((x > h && y > h) && (x < 2h && y < 4h))
            bool outRectangle1 = ((x < 0 || x > 3 * h) || (y < 0 || y > h));
            bool outRectangle2 = ((x < h || x > 2 * h) || (y < h || y > 4 * h));

            bool commonBorder = ((x > h && x < 2 * h) && y == h);

            if (outRectangle1 && outRectangle2) Console.WriteLine("outside");
            else if (inRectangle1 || inRectangle2 || commonBorder) Console.WriteLine("inside");
            else Console.WriteLine("border");
        }
    }
}
