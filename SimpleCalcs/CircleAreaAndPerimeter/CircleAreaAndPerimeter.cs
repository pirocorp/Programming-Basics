using System;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var per = Math.PI * 2 * r;
            Console.WriteLine(area);
            Console.WriteLine(per);
        }
    }
}
