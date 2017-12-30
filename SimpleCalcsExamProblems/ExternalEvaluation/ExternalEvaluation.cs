using System;

namespace ExternalEvaluation
{
    class ExternalEvaluation
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double m;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;

            for (int i = 1; i <= n; i++)
            {
                m = double.Parse(Console.ReadLine());
                if (m >= 0 && m < 22.5)
                    counter1++;
                if (m >= 22.2 && m < 40.5)
                    counter2++;
                if (m >= 40.5 && m < 58.5)
                    counter3++;
                if (m >= 58.5 && m < 76.5)
                    counter4++;
                if (m >= 76.5)
                    counter5++;
            }
            double result1 = counter1 / n * 100;
            double result2 = counter2 / n * 100;
            double result3 = counter3 / n * 100;
            double result4 = counter4 / n * 100;
            double result5 = counter5 / n * 100;

            Console.WriteLine("{0:f2}% poor marks", result1);
            Console.WriteLine("{0:f2}% satisfactory marks", result2);
            Console.WriteLine("{0:f2}% good marks", result3);
            Console.WriteLine("{0:f2}% very good marks", result4);
            Console.WriteLine("{0:f2}% excellent marks", result5);
        }   
    }
}
