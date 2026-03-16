using System;
using UnityEngine;

public class Letters
{
    private string lettrs = "";
    private string wordNow = "";
    public int score = 0;
    private int bfscore1 = 0;
    public string checkWord(string word, string wordInput)
    {
        wordNow = "";
        score = 0;
        int bfscore2 = 0;
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
                        bfscore2++;
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
            if (bfscore1 < bfscore2)
            {
                Console.WriteLine(bfscore1);
                Console.WriteLine(bfscore2);
                score += 1000;
                if (score > 2)
                    score += 80 * word.Length;
                bfscore1 = bfscore2;
                Console.WriteLine(bfscore1);
                Console.WriteLine(bfscore2);
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
