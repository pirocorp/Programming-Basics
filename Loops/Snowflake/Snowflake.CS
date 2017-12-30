using System;

namespace Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //First Part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.',i));
                Console.Write("*");
                if (n - i >= 2)
                {
                    Console.Write(new string('.', n - i));
                }
                else
                {
                    Console.Write("*");
                }
                Console.Write("*");
                if (n - i >= 2)
                {
                    Console.Write(new string('.', n - i));
                }
                else
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

            //Second Part
            Console.WriteLine(new string ('*', 2 * n + 3));

            //Third Part
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                if (n - i >= 2)
                {
                    Console.Write(new string('.', n - i));
                }
                else
                {
                    Console.Write("*");
                }
                Console.Write("*");
                if (n - i >= 2)
                {
                    Console.Write(new string('.', n - i));
                }
                else
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
        }
    }
}
