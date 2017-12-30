using System;


namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            //Input Data
            var cel = double.Parse(Console.ReadLine());

            //Calculation
            var far = cel * 1.8 + 32;

            //Output Data
            Console.WriteLine(far);
        }
    }
}
