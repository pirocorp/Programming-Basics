using System;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstTyre = 3 * n;
            var secondTyre = 0;
            var lastTyre = 2 * n - 2;

            //First Part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', firstTyre), new string('-', secondTyre), new string('-', lastTyre));
                secondTyre++;
                lastTyre--;
            }

            //Second Part
            secondTyre--;
            lastTyre++;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', firstTyre), new string('-', secondTyre), new string('-', lastTyre));
            }

            //Last Part
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', firstTyre), new string('-', secondTyre), new string('-', lastTyre));
                firstTyre--;
                secondTyre += 2;
                lastTyre--;
            }

            //Last Part
            Console.WriteLine("{0}*{1}*{2}", new string('-', firstTyre), new string('*', secondTyre), new string('-', lastTyre));
        }
    }
}
