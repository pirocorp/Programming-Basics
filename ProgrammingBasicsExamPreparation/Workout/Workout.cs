using System;

namespace Workout
{
    class Workout
    {
        static void Main()
        {
            var nDays = int.Parse(Console.ReadLine());
            var km = double.Parse(Console.ReadLine());

            var sum = km;
            for (int i = 0; i < nDays; i++)
            {
                var percent = int.Parse(Console.ReadLine());
                km = km + (km * percent / 100);
                sum = sum + km;
            }

            if(sum >= 1000)
            {
                var more = Math.Ceiling(sum - 1000);
                Console.WriteLine($"You've done a great job running {more} more kilometers!");
            }
            else
            {
                var left = Math.Ceiling(1000 - sum);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {left} more kilometers");
            }
        }
    }
}
