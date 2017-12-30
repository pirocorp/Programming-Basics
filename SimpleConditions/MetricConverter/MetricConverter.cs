using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double m = 1;
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;
            double x = double.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string d = Console.ReadLine();
            //Source
            if (s == "m")
            {
                x = x / m;
            }
            if (s == "mm")
            {
                x = x / mm;
            }
            if (s == "cm")
            {
                x = x / cm;
            }
            if (s == "mi")
            {
                x = x / mi;
            }
            if (s == "in")
            {
                x = x / inch;
            }
            if (s == "km")
            {
                x = x / km;
            }
            if (s == "ft")
            {
                x = x / ft;
            }
            if (s == "yd")
            {
                x = x / yd;
            }

            //Destination
            if (d == "m")
            {
                x = x * m;
            }
            if (d == "mm")
            {
                x = x * mm;
            }
            if (d == "cm")
            {
                x = x * cm;
            }
            if (d == "mi")
            {
                x = x * mi;
            }
            if (d == "in")
            {
                x = x * inch;
            }
            if (d == "km")
            {
                x = x * km;
            }
            if (d == "ft")
            {
                x = x * ft;
            }
            if (d == "yd")
            {
                x = x * yd;
            }
            Console.WriteLine($"{x:f8}"); //Интерполация закръгля до 8-я знак след десетичната запетая
        }
    }
}
