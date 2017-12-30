using System;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inRange = (num >= 100 && num <= 200) || num == 0;
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
