using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MemoryGame
{
    internal class UserPlayer : BasePlayer
    {
        private string name;

        public UserPlayer()
        {
            RestartName();
            this.cardsList = new List<Base>();
            this.Score = 0;
        }

        public override string Name => name;
        public override void RestartName()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            this.name = name;
        }
        public override int ChooseCard()
        {
            int num;
            do
            {
                Console.WriteLine($"Choose a card number (0-15):");
            } 
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num >= 16);
            return num;
        }
    }
}
