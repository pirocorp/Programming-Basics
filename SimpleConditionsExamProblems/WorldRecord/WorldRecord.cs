using System;

namespace WorldRecord
{
    class WorldRecord
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var meters = double.Parse(Console.ReadLine());
            var speed = double.Parse(Console.ReadLine());
            var rezult = meters * speed;
            var add = Math.Floor((meters / 15)) * 12.5;
            var total = rezult + add;
            if(total < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {total:f2} seconds.");
            }
            else Console.WriteLine($"No, he failed! He was {(total - record):f2} seconds slower.");
            

        }
    }
}
