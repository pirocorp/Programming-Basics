using System;

namespace ChristmasToy
{
    class ChristmasToy
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var tyre = 2 * n;
            var star = n;

            //First Line
            Console.Write(new string('-', tyre));
            Console.Write(new string('*', star));
            Console.Write(new string('-', tyre));
            Console.WriteLine();

            //Second Part
            tyre -= 2;
            star += 2;
            var innerStar = 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", 
                                   new string('-', tyre), 
                                   new string('*', innerStar), 
                                   new string('&', star));
                star += 2;
                innerStar++;
                tyre -= 2;
            }

            //Third Part            
            tyre++;
            innerStar--;
            star += (innerStar - 2) * 2;
            innerStar = 2;


            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                                   new string('-', tyre),
                                   new string('*', innerStar),
                                   new string('~', star));
                tyre--;
                star += 2;
            }

            //Midpoint
            innerStar = 1;
            tyre++;
            Console.WriteLine("{0}{1}{2}{1}{0}",
                   new string('-', tyre),
                   new string('*', innerStar),
                   new string('|', star));

            //Forth Part -> Reverse third part
            innerStar = 2;
            star -= 2;

            for (int i = n / 2; i > 0 ; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                                   new string('-', tyre),
                                   new string('*', innerStar),
                                   new string('~', star));
                tyre++;
                star -= 2;
            }

            //Fifth part -> Reverse second part
            innerStar = n / 2;
            star -= (innerStar - 2) * 2;

            for (int i = n / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                                   new string('-', tyre),
                                   new string('*', innerStar),
                                   new string('&', star));
                star -= 2;
                innerStar--;
                tyre += 2;
            }

            //Last Line
            Console.Write(new string('-', tyre));
            Console.Write(new string('*', star));
            Console.Write(new string('-', tyre));
            Console.WriteLine();
        }
    }
}
