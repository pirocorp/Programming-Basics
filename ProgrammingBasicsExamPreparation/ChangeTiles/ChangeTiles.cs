using System;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var hFloor = decimal.Parse(Console.ReadLine());
            var wFloor = decimal.Parse(Console.ReadLine());
            var aTriangle = decimal.Parse(Console.ReadLine());
            var haTriangle = decimal.Parse(Console.ReadLine());
            var pricePerTile = decimal.Parse(Console.ReadLine());
            var priceForWorker = decimal.Parse(Console.ReadLine());

            var florArea = hFloor * wFloor;
            var tileArea = (aTriangle * haTriangle) / 2;
            var neededTiles = Math.Ceiling(florArea / tileArea);
            neededTiles += 5;
            var totalAmount = neededTiles * pricePerTile + priceForWorker;

            if (money >= totalAmount)
            {
                var left = money - totalAmount;
                Console.WriteLine($"{left:f2} lv left.");
            }
            else
            {
                var missing = totalAmount - money;
                Console.WriteLine($"You'll need {missing:f2} lv more.");
            }
        }
    }
}
