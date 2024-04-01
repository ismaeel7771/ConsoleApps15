﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Ismaeel Omer  25/01/2024
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();
        private static StudentGrades grader = new StudentGrades();
        private static NewsApp app = new NewsApp();

        internal static BMI BMI
        {
            get => default;
            set
            {
            }
        }

        public static App01.ConsoleAppProject.App01.DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();


            //DistanceConverter converter = new DistanceConverter();
            //converter.ConvertDistance();

            // Display menu to choose between apps
            int appChoice = DisplayAppMenu("Choose an app to run:\n1. Distance Converter\n2. BMI Calculator\n3. Student Grades\n4. Social App");

            // Run the chosen app
            switch (appChoice)
            {
                case 1:
                    RunDistanceConverter();
                    break;

                case 2:
                    RunBMIApp();
                    break;

                case 3:
                    RunStudentGradesApp();
                    break;

                case 4:
                    RunSocialApp();
                    break;
                   
                default:
                    Console.WriteLine("Invalid choice. Exiting the program.");
                    break;
            }

        }

        private static int DisplayAppMenu(string prompt)
        {
            int choice;

            Console.WriteLine(prompt);
            Console.Write("Enter your choice: ");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Invalid input. Please enter a valid choice: ");
            }

            return choice;
        }


        private static void RunDistanceConverter()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ConvertDistance();
        }

        private static void RunBMIApp()
        {
            BMI bmi = new BMI();
            bmi.Main();
        }

        private static void RunStudentGradesApp()
        {
            StudentGrades studentGrades = new StudentGrades();
            studentGrades.Run();
        }

        private static void RunSocialApp() 
        {
            NewsApp news = new NewsApp();
            news.DisplayMenu();
        }


    }
}
