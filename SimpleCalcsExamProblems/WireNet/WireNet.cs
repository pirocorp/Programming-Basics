using System;

namespace WireNet
{
    class WireNet
    {
        static void Main(string[] args)
        {
            //Data Input
            var l  = double.Parse(Console.ReadLine());
            var w  = double.Parse(Console.ReadLine());
            var h  = double.Parse(Console.ReadLine());
            var pl = double.Parse(Console.ReadLine());
            var kg = double.Parse(Console.ReadLine());

            //Calculation
            var lm = 2 * (l + w);
            var sum = lm * pl;
            sum = Math.Round(sum, 2);
            decimal suma = (decimal)sum + 0.00m; //Converting to decimal and applying format
            var sumKG = lm * h * kg;
            sumKG = Math.Round(sumKG, 3);
            decimal sumaKG = (decimal)sumKG + 0.000m; //Converting to decimal and applying format

            //Output Data
            Console.WriteLine(lm);
            Console.WriteLine(suma);
            Console.WriteLine(sumaKG);
        }
    }
}
