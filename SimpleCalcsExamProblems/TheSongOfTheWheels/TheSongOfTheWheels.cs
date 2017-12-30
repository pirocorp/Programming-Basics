using System;

namespace TheSongOfTheWheels
{
    class TheSongOfTheWheels
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            int a;
            int b;
            int c;
            int d;
            int x;
            int br = 0;
            int rez = 0;
            for (int i = 1000; i < 10000; i++)
            {
                a = i / 1000;
                x = i % 1000;
                b = x / 100;
                x = x % 100;
                c = x / 10;
                x = x % 10;
                d = x;
                //Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                if (m == (a * b + c * d) && a > 0 && b > 0 && c > 0 && d > 0)
                    if (a < b)
                        if (c > d)
                        {
                            Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                            br++;
                            if (br == 4)
                                rez = d + 10 * c + 100 * b + 1000 * a;
                        }
                
            }
            Console.WriteLine();
            if (rez > 0)
            {
                Console.WriteLine("Password: " + rez);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
