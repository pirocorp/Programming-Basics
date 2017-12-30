using System;

namespace SumOddNumbers
{
    class SumOddNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            if (x <= 10)
            {
                for (int i = x; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {x} = {n * x}");
            }
        }
    }
}
