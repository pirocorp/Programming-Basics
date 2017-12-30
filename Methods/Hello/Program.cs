using System;

namespace Hello
{
    class Program
    {
        static void Main()
        {
            //double first = 1.22;
            //double second = 3.27;
            //double Result(double a, double b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine(Result(first, second));

            //string output = "I am a local function";
            //void PrintOutput()
            //{
            //    Console.WriteLine(output);
            //}
            //PrintOutput();

            var name = Console.ReadLine();
            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
