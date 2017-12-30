using System;

namespace Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            //Static Data
            var numDigitsAfterPoint = 3;

            //Data Input
            var l = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var pct = double.Parse(Console.ReadLine()) * 0.01;

            //Calculation
            double liters = l * w * h; //Volume
            liters = liters * 0.001;  //Converting cm3 in dm3
            liters = liters * (1 - pct); //Subtracting pct 
            string res = liters.ToString("F" + numDigitsAfterPoint); //Converting liters to string and formating it

            //Output Data
            Console.WriteLine(res); //Print res
        }
    }
}
