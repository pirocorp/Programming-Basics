using System;

namespace ThreeBrothers
{
    class ThreeBrothers
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var b3 = double.Parse(Console.ReadLine());
            var dad = double.Parse(Console.ReadLine());

            var totalTime = 1 / (1 / b1 + 1 / b2 + 1 / b3);
            var Time = totalTime * 1.15;
            var rez = dad - Time;

            Console.WriteLine("Cleaning time: {0:f2}", Math.Round(Time, 2));

            if (rez >= 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(rez));
            }
            else
            {
                rez = rez * (-1);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(rez));
            }
        }
    }
}
