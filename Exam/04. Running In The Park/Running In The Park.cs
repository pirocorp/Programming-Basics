namespace _04.Running_In_The_Park
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RunningInThePark
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var totalTimeInMin = 0;
            var totalDistanceInMeters = 0.0;

            for (var i = 0; i < n; i++)
            {
                var minRun = int.Parse(Console.ReadLine());
                totalTimeInMin += minRun;

                var distance = double.Parse(Console.ReadLine());
                var unitType = Console.ReadLine();

                if (unitType == "m")
                {
                    totalDistanceInMeters += distance;
                }
                else
                {
                    totalDistanceInMeters += distance * 1000;
                }
            }

            var cals = (totalTimeInMin / 20.0) * 400;
            Console.WriteLine($"He ran {(totalDistanceInMeters / 1000):F2}km for {totalTimeInMin} minutes and burned {cals} calories.");
        }
    }
}
