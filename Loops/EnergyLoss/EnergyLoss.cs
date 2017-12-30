using System;

namespace EnergyLoss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            double nDays = int.Parse(Console.ReadLine());
            double nDancers = int.Parse(Console.ReadLine());

            int h;
            double totalEnergy = nDays * nDancers * 100;
            double sum = 0;

            for (int i = 1; i <= nDays; i++)
            {
                h = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (h % 2 == 0)
                    {
                        sum = sum + 68 * nDancers;
                    }
                    else
                    {
                        sum = sum + 65 * nDancers;
                    }
                }
                else
                {
                    if (h % 2 == 0)
                    {
                        sum = sum + 49 * nDancers;
                    }
                    else
                    {
                        sum = sum + 30 * nDancers;
                    }
                }
                
            }

            double EnergyLeft = totalEnergy - sum;
            double energyByPerson = EnergyLeft / (nDancers * nDays);

            if(energyByPerson >= 50)
            {
                Console.WriteLine($"They feel good! Energy left: {energyByPerson:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {energyByPerson:f2}");
            }
        }
    }
}
