using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            var a = Math.Abs(x3 - x2);
            var ha = Math.Abs(y3 - y1);

            var area = (a * ha) / 2.0;

            Console.WriteLine(area);
        }
    }
}
