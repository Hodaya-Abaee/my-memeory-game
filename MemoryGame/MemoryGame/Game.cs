using MemoryGame;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    enum GameTypes
    {
        targil, characters, icon
    }
    internal class Game
    {
        private Dictionary<GameTypes, List<Base>> cards;
        private List<BasePlayer> playersList;
        private int playerIndex;
        private GameTypes type;
        private Board board;

        public Game(Dictionary<GameTypes, List<Base>> cards)
        {
            this.playersList = new List<BasePlayer>();
            UserPlayer player = new UserPlayer();
            BasePlayer bp;
            Console.WriteLine("do you want to play with another user or computer? if user - enter 1, if computer - enter 2");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                bp = new UserPlayer();
            }
            else 
            {
                bp = new ComputerPlayer();
            }
            this.playersList.Add(bp);
            this.playersList.Add(player);
            this.cards = cards;
            Console.WriteLine("what type of game you want to play? \n if you want char card types- enter 1. \n if you want exercise card types- enter 2.\n and if you want icon card types- enter 3. \n Good Luck!");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    this.type = GameTypes.characters; break;
                case 2:
                    this.type = GameTypes.targil; break;
                case 3:
                    this.type = GameTypes.icon; break;
                default:
                    Console.WriteLine("invalid choice"); break;
            }
            this.playerIndex = 0;
            //לשלוח גם מספר כרטיסים
            this.board = new Board(16,cards[type]);
        }

        public bool FindMatch(int index1, int index2)
        {
            if (!board.newCards[index1].CheckMatch(board.newCards[index2]))
                return false;
            playersList[this.playerIndex].cardsList.Add(board.newCards[index1]);
            playersList[this.playerIndex].cardsList.Add(board.newCards[index2]);
            playersList[this.playerIndex].Score += 10;
            board.newCards[index1] = null;
            board.newCards[index2] = null;
            return true;
        }

        public void Winner()
        {
            void PlayerInfo(BasePlayer player)
            {
                Console.Write($"{player.Name}'s cards:");
                player.ShowCards();
                Console.Write($"{player.Name}'s cards collection is: {(player.Score / 10)*2} cards ! \n Your score is: {player.Score}!");
                Console.WriteLine();
            }

            if (playersList[0].Score > playersList[1].Score)
            {
                Console.WriteLine($"The winner is: {playersList[0].Name} ! ! ! 🥳🥳");
            }
            else if (playersList[0].Score < playersList[1].Score)
            {
                Console.WriteLine($"The winner is: {playersList[1].Name} ! ! ! 🥳🥳");
            }
            else
            {
                Console.WriteLine($"The winners are: {playersList[0].Name} and {playersList[1].Name} ! ! ! 🥳🥳");
            }

            PlayerInfo(playersList[0]);
            PlayerInfo(playersList[1]);
        }

        public void GameCourse()
        {
            int choice1, choice2;
            this.playerIndex = 0;

            while (board.AreLeft())
            {
                var p = playersList[this.playerIndex];
                Console.WriteLine($"It's {p.Name}'s turn!");

                board.DrawBoard();

                //בחירת כרטיס 1
                choice1 = playersList[this.playerIndex].ChooseCard();
                while(!board.IsCorrect(choice1))
                {
                    choice1 = playersList[this.playerIndex].ChooseCard();
                }
                board.newCards[choice1].IsOver = true;
                board.DrawBoard();

                //בחירת כרטיס 2
                choice2 = playersList[this.playerIndex].ChooseCard();
                while (!board.IsCorrect(choice2))
                {
                    choice2 = playersList[this.playerIndex].ChooseCard();
                }
                board.newCards[choice2].IsOver = true;
                board.DrawBoard();

                if (board.newCards[choice1].CheckMatch(board.newCards[choice2]))
                {
                    FindMatch(choice1, choice2);
                    Console.WriteLine($"Good Job for player {p.Name}!!! Your score is: {p.Score}, keep it up!");

                    if (!board.AreLeft())
                    {
                        Winner();
                    }
                }
                else
                {
                    board.newCards[choice1].IsOver = false;
                    board.newCards[choice2].IsOver = false;
                    if (playerIndex == 1)
                        playerIndex = 0;
                    else
                        playerIndex = 1;
                }
            }
        }

    }
}
