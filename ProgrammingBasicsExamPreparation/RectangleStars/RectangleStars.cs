using System;

namespace RectangleStars
{
    class RectangleStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int numRows = n - 1;
            if (n % 2 == 1) numRows++;
            Console.WriteLine(new string ('%', 2*n));
            for (int i = 0; i < numRows; i++)
            {
                Console.Write("%");
                if (i == numRows / 2)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', 2 * n - 2));
                }
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new string ('%', 2*n));
        }
    }
}
