using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The app will ask the user to specify a measurement for conversion
    /// then will calaculate the conversion and provide the results to 
    /// the user.
    /// </summary>
    /// <author>
    /// Louis Symons version 0.3
    /// </author>
    public class DistanceConverter
    {

        public const string FEET = "Feet";

        public const string METRES = "Metres";

        public const string MILES = "Miles";

        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const String QUIT = "quit";

        public double FromDistance { get; set; }

        public double ToDistance { get; set; }

        public string FromUnit { get; set; }

        public string ToUnit  { get; set; }

        /// <summary>
        /// Constructor of the class to set values of constants and print 
        /// Heading for the user.
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// This method will input a distance then calculate 
        /// the same distance in the chosen measurement then 
        /// output the results to the user.
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            Boolean finished = false;

            while (!finished)
            {
                FromUnit = null;
                ToUnit = null;

                FromUnit = SelectUnit(" Please select the from distance unit >");

                ToUnit = SelectUnit(" Please select the to distance unit >");

                Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

                FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

                CalculateDistance();

                OutputDistance();

                finished = QuitApplication();
            }

            Console.WriteLine("Application Finshed");
        }

        private bool QuitApplication()
        {
            Console.WriteLine("\nDo you want to quit application?");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Checks for the selcted choice then prints a message to 
        /// show the user what they have selected.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = GetChoice(choice);

            if (Equals(unit, "Invalid choice"))
            {
                Console.WriteLine("Invalid choice");
                unit = SelectUnit(prompt);

            }
            else
            {
                Console.WriteLine($"\n You have selected {unit}");

            }

            return unit;
        }

        /// <summary>
        /// Will execute the choice that the user selects.
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static string GetChoice(string choice)
        {

            switch (choice)
            {
                case "1": return FEET;

                case "2": return METRES;

                case "3": return MILES;

                default: return "Invalid choice";

            }
        }

        /// <summary>
        /// Displays the choices for the user to select to convert.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
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
        /// Calculations for the measurements that the user enters.
        /// </summary>
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
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
        }

        /// <summary>
        /// Read the input from the user and then converts to input.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();

            while (true)
            {
                if (IsAllDigits(value))
                {
                    return Convert.ToDouble(value);
                }
                else
                {
                    Console.WriteLine(" \nInvalid Input Digits only allowed\n");
                    Console.Write(prompt);
                    value = Console.ReadLine();
                }

            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool IsAllDigits(string value)
        {
            foreach (char symbol in value)
            {
                if (!char.IsDigit(symbol)&& symbol!='.')
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Output the distance for the user.
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n{FromDistance} {FromUnit} is {ToDistance} {ToUnit}");
        }

       
    }
}
