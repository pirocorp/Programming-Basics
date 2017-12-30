using System;


namespace GreaterTwoValues
{
    class GreaterTwoValues
    {
        static void Main()
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }


            var division = Divide(1, 3);
            var x = division.reminder;
            var y = division.result;
        }

        static int GetMax(int first, int second)
        {
            if (first > second) return first;
            else return second;
        }

        static char GetMax(char first, char second)
        {
            if (first > second) return first;
            else return second;
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0) return first;
            else return second;
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void Print(int number)
        {
            Console.WriteLine(number);
        }

        static void Print(string text, int number)
        {
            Console.WriteLine(text + " " + number);
        }

        static (int result, int reminder) Divide(int x, int y)
        {
            int result = x / y;
            int reminder = x % y;

            return (result, reminder);
        }
    }
}
