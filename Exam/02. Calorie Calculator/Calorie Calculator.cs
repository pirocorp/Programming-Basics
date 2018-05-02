namespace _02.Calorie_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CalorieCalculator
    {
        public static void Main()
        {
            var gender = Console.ReadLine();
            var kg = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine()); //In meters
            var age = int.Parse(Console.ReadLine());
            var inputString = Console.ReadLine();

            var bhm = 0.0;

            if (gender == "m")
            {
                bhm = 66 + (13.7 * kg) + (5 * height * 100) - (6.8 * age);
            }
            else
            {
                bhm = 655 + (9.6 * kg) + (1.8 * height * 100) - (4.7 * age);
            }

            switch (inputString)
            {
                case "sedentary":
                    bhm *= 1.2;
                    break;
                case "lightly active":
                    bhm *= 1.375;
                    break;
                case "moderately active":
                    bhm *= 1.55;
                    break;
                case "very active":
                    bhm *= 1.725;
                    break;
            }

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bhm)} calories per day.");
        }
    }
}
