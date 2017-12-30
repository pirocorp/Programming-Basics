using System;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main()
        {
            var inputString = "";
            for (int i = 0; i < 4; i++)
            {
                int number = int.Parse(Console.ReadLine());
                inputString += $"{number:d4}";
                if (i != 3) inputString += " ";
            }
            Console.WriteLine(inputString);

        }
    }
}
