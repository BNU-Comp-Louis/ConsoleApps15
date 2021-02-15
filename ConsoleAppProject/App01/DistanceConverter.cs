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

        private double fromDistance;

        private double toDistance;

        private string fromUnit;

        private string toUnit;

        /// <summary>
        /// Constructor of the class to set values of constants and print 
        /// Heading for the user.
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This method will input a distance then calculate 
        /// the same distance in the chosen measurement then 
        /// output the results to the user.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit >");

            toUnit = SelectUnit(" Please select the to distance unit >");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
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

            string unit = ExecuteChoice(choice);

            Console.WriteLine($"\n You have selected {unit}");

            return unit;
        }

        /// <summary>
        /// Will execute the choice that the user selects.
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
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
        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
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
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Output the distance for the user.
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n{fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }

        /// <summary>
        /// Print method for a heading of the app
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("     Distance Converter    ");
            Console.WriteLine("      By Louis Symons       ");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine();
        }   
    }
}
