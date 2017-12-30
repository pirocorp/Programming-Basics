using System;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grapePerMeter = double.Parse(Console.ReadLine());
            var wineNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var totalGrapes = grapePerMeter * area;
            var wine = (totalGrapes * 0.4) / 2.5;
            var residue = Math.Abs(wine - wineNeeded);
            if (wine >= wineNeeded)
            {
                //if (outputVine != vine)
                {
                    var a = Math.Floor(wine);
                    var b = Math.Ceiling(residue);
                    var c = Math.Ceiling((residue) / workers);

                    Console.WriteLine("Good harvest this year! Total wine: {0} liters.", a);
                    Console.WriteLine("{0} liters left -> {1} liters per person.", b, c);

                }
                
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(residue));
            }
        }
    }
}
