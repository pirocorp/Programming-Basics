using System;

namespace Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var subline = 2 * (n - 2 - n / 2); //2 * n - 4 - 2 * (n / 2);

            //Firs Line
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', subline));

            //Second Part
            var spaces = (2 * n - 2 - subline) / 2;
            for (int i = 0; i < n-2; i++)
            {
                if (subline > 0 && i == n - 3)
                {
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', spaces), new string('_', subline));
                }
                else
                {
                    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
                }
                
            }

            //Last Line
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', subline));

        }
    }
}
