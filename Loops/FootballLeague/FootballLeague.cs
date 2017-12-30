using System;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = int.Parse(Console.ReadLine());
            double nFans = int.Parse(Console.ReadLine());

            int A = 0;
            int B = 0;
            int V = 0;
            int G = 0;

            string x;

            for (int i = 1; i <= nFans; i++)
            {
                x = Console.ReadLine().ToLower();
                if (x == "a") A++;
                else if (x == "b") B++;
                else if (x == "v") V++;
                else if (x == "g") G++;
            }

            double AP = A / nFans * 100;
            double BP = B / nFans * 100;
            double VP = V / nFans * 100;
            double GP = G / nFans * 100;
            double FanP = nFans / stadiumCapacity * 100;

            Console.WriteLine($"{AP:F2}%");
            Console.WriteLine($"{BP:F2}%");
            Console.WriteLine($"{VP:F2}%");
            Console.WriteLine($"{GP:F2}%");
            Console.WriteLine($"{FanP:F2}%");
        }
    }
}
