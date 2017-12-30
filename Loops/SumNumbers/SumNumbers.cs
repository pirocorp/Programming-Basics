using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
