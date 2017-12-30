using System;

namespace Photo
{
    class Photo
    {
        static void Main(string[] args)
        {
            var pictures = int.Parse(Console.ReadLine());
            var typePictures = Console.ReadLine();
            var typeOrder = Console.ReadLine();
            double price = 0;
            if (typePictures == "9X13")
            {
                price = 0.16 * pictures;
                if (pictures >= 50)
                    price = price * 0.95;
            }
            else if (typePictures == "10X15")
            {
                price = 0.16 * pictures;
                if (pictures >= 80)
                    price = price * 0.97;
            }
            else if (typePictures == "13X18")
            {
                price = 0.38 * pictures;
                if(pictures >= 50 && pictures <= 100)
                {
                    price = price * 0.97;
                }
                else if (pictures > 100)
                {
                    price = price * 0.95;
                }
            }
            else if (typePictures == "20X30")
            {
                price = 2.90 * pictures;
                if (pictures >= 10 && pictures <= 50)
                {
                    price = price * 0.93;
                }
                else if (pictures > 50)
                {
                    price = price * 0.91;
                }
            }
            if(typeOrder == "online")
            {
                price = price * 0.98;
            }
            Console.WriteLine($"{price:f2}BGN");
        }
    }
}
