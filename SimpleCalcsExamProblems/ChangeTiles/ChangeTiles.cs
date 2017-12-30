using System;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            //Data Input
            var N = double.Parse(Console.ReadLine());
            var wT = double.Parse(Console.ReadLine());
            var lT = double.Parse(Console.ReadLine());
            var wB = double.Parse(Console.ReadLine());
            var lB = double.Parse(Console.ReadLine());

            //Calculation
            var area = N * N;
            var bench = wB * lB;
            var tile = wT * lT;
            var ntile = (area - bench) / tile;

            //Output
            Console.WriteLine(ntile);
            Console.WriteLine(ntile * 0.2);

        }
    }
}
