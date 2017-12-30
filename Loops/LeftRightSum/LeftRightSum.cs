using System;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sumR = 0;
            double sumL = 0;

            for (int i = 0; i < n; i++)
            {
                sumL = sumL + double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sumR = sumR + double.Parse(Console.ReadLine());
            }

            if(sumL == sumR)
            {
                Console.WriteLine($"Yes, sum = {sumL}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumL - sumR)}");
            }
        }
    }
}
