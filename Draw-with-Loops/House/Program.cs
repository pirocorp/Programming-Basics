using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 0;

            if (n % 2 == 0) stars = 2;
            else stars = 1;

            var tire = (n - stars) / 2;

            for (int row = 0; row < (n + 1)/ 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', tire), new string('*', stars));
                tire--;
                stars += 2;
            }
            stars -= 4;
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("|{0}|", new string('*', stars));
            }
        }
    }
}
