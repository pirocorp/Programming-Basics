using System;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int uncaredPatients = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                    if (uncaredPatients > treatedPatients) doctors++;
                if (doctors - x >= 0)
                {
                    treatedPatients = treatedPatients + x;
                }
                else
                {
                    treatedPatients = treatedPatients + doctors;
                    uncaredPatients = uncaredPatients + x - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {uncaredPatients}.");
        }
    }
}
