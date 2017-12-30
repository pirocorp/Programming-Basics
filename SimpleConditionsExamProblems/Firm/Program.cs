using System;

namespace Firm
{
    class Program
    {
        static void Main()
        {
            var projectHours = int.Parse(Console.ReadLine());
            var availableDays = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var totalHours = availableDays * 0.9 * 8;
            totalHours = totalHours * workers;
            totalHours = totalHours + (workers * 2 * availableDays * 0.9);
            totalHours = Math.Floor(totalHours);
            if (totalHours >= projectHours)
            {
                Console.WriteLine($"Yes!{totalHours - projectHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{projectHours - totalHours} hours needed.");
            }
        }
    }
}
