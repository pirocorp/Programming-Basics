using System;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dot = n;
            var sharp = (3 * n);
            //First Part
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('#', sharp));
                dot++;
                sharp -= 2;
            }
            //Second Part
            sharp -= 2;
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dot), new string('.', sharp));
                dot++;
                sharp -= 2;
            }
            //Third Part
            sharp += 4;
            dot--;
            Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('#', sharp));
            sharp += 4;
            dot -= 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('#', sharp));
            }
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', dot + (n - 6) / 2));
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('#', sharp));
            }
        }
    }
}
