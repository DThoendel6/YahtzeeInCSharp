using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Die
    {
        public int DieId { get; set; }
        public int DotCount { get; set; }
        public bool Hold { get; set; }
        
        // Constructors
        public Die() { }

        public Die(int id, int count, bool hold)
        {
            DieId = id;
            DotCount = count;
            Hold = hold;
            id++;
        }
        
        public void Roll()
        {
            if (Hold)
            {
                //does not roll a new number
            }
            else
            {
                int newCount;
                // Random rand = new Random();
                newCount = frmYahtzeeGame.rand.Next(1, 7);
                DotCount = newCount;
            }
        }

        public Image GetDieImage()
        {
            if (DotCount == 1)
                return Yahtzee.Properties.Resources.dice1;
            else if (DotCount == 2)
                return Yahtzee.Properties.Resources.dice2;
            else if (DotCount == 3)
                return Yahtzee.Properties.Resources.dice3;
            else if (DotCount == 4)
                return Yahtzee.Properties.Resources.dice4;
            else if (DotCount == 5)
                return Yahtzee.Properties.Resources.dice5;
            else
                return Yahtzee.Properties.Resources.dice6;
        }

    }
}
