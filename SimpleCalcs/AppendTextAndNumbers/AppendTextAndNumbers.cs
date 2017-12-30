using System;

namespace AppendTextAndNumbers
{
    class AppendTextAndNumbers
    {
        static void Main(string[] args)
        {
            // Using Placeholders {}
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);
           
            //More examples
            Console.WriteLine("{1} + {1} = {0}", 1 + 1, 1);
        }
    }
}
