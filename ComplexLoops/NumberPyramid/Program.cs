using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            int k = 1;
            for (int i = 1; k <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (k > n) break;
                    Console.Write($"{k} ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
