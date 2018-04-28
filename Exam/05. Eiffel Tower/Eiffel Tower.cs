namespace _05.Eiffel_Tower
{
    using System;

    public class EiffelTower
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //Upper tower of tower :D
            var dashesCount = n + 2;
            var starsCount = 2;

            var dashesString = new string('-', dashesCount);
            var starsString = new string('*', starsCount);

            for (var i = 0; i < 4 * n - 10; i++)
            {
                dashesString = new string('-', dashesCount);

                Console.WriteLine("{0}{1}{0}", dashesString, starsString);

                if (i == n - 1)
                {
                    dashesCount--;
                    starsCount += 2;

                    starsString = new string('*', starsCount);
                }

                if (i == (n - 2) * 2)
                {
                    dashesCount--;
                    starsCount += 2;

                    dashesString = new string('-', dashesCount);
                    starsString = new string('*', starsCount);

                    Console.WriteLine("{0}{1}{0}", dashesString, starsString);

                    starsString = "**--**";
                }

                if (i == 3 * n - 8)
                {
                    dashesCount--;
                    starsString = "**----**";
                }
            }

            dashesCount--;
            dashesString = new string('-', dashesCount);
            var stars = new string('*', 10);
            
            //BaseLine
            Console.WriteLine("{0}{1}{0}", dashesString, stars);

            //Base of tower
            var dashesLeftAndRight = n - 3;
            var dashesInTheMiddle = 8;
            
            for (var i = 0; i < n - 3; i++)
            {
                var dashLR = new string('-', dashesLeftAndRight);
                var dashM = new string('-', dashesInTheMiddle);

                Console.WriteLine("{0}{1}{2}{1}{0}", dashLR, "**", dashM);

                dashesLeftAndRight--;
                dashesInTheMiddle += 2;
            }

            //LastLine
            dashesInTheMiddle -= 2;
            var dashMiddle = new string('-', dashesInTheMiddle);

            Console.WriteLine("{0}{1}{0}", "***", dashMiddle);
        }
    }
}
