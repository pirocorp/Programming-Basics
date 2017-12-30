using System;

namespace Bricks
{
    class Bricks
    {
        static void Main()
        {
            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var cart = int.Parse(Console.ReadLine());

            var cours = workers * cart;

            var courses = bricks / (double)cours;
            courses = Math.Ceiling(courses);

            Console.WriteLine(courses);
        }
    }
}
