using System;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            //Exchange Rates
            decimal USD = 1.79549m;
            decimal EUR = 1.95583m;
            decimal GBP = 2.53405m;
            decimal BGN = 1.0m;
            //decimal convert = 0;

            // Input Data
            var amount = decimal.Parse(Console.ReadLine());
            var sourceCurency = Console.ReadLine();
            var targetCurency = Console.ReadLine();
            
            // Calculating Rates multiplaing first curency by its price
            if (sourceCurency == "USD")
                amount = amount * USD;
            if (sourceCurency == "EUR")
                amount = amount * EUR;
            if (sourceCurency == "GBP")
                amount = amount * GBP;
            if (sourceCurency == "BGN")
                amount = amount * BGN;

            // Second step dividing amount by the price of second curency
            if (targetCurency == "USD")
                amount = amount / USD;
            if (targetCurency == "EUR")
                amount = amount / EUR;
            if (targetCurency == "GBP")
                amount = amount / GBP;
            if (targetCurency == "BGN")
                amount = amount / BGN;

            //Output Data + formating output data to show only 2 decimals
            Console.WriteLine(Math.Round(amount, 2));

        }             
        
    }
}

