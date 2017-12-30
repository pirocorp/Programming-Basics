using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string x;

            for (int r = 0; r < n; r++)
            {
                if (r == 0 || r == n - 1) x = "+";
                else x = "|";

                Console.Write(x);
                for (int c = 2; c < n; c++)
                {
                    Console.Write(" -");
                }
                Console.Write($" {x}");
                Console.WriteLine();
            }
        }
    }
}
