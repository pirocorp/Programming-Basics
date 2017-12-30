using System;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            //Data Input
            var vPrice = double.Parse(Console.ReadLine());
            var fPrice = double.Parse(Console.ReadLine());
            var vKG = int.Parse(Console.ReadLine());
            var fKG = int.Parse(Console.ReadLine());

            //Calculation
            var sumBGN = vPrice * vKG + fPrice * fKG;
            var sumEUR = sumBGN / 1.94;

            //DataOutput
            Console.WriteLine(sumEUR);                
        }
    }
}
