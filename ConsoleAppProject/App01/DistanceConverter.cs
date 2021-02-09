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

        private const String MILES = "miles";

        private const String QUIT = "quit";

        /// <summary>
        /// 
        /// </summary>

        public DistanceConverter()
        {
            miles = 0;
            feet = 0;

            OutputHeading();
        }

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

        private void ProcessChoice(String choice)
        {
            switch (choice)
            {
                case MILES:
                    InputMiles();               
                    CalculateFeet();
                    ConvertMilesToFeet();
                    PrintResults();
                    break;
                default:
                    Console.WriteLine("Menu choice not found!");
                    break;

            }
        }

        public String GetString()
        {
            Console.WriteLine("Type one of the menu options to select ");         // print prompt
            String inputLine = Console.ReadLine();

            return inputLine;
        }




        public double GetMiles()
        {
            Console.WriteLine("...");
            return Convert.ToDouble(Console.ReadLine());
        }

        private double ConvertMilesToFeet()
        {
           return  (miles * 5280);
        }

        private void PrintResults()
        {
            Console.WriteLine(miles + " Miles is: " + feet + " feet");
        }


        ///<summary>
        ///
        ///<summary>
        
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        ///<summary>
        ///
        ///<summary>
        
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        ///<summary>
        ///
        ///<summary>
        

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("   Convert Miles to Feet    ");
            Console.WriteLine("      By Louis Symons       ");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine();
            
        }   

        private void PrintMenuItems()
        {
            Console.WriteLine("\nPlease select the unit you want to convert");
            Console.WriteLine("(Miles)");
            Console.WriteLine("(Feet)");
            Console.WriteLine("(Metres)");
        }
    }
}
