using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConsoleUI
    {
        public int setDifficult()
        {
            string bfstr;
            int bfnum;
            while (true)
            {
                Console.WriteLine("Set difficulty (1-3):");
                bfstr = Console.ReadLine();
                try
                {
                    bfnum = Convert.ToInt32(bfstr);
                    if (bfnum < 4 && bfnum > 0)
                    {
                        return bfnum;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It wrong num.");
                }
            }
        }

        public string writeWord(string wordNow)
        {
            string bfstr;
            Console.WriteLine(wordNow);
            Console.WriteLine("Say word:");
            bfstr = Console.ReadLine();
            return bfstr;
        }

        public void showUsedLetters(string letters) 
        {
            Console.WriteLine($"You used this letters:\n{letters}");
        }
    }
}
