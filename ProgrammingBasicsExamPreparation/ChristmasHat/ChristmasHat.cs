using System;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dots = 2 * n - 1;
            var innerDots = 0;
            var width = 4 * n + 1;

            //First 2 lines
            Console.Write(new string('.', dots));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', dots));
            Console.Write(new string('.', dots));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', dots));

            //Midle part 2 * n
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('-', innerDots));
                Console.Write("*");
                Console.Write(new string('-', innerDots));
                Console.Write("*");
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots--;
                innerDots++;
            }

            //Last 3 Lines
            Console.WriteLine(new string('*', width));
            Console.Write("*");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', width));
        }
    }
}
