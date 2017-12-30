using System;

namespace BarcodeGenerator
{
    class BarcodeGenerator
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            var startA = 0;
            var startB = 0;
            var startC = 0;
            var startD = 0;

            var startx = 0;
            startA = start / 1000;
            startD = start % 10;
            startx = start / 10;
            startC = startx % 10;
            startx = startx / 10;
            startB = startx % 10;

            var endA = 0;
            var endB = 0;
            var endC = 0;
            var endD = 0;

            var endx = 0;
            endA = end / 1000;
            endD = end % 10;
            endx = end / 10;
            endC = endx % 10;
            endx = endx / 10;
            endB = endx % 10;


            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;

            for (int i = start; i <= end; i++)
            {
                var x = 0;
                a = i / 1000;
                d = i % 10;
                x = i / 10;
                c = x % 10;
                x = x / 10;
                b = x % 10;

                if(a % 2 != 0 && b % 2 != 0 && c % 2 != 0 && d % 2 != 0)
                    if (a >= startA && b >= startB && c >= startC && d >= startD)
                        if (a <= endA && b <= endB && c <= endC && d <= endD)
                            Console.Write($"{a}{b}{c}{d} ");
            }
        }
    }
}
