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
            Console.WriteLine("Not completed");
        }


    }
}
