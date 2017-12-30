using System;

namespace SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            var Season = Console.ReadLine().ToLower();
            var Group = Console.ReadLine().ToLower();
            int Students = int.Parse(Console.ReadLine());
            int Nights = int.Parse(Console.ReadLine());
            int sex = 5;
            int z = 5;
            double price = 0;

            if (Group == "mixed")
            {
                sex = 2;
                if (Season == "winter")
                {
                    price = 10;
                    z = 0;
                }
                else if (Season == "spring")
                {
                    price = 9.50;
                    z = 1;
                }
                else if (Season == "summer")
                {
                    price = 20;
                    z = 2;
                }
                else
                {
                    Console.WriteLine("Invalid season");
                }

            }
            else if (Group == "boys" || Group == "girls")
            {
                if (Season == "winter")
                {
                    price = 9.6;
                    z = 0;
                }
                else if (Season == "spring")
                {
                    price = 7.2;
                    z = 1;
                }
                else if (Season == "summer")
                {
                    price = 15;
                    z = 2;
                }
                else
                {
                    Console.WriteLine("Invalid season");
                }

                if(Group == "boys")
                {
                    sex = 1;
                }
                if (Group == "girls")
                {
                    sex = 0;
                }

            }
            else
            {
                Console.WriteLine("Invalid Group");
            }

            double discount = 1;

            if (Students >= 50)
            {
                discount = 0.5;
            }
            else if (Students >= 20 && Students < 50)
            {
                discount = 0.85;
            }
            else if (Students >= 10 && Students < 20)
            {
                discount = 0.95;
            }

            var sum = price * Students * Nights;
            sum = sum * discount;

            string[,] array = new string[3, 3] 
            { {"Gymnastics", "Judo", "Ski"}, 
              {"Athletics", "Tennis", "Cycling"}, 
              {"Volleyball", "Football", "Swimming"}
            };

            Console.WriteLine($"{array[z, sex]} {sum:f2} lv.");
        }
    }
}
