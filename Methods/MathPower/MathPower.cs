using System;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            var area = MathPow(number, power);
            Console.WriteLine(area);

        }

        static double MathPow (double number, double power)
        {
            double rezult = 1;
            double intPower = Math.Truncate(power);
            double floatPower = power - Math.Truncate(power);
            if(floatPower == 0)
            {
                for (int i = 0; i < intPower; i++)
                {
                    rezult *= number;
                }
                return rezult;
            }
            else
            {
                return 1;
            }
        }
    }
}
