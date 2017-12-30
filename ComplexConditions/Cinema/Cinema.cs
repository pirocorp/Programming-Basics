using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var Type = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var seats = r * c;
            var price = -1.00;

            if (Type == "remiere") price = 12.00;
            else if (Type == "normal") price = 7.5;
            else if (Type == "discount") price = 5.0;

            if (price >0)
            {
                Console.WriteLine("{0:f2} leva", seats * price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
