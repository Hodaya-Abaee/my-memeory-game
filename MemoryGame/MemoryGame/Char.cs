using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Char:Base
    {
        public char OneChar { get; set; }

        public override bool CheckMatch(Base other)
        {
            return other is Char otherCard && OneChar == otherCard.OneChar;
        }

        public override void DrawCard(string? s = null)
        {
            base.DrawCard(OneChar.ToString());
        }
    }
}
