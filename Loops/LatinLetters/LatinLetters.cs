using System;

namespace LatinLetters
{
    class LatinLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet");
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}
