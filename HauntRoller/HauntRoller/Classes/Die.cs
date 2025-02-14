﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HauntRoller
{
    class Die
    {
        public int total;
        public List<int> diceList;

        //constructor
        public Die()
        {
            total = 0;
            diceList = new List<int>();
        }

        //roll 1 die [0,1,2]
        private int _rollDie()
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);
        }

        //Roll total amount of dice, but return total and exact numbers rolled.
        public void RollDice(int totalDice)
        {
            int result;
            ResetDice();
            for (int i = 0; i < totalDice; i++)
            {
                result = _rollDie();
                total += result;
                diceList.Add(result);
            }
        }
        //Provide a string which prints the result of each individual die
        public string PrintDice()
        {
            string outstr = "";
            for (int i = 0; i < diceList.Count; i++)
            {
                outstr += diceList[i] + " ";
            }
            return outstr;
        }

        //Clear the totals between rounds of rolling, no need to store between rounds.
        public void ResetDice()
        {
            total = 0;
            diceList.Clear();
        }

    }
}
