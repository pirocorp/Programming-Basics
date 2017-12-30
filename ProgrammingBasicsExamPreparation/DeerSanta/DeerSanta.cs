using System;

namespace DeerSanta
{
    class DeerSanta
    {
        static void Main()
        {
            var nDays = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dear1 = double.Parse(Console.ReadLine());
            var dear2 = double.Parse(Console.ReadLine());
            var dear3 = double.Parse(Console.ReadLine());

            var needFood = nDays * dear1 + nDays * dear2 + nDays * dear3;

            if (food >= needFood)
            {
                var foodLeft = food - needFood;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                var foodMissing = needFood - food;
                Console.WriteLine($"{Math.Ceiling(foodMissing)} more kilos of food are needed.");
            }
        }
    }
}
