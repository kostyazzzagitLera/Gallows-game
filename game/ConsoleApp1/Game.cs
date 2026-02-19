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
            
            lett.checkWord(word.getWord(), cui.writeWord(lett.getWord(word.getWord())));
            ContinueGame();
        }
        public void ContinueGame()
        {
            while (true)
            {
                lett.checkWord(word.getWord(), cui.writeWord(lett.getWord(word.getWord())));
            }
        }

    }
}
