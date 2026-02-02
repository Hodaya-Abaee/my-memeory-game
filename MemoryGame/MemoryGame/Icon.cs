using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Icon:Base
    {
        public char Sign { get; set; }
        public ConsoleColor Color { get; set; }

        public override bool CheckMatch(Base other)
        {
            //if(this.Equals(other) && other is Icon otherCard)
            //{
            //    if(this.Sign == otherCard.Sign)
            //        return true;
            //}
            //return false;

            return other is Icon otherCard && this.Sign==otherCard.Sign;
        }

        public override void DrawCard(string? s = null)
        {
            if(this.IsOver)
                Console.ForegroundColor = Color;
            base.DrawCard(Sign.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
