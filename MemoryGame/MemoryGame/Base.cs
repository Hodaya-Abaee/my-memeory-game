using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal abstract class Base 
    {
        public bool IsOver { get; set; }
        public bool IsFirst { get; set; }

        //public override bool Equals(object? obj)
        //{
        //    if(obj is Base otherCard)
        //    {
        //        if (this.IsOver && otherCard.IsOver && this.IsFirst != otherCard.IsFirst)
        //            return true;
        //    }
        //    return false;
        //}

        public abstract bool CheckMatch(Base other);

        public virtual void DrawCard(string? s = null)
        {
            Console.Write("[");
            if (IsOver) 
                Console.Write(s);
            else
                Console.Write("?");
            Console.Write("]");
        }
    }
}
