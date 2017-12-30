using System;

namespace CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(a, ha);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double a, double h)
        {
            return (a * h) / 2;
        }

        static int PlusOne(int n)
        {
            return n + 1;
        }

        static string ReadFullName()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }

        static int CompareTo(int number1, int number2)
        {
            if (number1 > number2) return 1;
            else if (number1 < number2) return -1;
            else return 0;
        }
    }
}
