using System;

namespace SignIntegerNumber
{
    class SignIntegerNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign (int n)
        {
            if (n > 0) Console.WriteLine($"The number {n} is positive.");
            else if (n < 0) Console.WriteLine($"The number {n} is negative.");
            else Console.WriteLine($"The number {n} is zero.");
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine("{0} ",i);
            }
        }

        static void PrintStudent(string name, int age, double grade)
        {
            Console.Write("Student: {0}; Age: {1}, Grade: {2}", name, age, grade);
        }
    }
}
