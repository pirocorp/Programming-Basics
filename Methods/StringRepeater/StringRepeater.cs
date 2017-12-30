using System;

namespace StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            var resultString = RepeatString(str, n);
            Console.WriteLine(resultString);
        }

        static string RepeatString(string str, int count)
        {
            string repeatString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatString += str;
            }
            return repeatString;
        }
    }
}
