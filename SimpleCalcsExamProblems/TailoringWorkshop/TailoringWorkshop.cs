using System;

namespace TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            //Data Input
            var nTable = int.Parse(Console.ReadLine());
            var lTable = double.Parse(Console.ReadLine());
            var wTable = double.Parse(Console.ReadLine());

            //Calculation
            var rect = nTable * (lTable + 0.6) * (wTable + 0.6);
            var sq = nTable * (lTable / 2) * (lTable / 2);
            double dUSD = rect * 7 + sq * 9;
            double dBGN = dUSD * 1.85;
            // string sUSD = dUSD.ToString("F" + 2); //Formating to two digits after point
            // string sBGN = dBGN.ToString("F" + 2); //Formating to two digits after point

            decimal USD = (decimal)Math.Round(dUSD, 2) + 0.00m; // +0.00m Show trailing zeros after Round UP
            decimal BGN = (decimal)Math.Round(dBGN, 2) + 0.00m; //

            //Output Data
            // Console.WriteLine("{0} USD", sUSD);
            // Console.WriteLine("{0} BGN", sBGN);
            Console.WriteLine("{0} USD", USD);
            Console.WriteLine("{0} BGN", BGN);
                     
        }
    }
}
