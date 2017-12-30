using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 10000; i++)
            {
                var x = i;
                bool special = true;
                while (x > 0)
                {
                    var ostatuk = x % 10;
                    if (ostatuk == 0)
                    {
                        special = false; break;
                    }
                    if (n % ostatuk != 0)
                    {
                        special = false;
                        break;
                    }
                    else
                    {
                        x = x / 10;
                    }                        
                }
                if (special) Console.Write(i + " ");
            }
        }
    }
}
