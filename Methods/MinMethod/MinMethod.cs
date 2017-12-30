using System;

namespace MinMethod
{
    class MinMethod
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var min = GetMin(GetMin(num1, num2), num3);
            Console.WriteLine(min);
        }

        static int GetMin(int first, int second)
        {
            if (first < second) return first;
            else return second;
        }
    }
}
