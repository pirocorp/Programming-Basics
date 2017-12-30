using System;

namespace BullsCows
{
    class BullsCows
    {
        static void Main()
        {
            var secretNumber = int.Parse(Console.ReadLine());
            var nBulls = int.Parse(Console.ReadLine());
            var nCows = int.Parse(Console.ReadLine());

            bool no = true;

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            int secretDigit1 = (secretNumber / 1000) % 10;
                            int secretDigit2 = (secretNumber / 100) % 10;
                            int secretDigit3 = (secretNumber / 10) % 10;
                            int secretDigit4 = (secretNumber / 1) % 10;

                            int digitToCheck1 = digit1;
                            int digitToCheck2 = digit2;
                            int digitToCheck3 = digit3;
                            int digitToCheck4 = digit4;

                            int currentBulls = 0;
                            int currentCows = 0;

                            //Find All bulls
                            if (digitToCheck1 == secretDigit1)
                            {
                                currentBulls++;
                                secretDigit1 = -1;
                                digitToCheck1 = -2;
                            }

                            if (digitToCheck2 == secretDigit2)
                            {
                                currentBulls++;
                                secretDigit2 = -1;
                                digitToCheck2 = -2;
                            }

                            if (digitToCheck3 == secretDigit3)
                            {
                                currentBulls++;
                                secretDigit3 = -1;
                                digitToCheck3 = -2;
                            }

                            if (digitToCheck4 == secretDigit4)
                            {
                                currentBulls++;
                                secretDigit4 = -1;
                                digitToCheck4 = -2;
                            }

                            //Find All cows for digit1 count and remove
                            if (digitToCheck1 == secretDigit2)
                            {
                                currentCows++;
                                secretDigit2 = -1;
                            }
                            else if (digitToCheck1 == secretDigit3)
                            {
                                currentCows++;
                                secretDigit3 = -1;
                            }
                            else if (digitToCheck1 == secretDigit4)
                            {
                                currentCows++;
                                secretDigit4 = -1;
                            }

                            //Find All cows for digit2 count and remove
                            if (digitToCheck2 == secretDigit1)
                            {
                                currentCows++;
                                secretDigit1 = -1;
                            }
                            else if (digitToCheck2 == secretDigit3)
                            {
                                currentCows++;
                                secretDigit3 = -1;
                            }
                            else if (digitToCheck2 == secretDigit4)
                            {
                                currentCows++;
                                secretDigit4 = -1;
                            }

                            //Find All cows for digit3 count and remove
                            if (digitToCheck3 == secretDigit1)
                            {
                                currentCows++;
                                secretDigit1 = -1;
                            }
                            else if (digitToCheck3 == secretDigit2)
                            {
                                currentCows++;
                                secretDigit2 = -1;
                            }
                            else if (digitToCheck3 == secretDigit4)
                            {
                                currentCows++;
                                secretDigit4 = -1;
                            }

                            //Find All cows for digit4 count and remove
                            if (digitToCheck4 == secretDigit1)
                            {
                                currentCows++;
                                secretDigit1 = -1;
                            }
                            else if (digitToCheck4 == secretDigit2)
                            {
                                currentCows++;
                                secretDigit2 = -1;
                            }
                            else if (digitToCheck4 == secretDigit3)
                            {
                                currentCows++;
                                secretDigit3 = -1;
                            }

                            if (currentBulls == nBulls && currentCows == nCows)
                            {
                                Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
                                no = false;
                            }
                        }
                    }
                }
            }



            if (no) Console.WriteLine("No");
        }
    }
}
