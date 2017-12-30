using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int x;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) p2++;
                if (x % 3 == 0) p3++;
                if (x % 4 == 0) p4++;
            }


            Console.WriteLine($"{(p2 * 100.00 / n):f2}%");
            Console.WriteLine($"{(p3 * 100.00 / n):f2}%");
            Console.WriteLine($"{(p4 * 100.00 / n):f2}%");
        }
    }
}
