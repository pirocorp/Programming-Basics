using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMax = 0;
            double OddMin = 0;
            double EvenSum = 0;
            double EvenMax = 0;
            double EvenMin = 0;

            if (n >= 2)
            {
                var x = double.Parse(Console.ReadLine());
                OddSum = x;
                OddMax = x;
                OddMin = x;

                x = double.Parse(Console.ReadLine());
                EvenSum = x;
                EvenMax = x;
                EvenMin = x;

                for (int i = 3; i <= n; i++)
                {
                    x = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        EvenSum = EvenSum + x;
                        if (x > EvenMax) EvenMax = x;
                        if (x < EvenMin) EvenMin = x;
                    }
                    else
                    {
                        OddSum = OddSum + x;
                        if (x > OddMax) OddMax = x;
                        if (x < OddMin) OddMin = x;
                    }
                }


                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine($"OddMin={OddMin}");
                Console.WriteLine($"OddMax={OddMax}");
                Console.WriteLine($"EvenSum={EvenSum}");
                Console.WriteLine($"EvenMin={EvenMin}");
                Console.WriteLine($"EvenMax={EvenMax}");
               
            }

            if (n == 1)
            {
                var x = double.Parse(Console.ReadLine());
                OddSum = x;
                OddMax = x;
                OddMin = x;
                EvenSum = 0;
                EvenMax = 0;
                EvenMin = 0;
                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine($"OddMin={OddMin}");
                Console.WriteLine($"OddMax={OddMax}");
                Console.WriteLine($"EvenSum={EvenSum}");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            if (n == 0)
            {
                OddSum = 0;
                OddMax = 0;
                OddMin = 0;
                EvenSum = 0;
                EvenMax = 0;
                EvenMin = 0;
                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine($"EvenSum={EvenSum}");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");                              
            }
        }
    }
}
