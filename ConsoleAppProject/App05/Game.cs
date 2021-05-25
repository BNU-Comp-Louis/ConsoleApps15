using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
   public class Game
    {
        public const int MAXIMUM_ROUND = 10;

        public int Round { get; set; }

        public int LastRound;

        public Player Human { get; }

        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }

        private Random generator = new Random(55);

        public Game(string name)
        {
            Human = new Player(name, GamePlayers.Player);
            Computer = new Player("Computer", GamePlayers.Computer);

            Round = 0;

        }

        public void Start()
        {
            Round = 1;
            LastRound = 5;
            CurrentPlayer = Human;
            Human.Score = 0;
            Computer.Score = 0;

        }

        public void MakeComputerChoice()
        {
            int choice = generator.Next(1,4);

            switch(choice)
            {
                case 1: Computer.Choice = GameChoices.Paper; break;
                case 2: Computer.Choice = GameChoices.Rock; break;
                case 3: Computer.Choice = GameChoices.Scissors; break;
            }
        }

        public void ScoreRound()
        {
            if(Human.Choice == GameChoices.Rock &&
                Computer.Choice == GameChoices.Paper)
            {
                Computer.Score += 2;
                Winner = Computer;
            }
            //ADD 5 MORE CONBINATIONS 
            if (Round < LastRound)
            {
                Round++;
            }
            else End();
        }

        public void End()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
            }
            else Winner = null;
        }
    }
}
