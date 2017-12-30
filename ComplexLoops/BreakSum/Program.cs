using System;

namespace BreakSum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            for (int i = 1; i < 3; i++)
            {
                if (end)
                {
                    break;
                }
                else
                {
                    for (int j = 3; j >= 1; j--)
                    {
                        if(i + j == 2)
                        {
                            end = true;
                            break;
                        }
                       Console.WriteLine(i + " " + j);                        
                    }
                }
            }
        }
    }
}
