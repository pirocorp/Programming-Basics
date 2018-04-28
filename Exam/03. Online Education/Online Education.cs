namespace _03.Online_Education
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OnlineEducation
    {
        public static void Main()
        {
            var totalOnline = 0;
            var totalOnsite = 0;

            for (var i = 0; i < 3; i++)
            {
                var inputString = Console.ReadLine().ToLower();
                var students = int.Parse(Console.ReadLine());

                if (inputString == "online")
                {
                    totalOnline += students;
                }
                else
                {
                    if (totalOnsite + students <= 600)
                    {
                        totalOnsite += students;
                    }
                    else
                    {
                        var left = totalOnsite + students - 600;
                        totalOnsite = 600;
                        totalOnline += left;
                    }
                }
            }

            Console.WriteLine($"Online students: {totalOnline}");
            Console.WriteLine($"Onsite students: {totalOnsite}");
            Console.WriteLine($"Total students: {totalOnsite + totalOnline}");
        }
    }
}
