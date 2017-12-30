using System;

namespace ChristmasPreparation
{
    class ChristmasPreparation
    {
        static void Main()
        {
            var nPaper = int.Parse(Console.ReadLine());
            var nCloth = int.Parse(Console.ReadLine());
            var lGlue = decimal.Parse(Console.ReadLine());
            decimal discount = int.Parse(Console.ReadLine());

            //Price
            var paper = 5.8m;
            var cloth = 7.2m;
            var glue = 1.2m;

            var total = nPaper * paper + nCloth * cloth + lGlue * glue;
            discount = discount / 100.0m;
            discount = total * discount;
            total = total - discount;

            Console.WriteLine($"{total:f3}");
        }
    }
}
