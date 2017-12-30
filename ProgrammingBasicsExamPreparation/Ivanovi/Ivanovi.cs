using System;

namespace Ivanovi
{
    class Ivanovi
    {
        static void Main()
        {
            var budget = decimal.Parse(Console.ReadLine());
            var child1 = decimal.Parse(Console.ReadLine());
            var child2 = decimal.Parse(Console.ReadLine());
            var child3 = decimal.Parse(Console.ReadLine());

            var sum = child1 + child2 + child3;
            var left = budget - sum;
            left = left * 0.9m;

            Console.WriteLine($"{left:f2}");
        }
    }
}
