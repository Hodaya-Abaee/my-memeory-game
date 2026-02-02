namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Base> charList = new List<Base>();
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'A' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'A' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'B' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'B' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'C' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'C' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'D' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'D' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'E' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'E' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'F' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'F' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'G' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'G' });
            charList.Add(new Char { IsFirst = true, IsOver = false, OneChar = 'H' });
            charList.Add(new Char { IsFirst = false, IsOver = false, OneChar = 'H' });

            List<Base> iconList = new List<Base>();
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Yellow, Sign = '@' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Yellow, Sign = '@' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Cyan, Sign = '#' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Cyan, Sign = '#' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Red, Sign = '*' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Red, Sign = '*' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Green, Sign = '!' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Green, Sign = '!' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Gray, Sign = '%' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Gray, Sign = '%' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Black, Sign = '$' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Black, Sign = '$' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Blue, Sign = '#' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Blue, Sign = '#' });
            iconList.Add(new Icon { IsFirst = true, IsOver = false, Color = ConsoleColor.Magenta, Sign = '~' });
            iconList.Add(new Icon { IsFirst = false, IsOver = false, Color = ConsoleColor.Magenta, Sign = '~' });
            

            List<Base> targiList = new List<Base>();
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 2, Targil1 = "1+1" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 2, Targil1 = "1+1" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 4, Targil1 = "2+2" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 4, Targil1 = "2+2" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 6, Targil1 = "3+3" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 6, Targil1 = "3+3" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 8, Targil1 = "4+4" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 8, Targil1 = "4+4" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 10, Targil1 = "5+5" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 10, Targil1 = "5+5" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 12, Targil1 = "6+6" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 12, Targil1 = "6+6" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 14, Targil1 = "7+7" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 14, Targil1 = "7+7" });
            targiList.Add(new Targil { IsFirst = true, IsOver = false, Result = 16, Targil1 = "8+8" });
            targiList.Add(new Targil { IsFirst = false, IsOver = false, Result = 16, Targil1 = "8+8" });

            foreach (Targil item in targiList)
            {
                item.DrawCard(item.Targil1);
            }
            Console.WriteLine();
            foreach (Icon item in iconList)
            {
                item.DrawCard(item.Sign.ToString());
            }
            Console.WriteLine();
            foreach (Char item in charList)
            {
                item.DrawCard(item.OneChar.ToString());
            }
            Console.WriteLine();
            //Console.WriteLine("If you want a game of letters, type 1");
            //Console.WriteLine("If you want a game of math questions, type 2");
            //Console.WriteLine("If you want a game of symbols, type 3");

            Dictionary<GameTypes, List<Base>> cards = new Dictionary<GameTypes, List<Base>>();
            cards.Add(GameTypes.targil, targiList);
            cards.Add(GameTypes.icon, iconList);
            cards.Add(GameTypes.characters, charList);
            Game game = new Game(cards);
            game.GameCourse();
        }
    }
}
