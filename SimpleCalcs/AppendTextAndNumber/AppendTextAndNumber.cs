using System;

namespace AppendTextAndNumber
{
    class AppendTextAndNumber
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var lastname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            //Concatenation
            string str = firstname + " " + lastname + " @ " + age;
            Console.WriteLine(str);

            // Another Example
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var sum1 = "The sum is: " + (a + b);
            var sum2 = "The sum is: " + a + b;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
