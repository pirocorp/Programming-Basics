using System;

namespace MoneyPrise
{
    class MoneyPrise
    {
        static void Main(string[] args)
        {
            var parts = int.Parse(Console.ReadLine());
            decimal prise = decimal.Parse(Console.ReadLine());
            var points = 0;

            for (int i = 1; i <= parts; i++)
            {
                var p = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    points = p * 2 + points;
                }
                else
                {
                    points = points + p;
                }
            }

            Console.WriteLine(value: $"The project prize was {(points * prise):f2} lv.");
        }
    }
}
