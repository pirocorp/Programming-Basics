using System;

namespace MaxNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double Min = double.Parse(Console.ReadLine());
            double x;

            for (int i = 1; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                if (x < Min)
                    Min = x;
            }
            Console.WriteLine(Min);
        }
    }
}
