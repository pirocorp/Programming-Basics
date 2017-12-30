using System;

namespace NumberGenerator
{
    class NumberGenerator
    {
        static void Main()
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var special = int.Parse(Console.ReadLine());
            var control = int.Parse(Console.ReadLine());

            var number = 0;
            bool reach = false;

            for (int i1 = m; i1 >= 1; i1--)
            {
                if (reach) break;
                for (int i2 = n; i2 >= 1; i2--)
                {
                    if (reach) break;
                    for (int i3 = l; i3 >= 1; i3--)
                    {
                        number = i1 * 100 + i2 * 10 + i3;
                        if (number %3 == 0) special += 5;
                        else if (i3 == 5) special -= 2;
                        else if (number % 2 == 0) special = special * 2;
                        if (special >= control)
                        {
                            reach = true;
                            break;
                        }
                    }
                }
            }

            if (reach)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {special}.");
            }
            else
            {
                Console.WriteLine($"No! {special} is the last reached special number.");
            }
        }
    }
}
