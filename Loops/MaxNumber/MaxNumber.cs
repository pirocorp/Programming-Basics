using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double Max = double.Parse(Console.ReadLine());
            double x;

            for (int i = 1; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                if (x > Max)
                    Max = x;
            }
            Console.WriteLine(Max);
        }
    }
}
