using System;

namespace Grades
{
    class Grades
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int perfect = 0;
            int veryGood = 0;
            int good = 0;
            int fail = 0;
            decimal average = 0;

            for (int i = 0; i < n; i++)
            {
                var x = decimal.Parse(Console.ReadLine());
                if (x >= 5) perfect++;
                else if (x >= 4 && x < 5) veryGood++;
                else if (x >= 3 && x < 4) good++;
                else if (x < 3) fail++;
                average += x;
            }

            var percentPerfect = (perfect / (decimal)n) * 100;
            var percentVeryGood = (veryGood / (decimal)n) * 100;
            var percentGood = (good / (decimal)n) * 100;
            var percentFail = (fail / (decimal)n) * 100;
            average = average / n;

            Console.WriteLine($"Top students: {percentPerfect:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentVeryGood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentGood:f2}%");
            Console.WriteLine($"Fail: {percentFail:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
