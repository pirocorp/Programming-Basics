using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int ki = 1; ki < 10; ki++)
            //{
            //    var n = ki;

            var n = int.Parse(Console.ReadLine());

            var TireBetweenStars = 0;

                if (n % 2 == 0) TireBetweenStars = 2;
                else TireBetweenStars = 1;

                int TireBeforStar = (n - TireBetweenStars) / 2;

                //First Line
                Console.WriteLine("{0}{1}{0}", new string('-', TireBeforStar), new string('*', TireBetweenStars));
                TireBeforStar--;
                //First Half
                for (int i = 1; i < (n + 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', TireBeforStar), new string('-', TireBetweenStars));
                    TireBetweenStars += 2;
                    TireBeforStar--;
                }
                //Second Half
                TireBetweenStars -= 4;
                TireBeforStar += 2;
                for (int i = 1; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', TireBeforStar), new string('-', TireBetweenStars));
                    TireBetweenStars -= 2;
                    TireBeforStar++;
                }
                //Last Line
                if (n % 2 == 0 && n != 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', TireBeforStar), "*");
                }
        }
    }
}
