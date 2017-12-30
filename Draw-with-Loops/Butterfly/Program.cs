using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //First Part
            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
            }

            //Middle 
            Console.WriteLine("{0}@{0}", new string(' ', n - 1)); //TODO

            //Last Part
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
            }
        }
    }
}
