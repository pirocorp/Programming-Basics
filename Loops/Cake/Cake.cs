using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int cake = h * l;
            bool br = false;

            while (cake >= 0)
            {
                var x = Console.ReadLine().ToLower();
                if (x == "stop")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    br = true;
                    break;
                }
                else
                {
                    cake = cake - int.Parse(x);
                }
            }
            if (!br)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
