using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    public class GameView
    {
        private Game game;

        public void Play()
        {
            bool wantToQuit = false;

            do
            {
                StartGame();

                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);
                game.MakeComputerChoice();
                DisplayChoice(game.Computer.Choice);

                game.ScoreRound();

                if (game.Round == game.LastRound)
                {
                    Console.WriteLine();
                }

            } while (!wantToQuit);
        }

        private void DisplayChoice(GameChoices choice)
        {
            throw new NotImplementedException();
        }

        private void GetPlayerChoice()
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            SetupConsole();

            ConsoleHelper.OutputHeading("   Rock-Paper-Scissors Game");

            if(game == null)
            {
                Console.Write(" Please enter your name >");
                string name = Console.ReadLine();

                game = new Game("Louis");
            }

            game.Start();
        }

        public void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }
    }
}
