namespace _01.SeaTrip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SeaTrip
    {
        public static void Main()
        {
            var moneyForFoodPerDay = decimal.Parse(Console.ReadLine());
            var moneyPerSouvenirsPerDay = decimal.Parse(Console.ReadLine());
            var moneyForHotelPerDay = decimal.Parse(Console.ReadLine());

            var gasMoney = ((420 / 100M) * 7) * 1.85M;
            var spending = 3 * (moneyForFoodPerDay + moneyPerSouvenirsPerDay);
            var hotelMoney = moneyForHotelPerDay * 0.9M +
                             moneyForHotelPerDay * 0.85M +
                             moneyForHotelPerDay * 0.8M;

            var totalMoney = gasMoney + spending + hotelMoney;

            Console.WriteLine($"Money needed: {totalMoney:F2}");
        }
    }
}
