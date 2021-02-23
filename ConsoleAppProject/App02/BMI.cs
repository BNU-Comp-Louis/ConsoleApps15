using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
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
        public double Index;

        public double Centimetres;
        public double Inches;
        public double Feet;
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

        public BMI()
        {
            weight = 0;
            height = 0;
        }

        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            SelectUnits();

            
            
            BmiRange();
            DisplayBmi();
            PrintHealthMessage();

        }

        public void CalculateImperial()
        {
            Index = (double)Pounds * 703 / (Inches * Inches);
        }

        public void CalculateMetric()
        {
            Index = Kilograms / Math.Pow((Centimetres / 100), 2);
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
        public void DisplayBmi()
        {
            Console.WriteLine("You are in the range: " + Person);
            Console.WriteLine();
            Console.WriteLine($"Your BMI is {Index:0.00}");
        }

        public void BmiRange()
        {
            if (Index < 18.5)
            {
                Person = "Underweight";
            }
            else if (Index >= 18.5 && Index <= 24.9)
            {
                Person = "Healthy";
            }
            else if (Index >= 25.0 && Index <= 29.9)
            {
                Person = "Overweight";
            }
            else if (Index >= 30.0 && Index <= 34.9)
            {
                Person = "Obese level 1";
            }
            else if (Index >= 35.0 && Index <= 39.9)
            {
                Person = "Obese level 2";
            }
            else if (Index >= 40.0)
            {
                Person = "Obese level 3";
            }
        }


        public void PrintHealthMessage()
        {
            Console.WriteLine("\nIf you are Black, Asian or other ethinic groups,");
            Console.WriteLine("\nyou have a higher risk.");
            Console.WriteLine("\nAdults 23.0 or more are at increased risk");
            Console.WriteLine("\nAdults 27.5 or more are at high risk.");

        }
    }
}
