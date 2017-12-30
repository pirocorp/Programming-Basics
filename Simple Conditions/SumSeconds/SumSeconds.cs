using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sec = a + b + c;
            int min = 0;
            
            while (sec >= 60)
            {
                sec = sec - 60;
                min++;
            }

            if(sec < 10)
            {
                Console.WriteLine(min + ":" + "0" + sec);
            }
            else
            {
                Console.WriteLine(min + ":" + sec);
            }
        }
    }
}
