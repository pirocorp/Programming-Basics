using System;

namespace nDigit
{
    class nDigit
    {
        static void Main()
        {
            var number = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            char c = ReturnNElement(number, n);
            Console.WriteLine(c);
        }

        static char ReturnNElement(string str, int index)
        {
            var i = str.Length - index;            
            //Console.WriteLine(i);
            return str[i];
        }
    }
}
