using System;

namespace Distance
{
    class Distance
    {
        static void Main()
        {
            double speed = int.Parse(Console.ReadLine());
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());

            double KM = 0;

            KM = speed * (time1 / 60.0);
            speed = speed * 1.1;
            KM = KM + speed * (time2 / 60.0);
            speed = speed * 0.95;
            KM = KM + speed * (time3 / 60.0);

            Console.WriteLine($"{KM:f2}");
        }
    }
}
