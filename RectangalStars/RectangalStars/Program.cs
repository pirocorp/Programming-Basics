using System;

namespace RectangalStars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            n = n - 2;

            for (int k = 1; k <= n; k++)
                Console.Write("*");
            Console.WriteLine("**");


            for (int i = 1; i <= n; i++)
            {            
                Console.Write("*");
                for (int j = 1; j <= n; j++)
                    Console.Write(" ");
                Console.WriteLine("*");
            }

            for (int p = 1; p <= n; p++)
                Console.Write("*");
            Console.WriteLine("**");
            
        }
    }
}
