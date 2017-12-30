using System;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            while(num < 1 || num > 100)
            {
                Console.WriteLine("Invalid Number!");
                num = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"The number is: {num}");
        }
    }
}
