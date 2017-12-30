﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            for (int number = 0; number < 101; number++)
            { 
            string[] shortName = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
            string[] compositeName = new string[] { "twen", "thir", "four", "fif", "six", "seven", "eigh", "nine" };
            string name = "";

            if ((number < 0) || (number > 100))
                name = "invalid number";
            else if (number < 13)
                name = shortName[number];
            else if (number < 20)
                name = compositeName[number % 10 - 2] + "teen";
            else if (number < 100)
            {
                if (number / 10 == 4) name = "forty";
                else name = compositeName[number / 10 - 2] + "ty";
                if (number % 10 != 0)
                    name += " " + shortName[number % 10];
            }
            else // number = 100
                name = "one hundred";
            Console.WriteLine(name);
            }
        }
    }
}
