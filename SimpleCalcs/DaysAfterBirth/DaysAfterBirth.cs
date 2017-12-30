using System;

namespace DaysAfterBirth
{
    class DaysAfterBirth
    {
        static void Main(string[] args)
        {
             //Data Input
             string datenow = Console.ReadLine();
             

             //Converting Input string into DateTime
             DateTime DT = DateTime.ParseExact(datenow, "dd-MM-yyyy", null);
             //var DT2 = DT;
             

            //Adding days
            DT = DT.AddDays(1000);

             //Converting DateTime to String
             datenow = DT.ToString("dd-MM-yyyy");

             //Output String
             Console.WriteLine(datenow);
             //Console.WriteLine(DT2.AddDays(1000).ToString("dd-MM-yyyy"));
        }
    }
}
