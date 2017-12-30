using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Input
            var whiskyPrice = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var schnapps = double.Parse(Console.ReadLine());
            var whisky = double.Parse(Console.ReadLine());

            //Calculations
            var sum = whiskyPrice * whisky + 
                      (whiskyPrice / 2) * schnapps + 
                      (whiskyPrice / 2) * 0.6 * wine + 
                      (whiskyPrice / 2) * 0.2 * beer;
            sum = Math.Round(sum, 2);
            decimal suma = (decimal)sum + 0.00m; //Converting to decimal and formating with 0.00m

            //Data Output
            Console.WriteLine(suma);
        }
    }
}
