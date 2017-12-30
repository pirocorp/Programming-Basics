using System;

namespace Lutenitsa
{
    class Lutenitsa
    {
        static void Main(string[] args)
        {
            //Data Input
            var tomatoes = double.Parse(Console.ReadLine());
            var nBox = int.Parse(Console.ReadLine());
            var bJar = int.Parse(Console.ReadLine());

            var Lutenica = tomatoes / 5;
            var lJar = Lutenica / 0.535;
            var lBox = lJar / bJar;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(Lutenica));

            if(lBox > nBox)
            {
                var leftBox = Math.Floor(lBox - nBox);
                var leftJar = Math.Floor(lJar - (nBox * bJar));
                Console.WriteLine("{0} boxes left.", leftBox);
                Console.WriteLine("{0} jars left.", leftJar);
            }


            if (lBox < nBox)
            {
                var missingBox = Math.Floor(nBox - lBox);
                var missingJar = Math.Floor((nBox * bJar) - lJar);
                Console.WriteLine("{0} more boxes needed.", missingBox);
                Console.WriteLine("{0} more jars needed.", missingJar);
            }
                       
        }
    }
}
