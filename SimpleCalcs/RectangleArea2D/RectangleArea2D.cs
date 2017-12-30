using System;


namespace RectangleArea2D
{
    class RectangleArea2D
    {
        static void Main(string[] args)
        {
            //Input Data
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            //Calculating the sides of rectangle
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var height = Math.Max(y1, y2) - Math.Min(y1, y2);

            //Calculating Area and Perimeter
            var area = width * height;
            var per = (width + height) * 2;

            //Output Data
            Console.WriteLine(area);
            Console.WriteLine(per);              
        }
    }
}
