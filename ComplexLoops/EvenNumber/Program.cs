using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            while (true)
            {
                Console.WriteLine("Enter number: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break; // even number -> exit from loop
                }
                Console.WriteLine("The number is not even.");
            }
            Console.WriteLine($"Even number entered: {n}");
        }
    }
}
