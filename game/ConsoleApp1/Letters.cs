using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Letters
    {
        private string lettrs = "";
        private string wordNow = "";
        public string checkWord(string word, string wordInput) {
            wordNow = "";
            foreach (var item2 in word)
            {
                string bfstr = "";
                int bfnum = 0;
                foreach (var item in wordInput)
                    saveLetter(Convert.ToString(item));
                if (lettrs.Length > 0 && bfnum != 1)
                {
                    Console.WriteLine(lettrs);
                    for (int k = 0; k < lettrs.Length; k++)
                    {
                        if (item2 == lettrs[k])
                        {
                            Console.WriteLine($"Letters: {item2} {lettrs[k]} {item2}");
                            bfstr = Convert.ToString(lettrs[k]);
                            bfnum = 1;
                            break;
                        }
                    }
                }
                if (bfnum != 1)
                {
                    foreach (var item in wordInput)
                    {
                        if (item2 == item)
                        {
                            bfstr = Convert.ToString(item);
                            bfnum = 1;
                            break;
                        }
                    }
                }
                if (bfnum == 0)
                {
                    bfstr = "*";
                }
                wordNow += bfstr;
                bfstr = "";
                bfnum = 0;
            }
            return wordNow;
        }

        private void saveLetter(string letter) 
        {
            int bfnum = 0;
            foreach (var item in lettrs)
            {
                if (letter == Convert.ToString(item))
                {
                    bfnum = 1;
                    break;
                }
            }
            if (bfnum == 0)
            {
                lettrs += letter;
            }
        }

        public string getWord(string word)
        {
            if (wordNow == "")
            {
                string bfwordNow = "";
                foreach (var item in word)
                    bfwordNow += "*";
                return bfwordNow;
            }
            else
            {
                return wordNow;
            }
        }

        public string getLetter()
        {
            string bflett = "";
            foreach (var item in lettrs)
            {
                bflett += Convert.ToString(item);
                bflett += ", ";
            }
            return bflett;
        }
    }
}
