using System;

namespace PipesPool
{
    class PipesPool
    {
        static void Main()
        {
            var Volume = int.Parse(Console.ReadLine());
            var Pipe1 = double.Parse(Console.ReadLine());
            var Pipe2 = double.Parse(Console.ReadLine());
            var Hours = double.Parse(Console.ReadLine());
            double water = Pipe1 * Hours + Pipe2 * Hours;
            if(water <= Volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                                    Math.Truncate((water / Volume) * 100),
                                    Math.Truncate(((Pipe1 * Hours) / water) * 100),
                                    Math.Truncate(((Pipe2 * Hours) / water) * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", Hours, water - Volume);
            }
        }
    }
}
