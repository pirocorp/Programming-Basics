using System;

namespace MagicCombination
{
    class MagicCombination
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 1;
            
            for (int i = 100000; i < 1000000; i++)
            {
                var x = i;
                while (x > 0)
                {
                    sum = sum * (x % 10);
                    x = x / 10;
                }
                if (sum == n)
                    Console.Write(i + " ");
                sum = 1;
            }
        }
    }
}
