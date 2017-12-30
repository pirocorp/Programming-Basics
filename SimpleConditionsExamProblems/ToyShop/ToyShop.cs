using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main()
        {
            var jigsaw = 2.6;
            var doll = 3.0;
            var bear = 4.1;
            var minion = 8.2;
            var truck = 2.0;
            var price = double.Parse(Console.ReadLine());
            var nJigsaw = int.Parse(Console.ReadLine());
            var nDoll = int.Parse(Console.ReadLine());
            var nBear = int.Parse(Console.ReadLine());
            var nMinion = int.Parse(Console.ReadLine());
            var nTruck = int.Parse(Console.ReadLine());
            var discount = 0.0;
            int nTotal = nJigsaw + nDoll + nBear + nMinion + nTruck;
            double total = nJigsaw * jigsaw + 
                    nDoll * doll + 
                    nBear * bear + 
                    nMinion * minion + 
                    nTruck * truck;
            if (nTotal >= 50) discount = total * 0.25;
            total = total - discount;
            var rent = total * 0.10;
            total = total - rent;
            if (total >= price) Console.WriteLine($"Yes! {(total - price):f2} lv left.");
            else Console.WriteLine($"Not enough money! {(price - total):f2} lv needed.");
        }
    }
}
