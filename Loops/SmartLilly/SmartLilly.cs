using System;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;
            double oddSum = 0;

            if (ageLilly % 2 == 0)
            {
                even = ageLilly / 2;
                odd = ageLilly / 2;
            }
            else
            {
                even = (ageLilly - 1) / 2;
                odd = ((ageLilly - 1) / 2) + 1;
            }

            oddSum = odd * toyPrice;
            double evenSum = (10 + even * 10);
            evenSum = evenSum / 2;
            evenSum = evenSum * even;
            evenSum = evenSum - even;
            double total = evenSum + oddSum;

            if (total >= washer)
            {
                Console.WriteLine($"Yes! {(total - washer):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washer - total):f2}");
            }
        }
    }
}
