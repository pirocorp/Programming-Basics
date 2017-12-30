using System;

namespace Choreography
{
    class Choreography
    {
        static void Main()
        {
            double nSteps = int.Parse(Console.ReadLine());
            double nDancers = int.Parse(Console.ReadLine());
            double nDays = int.Parse(Console.ReadLine());
            double daySteps = ((nSteps / nDays) / nSteps) * 100;
            daySteps = Math.Ceiling(daySteps);
            if (daySteps <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {(daySteps / nDancers):f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {(daySteps / nDancers):f2}% steps to be learned per day.");
            }
        }
    }
}
