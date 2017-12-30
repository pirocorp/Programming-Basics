using System;

namespace SantasHoliday
{
    class SantasHoliday
    {
        static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var room = Console.ReadLine().ToLower();
            var vote = Console.ReadLine().ToLower();

            //Prices
            var roomForOnePerson = 18.00m;
            var apartment = 25.00m;
            var presidentApartment = 35.00m;

            var nights = days - 1;
            var sum = 0.0m;
            var discount = 1.0m;

            var voteMultiple = 1.0m;

            if (room == "room for one person")
            {
                sum = nights * roomForOnePerson;
            }
            else if (room == "apartment")
            {
                sum = nights * apartment;
                if (days < 10) discount = 0.70m;
                else if (days <= 15) discount = 0.65m;
                else if (days > 15) discount = 0.50m;
            }
            else if (room == "president apartment")
            {
                sum = nights * presidentApartment;
                if (days < 10) discount = 0.90m;
                else if (days <= 15) discount = 0.85m;
                else if (days > 15) discount = 0.80m;
            }
            else Console.WriteLine("Invalid room");

            if (vote == "positive") voteMultiple = 1.25m;
            else if (vote == "negative") voteMultiple = 0.9m;
            else Console.WriteLine("Invalid Vote");

            sum = sum * discount;
            sum = sum * voteMultiple;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
