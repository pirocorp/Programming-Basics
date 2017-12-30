using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    var num = row + col;
                    if (num > n)
                    {
                        num = 2 * n - num;
                        Console.Write("!");
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
