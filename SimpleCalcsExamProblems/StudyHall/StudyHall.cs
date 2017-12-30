using System;

namespace StudyHall
{
    class StudyHall
    {
        static void Main(string[] args)
        {
            //Data Input
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            //Converting Data in cm
            length = length * 100;
            width = width * 100;

            //Calculating seats
            int cols = ((int) width - 100) / 70;
            int rows = (int) length / 120; 
            /* var cols = Math.Floor((width - 100) / 70);
            var rows = Math.Floor(length / 120); */
            var seats = cols * rows - 3;
        
            //Output Result
            Console.WriteLine(seats);
        }
    }
}
