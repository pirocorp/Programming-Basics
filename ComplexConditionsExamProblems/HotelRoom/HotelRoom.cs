using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var Month = Console.ReadLine().ToLower();
            var Nights = int.Parse(Console.ReadLine());

            var studio = 0.0m;
            var apartment = 0.0m;
            var discountStudio = 1.0m;
            var discountApartment = 1.0m;

            if (Month == "may" || Month == "october")
            {
                studio = 50 * Nights;
                apartment = 65 * Nights;
            }
            else if (Month == "june" || Month == "september")
            {
                studio = 75.20m * Nights;
                apartment = 68.70m * Nights;
            }
            else if (Month == "july" || Month == "august")
            {
                studio = 76 * Nights;
                apartment = 77 * Nights;
            }
            else
            {
                Console.WriteLine("Invalid Month");
            }

            if (Nights > 14)
            {
                if (Month == "may" || Month == "october")
                {
                    discountStudio = 0.70m;
                }
                else if (Month == "june" || Month == "september")
                {
                    discountStudio = 0.80m;
                }

                discountApartment = 0.90m;
            }
            else if (Nights > 7)
            {
                if (Month == "may" || Month == "october")
                {
                    discountStudio = 0.95m;
                }
            }

            Console.WriteLine($"Apartment: {apartment * discountApartment:f2} lv.");
            Console.WriteLine($"Studio: {studio * discountStudio:f2} lv.");
        }
    }
}
