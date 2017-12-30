using System;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var priceBus = 200.00;
            var priceTruck = 175.00;
            var priceTrain = 120.00;

            int Bus = 0;
            int Truck = 0;
            int Train = 0;

            int x;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x <= 3) Bus = Bus + x;
                else if (x > 3 && x <= 11) Truck = Truck + x;
                else if (x > 11) Train = Train + x;
                else Console.WriteLine("Invalid tonnage");
            }

            int totalCargo = Bus + Truck + Train;
            double PricePerTon = (Bus * priceBus + Truck * priceTruck + Train * priceTrain) / totalCargo;
            double percentBus = Bus * 100.00 / totalCargo;
            double percentTruck = Truck * 100.00 / totalCargo;
            double percentTrain = Train * 100.00 / totalCargo;

            Console.WriteLine($"{PricePerTon:f2}");
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
