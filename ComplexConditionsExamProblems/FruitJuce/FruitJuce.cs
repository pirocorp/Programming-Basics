using System;

namespace FruitJuce
{
    class FruitJuce
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var size = Console.ReadLine().ToLower();
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            switch (fruit)
            {
                case "watermelon":
                    {
                        if (size == "small")
                        {
                            sum = 2 * 56;
                        }
                        else if (size == "big")
                        {
                            sum = 5 * 28.70m;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Size");
                        }
                        break;
                    }
                case "mango":
                    {
                        if (size == "small")
                        {
                            sum = 2 * 36.66m;
                        }
                        else if (size == "big")
                        {
                            sum = 5 * 19.60m;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Size");
                        }
                        break;
                    }

                case "pineapple":
                    {
                        if (size == "small")
                        {
                            sum = 2 * 42.10m;
                        }
                        else if (size == "big")
                        {
                            sum = 5 * 24.80m;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Size");
                        }
                        break;
                    }

                case "raspberry":
                    {
                        if (size == "small")
                        {
                            sum = 2 * 20;
                        }
                        else if (size == "big")
                        {
                            sum = 5 * 15.20m;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Size");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid fruit"); break;
                    }
            }

            sum = sum * n;

            if (sum > 1000)
            {
                sum = sum * 0.50m;
            }
            else if (sum >= 400 && sum <= 1000)
            {
                sum = sum * 0.85m;
            }

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
