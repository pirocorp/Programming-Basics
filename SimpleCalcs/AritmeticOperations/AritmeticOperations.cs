using System;

namespace AritmeticOperations
{
    class AritmeticOperations
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            // Sum
            var sum = a + b;
            Console.WriteLine(sum);

            //subtraction
            var result = a - b;
            Console.WriteLine(result);

            //multiplication
            var product = a * b;
            Console.WriteLine(product);

            //division
            var divInt = a / b; // Division of integers 
            var divfloata = a / (double) b; // Division of float numbers b is changed to double
            var divfloatb = (double) a / b; // Division of float numbers a is changed to double
            Console.WriteLine(divInt);
            Console.WriteLine(divfloata);
            Console.WriteLine(divfloatb);
        }
    }
}
