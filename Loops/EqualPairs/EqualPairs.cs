using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var MaxDiff = 0d;
            bool dif = false;

            var Sum = double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                if (MaxDiff < Math.Abs(Sum - (a + b)))
                    MaxDiff = Math.Abs(Sum - (a + b));
                Sum = a + b;
            }
            if (MaxDiff == 0)
            {
                Console.WriteLine($"Yes, value={Sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={MaxDiff}");
            }
        }
    }
}
