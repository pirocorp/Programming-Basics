using System;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (4 * n) + 1;

            //First Line
            Console.WriteLine(new string('#', (4 * n) + 1));

            //Second Part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i + 1));
                Console.Write(new string('#', 2 * n - 1 - 2 * i));
                if (i == n / 2)
                {
                    Console.Write(new string(' ', (n - 2) / 2));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (n - 2) / 2));

                }
                else
                {
                    Console.Write(new string(' ', 1 + 2 * i));
                }
                Console.Write(new string('#', 2 * n - 1 - 2 * i));
                Console.Write(new string('.', i + 1));


                Console.WriteLine();
            }

            int k = 0;

            //Third Part
            for (int i = n; i < 2 * n; i++)
            {
                Console.Write(new string('.', i + 1));
                Console.Write(new string('#', 2 * n - 1 - 2 * k));
                Console.Write(new string('.', i + 1));
                k++;

                Console.WriteLine();
            }
        }
    }
}
