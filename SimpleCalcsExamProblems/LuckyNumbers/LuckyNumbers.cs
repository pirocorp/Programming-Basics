using System;

namespace LuckyNumbers
{
    class LuckyNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int a;
            int b;
            int c;
            int d;
            int x;
            //int br = 0;
            for (int i = 1000; i < 10000; i++ )
            {
                a = i / 1000;
                x = i % 1000;
                b = x / 100;
                x = x % 100;
                c = x / 10;
                x = x % 10;
                d = x;
                
                if((a + b) == (c + d) && a > 0 && b > 0 && c > 0 && d > 0)
                {
                    if((n % (a + b)) == 0)
                    {
                        Console.Write(i + " ");
                        //br++;
                        //if(br == 11)
                        //{
                        //    Console.WriteLine();
                        //    br = 0;
                        //}
                    }
                }
            }
        }
    }
}
