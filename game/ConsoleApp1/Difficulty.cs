using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Difficulty
    {
        private int difficult = 1;

        public void SetDifficult(int d) => difficult = d;

        public int GetDifficult() => difficult;
    }
}
