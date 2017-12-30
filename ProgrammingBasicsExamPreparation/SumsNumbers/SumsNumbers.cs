using System;

namespace SumsNumbers
{
    class SumsNumbers
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var sum = a + b + c;
            var max = a;
            var x = 0;

            if (a < b)
            {
                max = b;
                x = a;
                a = b;
                b = x;
            }
            if (max < c) 
            {
                max = c;
                x = a;
                a = c;
                c = x;
            }

            if (sum - max == max)
            {
                Console.WriteLine($"{Math.Min(b,c)}+{Math.Max(b,c)}={max}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
