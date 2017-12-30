using System;

namespace SumElement
{
    class SumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int Max = int.Parse(Console.ReadLine());
            int sum = Max;
            int x;

            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (Max < x) Max = x;
                sum = sum + x;
            }

            sum = sum - Max;

            if (Max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - Max)}");
            }
        }
    }
}
