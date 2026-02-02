using MemoryGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Board
    {
        private int boardSize;
        public Base [] newCards;

        Random rnd = new Random();

        public Board(int boardSize, List<Base> cards)
        {
            RestartBoard(boardSize, cards);
        }

        //אתחול הלוח
        public void RestartBoard(int boardSize, List<Base> cards)
        {
            this.boardSize = boardSize;
            this.newCards = new Base[boardSize];

            foreach (Base card in cards)
            {
                int num = rnd.Next(boardSize);
                while (newCards[num] != null)
                    num = rnd.Next(boardSize);
                if (newCards[num] == null)
                {
                    newCards[num] = card;
                }
            }
        }

        //ציור הלוח
        public void DrawBoard()
        {
            foreach (var card in newCards)
            {
                if (card == null)
                    Console.Write("[]");
                else
                    card.DrawCard(card.ToString());
            }
            Console.WriteLine();
        }

        //מיקום כרטיס להרמה חוקי או לא
        public bool IsCorrect(int num)
        {
            if(num<0 || num>=this.boardSize || (newCards[num] == null))
                return false;
            return true;
        }

        //האם עדיין יש כרטיסים במשחק
        public bool AreLeft()
        {
            foreach (var card in newCards)
            {
                if (card != null)
                    return true;
            }
            return false;
        }
    }
}
