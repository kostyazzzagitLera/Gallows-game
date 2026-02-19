using System;
using System.Collections.Generic;
using System.Linq;
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
            bfwrite = cui.writeWord(lett.getWord(word.getWord()));
            lett.checkWord(word.getWord(), bfwrite);
        }

    }
}
