using System;

namespace Java
{
    class Java
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n + 6;
            var length = 3 * n + 1;
            var javarow = (n - 2) / 2;
            
            //First Part ~ ~ ~
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n));
                Console.WriteLine("~ ~ ~");
            }
            
            //Second Part ====
            Console.WriteLine(new string('=', (width - 1)));
            
            //Third Part
            if (n == 3)
                Console.WriteLine("|~~~JAVA~~~|  |");
            else
            {
                var rows = n - 2;
                for (int i = 0; i < rows; i++)
                {
                    if(i == javarow)
                    {
                        Console.WriteLine("|" + 
                                            new string('~', n) + 
                                            "JAVA" + 
                                            new string('~', n) + 
                                            "|" + 
                                            new string(' ', n-1) +
                                            "|");
                    }
                    else
                    {
                        Console.WriteLine("|" + 
                                            new string('~', n * 2 + 4) +
                                            "|" +
                                            new string(' ', n - 1) +
                                            "|");
                    }
                }
            }   
            
            //Forth Parth
            Console.WriteLine(new string('=', (width - 1)));

            //Fift Part
            var at = n * 2 + 4;
            var spaces =0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', spaces) + 
                                    "\\" + 
                                    new string('@', at) +
                                   "/" );
                spaces++;
                at = at - 2;
            }

            //Sixt Part
            Console.WriteLine(new string('=', n * 2 + 6));
        }
    }
}
