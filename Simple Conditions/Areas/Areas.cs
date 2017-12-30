using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Areas
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();
            if (fig == "square")
            {
                var x = double.Parse(Console.ReadLine());
                Console.WriteLine(x * x);
            }
            if (fig == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            if (fig == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                r = Math.PI * r * r;
                Console.WriteLine(r);
            }
            if (fig == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                a = a * b / 2;
                Console.WriteLine(a);
            }
        }
    }
}
