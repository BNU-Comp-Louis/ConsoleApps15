using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Louis Symons 02/02/21
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BmiCalculator calculator = new BmiCalculator();

        private static StudentGrades grades = new StudentGrades();

        private static NetworkApp app04 = new NetworkApp();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
        
            Console.WriteLine();
            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!");

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Grades",
                                 "Social Network"};
            int choiceNo = ConsoleHelper.SelectChoice(choices);


            String choice = Console.ReadLine();

            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.CalculateIndex();
            }
            else if (choiceNo == 3)
            {
                grades.CalculateGrades();
            }
            else if (choiceNo == 4)
            {
                app04.DisplayMenu();
            }
            else Console.WriteLine("Invalid Choice!");


            
            

            
        }
      
    }
    
}
