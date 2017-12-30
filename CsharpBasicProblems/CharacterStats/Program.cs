using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var helth = int.Parse(Console.ReadLine());
            var maxHelth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var leftHelth = maxHelth - helth;
            var leftEnergy = maxEnergy - energy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', helth), new string('.', leftHelth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', leftEnergy));
        }
    }
}
