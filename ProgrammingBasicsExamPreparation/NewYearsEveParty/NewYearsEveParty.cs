using System;

namespace NewYearsEveParty
{
    class NewYearsEveParty
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var budget = decimal.Parse(Console.ReadLine());

            var pricePerN = 20.0m;

            var sum = n * pricePerN;

            if (sum <= budget)
            {
                var left = budget - sum;
                var boom = left * 0.4m;
                var donate = left - boom;
                Console.WriteLine($"Yes! {boom:f0} lv are for fireworks and {donate:f0} lv are for donation.");
            }
            else
            {
                var missing = sum - budget;
                //missing = math
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {missing:f0} lv more.");
            }
        }
    }
}
