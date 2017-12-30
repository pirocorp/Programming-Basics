using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            m = m + 15;

            if (m > 59)
            {
                m = m - 60;
                h++;
            }

            if (h > 23)
            {
                h = 0;
            }

            Console.Write(h);
            Console.Write(":");
            if(m < 10)
            {
                Console.WriteLine("0" + m);
            }
            else
            {
                Console.WriteLine(m);
            }
        }
    }
}
