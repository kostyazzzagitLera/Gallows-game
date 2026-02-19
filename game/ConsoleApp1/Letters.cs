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
                Console.WriteLine($"wordInput {wordInput.Length}");
                string bfstr = "";
                int bfnum = 0;
                foreach (var item in wordInput)
                {
                    saveLetter(Convert.ToString(item));
                }
                foreach (var item in wordInput)
                {
                    Console.WriteLine($"ВОРДДЖ {item2}");
                    Console.WriteLine($"ДЖ {item2}");
                    Console.WriteLine($"Input: {item2} {item2} {item}");
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
                    if (item2 == item && bfnum != 1)
                    {
                        bfstr = Convert.ToString(item);
                        
                        bfnum = 1;
                        break;
                    }
                }

                if (bfnum == 0)
                {
                    bfstr = "*";
                    break;
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
    }
}
