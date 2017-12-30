using System;

namespace RhombusStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                Console.Write(new string(' ', n-r));
                for (int i = 0; i < r; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int r = 1; r < n; r++)
            {
                Console.Write(new string(' ', r));
                for (int i = 0; i < n - r; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
