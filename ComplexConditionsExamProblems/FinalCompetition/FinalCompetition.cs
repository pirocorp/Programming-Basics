using System;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dancers = int.Parse(Console.ReadLine());
            var Points = decimal.Parse(Console.ReadLine());
            var Season = Console.ReadLine().ToLower();
            var Place = Console.ReadLine().ToLower();

            var sum = 0.0M;

            if (Place == "bulgaria")
            {
                sum = Points * Dancers;

                if (Season == "summer")
                {
                    sum = sum * 0.95m;
                }
                else if (Season == "winter")
                {
                    sum = sum * 0.92m;
                }
                else
                {
                    Console.WriteLine("Invalid Season");
                }
            }
            else if (Place == "abroad")
            {
                sum = Points * Dancers * 1.5M;

                if (Season == "summer")
                {
                    sum = sum * 0.90m;
                }
                else if (Season == "winter")
                {
                    sum = sum * 0.85m;
                }
                else
                {
                    Console.WriteLine("Invalid Season");
                }
            }
            else
            {
                Console.WriteLine("Invalid Place");
            }

            var charity = sum * 0.75m;
            var moneyPerDancer = (sum * 0.25m) / Dancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
        }
    }
}
