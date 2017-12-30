using System;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var counter = 0;
            var MaxCounter = 0;

            var prev = 0;
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num > prev)
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }

                    if (counter > MaxCounter)
                    {
                        MaxCounter = counter;
                    }
                    prev = num;
                }
            }
            else
            {
                counter = 0;
                MaxCounter = 0;
            }
            Console.WriteLine(MaxCounter);
        }
    }
}
