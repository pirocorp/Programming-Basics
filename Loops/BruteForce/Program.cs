using System;

namespace LatinLetters
{
    class LatinLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet");
            for (char letter1 = 'a'; letter1 <= 'z'; letter1++)
            {
                Console.Write(letter1 + " ");
                for (char letter2 = 'a'; letter2 <= 'z'; letter2++)
                {
                    Console.Write(letter2 + " ");
                    for (char letter3 = 'a'; letter3 <= 'z'; letter3++)
                    {
                        Console.WriteLine(letter3 + " ");
                    }
                }
                    //Console.Clear();
            }
            Console.WriteLine();
        }
    }
}
