using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Targil : Base
    {
        public string Targil1 { get; set; }
        public int Result { get; set; }

        public override bool CheckMatch(Base other)
        {
            //if (this.Equals(other) && other is Targil otherCard)
            //{
            //    if (this.Result == otherCard.Result)
            //        return true;
            //}
            //return false;
            
            return other is Targil otherCard && this.Result==otherCard.Result;
        }

        public override void DrawCard(string? s = null)
        {
            if (this.IsFirst)
                base.DrawCard(Targil1);
            else
                base.DrawCard(Result.ToString());
        }
    }
}
