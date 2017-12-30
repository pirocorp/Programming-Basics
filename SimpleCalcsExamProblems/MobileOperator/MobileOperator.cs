using System;

namespace MobileOperator
{
    class MobileOperator
    {
        static void Main(string[] args)
        {
            var years = Console.ReadLine();
            var contract = Console.ReadLine();
            var internet = Console.ReadLine();
            var monts = int.Parse(Console.ReadLine());
            double pay = 0;

            if (years == "one")
            {
                if(contract== "Small")
                {
                    pay = 9.98;
                    if(internet == "yes")
                    {
                        pay = pay + 5.5;
                    }
                }
                if (contract == "Middle")
                {
                    pay = 18.99;
                    if (internet == "yes")
                    {
                        pay = pay + 4.35;
                    }
                }
                if (contract == "Large")
                {
                    pay = 25.98;
                    if (internet == "yes")
                    {
                        pay = pay + 4.35;
                    }
                }
                if (contract == "ExtraLarge")
                {
                    pay = 35.99;
                    if (internet == "yes")
                    {
                        pay = pay + 3.85;
                    }
                }
            }
            if (years =="two")
            {
                if (contract == "Small")
                {
                    pay = 8.58;
                    if (internet == "yes")
                    {
                        pay = pay + 5.5;
                    }
                }
                if (contract == "Middle")
                {
                    pay = 17.09;
                    if (internet == "yes")
                    {
                        pay = pay + 4.35;
                    }
                }
                if (contract == "Large")
                {
                    pay = 23.59;
                    if (internet == "yes")
                    {
                        pay = pay + 4.35;
                    }
                }
                if (contract == "ExtraLarge")
                {
                    pay = 31.79;
                    if (internet == "yes")
                    {
                        pay = pay + 3.85;
                    }
                }
            }
            var total = pay * monts;
            if (years == "two")
                total = 0.9625 * total;
            Console.WriteLine("{0:f2} lv.", total);
        }
    }
}
