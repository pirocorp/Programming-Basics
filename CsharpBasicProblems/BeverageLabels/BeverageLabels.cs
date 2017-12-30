using System;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100ml = int.Parse(Console.ReadLine());
            var sugarContentPer100ml = int.Parse(Console.ReadLine());

            var volumeRatioPer100ml = (volume / 100.0);
            var energy = volumeRatioPer100ml * energyContentPer100ml;
            var sugar = volumeRatioPer100ml * sugarContentPer100ml;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
