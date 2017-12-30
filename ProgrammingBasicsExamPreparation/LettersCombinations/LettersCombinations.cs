using System;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main()
        {
            var startChar = char.Parse(Console.ReadLine());
            var endChar = char.Parse(Console.ReadLine());
            var skipChar = char.Parse(Console.ReadLine());

            var counter = 0;
            for (char c1 = startChar; c1 <= endChar; c1++)
            {
                for (char c2 = startChar; c2 <= endChar; c2++)
                {
                    for (char c3 = startChar; c3 <= endChar; c3++)
                    {
                        if (c1 != skipChar && c2 != skipChar && c3 != skipChar)
                        {
                            Console.Write($"{c1}{c2}{c3} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
