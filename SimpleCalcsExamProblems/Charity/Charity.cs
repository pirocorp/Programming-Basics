using System;

namespace Charity
{
    class Charity
    {
        static void Main(string[] args)
        {
            //Data Input
            var days = int.Parse(Console.ReadLine());
            var ppl = int.Parse(Console.ReadLine());
            var cake = int.Parse(Console.ReadLine());
            var wafer = int.Parse(Console.ReadLine());
            var pancake = int.Parse(Console.ReadLine());

            //Calculation
            var sum = cake * 45 + wafer * 5.8 + pancake * 3.2;
            sum = sum * ppl * days;
            sum = sum - sum / 8;
            sum = Math.Round(sum, 2);
            decimal suma = (decimal)sum + 0.00m; //Converting to decimal and applying formating

            //Output
            Console.WriteLine(suma);
        }
    }
}
