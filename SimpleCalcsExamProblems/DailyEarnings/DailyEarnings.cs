using System;

namespace DailyEarnings
{
    class DailyEarnings
    {
        static void Main(string[] args)
        {
            //Data input
            var days = int.Parse(Console.ReadLine());
            var epd = double.Parse(Console.ReadLine());
            var USDBGN = double.Parse(Console.ReadLine());

            //Calculation
            var mSalary = days * epd;
            var ySalary = mSalary * 14.5;
            var tax = ySalary * 0.25;
            var yIncomeBGN = (ySalary - tax) * USDBGN;

            //Data Output
            Console.WriteLine(Math.Round((yIncomeBGN / 365), 2));
        }
    }
}
