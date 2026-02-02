using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class ComputerPlayer:BasePlayer
    {
        private readonly string name = "computer";

        public override string Name => name;

        Random rnd = new Random();

        public ComputerPlayer()
        {
            this.cardsList = new List<Base>();
            this.Score = 0;
        }
        public override int ChooseCard()
        {
            int num = rnd.Next(16);
            return num;
        }
    }
}
