namespace _06.Sum_And_Product
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumAndProduct
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var a = 1; a <= 9; a++)
            {
                for (var b = 9; b >= a; b--)
                {
                    for (var c = 0; c <= 9; c++)
                    {
                        for (var d = 9; d >= c; d--)
                        {
                            var sum = a + b + c + d;
                            var product = a * b * c * d;

                            if (sum == product && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                return;
                            }

                            if (product / sum == 3 && n % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                return;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Nothing found");
        }
    }
}
