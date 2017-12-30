using System;

namespace Transport
{
    class Transport
    {
        static void Main()
        {
            var sTaxi = 0.7;
            var dTaxi = 0.79;
            var nTaxi = 0.9;
            var pBus = 0.09;
            var pTrain = 0.06;
            double Taxi = 0;
            double Bus = 0;
            double Train = 0;
            var KM = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            if (time == "day") Taxi = sTaxi + (dTaxi * KM);
            else Taxi = sTaxi + (nTaxi * KM);
            Bus = pBus * KM;
            Train = pTrain * KM;
            if (KM < 20) Console.WriteLine(Taxi);
            if (KM < 100 && KM >= 20)
            { if (Bus < Taxi) Console.WriteLine(Bus);
                else Console.WriteLine(Taxi);
            }
            if (KM >= 100)
            {
                if (Taxi < Bus)
                {
                    if (Taxi < Train) Console.WriteLine(Taxi);
                    else Console.WriteLine(Train);
                }
                else
                {
                    if (Bus < Train) Console.WriteLine(Bus);
                    else Console.WriteLine(Train);
                }

            }
        }
    }
}
