using System;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToLower();
            if (s == "banana" || s == "apple" || s == "kiwi" ||
                s == "cherry" || s == "lemon" || s == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
