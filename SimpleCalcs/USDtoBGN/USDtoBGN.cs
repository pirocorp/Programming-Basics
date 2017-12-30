using System;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            //Input Data
            var usd = decimal.Parse(Console.ReadLine());
                                   
            //Calculation
            var bgn = usd * (Decimal)1.79549; //Converting Double to decimal also with suffix m after the value

            //Output Data
            Console.WriteLine(Math.Round(bgn, 2));

        }
    }
}
