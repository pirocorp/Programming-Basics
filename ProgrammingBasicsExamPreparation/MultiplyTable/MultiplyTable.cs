using System;

namespace MultiplyTable
{
    class MultiplyTable
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var a = 0;
            var b = 0;
            var c = 0;
            var x = 0;

            a = n % 10;
            c = n / 100;
            x = n / 10;
            b = x % 10;


            for (int d1 = 1; d1 <= a; d1++)
            {
                for (int d2 = 1; d2 <= b; d2++)
                {
                    for (int d3 = 1; d3 <= c; d3++)
                    {
                        Console.WriteLine($"{d1} * {d2} * {d3} = {d1 * d2 * d3};");
                    }
                }
            }
        } 
    }
}
