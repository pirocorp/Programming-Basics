using System;

namespace IntegerToBase
{
    class Program
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var numericSystem = long.Parse(Console.ReadLine());

            var rezult = IntegerToBase(number, numericSystem);
            Console.WriteLine(rezult);
        }

        static long IntegerToBase(long number, long toBase)
        {
            long convertedNumber = 0;

            if (toBase == 1)
            {
                var rezult = new string('1', (int)number);
                convertedNumber = long.Parse(rezult);
            }
            else
            {
                long step = 1;
                long x;
                while (number != 0)
                {
                    x = number % toBase;
                    convertedNumber += x * step;
                    step *= 10;
                    number = number / toBase;
                }
            }
            return convertedNumber;
        }
    }
}
