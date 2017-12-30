using System;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dot = (n - 1) / 2;
            var midot = n;

            //First Line
            Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('#', midot));
            midot -= 2;

            //First Part
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dot), new string('.', midot));
            }

            // Midline
            Console.WriteLine("{0}#{1}#{0}", new string('#', dot), new string('.', midot));
            
            //Last Part
            midot = 2 * n - 5;
            dot = 1;

            for (int i = 0; i < n - 1; i++)
            {
                if (midot > 0)
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('.', dot), new string('.', midot));
                    dot++;
                    midot -= 2;
                }
                else
                {
                    Console.WriteLine("{0}#{0}", new string('.', n-1));
                }
            }
        }
    }
}
