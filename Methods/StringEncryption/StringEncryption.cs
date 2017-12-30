using System;

namespace StringEncryption
{
    class StringEncryption
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string criptedString = "";
            for (int i = 0; i < n; i++)
            {
                var c = char.Parse(Console.ReadLine());
                criptedString += Encrypt(c);
            }
            Console.WriteLine(criptedString);
        }

        static string Encrypt(char letter)
        {
            string stringResult = "";
            int ascii = letter;
            int firstAscii = 0;
            int lastAscii = ascii % 10;
            while (ascii != 0)
            {
                firstAscii = ascii % 10;
                ascii /= 10;
            }
            int firstC = letter + lastAscii;
            int lastC = letter - firstAscii;
            char firstChar = (char)firstC;
            char lastChar = (char)lastC;
            stringResult = $"{firstChar}{firstAscii}{lastAscii}{lastChar}";

            return stringResult;
        }
    }
}
