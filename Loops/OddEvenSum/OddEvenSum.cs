using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumE = 0;
            var sumO = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumE = sumE + int.Parse(Console.ReadLine());
                }
                else
                {
                    sumO = sumO + int.Parse(Console.ReadLine());
                }
            }

            if(sumO == sumE)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumE}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumE - sumO)}");
            }
        }
    }
}
