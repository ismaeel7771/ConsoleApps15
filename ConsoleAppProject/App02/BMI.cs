using System;

namespace ConsoleAppProject.App02
{
    class BMI
    {
        public void Main()
        {
            // Ask user for weight in kilograms
            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Ask user for height in meters
            Console.Write("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            double bmi = CalculateBMI(weight, height);

            // Display BMI
            Console.WriteLine("Your BMI is: " + bmi.ToString("F2"));

            // Check BMI category
            string bmiCategory = GetBMICategory(bmi);
            Console.WriteLine("BMI Category: " + bmiCategory);

            Console.ReadLine();
        }
        public void DisplayMessage()
        {
           Console.WriteLine("\n if you are Black, Asian or other minority ethnic groups, " +
                " you have a higher risk, Adults at 23.0 or more are at increased risk," +
                " Adults at 27.5 or more are at high risk.");
        }
        // Method to calculate BMI
        static double CalculateBMI(double weight, double height)
        {
            // BMI formula: weight / (height * height)
            double bmi = weight / (height * height);
            return bmi;
        }

        // Method to get BMI category
        static string GetBMICategory(double bmi)
        {
            string bmiCategory;

            if (bmi < 18.5)
            {
                bmiCategory = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                bmiCategory = "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                bmiCategory = "Overweight";
            }
            else if (bmi >= 30)
            {
                bmiCategory = "Obese";
            }
            else
            {
                bmiCategory = "Unknown";
            }

            return bmiCategory;
        }
    }
}