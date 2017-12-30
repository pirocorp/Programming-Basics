using System;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int c1 = 1; c1 <= n; c1++)
            {
                for (int c2 = 1; c2 <= n; c2++)
                {
                    for (char c3 = 'a'; c3 < 97 + l; c3++)
                    {
                        for (char c4 = 'a'; c4 < 97 + l; c4++)
                        {
                            for (int c5 = 1; c5 <= n; c5++)
                            {
                                if (c5 > c1 && c5 > c2)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", c1, c2, c3, c4, c5);

                                }
                            }

                        }
                    }
                }
            }
        }
    }
}
