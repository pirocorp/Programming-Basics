using System;

namespace Sheriff
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var colons = 3 * n;
            var rows = 2 * n + 8;

            //First Line
            Console.WriteLine(new string('.', (3 * n - 1) / 2) +
                                "x" +
                                new string('.', (3 * n - 1) / 2));

            //Second Line
            Console.WriteLine(new string('.', (3 * n - 3) / 2) +
                                "/x\\" +
                                new string('.', (3 * n - 3) / 2));

            //Third Line
            Console.WriteLine(new string('.', (3 * n - 3) / 2) +
                                "x|x" +
                                new string('.', (3 * n - 3) / 2));

            //Second Part
            int x = (3 * n - 1) / 2;
            int r = ((3 * n - 1) / 2 - n);
            bool b = true;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < r; k++)
                    Console.Write(".");
                for (int j = 0; j < x - r; j++)
                    Console.Write("x");
                Console.Write("|");
                for (int j = 0; j < x - r; j++)
                    Console.Write("x");
                for (int k = 0; k < r; k++)
                    Console.Write(".");
                //Console.Write(r);
                Console.WriteLine();
                if (b == true) r--;
                if (b == false) r++;
                if (r == 0) b = false;                         
            }

            //Third Part First Line
            Console.WriteLine(new string('.', (3 * n - 3) / 2) +
                                "/x\\" +
                                new string('.', (3 * n - 3) / 2));

            //Third Part Second Line
            Console.WriteLine(new string('.', (3 * n - 3) / 2) +
                                "\\x/" +
                                new string('.', (3 * n - 3) / 2));

            //Forth Part
            x = (3 * n - 1) / 2;
            r = ((3 * n - 1) / 2 - n);
            b = true;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < r; k++)
                    Console.Write(".");
                for (int j = 0; j < x - r; j++)
                    Console.Write("x");
                Console.Write("|");
                for (int j = 0; j < x - r; j++)
                    Console.Write("x");
                for (int k = 0; k < r; k++)
                    Console.Write(".");
                //Console.Write(r);
                Console.WriteLine();
                if (b == true) r--;
                if (b == false) r++;
                if (r == 0) b = false;
            }

            //Fift Part First Line
            Console.WriteLine(new string('.', (3 * n - 3) / 2) +
                                "x|x" +
                                new string('.', (3 * n - 3) / 2));

            //Fift Part Second Line
            Console.WriteLine(new string('.', (3 * n - 3) / 2) +
                                "\\x/" +
                                new string('.', (3 * n - 3) / 2));

            //Fift Part Third Line
            Console.WriteLine(new string('.', (3 * n - 1) / 2) +
                                "x" +
                                new string('.', (3 * n - 1) / 2));
        }
    }
}
