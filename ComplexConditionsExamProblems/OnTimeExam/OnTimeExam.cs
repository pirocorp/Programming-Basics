using System;

namespace OnTimeExam
{
    class OnTimeExam
    {
        static void Main(string[] args)
        {
            var hExam = int.Parse(Console.ReadLine());
            var mExam = int.Parse(Console.ReadLine());
            var hArrival = int.Parse(Console.ReadLine());
            var mArrival = int.Parse(Console.ReadLine());

            //string OnTime;
            var ExamTime = hExam * 60 + mExam;
            var ArrivalTime = hArrival * 60 + mArrival;
            if (ArrivalTime >= ExamTime - 30 && ArrivalTime <= ExamTime)
            {
                var x = ExamTime - ArrivalTime;
                Console.WriteLine("On time");
                if (x != 0)
                {
                    Console.WriteLine($"{x} minutes before the start");
                }
            }
            else if (ArrivalTime > ExamTime)
            {
                Console.WriteLine("Late");
                var x = ArrivalTime - ExamTime;
                var h = 0;
                var m = 0;
                while (x >= 60)
                {
                    h++;
                    x = x - 60;
                }
                m = x;
                if (h > 0)
                {
                    Console.WriteLine($"{h}:{m:00} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{m} minutes after the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                var x = ExamTime - ArrivalTime;
                var h = 0;
                var m = 0;
                while (x >= 60)
                {
                    h++;
                    x = x - 60;
                }
                m = x;
                if (h > 0)
                {
                    Console.WriteLine($"{h}:{m:00} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{m} minutes before the start");
                }
            }
        }
    }
}
