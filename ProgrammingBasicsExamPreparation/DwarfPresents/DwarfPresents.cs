using System;

namespace DwarfPresents
{
    class DwarfPresents
    {
        static void Main(string[] args)
        {
            var nDwarfs = int.Parse(Console.ReadLine());
            var money = int.Parse(Console.ReadLine());

            var giftSum = 0.0m;

            for (int dwarf = 0; dwarf < nDwarfs; dwarf++)
            {
                var gift = Console.ReadLine().ToLower();
                if (gift == "sand clock") giftSum += 2.20m;
                else if (gift == "magnet") giftSum += 1.50m;
                else if (gift == "cup") giftSum += 5.00m;
                else if (gift == "t-shirt") giftSum += 10.00m;
                else Console.WriteLine("Invalid gift");
            }

            if (money >= giftSum)
            {
                var moneyLeft = money - giftSum;
                Console.WriteLine($"Santa Claus has {moneyLeft:f2} more leva left!");
            }
            else
            {
                var moneyMissing = giftSum - money;
                Console.WriteLine($"Santa Claus will need {moneyMissing:f2} more leva.");
            }
        }
    }
}
