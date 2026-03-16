using System;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    private Dictionary<int, string> stats = new Dictionary<int, string>()
    {
        [1] = "Best result: 0",
        [2] = "Best time: 0 sec",
        [3] = "Score: 0"
    };
    public void addStats(int key, int stat)
    {
        var value = stats[key];
        string bfStr = "";
        stats.Remove(key);
        //Console.WriteLine(">>>>>> " + value);
        if (key == 2)
        {
            var bfChar = value.Split(' ');
            bfStr += bfChar[0] + " ";
            bfStr += bfChar[1] + " ";
            bfStr += Convert.ToString(Convert.ToInt32(bfChar[2]) + stat);
            bfStr += bfChar[3];
        }
        else if (key == 3)
        {
            var bfChar = value.Split(' ');
            bfStr += bfChar[0] + " ";
            bfStr += Convert.ToString(Convert.ToInt32(bfChar[1]) + stat);
        }

        stats.Add(key, bfStr);
        setBestRes();
        //Console.WriteLine($">>>>>> \n" + stats);
    }
    private void setBestRes()
    {
        string bfStr = "";
        var value = stats[1];
        var value2 = stats[3];
        var bfChar = value.Split(' ');
        var bfChar2 = value2.Split(' ');
        if (Convert.ToInt32(bfChar2[1]) > Convert.ToInt32(bfChar[2]))
        {
            bfStr += bfChar[0] + " ";
            bfStr += bfChar[1] + " ";
            bfStr += Convert.ToString(bfChar2[1]);
        }
        else
        {
            bfStr += bfChar[0] + " ";
            bfStr += bfChar[1] + " ";
            bfStr += bfChar[2];
        }
        stats.Remove(1);
        stats.Add(1, bfStr);
    }
    public string GetStat(int key)
    {
        return stats[key];
    }
}
