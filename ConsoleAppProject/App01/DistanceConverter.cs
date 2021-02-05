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
        public const int FEET_IN_MILES = 5280

        private double miles;

        private double feet;
        
        /// <summary>
        /// 
        /// </summary>

        public DistanceConverter()
        {
            miles = 0;
            feet = 0;

           miles = GetMiles();
           feet = ConvertMilesToFeet();
           PrintResults();
        }

        public double GetMiles()
        {
            Console.WriteLine("Please Input the number of Miles: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private double ConvertMilesToFeet()
        {
           return  (miles * 5280);
        }

        private void PrintResults()
        {
            Console.WriteLine(miles + "miles is " + feet "feet" )
        }

         public void Run()
        {

            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        ///<summary>
        ///
        ///<summary>
        }
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        ///<summary>
        ///
        ///<summary>
        }
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        ///<summary>
        ///
        ///<summary>
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------- ")
            Console.WriteLine("   Convert Miles to Feet    ")
            Console.WriteLine("      By Louis Symons       ") 
            Console.WriteLine(" -------------------------- ")
            Console.WriteLine();
        }   
    }
}
