using System;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            //Static Data
            decimal BTCBGN = 1168;
            decimal CNYUSD = 0.15m;
            decimal USDBGN = 1.76m;
            decimal EURBGN = 1.95m;            
            
            //Data input
            decimal BTC = decimal.Parse(Console.ReadLine());
            decimal CNY = decimal.Parse(Console.ReadLine());
            decimal commission = decimal.Parse(Console.ReadLine()) / 100.00m;

            //Caluclation
            var EUR = (BTC * BTCBGN / EURBGN) + (CNY * CNYUSD * USDBGN / EURBGN); // Everything converted in EUR
            var res = EUR - EUR * commission;

            //Data Output
            Console.WriteLine((double)res);
        }
    }
}
