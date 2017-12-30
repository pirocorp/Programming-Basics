using System;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var minArea = int.Parse(Console.ReadLine());
            bool printNo = true;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            var sideX = right - left;
                            var sideY = bottom - top;
                            var area = sideX * sideY;
                            if (area >= minArea)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                                printNo = false;
                            }
                        }
                    }
                }
            }

            if (printNo) Console.WriteLine("No");
        }
    }
}
