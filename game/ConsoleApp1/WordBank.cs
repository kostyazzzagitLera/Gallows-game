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
            Random rnd1 = new Random();
            int massI = 0;
            if (difficulty == 1)
            {
                int[] bfwords = new int[_words.Length];

                for (int i = 0; i < _words.Length; i++)
                {
                    if (_words[i].Length < 6)
                        bfwords.Append(i);
                }

                int bfnum = rnd1.Next(0, bfwords.Length);

                massI = rnd1.Next(0, bfwords[bfnum]);
            }
            else if (difficulty == 2)
            {
                int[] bfwords = new int[_words.Length];

                for (int i = 0; i < _words.Length; i++)
                {
                    if (_words[i].Length > 5 && _words[i].Length < 8)
                        bfwords.Append(i);
                }

                int bfnum = rnd1.Next(0, bfwords.Length);

                massI = rnd1.Next(0, bfwords[bfnum]);
            }
            else if (difficulty == 3)
            {
                int[] bfwords = new int[_words.Length];

                for (int i = 0; i < _words.Length; i++)
                {
                    if (_words[i].Length > 7)
                        bfwords.Append(i);
                }

                int bfnum = rnd1.Next(0, bfwords.Length);

                massI = rnd1.Next(0, bfwords[bfnum]);
            }
            word = _words[massI];
            return _words[massI];
        }

        public string getWord() {
            return word;
        }

    }
}
