using System;

namespace Courier
{
    class Courier
    {
        static void Main(string[] args)
        {
            var KG = double.Parse(Console.ReadLine());
            string mode = Console.ReadLine();
            int KM = int.Parse(Console.ReadLine());
            double price = 0;

            if(mode == "standard")
            {
                if (KG < 1)
                    price = KM * 3;
                if (KG >= 1 && KG < 11)
                    price = KM * 5;
                if (KG >= 11 && KG < 40)
                    price = KM * 10;
                if (KG >= 41 && KG < 91)
                    price = KM * 15;
                if (KG >= 91)
                    price = KM * 20;
            }

            if(mode == "express")
            {
                if (KG < 1)
                    price = KM * 3 + 2.4 * KG * KM;
                if (KG >= 1 && KG < 11)
                    price = KM * 5 + 2 * KG * KM;
                if (KG >= 11 && KG < 41)
                    price = KM * 10 + 0.5 * KG * KM;
                if (KG >= 41 && KG <= 90)
                    price = KM * 15 + 0.3 * KG * KM;
                if (KG > 90)
                    price = KM * 20 + 0.2 * KG * KM;
            }
            //decimal kg = (decimal)KG + 0.000m;
            price = price / 100;
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.",
                               KG, price); //Placeholder f + number decimals
        }
    }
}
