using System;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var Budget = decimal.Parse(Console.ReadLine());
            var Season = Console.ReadLine().ToLower();

            if (Budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (Season == "summer")
                {
                    Budget = Budget * 0.3m;
                    Console.WriteLine($"Camp - {Budget:f2}");
                }
                else if (Season == "winter")
                {
                    Budget = Budget * 0.7m;
                    Console.WriteLine($"Hotel - {Budget:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid Season");
                }
            }
            else if (Budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (Season == "summer")
                {
                    Budget = Budget * 0.4m;
                    Console.WriteLine($"Camp - {Budget:f2}");
                }
                else if (Season == "winter")
                {
                    Budget = Budget * 0.8m;
                    Console.WriteLine($"Hotel - {Budget:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid Season");
                }
            }
            else if (Budget > 1000)
            {
                Budget = Budget * 0.9m;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {Budget:f2}");
                if (Season == "summer")
                {

                }
                else if (Season == "winter")
                {

                }
                else
                {
                    Console.WriteLine("Invalid Season");
                }
            }
            else
            {
                Console.WriteLine("Invalid Budget");
            }
        }
    }
}
