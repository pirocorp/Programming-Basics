using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int x;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 200) p1++;
                else if (x >= 200 && x < 400) p2++;
                else if (x >= 400 && x < 600) p3++;
                else if (x >= 600 && x < 800) p4++;
                else if (x >= 800 && x <= 1000) p5++;                                   
            }

            double percent1 = p1 / n * 100;
            double percent2 = p2 / n * 100;
            double percent3 = p3 / n * 100;
            double percent4 = p4 / n * 100;
            double percent5 = p5 / n * 100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");

            int l = 3, y = 4;
            double z;

            z = l * 100 / y ;
            Console.WriteLine(z);
        }
    }
}
