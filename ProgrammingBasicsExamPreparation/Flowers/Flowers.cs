using System;

namespace Flowers
{
    class Flowers
    {
        static void Main()
        {
            var chrysanthemums = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var holiday = char.Parse(Console.ReadLine().ToLower());

            //Price per flower
            decimal chrysanthemumsHot = 2.00m;
            decimal chrysanthemumsCold = 3.75m;
            decimal rosesHot = 4.10m;
            decimal rosesCold = 4.50m;
            decimal tulipsHot = 2.50m;
            decimal tulipsCold = 4.15m;

            decimal total = 0;

            //Total without discounts
            if (season == "spring" || season == "summer")
            {
                total = chrysanthemumsHot * chrysanthemums + rosesHot * roses + tulipsHot * tulips;
            }
            else
            {
                total = chrysanthemumsCold * chrysanthemums + rosesCold * roses + tulipsCold * tulips;
            }

            //Premium for holidays
            if(holiday == 'y')
            {
                total *= 1.15m;
            }

            //Discount section
            if (tulips > 7 && season == "spring") total *= 0.95m;
            if (roses >= 10 && season == "winter") total *= 0.90m;
            if (tulips + roses + chrysanthemums > 20) total *= 0.80m;

            //Arranging
            total += 2;

            Console.WriteLine($"{total:f2}");
        }
    }
}
