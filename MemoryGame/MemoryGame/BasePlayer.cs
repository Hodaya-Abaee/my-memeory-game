using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal abstract class BasePlayer
    {
        //מאפיין
        public abstract string Name { get; }
        //משתנים
        public int Score { get; set; }
        public List<Base> cardsList;
        //פעולה בונה
        //public BasePlayer(string name, int score)
        //{
            
        //}
        //פונקציות
        public virtual void RestartName() 
        {
            
        }
        public abstract int ChooseCard();
        public void ShowCards()
        {
            foreach (var card in cardsList)
            {
                card.DrawCard();
            }
            Console.WriteLine();
        }
    }
}
