using System;

namespace OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            int n;
            while(true)
            {
                n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 == 1) break;
                Console.WriteLine("Please write an odd number.");
            }
            Console.WriteLine("The number is: " + n);
        }
    }
}
