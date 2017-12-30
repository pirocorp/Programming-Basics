using System;

namespace PassionDays
{
    class PassionDays
    {
        static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());

            int purchases = 0;
            string command = Console.ReadLine();
            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                foreach (char action in command)
                {
                    if (action >= 'A' && action <= 'Z')
                    {
                        decimal price = action * 0.5m;
                        if (money >= price)
                        {
                            money -= price;
                            purchases++;
                        }

                    }
                    else if (action >= 'a' && action <= 'z')
                    {
                        decimal price = action * 0.3m;
                        if (money >= price)
                        {
                            money -= price;
                            purchases++;
                        }

                    }
                    else if (action == '%')
                    {
                        if (money > 0)
                        {
                            money /= 2.0m;
                            purchases++;
                        }
                    }
                    else if (action == '*')
                    {
                        money += 10.0m;
                    }
                    else
                    {
                        decimal price = action;
                        if (money >= price)
                        {
                            money -= price;
                            purchases++;
                        }

                    }
                }
                command = Console.ReadLine();
            }

            if(purchases == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchases} purchases. Money left: {money:f2} lv.");
            }
        }
    }
}
