using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee.Model
{
    class Game
    {
        public List<Die> Dice = new List<Die>(5);

        public Game() { }

        public Game(List<Die> dice) 
        {
            Dice = dice;
        }
        
       
        public static void UpdateScores(User player)
        {
            YahtzeeDA.UpdateUserScores(player);
            return;
        }
    }
}
