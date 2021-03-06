﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        /// <summary>
        /// Sets the Array for students 
        /// </summary>
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

        /// <summary>
        /// Method to print the heading for the menu 
        /// </summary>
        public void CalculateGrades()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            Console.WriteLine("Please Choose from the following Options >");
            SelectUnits();
        }

        /// <summary>
        /// Take the grade provived and runs a check to see where it sit 
        /// with the grade boundry 
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Menu choices for the user stored in array
        /// </summary>
        public void SelectUnits()
        {

            string[] choices = { "Input Marks", "Output Marks", "Output Stats"
            , "Output Grade Profile", "Exit Application"};

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                InputMarks();              
            }
            else if (choice == 2)
            {
                OutputMarks();
            }
            else if (choice == 3)
            {
                PrintStats();
            }
            else if (choice == 4)
            {
                OutputGradeProfile();
            }
            else if (choice == 5)
            {
                QuitApp();
            }
            else
            {
                Console.WriteLine("\tInvalid choice!");
                SelectUnits();
            }
        }

        /// <summary>
        /// Method to quit the Application.
        /// </summary>
        private void QuitApp()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Method to take the input from the user,
        /// also ensures marks is between 1/100
        /// </summary>
        public void InputMarks()
        {
            Console.WriteLine("\n\tPlease enter a mark for each student.");

            for (int i = 0; i < Students.Length; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($"\nEnter Mark for:" + $" {Students[i]} >", 0,100);

            }
            Console.WriteLine();
            SelectUnits();
        }

        /// <summary>
        /// Out put the marks for the particular student 
        /// </summary>
        public void OutputMarks()
        {
            Console.WriteLine("\nBelow are Grades for all students");

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"\t{Students[i]} {Marks[i]} " +
                    $"{ConvertToGrade(Marks[i])}");
            }
            SelectUnits();

        }

        /// <summary>
        /// Calculate the stats for a student stores max and min in array
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach(int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                if (mark < Maximum)
                { 
                    Minimum = mark;
                }
                total += mark;
            }
            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Prints the stats for the marks 
        /// </summary>
        public void PrintStats()
        {
            CalculateStats();

            Console.WriteLine( "Minimum Mark: " + $"{Minimum}");
            Console.WriteLine( "Maximum Mark: " + $"{Maximum}");
            Console.WriteLine( "Mean Mark: " +  $"{Mean}");

            SelectUnits();
            
        }

        /// <summary>
        /// Calculates the grade profile for a student 
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /// <summary>
        /// Outputs the grade profile and converter the results to percent.
        /// </summary>
        private void OutputGradeProfile()
        {

            CalculateGradeProfile();

            Grades grade = Grades.X;
                Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade}  {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
            SelectUnits();
        }
    }
}
