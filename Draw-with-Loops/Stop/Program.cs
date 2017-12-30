using System;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var underline = 2 * n + 1;
            var dot = n + 1;

            //First Line
            Console.WriteLine("{0}{1}{0}", new string ('.', dot), new string ('_', underline));
            underline -= 2;
            dot -= 1;

            //Second Part
            for (int i = 1; i < n + 2; i++)
            {
                if (i == n + 1)
                {
                    Console.WriteLine("{0}//{1}STOP!{1}\\\\{0}", new string('.', dot), new string('_', (underline - 5) / 2));

                }
                else
                {
                    Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dot), new string('_', underline));
                    underline += 2;
                    dot -= 1;
                }
            }
            //STOP line

            //Forth part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dot), new string('_', underline));
                underline -= 2;
                dot += 1;
            }
        }
    }
}
