using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Ismaeel's version 0.6
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";
        
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// This method will input thee distance measured in miles
        /// calculate the same distance in feet, and output the 
        /// distance in feet.
        /// </summary>



        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select the to Distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();


        }

        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }

            // Round the toDistance to 2 decimal places
            ToDistance = Math.Round(ToDistance, 2);
        }

        private string SelectUnit(string prompt)
        {
            string choice;
            string unit;

            do
            {
                choice = DisplayChoices(prompt);
                unit = ExecuteChoice(choice);

                if (unit == null)
                {
                    Console.WriteLine("\nInvalid choice! Please select a valid option.");
                }

            } while (unit == null);

            Console.WriteLine($"\nYou have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }

            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }



        /// <summary>
        /// Prompt the user to enter thew distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance (string prompt)
        {
            double result = 0.0;
            bool error = false;
            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();
                try
                {
                    result = Convert.ToDouble(value);
                    if (result < 0)
                    {
                        error = true;
                        Console.WriteLine(" invalid entry & repeat");
                    }
                    else
                    {
                        break;
                    }
                    //break;
                }
                catch (Exception e)
                {
                    error = true;
                    Console.WriteLine(" invalid entry & repeat");
                }
            }
            while (error == true);
            return result;
        }


        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is  {ToDistance} {ToUnit} !\n" );
        }

      
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("         Distance Converter                             ");
            Console.WriteLine("      by Ismaeel Omer                                      ");
            Console.WriteLine("------------------------------------------------------------\n");

        }
    }
}
