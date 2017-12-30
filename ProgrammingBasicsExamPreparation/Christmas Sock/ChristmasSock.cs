using System;

namespace Christmas_Sock
{
    class ChristmasSock
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var row = 0;
            //First part
            Console.WriteLine("|{0}|", new string('-', 2 * n)); row++;
            Console.WriteLine("|{0}|", new string('*', 2 * n)); row++;
            Console.WriteLine("|{0}|", new string('-', 2 * n)); row++;

            //Second Part
            var tilde = 1;
            while (tilde <= n- 1)
            {
                var tyre = n - tilde;
                Console.WriteLine("|{0}{1}{1}{0}|", new string('-',tyre), new string('~', tilde));
                tilde++;
                row++;
            }

            //Third Part -> Reverse second part
            tilde = n - 2;
            while (tilde >= 1)
            {
                var tyre = n - tilde;
                Console.WriteLine("|{0}{1}{1}{0}|", new string('-', tyre), new string('~', tilde));
                tilde--;
                row++;
            }

            //Forth Part 
            var midpoint = (n + 4) / 2;
            var dot = 2 * n + 1;
            for (int i = 1; i <= n + 3; i++)
            {
                var tyre = i - 1;

                if (i != n + 3)
                {
                    if (i == midpoint - 1)
                    {
                        Console.WriteLine("{0}\\{1}MERRY{1}\\", new string('-', tyre), new string('.', (dot - 5) / 2));
                        continue;
                    }
                    if (i == midpoint + 1)
                    {
                        Console.WriteLine("{0}\\{1}X-MAS{1}\\", new string('-', tyre), new string('.', (dot - 5) / 2));
                        continue;
                    }

                    Console.WriteLine("{0}\\{1}\\", new string('-', tyre), new string('.', dot));
                }
                else
                {
                    Console.WriteLine("{0}\\{1})", new string('-', tyre), new string('_', dot));
                }
            }
        }
    }
}
