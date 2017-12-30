using System;

namespace GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var ostatuk = 5;

            while (ostatuk != 0)
            {
                ostatuk = a % b;
                a = b;
                b = ostatuk;
            }

            Console.WriteLine(a);
        }
    }
}
