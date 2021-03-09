using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public const int LowestMark = 0;
        public const int LowestDMark = 40;
        public const int LowestCMark = 50;
        public const int LowestBMark = 60;
        public const int LowestAMark = 70;
        public const int MaxMark = 100;

        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int [] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Phil", "Dave", "Anna", "Emma",
                "Sam", "Joe", "Mike", "Alice",
                "Lauren", "Karl"
            };

            GradeProfile = new int[(int) Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void CalculateGrades()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            Console.WriteLine("Please Choose from the following Options >");
            SelectUnits();
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestDMark)
            {
                return Grades.F;
            }
            else if (mark >= LowestDMark && mark < LowestCMark)
            {
                return Grades.D;
            }
            else if (mark >= LowestCMark && mark < LowestBMark)
            {
                return Grades.C;
            }
            else if (mark >= LowestBMark && mark < LowestAMark)
            {
                return Grades.B;
            }
            else if (mark >= LowestAMark && mark <= MaxMark)
            {
                return Grades.A;
            }
            else return Grades.X;
        }

        public void SelectUnits()
        {
            Console.WriteLine("\tPlease from the following options >");

            string[] choices = { "Input Marks", "Output Marks", "Output Stats"
            , "Output Grade Profile", "Exit Application"};

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                InputMarks();              
            }
            else if (choice == 2)
            {
                Console.WriteLine("Test");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Test");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Test");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Test");
            }
            else
            {
                Console.WriteLine("\tInvalid choice!");
                SelectUnits();
            }
        }

        public void InputMarks()
        {
            Console.WriteLine("\n\tPlease enter a mark for each student.");

            
        }
    }
}
