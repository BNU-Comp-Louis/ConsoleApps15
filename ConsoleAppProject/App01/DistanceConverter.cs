using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Louis Symons version 0.1
    /// </author>
    public class DistanceConverter
    {

        private double miles;

        private double feet;

        private double meters;

        private const String MILES = "miles";

        private const String FEET = "feet";

        private const String QUIT = "quit";

        private const String METERS = "meters";

        /// <summary>
        /// Constructor of the class to set values of constants and print 
        /// Heading for the user.
        /// </summary>
        public DistanceConverter()
        {
            miles = 0;
            feet = 0;
            meters = 0;

            OutputHeading();
        }

        /// <summary>
        /// Method to check the user input and pass to the switch case.
        /// </summary>
         public void Run()
        {
            Boolean finished = false; 

                while (!finished)
            {
                PrintMenuItems();

                String choice = GetString();
                if (choice.Equals(QUIT))
                    finished = true;
                else
                    ProcessChoice(choice);
            }

        }

        /// <summary>
        /// Switch case to process the users inputs.
        /// </summary>
        /// <param name="choice"></param>
        private void ProcessChoice(String choice)
        {
            switch (choice)
            {
                case MILES:
                    InputMiles();               
                    CalculateFeet();
                    ConvertMilesToFeet();
                    PrintMilesResults();
                    break;
                case FEET:
                    InputFeet();
                    CalculateMiles();
                    ConvertFeettoMiles();
                    PrintFeetResults();
                    break;
                case METERS:
                    InputMeters();
                    CalculateMeters();
                    ConvertMeterstoMiles();
                    PrintMetersResults();
                    break;
                default:
                    Console.WriteLine("Menu choice not found!");
                    break;

            }
        }

        /// <summary>
        /// Provides a message to the use to prompt a input based on menu items.
        /// Reads the Input that the user provides.
        /// </summary>
        /// <returns></returns>
        public String GetString()
        {
            Console.WriteLine("Type one of the menu options to select ");         // print prompt
            String inputLine = Console.ReadLine();

            return inputLine;
        }

        /// <summary>
        /// Convert miles to feet
        /// </summary>
        /// <returns></returns>
        private double ConvertMilesToFeet()
        {
           return  (miles * 5280);
        }

        /// <summary>
        /// Convert feet to miles
        /// </summary>
        /// <returns></returns>
        private double ConvertFeettoMiles()
        {
            return (feet / 5280);
        }

        /// <summary>
        /// Convert meters to miles
        /// </summary>
        /// <returns></returns>
        private double ConvertMeterstoMiles()
        {
            return (miles * 1609.34);
        }

        /// <summary>
        /// Print results
        /// </summary>
        private void PrintMilesResults()
        {
            Console.WriteLine(miles + " Miles is: " + feet + " Feet");
        }

        /// <summary>
        /// Print results
        /// </summary>
        private void PrintFeetResults()
        {
            Console.WriteLine(feet + " Feet is: " + miles + " Miles");
        }

        /// <summary>
        /// Print results
        /// </summary>
        private void PrintMetersResults()
        {
            Console.WriteLine(miles + " Miles is: " + meters + " Meters");
        }

        ///<summary>
        /// Reads user Input for for miles and converts it to doulbe. 
        ///<summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Reads user Input for for miles and converts it to doulbe. 
        /// </summary>
        private void InputFeet()
        {
            Console.WriteLine("Please Enter the number of Feet >");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// Reads user Input for for miles and converts it to doulbe. 
        /// </summary>
        private void InputMeters()
        {
            Console.WriteLine("Please Enter the number of Miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        ///<summary>
        /// Calculation for feet to miles.
        ///<summary>
        
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Calculation for miles to feet
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / 5280;
        }

        /// <summary>
        /// Calculation for meters to miles.
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * 1609.34;
        }
        
        /// <summary>
        /// Print method for a heading of the app
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("   Convert Miles to Feet    ");
            Console.WriteLine("      By Louis Symons       ");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine();
        }   

        /// <summary>
        /// Print method for menu items for the user to select.
        /// </summary>
        private void PrintMenuItems()
        {
            Console.WriteLine("\nPlease select the unit you want to convert");
            Console.WriteLine("(Miles)");
            Console.WriteLine("(Feet)");
            Console.WriteLine("(Metres)");
        }
    }
}
