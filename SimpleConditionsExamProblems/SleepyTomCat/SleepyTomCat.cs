using System;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var minutes = (365 - days) * 63 + days * 127;
            if (minutes <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                var difrence = 30000 - minutes;
                var h = difrence / 60;
                var m = difrence % 60;
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                var difrence = minutes - 30000;
                var h = difrence / 60;
                var m = difrence % 60;
                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }
        }
    }
}
