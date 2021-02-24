using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BmiCalculator
    {
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double ObeaseCLassI = 34.9;
        public const double ObeaseClassII = 39.9;
        public const double ObeaseClassIII = 40.0;

        public const int InchesToFeet = 12;
        public const int PoundsToStone = 14;

        public string Person;
        public double BmiUser { get; set; }

        public double Centimetres { get; set; }
        public double Inches { get; set; }
        public double Feet { get; set; }
        public double Kilograms { get; set; }
        public double Metres { get; set; }
        public double Pounds { get; set; }
        public double Stone { get; set; }
        public double Bmi { get; set; }
        public double weight;
        public double height;

        public string SelectedUnit;

        public double BmiResult = 0;

        public string[] MenuChoices = { METRIC, IMPERIAL };

        public BmiCalculator()
        {
            weight = 0;
            height = 0;
        }

        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            SelectUnits();

            
            
            GetBmiRange();
            Console.WriteLine(GetBmiRange());
            Console.WriteLine(PrintBameMessage());

            ExitApp();

        }

        public void CalculateImperial()
        {
            double stoneToPounds = (Stone * 14) + Pounds;
            double feetToInches = (Feet * 12) + Inches;
            BmiUser = ((stoneToPounds / feetToInches) / feetToInches) * 703;
        }

        public void CalculateMetric()
        {
            BmiUser = Kilograms / Math.Pow((Centimetres / 100), 2);
        }

        public void InputImperialValues()
        {
            Feet = ConsoleHelper.InputNumber("Please Enter your height in Feet >");
            Inches = ConsoleHelper.InputNumber("\nPlease enter your height in Inches >");
            Stone = ConsoleHelper.InputNumber("\nPlease Enter your weight in Stone >");
            Pounds = ConsoleHelper.InputNumber("\nPlease enter your weight in Pounds >");

        }

        public void InputMetricValues()
        {
            Kilograms = ConsoleHelper.InputNumber("\t\nPlease enter your weight in Kilograms >");
            Centimetres = ConsoleHelper.InputNumber("\t\nPlease enter your weight in Centimetres >");

        }


        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {METRIC}");
            Console.WriteLine($" 2. {IMPERIAL}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void SelectUnits()
        {
            Console.WriteLine("\tPlease choose your measure type >");

            string[] choices = { "Imperial", "Metric" };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                InputImperialValues();
                CalculateImperial();
            }
            else if (choice == 2)
            {
                InputMetricValues();
                CalculateMetric();
            }
            else
            {
                Console.WriteLine("\tInvalid choice!");
                SelectUnits();
            }
        }

        private static string GetChoice(string choice)
        {

            switch (choice)
            {
                case "1": return METRIC;

                case "2": return IMPERIAL;

                default: return "Invalid choice";

            }
        }

        public string GetBmiRange()
        {
            StringBuilder message = new StringBuilder("\n");

            if (BmiUser < Underweight)
            {
                message.Append($" Your BMI is {BmiUser:0.00}," + $"You are Underweight!");
            }
            else if (BmiUser <= Normal)
            {
                message.Append($"Your BMI is {BmiUser:0.00}," + $"You are in the Normal range.");
            }
            else if (BmiUser <= Overweight)
            {
                message.Append($"Your BMI is {BmiUser:0.00}," + $"You are Overweight");
            }
            else if (BmiUser <= ObeaseCLassI)
            {
                message.Append($"Your BMI is {BmiUser:0.00}," + $"You are Obese Class I");
            }
            else if (BmiUser <= ObeaseClassII)
            {
                message.Append($"Your BMI is {BmiUser:0.00}," + $"You are Obese Class II");
            }
            else if (BmiUser <= ObeaseClassIII)
            {
                message.Append($"Your BMI is {BmiUser:0.00}," + $"You are Obese Class III");
            }
            return message.ToString();
        }


        public string PrintBameMessage()
        {
            StringBuilder message = new StringBuilder("\n");
            message.Append("\nIf you are Black, Asian or other ethinic groups,");
            message.Append("\nyou have a higher risk.");
            message.Append("\nAdults 23.0 or more are at increased risk");
            message.Append("\nAdults 27.5 or more are at high risk.");

            return message.ToString();

        }

        public void ExitApp()
        {
            Console.WriteLine("\nWould you like to Calculate another Bmi?");
            Console.WriteLine("\ny / n ?");
            string choice = Console.ReadLine().ToLower();

            if (choice == "y")
            {
                CalculateIndex();
            }
            else if (choice == "n")
            {
                System.Environment.Exit(0);
            }
            else Console.WriteLine("Invalid Choice!");

        }
    }
}
