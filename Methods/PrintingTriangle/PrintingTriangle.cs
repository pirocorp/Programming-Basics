using System;

namespace PrintingTriangle
{
    class ProgramPrinting
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int row = 0; row < n; row++)
            {
                int number = 1;
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0} ",number);
                    number++;
                }
                Console.WriteLine();
            }

            for (int row = n-1; row > 0; row--)
            {
                int number = 1;
                for (int col = 0; col < row; col++)
                {
                    Console.Write("{0} ", number);
                    number++;
                }
                Console.WriteLine();
            }
        }

        static void PrintNumbers(int start = 0, int end = 100)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
