using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var grade = double.Parse(Console.ReadLine());
            var payroll = double.Parse(Console.ReadLine());
            double scholarshipSocial = 0;
            double scholarship = 0;
            if (income < payroll && grade > 4.5)
            {
                scholarshipSocial = payroll * 0.35;
            }

            if (grade >= 5.5)
            {
                scholarship = grade * 25;
            }

            if (scholarshipSocial == 0 && scholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                if (scholarshipSocial > scholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(scholarshipSocial)} BGN");
                }

                if (scholarship >= scholarshipSocial)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarship)} BGN");
                }
            }
        }
    }
}
