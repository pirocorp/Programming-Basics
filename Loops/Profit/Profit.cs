using System;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var m1 = int.Parse(Console.ReadLine());
            var m2 = int.Parse(Console.ReadLine());
            var m5 = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= m1; i++)
            {
                for (int k = 0; k <= m2; k++)
                {
                    for (int j = 0; j <= m5; j++)
                    {
                        if (sum == i + k * 2 + j * 5)
                        Console.WriteLine($"{i} * 1 lv. + {k} * 2 lv. + {j} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}
