using System;

namespace GroupName
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char s1 = char.Parse(Console.ReadLine());
            char s2 = char.Parse(Console.ReadLine());
            char s3 = char.Parse(Console.ReadLine());
            char s4 = char.Parse(Console.ReadLine());
            var s5 = int.Parse(Console.ReadLine());

            int counter = -1;
            for (char i1 = 'A'; i1 <= s1; i1++)
            {
                for (char i2 = 'a'; i2 <= s2; i2++)
                {
                    for (char i3 = 'a'; i3 <= s3; i3++)
                    {
                        for (char i4 = 'a'; i4 <= s4; i4++)
                        {
                            for (int i5 = 0; i5 <= s5; i5++)
                            {
                                counter++;
                                //Console.Write($"{i1}{i2}{i3}{i4}{i5} ");
                            }

                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
