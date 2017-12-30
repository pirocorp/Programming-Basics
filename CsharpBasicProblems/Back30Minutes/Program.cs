using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours = hours - 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}