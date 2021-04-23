using System;
using System.Collections.Generic;
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

    }
}
