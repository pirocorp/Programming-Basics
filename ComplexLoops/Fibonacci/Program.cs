using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            try
            {
                var m = int.Parse(Console.ReadLine());
                n = m;
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            var f0 = 1;
            var f1 = 1;
            var fn = 0;

            for (int i = 2; i <= n; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }
            if (n == 1) Console.WriteLine(f1);
            else if (n == 0) Console.WriteLine(f0);
            else Console.WriteLine(fn);
        }
    }
}
