using System;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var VIP = 499.99m;
            var Normal = 249.99m;

            var Budget = decimal.Parse(Console.ReadLine());
            var Category = Console.ReadLine().ToLower();
            var People = int.Parse(Console.ReadLine());

            var transport = 0.0m;
            var moneyLeft = 0.0m;

            if (People > 0 && People <= 4)
            {
                transport = Budget * 0.75m;
            }
            else if (People >= 5 && People <= 9)
            {
                transport = Budget * 0.60m;
            }
            else if (People >= 10 && People <= 24)
            {
                transport = Budget * 0.50m;
            }
            else if (People >= 25 && People <= 49)
            {
                transport = Budget * 0.40m;
            }
            else if (People >= 50)
            {
                transport = Budget * 0.25m;
            }
            else
            {
                Console.WriteLine("Number of people is invalid");
            }

            moneyLeft = Budget - transport;

            if (Category == "vip")
            {
                moneyLeft = moneyLeft - People * VIP;
            }
            else
            {
                moneyLeft = moneyLeft - People * Normal;
            }

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
            }
        }
    }
}
