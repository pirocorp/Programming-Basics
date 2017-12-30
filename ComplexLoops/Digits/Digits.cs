using System;

namespace Digits
{
    class Digits
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var d1 = n / 100;
            var d2 = n / 10;
            d2 = d2 % 10;
            var d3 = n % 10;
            var rows = d1 + d2;
            var cols = d1 + d3;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (n % 5 == 0) n = n - d1;
                    else if (n % 3 == 0) n = n - d2;
                    else n = n + d3;
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
