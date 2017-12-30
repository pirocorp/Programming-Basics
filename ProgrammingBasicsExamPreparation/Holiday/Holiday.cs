using System;

namespace Holiday
{
    class Holiday
    {
        static void Main(string[] args)
        {
            //3D array represents destinations and prices
            decimal[,,] hotel =                                     //Destination, Stay, Person -> 0 - Adult, 1 - child
            {{{24.99m, 14.99m}, {22.99m, 11.99m}, {20.00m, 10.00m}},
             {{32.50m, 28.50m}, {30.50m, 25.60m}, {28.00m, 22.00m}},
             {{42.99m, 39.99m}, {41.00m, 36.00m}, {38.50m, 32.40m}}
            };

            //Vehicle, Person -> 0 - Adult, 1 - child
            decimal[,] vehicle =
            {
                {22.30m, 12.50m},
                {45.00m, 37.00m},
                {90.00m, 68.50m}
            };

            //Input Section
            var nights = int.Parse(Console.ReadLine());
            var dest = Console.ReadLine().ToLower();
            var transport = Console.ReadLine().ToLower();
            var adults = 2;
            var children = 3;

            //Preparing Data
            int destination;
            if (dest == "miami") destination = 0;
            else if (dest == "canary islands") destination = 1;
            else destination = 2;

            int stay;
            if (nights < 11) stay = 0;
            else if (nights <= 15) stay = 1;
            else stay = 2;

            int voyage;
            if (transport == "train") voyage = 0;
            else if (transport == "bus") voyage = 1;
            else voyage = 2;

            //Calculating
            var vacation = (adults * hotel[destination, stay, 0] + children * hotel[destination, stay, 1]) * nights;
            vacation = 1.25m * vacation;
            var transportExpenses = adults * vehicle[voyage, 0] + children * vehicle[voyage, 1];
            var total = vacation + transportExpenses;

            //Output Data
            Console.WriteLine($"{total:f3}");
        }
    }
}
