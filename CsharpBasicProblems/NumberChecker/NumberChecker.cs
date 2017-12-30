using System;

namespace NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            try
            {
                double n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
