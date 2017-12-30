using System;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var space = n - 2;
            Console.WriteLine("@{0}@{0}@", new string (' ', space));
            space--;
            Console.WriteLine("**{0}*{0}**", new string(' ', space));

            int dot = 1;
            int midot = 1;
            var spaces = (2 * n) - 7 - 2 * dot - midot;
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', dot), new string(' ', spaces / 2), new string('.', midot));
                dot++;
                midot += 2;
                spaces -= 4;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dot), new string('.', midot));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n /2), new string('*', (n - 4) / 2));
            Console.WriteLine("{0}", new string ('*', (2 * n) - 1));
            Console.WriteLine("{0}", new string('*', (2 * n) - 1));
        }
    }
}
