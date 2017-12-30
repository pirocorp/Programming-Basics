using System;

namespace TheatrePromotions
{
    class TheatrePromotions
    {
        static void Main()
        {
            var typeOfDay = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            if (typeOfDay == "weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
