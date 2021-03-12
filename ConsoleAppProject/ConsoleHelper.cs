using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="choices"></param>
        /// <returns></returns>
        public static int SelectChoice(string[] choices)
        {
            DisplayChoices(choices);

            int choiceNo = (int)InputNumber("\nPlease Enter your choice >", 1, choices.Length);
            return choiceNo;
        }

        /// <summary>
        /// Print method for a heading of the app
        /// </summary>
        public static void OutputHeading(string title)
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine($"     {title}    ");
            Console.WriteLine("      By Louis Symons       ");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine();
        }


        /// <summary>
        /// Method for displays user choices
        /// </summary>
        /// <param name="choices"></param>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"     {choiceNo}.    {choice}");
            }

            
        }

        /// <summary>
        /// Genrenic method to read input from the user 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool IsValid = false;

            do
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    IsValid = true;
                }
                catch (Exception)
                {
                    IsValid = false;
                    Console.WriteLine(" Invalid Number!");
                }
            } while (!IsValid);

            return number;

        }

        /// <summary>
        /// Input method for the user 
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool Isvalid = false;
            double number = 0;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    Isvalid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else Isvalid = true;
            } while (!Isvalid);

            return number;
        }

     
    }
}
