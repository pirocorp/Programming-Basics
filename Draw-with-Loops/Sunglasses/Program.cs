using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string x;

            Console.WriteLine("{0}{1}{0}", new string ('*', 2 * n), new string (' ', n));
            for (int r = 0; r < n - 2; r++)
            {
                if (r == (n - 3) / 2)  x = new string('|', n);
                else x = new string(' ', n);

                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), x);
            }
            Console.WriteLine("{0}{1}{0}", new string ('*', 2 * n), new string (' ', n));
        }
    }
}
