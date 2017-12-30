using System;

namespace DateAfterDays
{
    class DateAfterDays
    {
        static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            day = day + 5;
            var DaysInMonth = 31;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
               DaysInMonth = 30;
            }
            if (month == 2)
            {
                DaysInMonth = 28;
            }
            if (day > DaysInMonth)
            {
                day = day - DaysInMonth;
                month = month + 1;
            }
            if (month == 13)
            {
                month = 1;
            }

            Console.WriteLine($"{day}.{month:00}");
        }
    }
}
