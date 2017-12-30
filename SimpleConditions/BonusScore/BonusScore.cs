using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double bonus;
            if (n <= 100)
            {
                bonus = 5;
            }
            else if (n < 1000)
            {
                bonus = n * 0.2;
            }
            else
            {
                bonus = n * 0.1;
            }
            if (n % 2 == 0)
            {
                bonus = bonus + 1;
            }
            if (n % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+n);
        }
    }
}
