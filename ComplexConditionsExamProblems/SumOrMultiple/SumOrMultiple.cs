using System;

namespace SumOrMultiple
{
    class SumOrMultiple
    {
        static void Main(string[] args)
        {
            bool print = false;
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 30; i++)
            {
                for (int k = 1; k <= 30; k++)
                {
                    for (int j = 1; j <=30; j++)
                    {
                        if (i > k && k > j)
                        {
                            if(i * j * k == n)
                            {
                                print = true;
                                Console.WriteLine($"{i} * {k} * {j} = {i * j * k}");
                            }
                        }
                        else if (i < k && k < j)
                        {
                            if(i + j + k == n)
                            {
                                Console.WriteLine($"{i} + {k} + {j} = {i + j + k}");
                                print = true;
                            }
                        }
                    }
                }                
            }
            if(!print)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
