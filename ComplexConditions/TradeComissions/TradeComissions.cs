﻿using System;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commision = -1.0;

            if(town =="sofia")
            {
                if (sales >= 0 && sales <= 500) commision = 0.05;
                if (sales > 500 && sales <= 1000) commision = 0.07;
                if (sales > 1000 && sales <= 10000) commision = 0.08;
                if (sales > 10000) commision = 0.12;

            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500) commision = 0.045;
                if (sales > 500 && sales <= 1000) commision = 0.075;
                if (sales > 1000 && sales <= 10000) commision = 0.10;
                if (sales > 10000) commision = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) commision = 0.055;
                if (sales > 500 && sales <= 1000) commision = 0.08;
                if (sales > 1000 && sales <= 10000) commision = 0.12;
                if (sales > 10000) commision = 0.145;
            }
            if(commision > 0)
                Console.WriteLine("{0:f2}", sales * commision);
            else
                Console.WriteLine("error");
        }
    }
}
