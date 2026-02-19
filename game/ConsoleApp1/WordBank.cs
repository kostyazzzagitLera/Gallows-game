using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WordBank
    {
        private string[] _words = { 
            "диез",
            "диета",
            "дилер",
            "дилетант",
            "марля",
            "намаз",
            "оболтус",
            "оселок",
            "пандус",
            "парафировать",
            "скандировать",
            "смиренный",
            "спорадический",
            "стоеросовый",
        };

        private string word;

        public string setWord()
        {
            Random rnd = new Random();
            int rndbf = rnd.Next(0, _words.Length);
            word = _words[rndbf];
            return _words[rndbf];
        }

        public string setWord(int difficulty)
        {
            if (difficulty == 1)
                word = _words[getRandomIdWord(1, 6)];
            else if (difficulty == 2)
                word = _words[getRandomIdWord(5, 8)];
            else if (difficulty == 3)
                word = _words[getRandomIdWord(7, 20)];
            return word;
        }

        private int getRandomIdWord(int diffMin, int diffMax)
        {
            Random rnd1 = new Random();
            List<int> bfwords = new List<int>();
            int bfnum = 0;
            int bfnum2 = 1;

            for (int i = 0; i < _words.Length; i++)
            {
                if (_words[i].Length > diffMin && _words[i].Length < diffMax)
                {
                    bfwords.Add(bfnum2);
                    bfwords[bfnum] = i;
                    bfnum++;
                    bfnum2++;
                }
            }

            bfnum = 0;
            bfnum2 = 0;
            bfnum = rnd1.Next(0, bfwords.Count);
            return rnd1.Next(0, Convert.ToInt32(bfwords[bfnum]));
        }

        public string getWord() {
            return word;
        }

    }
}
