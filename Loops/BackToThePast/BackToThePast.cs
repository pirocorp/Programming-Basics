using System;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double sum;
            int yearsInPast = year - 1800;
            int evenYears = 0;
            int oddYears = 0;
            double a1 = 50 * 19;
            double an;

            if (yearsInPast % 2 == 0)
            {
                evenYears = yearsInPast / 2;
                oddYears = yearsInPast / 2;
                an = 50 * (17 + yearsInPast);                
            }
            else
            {
                evenYears = (yearsInPast - 1) / 2;
                oddYears = ((yearsInPast - 1) / 2) + 1;
                an = 50 * (18 + yearsInPast);                
            }

            //Arithmetic progresion
            double sumArithmeticProgresion;
            sumArithmeticProgresion = ((a1 + an) / 2) * oddYears; // This returns diffrence between odd and even years
            sum = (yearsInPast + 1) * 12000 + sumArithmeticProgresion;

            if (sum <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(money - sum):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {(sum - money):f2} dollars to survive.");
            }
        }
    }
}
