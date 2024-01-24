using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit and it will calculate and
    /// output the equivalent distance in another unit.
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// 
        /// </summary>



        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");
            

           miles =  InputDistance("Please enter the number of miles > ");
            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));

        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));

        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), feet, nameof(metres));

        }
      
        

        /// <summary>
        /// Prompt the user to enter thew distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance (string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }


        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is  {toDistance} {toUnit} !" );
        }

      
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("         Distance Converter                             ");
            Console.WriteLine("      by Ismaeel Omer                                      ");
            Console.WriteLine("-----------------------------------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
