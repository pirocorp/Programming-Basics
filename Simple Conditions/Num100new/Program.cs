using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num100new
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            for (int x = 0; x <= 100; x++)
            {
            int a;
            int b;
            a = x / 10;
            b = x % 10;

            if (a == 0 && b == 0)
            {
                goto End;
            }

            if (a == 0 && b != 0)
            {
                goto Numbers;
            }

            if (x == 100)
            {
                Console.WriteLine("one hundred");
                goto End;
            }


            //Teens
            if (a == 1)
            {
                if (b == 1)
                {
                    Console.WriteLine("eleven");
                    goto End;
                }

                if (b == 2)
                {
                    Console.WriteLine("twelve");
                    goto End;
                }
                if (b == 3)
                {
                    Console.WriteLine("thirteen");
                    goto End;
                }
                if (b == 4)
                {
                    Console.WriteLine("fourteen");
                    goto End;
                }
                if (b == 5)
                {
                    Console.WriteLine("fifteen");
                    goto End;
                }
                if (b == 6)
                {
                    Console.WriteLine("sixteen");
                    goto End;
                }
                if (b == 7)
                {
                    Console.WriteLine("seventeen");
                    goto End;
                }
                if (b == 8)
                {
                    Console.WriteLine("eighteen");
                    goto End;
                }
                if (b == 9)
                {
                    Console.WriteLine("nineteen");
                    goto End;
                }
                if (b == 0)
                {
                    Console.WriteLine("ten");
                    goto End;
                }
            }

            //Tens
            if (a == 2)
            {
                Console.Write("twenty");
                goto Numbers;
            }
            if (a == 3)
            {
                Console.Write("thirty");
                goto Numbers;
            }
            if (a == 4)
            {
                Console.Write("forty");
                goto Numbers;
            }
            if (a == 5)
            {
                Console.Write("fifty");
                goto Numbers;
            }
            if (a == 6)
            {
                Console.Write("sixty");
                goto Numbers;
            }
            if (a == 7)
            {
                Console.Write("seventy");
                goto Numbers;
            }
            if (a == 8)
            {
                Console.Write("eighty");
                goto Numbers;
            }
            if (a == 9)
            {
                Console.Write("ninety");
                goto Numbers;
            }

        Numbers:
            if (b != 0 && a != 0 && a != 1)
            {
                Console.Write(" ");
            }
            if (b == 1)
            {
                Console.WriteLine("one");
                goto End;
            }

            if (b == 2)
            {
                Console.WriteLine("two");
                goto End;
            }
            if (b == 3)
            {
                Console.WriteLine("three");
                goto End;
            }
            if (b == 4)
            {
                Console.WriteLine("four");
                goto End;
            }
            if (b == 5)
            {
                Console.WriteLine("five");
                goto End;
            }
            if (b == 6)
            {
                Console.WriteLine("six");
                goto End;
            }
            if (b == 7)
            {
                Console.WriteLine("seven");
                goto End;
            }
            if (b == 8)
            {
                Console.WriteLine("eight");
                goto End;
            }
            if (b == 9)
            {
                Console.WriteLine("nine");
                goto End;
            }
            if (b == 0)
            {
                Console.WriteLine();
                goto End;
            }


        End:
            if (x == 0)
            {
                Console.WriteLine("zero");
            }
            if (x < 0 || x > 100)
            {
                Console.WriteLine("invalid number");
            }
            }
        }
    }
}
