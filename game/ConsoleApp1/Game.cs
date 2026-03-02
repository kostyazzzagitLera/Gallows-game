using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Game
    {
        private WordBank word = new WordBank();
        private Difficulty diff = new Difficulty();
        private ConsoleUI cui = new ConsoleUI();
        private Letters lett = new Letters();
        private Statistics stat = new Statistics();
        public void StartGame() {
            diff.SetDifficult(cui.setDifficult());
            word.setWord(diff.GetDifficult());
            
            while (true)
            {
                ContinueGame();
            }
        }

        public void ContinueGame()
        {
            Console.Clear();
            string bfwrite = "";
            cui.showUsedLetters(lett.getLetter());
            Console.WriteLine($"\n");
            cui.showStats(stat.GetStat(1), stat.GetStat(2), stat.GetStat(3));
            Console.WriteLine($"\n");
            bfwrite = cui.writeWord(lett.getWord(word.getWord()));
            lett.checkWord(word.getWord(), bfwrite);
            int bfnum = lett.score;
            stat.addStats(3, bfnum);
        }

    }
}
