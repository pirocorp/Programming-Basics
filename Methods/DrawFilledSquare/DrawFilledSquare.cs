using System;

namespace DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            DrawRectangle(n);
        }

        static void DrawRectangle(int n)
        {
            PrintHeaderFooter(n);
            PrintBody(n);
            PrintHeaderFooter(n);
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintBody(int n)
        {
            int end = n-2;
            for (int i = 0; i < end; i++)
            {
                PrintMidRow(n);
            }
        }

        static void PrintMidRow (int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
