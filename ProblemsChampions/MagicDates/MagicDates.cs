using System;

namespace MagicDates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            var startYear = int.Parse(Console.ReadLine());
            var endYear = int.Parse(Console.ReadLine());
            var magicWeight = int.Parse(Console.ReadLine());

            string format = "dd-MM-yyyy";
            var weight = 0;
            bool no = true;

            //Creating Start and End Date
            DateTime startDate = new DateTime(startYear, 01, 01);
            DateTime endDate = new DateTime(endYear, 12, 31);
            
            //Loop trough Dates
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                //Converting Date time into digits
                DateTime currentDate = i;
                int x;
                int day = int.Parse(currentDate.ToString("dd"));
                int d1 = day / 10;
                int d2 = day % 10;
                int month = int.Parse(currentDate.ToString("MM"));
                int d3 = month / 10;
                int d4 = month % 10;
                int year = int.Parse(currentDate.ToString("yyyy"));
                int d5 = year / 1000;
                x = year / 100;
                int d6 = x % 10;
                x = year / 10;
                int d7 = x % 10;
                int d8 = year % 10;

                //Calculating weight of Date
                weight = 0;
                int[] dn = { d1, d2, d3, d4, d5, d6, d7, d8 };
                for (int k = 0; k < 8; k++)
                {
                    for (int j = k + 1; j < 8; j++)
                    {
                        weight += dn[k] * dn[j];
                    }
                }

                //Output if find
                if (weight == magicWeight)
                {
                    Console.WriteLine(i.ToString(format));
                    no = false;
                }
            }

            if (no) Console.WriteLine("No");
        }
    }
}
