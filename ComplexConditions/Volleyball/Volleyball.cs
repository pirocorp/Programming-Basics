using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsHome = int.Parse(Console.ReadLine());

            int sofiaWeekends = 48 - weekendsHome;
            double playSofia = 3.0 * sofiaWeekends / 4 + 2.0 * holidays / 3;
            double playTotal = playSofia + weekendsHome;

            if (year == "leap")
            {
                playTotal = Math.Floor((playTotal * 1.15));

            }
            else if (year == "normal")
            {
                playTotal = Math.Floor(playTotal);
            }
            Console.WriteLine(playTotal);
        }
    }
}
