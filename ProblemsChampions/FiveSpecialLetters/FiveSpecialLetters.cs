using System;

namespace FiveSpecialLetters
{
    class FiveSpecialLetters
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            var weight = 0;
            bool no = true;

            //Generating 5 leter string
            for (char c1 = 'a'; c1 <= 'e'; c1++)
            {
                for (char c2 = 'a'; c2 <= 'e'; c2++)
                {
                    for (char c3 = 'a'; c3 <= 'e'; c3++)
                    {
                        for (char c4 = 'a'; c4 <= 'e'; c4++)
                        {
                            for (char c5 = 'a'; c5 <= 'e'; c5++)
                            {
                                weight = WeightString(c1, c2, c3, c4, c5);
                                if (weight >= start && weight <= end)
                                {
                                    Console.Write("" + c1 + c2 + c3 + c4 + c5 + " ");
                                    no = false;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if(no) Console.WriteLine("No");
        }

        static int WeightString (char c1, char c2, char c3, char c4, char c5)
        {
            var weight = 0;
            var multiple = 1;

            weight += Weight(c1, multiple);
            if (c2 != c1)
            {
                multiple++;
                weight += Weight(c2, multiple);
            }
            if (c3 != c1 && c3 != c2)
            {
                multiple++;
                weight += Weight(c3, multiple);
            }
            if (c4 != c1 && c4 != c2 && c4 != c3)
            {
                multiple++;
                weight += Weight(c4, multiple);
            }
            if (c5 != c1 && c5 != c2 && c5 != c3 && c5 != c4)
            {
                multiple++;
                weight += Weight(c5, multiple);
            }
            return weight;
        }

        static int Weight (char c, int multiple)
        {
            var weightA = 5;
            var weightB = -12;
            var weightC = 47;
            var weightD = 7;
            var weightE = -32;
            var weight = 0;

            switch (c)
            {
                case 'a': weight += multiple * weightA; break;
                case 'b': weight += multiple * weightB; break;
                case 'c': weight += multiple * weightC; break;
                case 'd': weight += multiple * weightD; break;
                case 'e': weight += multiple * weightE; break;
            }

            return weight;
        }
    }
}
